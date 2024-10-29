using CDatos.Repositories.Contracts;
using CDatos.Repositories.CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using Microsoft.EntityFrameworkCore;
using CDatos.Repositories;

namespace CLogica.Implementations
{
    public class GeneroLogic : IGeneroLogic
    {
        IGeneroRepository _generoRepository;
        ILibroRepository _libroRepository;
       public GeneroLogic(IGeneroRepository generoRepository,ILibroRepository libroRepository)
       {
            _generoRepository = generoRepository;
            _libroRepository = libroRepository;
       }

        public void AltaGenero(string descripcion, string nombre, List<int> libros)
        {
            List<Libro> listaLibros= _libroRepository.ObtenerPorIdLista(libros);

            Genero genero = new Genero()
            {
                Descripcion = descripcion,
                Nombre = nombre,
                Libros = listaLibros
            };

            if (genero == null)
            {
                throw new Exception("Debes completar todos los datos");
            }
            if (string.IsNullOrEmpty(genero.Descripcion) || genero.Descripcion.Length > 4000)
            {
                throw new Exception("Debes ingresar una descripcion, o es demaciada larga");
            }
            
            _generoRepository.Create(genero);
            _generoRepository.Save();

        }
        public void ModificarGenero(string idGenero,string descripcion, string nombre, List<int> libros)
        {
            Genero? generoBuscado = _generoRepository.ObtenerPorId(idGenero);

            if (generoBuscado == null)
            {
                throw new Exception("Gnero no encontrado");
            }
            List<Libro> listaLibros = _libroRepository.ObtenerPorIdLista(libros);

            generoBuscado.Descripcion = descripcion;
            generoBuscado.Nombre = nombre;
            generoBuscado.Libros = listaLibros;

            if (generoBuscado == null)
            {
                throw new Exception("Debes completar todos los datos");
            }
            if (string.IsNullOrEmpty(generoBuscado.Descripcion) || generoBuscado.Descripcion.Length > 4000)
            {
                throw new Exception("Debes ingresar una descripcion, o es demaciada larga");
            }

            _generoRepository.Update(generoBuscado);
            _generoRepository.Save();
        }
        public void EliminarGenero(string IdGenero)
        {
            if (string.IsNullOrEmpty(IdGenero))
            {
                throw new Exception("Id nulo");
            }

           Genero? generoEliminar =  _generoRepository.ObtenerPorId(IdGenero);

            if( generoEliminar == null)
            {
                throw new Exception("genero no encontrado");
            }

            _generoRepository.Delete(generoEliminar);
            _generoRepository.Save();
        }

        public IEnumerable<Genero> ObtenerGeneros()
        {
            return _generoRepository.FindAll(); 
        }

        public Genero ObtenerPorId(string IdGenero)
        {
            if (!int.TryParse(IdGenero, out int id))
            {
                throw new ArgumentException("El ID proporcionado no es válido.");
            }

            return _generoRepository.FindAll()
                .FirstOrDefault(a => a.IdGenero == id);

        }
    }
}
