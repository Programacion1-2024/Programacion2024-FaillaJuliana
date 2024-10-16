using CDatos.Repositories.CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        private IAutorRepository _autorRepository;
        private IPersonaLogic _personaLogic;
        public AutorLogic(IAutorRepository autorRepository, IPersonaLogic personaLogic)
        {
            _autorRepository = autorRepository;
            _personaLogic = personaLogic;
        }
        public void AltaAutor(string nombre, string apellido, string nacionalidad, string telefono, string email, string biografia)
        {
            try
            {
                Persona personaNueva = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Nacionalidad = nacionalidad,
                    Telefono = telefono,
                    Email = email,
                    Documento = null 
                };

                Persona persona = _personaLogic.AltaPersona(personaNueva);

                if (persona == null || persona.IdPersona == 0)
                {
                    throw new Exception("Error al crear la persona.");
                }

                Autor autorNuevo = new Autor()
                {
                    Persona = persona, 
                    Biografia = biografia
                };

                if (autorNuevo.Persona == null)
                {
                    throw new ArgumentNullException("El autor debe estar vinculado a una persona del sistema.");
                }
                if (string.IsNullOrEmpty(autorNuevo.Biografia) || autorNuevo.Biografia.Length > 4000)
                {
                    throw new ArgumentException("La biografía es demasiado larga o está vacía.");
                }

                _autorRepository.CrearAutor(autorNuevo);
                _autorRepository.Save();
            }
            catch (Exception ex)
            {
                // Mostrar la excepción interna si existe
                var innerExceptionMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error al crear el autor: " + innerExceptionMessage);
            }
        }


        public void ModificarAutor(string idAutor, string nombre, string apellido, string nacionalidad, string telefono, string email, string biografia)
        {
            try
            {
                Autor autorExistente = _autorRepository.ObtenerPorId(idAutor); 

                if (autorExistente == null)
                {
                    throw new ArgumentException("El autor no fue encontrado.");
                }

                Persona personaModificar = new Persona()
                {
                    IdPersona = autorExistente.Persona.IdPersona, 
                    Nombre = nombre,
                    Apellido = apellido,
                    Nacionalidad = nacionalidad,
                    Telefono = telefono,
                    Email = email,
                    Documento = null 
                };

                _personaLogic.ActualizacionPersona(personaModificar);

                // Actualizar los datos del autor
                autorExistente.Biografia = biografia;

                if (string.IsNullOrEmpty(autorExistente.Biografia) || autorExistente.Biografia.Length > 4000)
                {
                    throw new ArgumentNullException("La biografia es demasiado larga o está vacía.");
                }

                // Guardar los cambios
                _autorRepository.Update(autorExistente);
                _autorRepository.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void BajaAutor(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !PersonaLogic.IsValidDocumento(documento))
            {
                throw new ArgumentException("El documento ingresado no es válido.");
            }

            Autor? autorEliminar = _autorRepository.FindByCondition(p => p.Persona.Documento == documento).FirstOrDefault();

            if (autorEliminar == null)
            {
                throw new InvalidOperationException("El profesor que se desea eliminar no existe.");
            }

            _autorRepository.Delete(autorEliminar);
            _autorRepository.Save();
        }
        public List<Autor> ConsultaTodosLosAutores()
        {
            return _autorRepository
                   .FindAllIQueryable()
                   .Include(a => a.Persona)  
                   .ToList();
        }

        
        public Autor ObtenerPorId(string id)
        {
            if (!int.TryParse(id, out int autorId))
            {
                throw new ArgumentException("El ID proporcionado no es válido.");
            }

            return _autorRepository.FindAllIQueryable()
                .Include(a => a.Persona) 
                .FirstOrDefault(a => a.IdAutor == autorId);
        }
    }
}
