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
        public LibroLogic(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        public void AltaLibro (Libro libro)
        {
            Libro libroNuevo = new Libro();

            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(libroNuevo.Titulo) || !PersonaLogic.IsValidName(libroNuevo.Titulo))
                camposErroneos.Add("Titulo");
            if(string.IsNullOrEmpty(libroNuevo.Descripcion) || !PersonaLogic.IsValidName(libroNuevo.Descripcion))
                camposErroneos.Add("Descripcion");
            if (libroNuevo.FechaPublicacion == DateTime.MinValue || !IsValidFecha(libroNuevo.FechaPublicacion))
                camposErroneos.Add("FechaPublicacion");
            if (string.IsNullOrEmpty(libroNuevo.ISBN) || !IsValidIsbn(libroNuevo.ISBN) || _libroRepository.FindByCondition(p => p.ISBN == libroNuevo.ISBN).Count() != 0)
                camposErroneos.Add("ISBN");
            if (!IsValidPrecio(libroNuevo.PrecioVenta))
                camposErroneos.Add("Precio Venta");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", String.Join(",", camposErroneos));
            }

            libroNuevo.ISBN = libro.ISBN;
            libroNuevo.Titulo = libro.Titulo;
            libroNuevo.Descripcion = libro.Descripcion;
            libroNuevo.FechaPublicacion = libro.FechaPublicacion;
            libroNuevo.PrecioVenta = libro.PrecioVenta;
            libroNuevo.Editorial = libro.Editorial;

            _libroRepository.Create(libro);
            _libroRepository.Save();
        }

        public void ModificarLibro(string titulo,Libro libroModificar)
        {
            List<string> camposErroneos = new List<string>();

            if (string.IsNullOrEmpty(libroModificar.Descripcion) || !PersonaLogic.IsValidName(libroModificar.Descripcion))
                camposErroneos.Add("Descripcion");
            if (libroModificar.FechaPublicacion == DateTime.MinValue || !IsValidFecha(libroModificar.FechaPublicacion))
                camposErroneos.Add("FechaPublicacion");
            if (string.IsNullOrEmpty(libroModificar.ISBN) || !IsValidIsbn(libroModificar.ISBN) || _libroRepository.FindByCondition(p => p.ISBN == libroModificar.ISBN).Count() != 0)
                camposErroneos.Add("ISBN");
            if (!IsValidPrecio(libroModificar.PrecioVenta))
                camposErroneos.Add("Precio Venta");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", String.Join(",", camposErroneos));
            }

            if (string.IsNullOrEmpty(libroModificar.Titulo) || !PersonaLogic.IsValidName(libroModificar.Titulo))
                throw new ArgumentNullException("El titulo ingresado es invalido");

            Libro? libro = _libroRepository.FindByCondition(p => p.Titulo == titulo).FirstOrDefault();

            if (libro == null)
            {
                throw new ArgumentException("El libro con este titulo no fue encontrado");
            }

            _libroRepository.Update(libro);
            _libroRepository.Save();
        }

        public void EliminarLibro(string titulo, Libro libroEliminar)
        {
            if (string.IsNullOrEmpty(libroEliminar.Titulo) || !PersonaLogic.IsValidName(libroEliminar.Titulo))
                throw new ArgumentNullException("El titulo ingresado es invalido");

            Libro? libro = _libroRepository.FindByCondition(p => p.Titulo == titulo).FirstOrDefault();

            if (libro == null)
            {
                throw new ArgumentException("El libro con este titulo no fue encontrado");
            }
            _libroRepository.Delete(libro);
            _libroRepository.Save();
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

        




        private bool IsValidFecha(DateTime fecha)
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
