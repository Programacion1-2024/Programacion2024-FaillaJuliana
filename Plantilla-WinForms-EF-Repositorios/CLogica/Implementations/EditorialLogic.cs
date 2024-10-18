using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using Microsoft.EntityFrameworkCore;


namespace CLogica.Implementations
{
    public class EditorialLogic : IEditorialLogic
    {
        private IEditorialRepository _editorialRepository;
        public EditorialLogic(IEditorialRepository editorialRepository)
        {
            _editorialRepository = editorialRepository;
        }

        public void AltaEditorial(string descripcion,string contacto,string direccion)
        {
            try
            {
                Editorial editorialNueva = new Editorial()
                {
                    Descripcion = descripcion,
                    Contacto = contacto,
                    Direccion = direccion
                };

                if (editorialNueva == null)
                {
                    throw new ArgumentException("Editorial no puede ser null.");
                }
                if (string.IsNullOrEmpty(editorialNueva.Descripcion))
                {
                    throw new ArgumentException("La biografía está vacía.");
                }
                if (string.IsNullOrEmpty(editorialNueva.Contacto) || !PersonaLogic.IsValidTelefono(editorialNueva.Contacto))
                {
                    throw new ArgumentException("El contacto es demasiado largo o está vacía.");
                }
                if (string.IsNullOrEmpty(editorialNueva.Direccion))
                {
                    throw new ArgumentException("La direccion está vacía.");
                }

                _editorialRepository.Create(editorialNueva);
                _editorialRepository.Save();
            }
            catch(Exception ex) 
            {
                var innerExceptionMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error al crear editorial: " + innerExceptionMessage);
            }
        }
        public void ModificarEditorial(int idEditorial,string descripcion, string contacto, string direccion)
        {
            try
            {
                Editorial? editorialExistente = _editorialRepository.ObtenerPorId(idEditorial);
                if (editorialExistente == null)
                {
                    throw new ArgumentException("La editorial no fue encontrada.");
                }

                Editorial editoriaModificar= new Editorial()
                {
                    Descripcion = descripcion,
                    Contacto = contacto,
                    Direccion = direccion
                };

                if (editoriaModificar == null)
                {
                    throw new ArgumentException("Editorial no puede ser null.");
                }
                if (string.IsNullOrEmpty(editoriaModificar.Descripcion))
                {
                    throw new ArgumentException("La biografía está vacía.");
                }
                if (string.IsNullOrEmpty(editoriaModificar.Contacto) || !PersonaLogic.IsValidTelefono(editoriaModificar.Contacto))
                {
                    throw new ArgumentException("El contacto es demasiado largo o está vacía.");
                }
                if (string.IsNullOrEmpty(editoriaModificar.Direccion))
                {
                    throw new ArgumentException("La direccion está vacía.");
                }

                _editorialRepository.Update(editorialExistente);
                _editorialRepository.Save(); 
            }
            catch (Exception ex)
            {
                var innerExceptionMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error al crear editorial: " + innerExceptionMessage);
            }
        }

        public void BajaEditorial(int idEditorial)
        {

            Editorial editorialEliminar = _editorialRepository.ObtenerPorId(idEditorial);

            if (editorialEliminar == null)
            {
                throw new InvalidOperationException("La editorial que se desea eliminar no existe.");
            }

            _editorialRepository.Delete(editorialEliminar);
            _editorialRepository.Save();

        }
        public Editorial ObtenerPorIdEditorial(int idEditorial)
        {
           
            return _editorialRepository.FindAllIQueryable().FirstOrDefault(a => a.IdEditorial == idEditorial);
        }
        public List<Editorial> ObtenerEditoriales()
        {
            return _editorialRepository
                  .FindAllIQueryable()
                  .ToList();
        }

    }
}
