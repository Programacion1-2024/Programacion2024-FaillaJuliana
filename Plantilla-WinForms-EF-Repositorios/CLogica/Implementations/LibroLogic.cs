using CDatos.Repositories;
using CDatos.Repositories.CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System.Collections.Generic;


namespace CLogica.Implementations
{
    public class LibroLogic: ILibroLogic
    {
        ILibroRepository _libroRepository;
        IAutorRepository _autorRepository;
        public LibroLogic(ILibroRepository libroRepository,IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
            _libroRepository = libroRepository;
        }

        public void AltaLibro (string isbn, string titulo, string descripcion, DateTime fechaPublicacion,float previoVenta, Editorial editorial,List<int> autores)
        {
            List<Autor> listaAutores = _autorRepository.ObtenerPorIdLista(autores);

            Libro libro = new Libro()
            {
                ISBN = isbn,
                Titulo = titulo,
                Descripcion = descripcion,
                FechaPublicacion = fechaPublicacion,
                PrecioVenta = previoVenta,
                Editorial = editorial, 
                Autores = new List<Autor>(listaAutores)
            };

            List<string> camposErroneos = new List<string>();

            if (editorial == null)
            {
                throw new ArgumentException("La editorial no puede ser nula.");
            }

            if (string.IsNullOrEmpty(libro.Titulo) || !PersonaLogic.IsValidName(libro.Titulo))
                camposErroneos.Add("Titulo");
            if(string.IsNullOrEmpty(libro.Descripcion) || libro.Descripcion.Length > 4000)
                camposErroneos.Add("Descripcion");
            if (libro.FechaPublicacion == DateTime.MinValue || !IsValidFecha(libro.FechaPublicacion))
                camposErroneos.Add("FechaPublicacion");
            if (string.IsNullOrEmpty(libro.ISBN) || !IsValidIsbn(libro.ISBN) || _libroRepository.FindByCondition(p => p.ISBN == libro.ISBN).Count() != 0)
                camposErroneos.Add("ISBN");
            if (!IsValidPrecio(libro.PrecioVenta))
                camposErroneos.Add("Precio Venta");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", String.Join(",", camposErroneos));
            }

            _libroRepository.Create(libro);
            _libroRepository.Save();
        }

        public async Task ModificarLibro(string idLibro,string isbn, string titulo, string descripcion, DateTime fechaPublicacion, float previoVenta, Editorial editorial, List<int> autores)
        {
            List<Autor> listaAutores = _autorRepository.ObtenerPorIdLista(autores);

            int.TryParse(idLibro, out int id);
            
            Libro? libroExistente =await _libroRepository.GetById(id);

            libroExistente.ISBN=isbn;
            libroExistente.Titulo=titulo;
            libroExistente.Descripcion=descripcion;
            libroExistente.FechaPublicacion=fechaPublicacion;
            libroExistente.PrecioVenta=previoVenta;
            libroExistente.Editorial=editorial;
            libroExistente.Autores = new List<Autor>(listaAutores);

            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(libroExistente.Descripcion) || !PersonaLogic.IsValidName(libroExistente.Descripcion))
                camposErroneos.Add("Descripcion");
            if (libroExistente.FechaPublicacion == DateTime.MinValue || !IsValidFecha(libroExistente.FechaPublicacion))
                camposErroneos.Add("FechaPublicacion");
            if (string.IsNullOrEmpty(libroExistente.ISBN) || !IsValidIsbn(libroExistente.ISBN) || _libroRepository.FindByCondition(p => p.ISBN == libroExistente.ISBN).Count() != 0)
                camposErroneos.Add("ISBN");
            if (!IsValidPrecio(libroExistente.PrecioVenta))
                camposErroneos.Add("Precio Venta");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", String.Join(",", camposErroneos));
            }

            if (string.IsNullOrEmpty(libroExistente.Titulo) || !PersonaLogic.IsValidName(libroExistente.Titulo))
                throw new ArgumentNullException("El titulo ingresado es invalido");

            if (libroExistente == null)
            {
                throw new ArgumentException("El libro con este titulo no fue encontrado");
            }

            _libroRepository.Update(libroExistente);
            _libroRepository.Save();
        }

        public async Task EliminarLibro(string idLibro)
        {
            int.TryParse(idLibro, out int id);

            Libro? libroExistente = await _libroRepository.GetById(id);

            if (libroExistente == null)
            {
                throw new ArgumentException("El libro con este titulo no fue encontrado");
            }
            _libroRepository.Delete(libroExistente);
            _libroRepository.Save();
        }
        public Libro ObtenerPorIdLibro(string idLibro)
        {
            if (int.TryParse(idLibro, out int id))
            {
                return _libroRepository.FindAllIQueryable().FirstOrDefault(a => a.IdLibro == id);
            }
            else
            { throw new ArgumentException("id invalido"); }
        }
        public IEnumerable<Libro> ObtenerLibros()
        {
            return this._libroRepository.FindAll().ToList();
        }
        public Libro ConsultaLibro(string titulo, Libro libroBuscado)
        {
            if (string.IsNullOrEmpty(libroBuscado.Titulo) || !PersonaLogic.IsValidName(libroBuscado.Titulo))
                throw new ArgumentNullException("El titulo ingresado es invalido");

            Libro? libro = _libroRepository.FindByCondition(p => p.Titulo == titulo).FirstOrDefault();

            if (libro == null)
            {
                throw new ArgumentException("El libro con este titulo no fue encontrado");
            }
            return libroBuscado;
        }

        public static bool IsValidFecha(DateTime fecha)
        {
            if (fecha > DateTime.Now)
            {
                return false;
            }
            return true;
        }
        private bool IsValidIsbn(string isbn)
        {
            return isbn.Length == 13 && isbn.All(c => Char.IsNumber(c));
        }
        private bool IsValidPrecio(float precio)
        {
            return precio > 0;
        }

    }
}
