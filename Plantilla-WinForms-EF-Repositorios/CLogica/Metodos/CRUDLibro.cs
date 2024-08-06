using CDatos.Contexts;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Metodos
{
    public class CRUDLibro
    {
        public LibreriaContext context = new LibreriaContext();

        public void AgregarLibro(Libro libro)
        {
            Libro libroNuevo = new Libro();

            libroNuevo.ISBN = libro.ISBN;
            libroNuevo.Titulo = libro.Titulo;
            libroNuevo.Descripcion = libro.Descripcion;
            libroNuevo.FechaPublicacion = libro.FechaPublicacion;
            libroNuevo.PrecioVenta = libro.PrecioVenta;
            libroNuevo.Autores = libro.Autores;
            libroNuevo.Generos = libro.Generos;
            libroNuevo.Editorial = libro.Editorial;
            libroNuevo.Venta = libro.Venta;
            libroNuevo.CopiasLibro = libro.CopiasLibro;
            context.Libro.Add(libroNuevo);
            context.SaveChanges();
        }

        public void ModificarLibro(Libro libromodificado, Libro libro)
        {
            libromodificado.ISBN = libro.ISBN;
            libromodificado.Titulo = libro.Titulo;
            libromodificado.Descripcion = libro.Descripcion;
            libromodificado.FechaPublicacion = libro.FechaPublicacion;
            libromodificado.PrecioVenta = libro.PrecioVenta;
            libromodificado.Autores = libro.Autores;
            libromodificado.Generos = libro.Generos;
            libromodificado.Editorial = libro.Editorial;
            libromodificado.Venta = libro.Venta;
            libromodificado.CopiasLibro = libro.CopiasLibro;
            context.Libro.Update(libromodificado);
            context.SaveChanges();
        }

        public void EliminarLibro(Libro libro)
        {
            context.Libro.Remove(libro);
            context.SaveChanges();
        }
    }
}
