using CDatos.Repositories.CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        IAutorRepository _autorRepository;
        public AutorLogic(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }
        public void AltaAutor(Autor autorAgregar)
        {
            Autor autorNuevo = new Autor();
            if (autorAgregar == null)
            {
                throw new ArgumentNullException("No se ha ingresado ningun autor. ");
            }
            if (autorAgregar.Persona == null)
            {
                throw new ArgumentNullException("El autor debe estar vinculado a una persona del sistema.");
            }
            if (autorAgregar.Biografia.Length < 4000)
            {
                throw new ArgumentNullException("La biografia es demasiado larga.");
            }
            autorNuevo.Biografia = autorAgregar.Biografia;
            autorNuevo.Persona = autorAgregar.Persona;

            _autorRepository.Create(autorNuevo);
            _autorRepository.Save();
        }

        public void ModificarAutor(string documento, Autor autorModificar)
        {
            if (autorModificar == null)
            {
                throw new ArgumentNullException("No se ha ingresado ningun autor. ");
            }
            if (autorModificar.Persona == null)
            {
                throw new ArgumentNullException("El autor debe estar vinculado a una persona del sistema.");
            }
            if (autorModificar.Biografia.Length < 4000)
            {
                throw new ArgumentNullException("La biografia es demasiado larga.");
            }

            if (string.IsNullOrEmpty(documento) || !PersonaLogic.IsValidDocumento(documento))
                throw new ArgumentNullException("El domuento ingresado es invalido");
            Autor? autor = _autorRepository.FindByCondition(p => p.Persona.Documento == documento).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentException("La persona con este documento no fue encontrada");
            }

            _autorRepository.Update(autor);
            _autorRepository.Save();
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

        public Autor ConsultaAutor(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !PersonaLogic.IsValidDocumento(documento))
                throw new ArgumentNullException("El domuento ingresado es invalido");
            Autor? autor = _autorRepository.FindByCondition(p => p.Persona.Documento == documento).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentException("La persona con este documento no fue encontrada");
            }

            return autor;
        }

        public async Task<List<Autor>> ConsultaTodosLosAutoresAsync()
        {
            List<Autor> autores = await _autorRepository.GetAll();

            if (!autores.Any())
            {
                throw new ArgumentException("No se encontraron autores.");
            }

            return autores;
        }


    }
}
