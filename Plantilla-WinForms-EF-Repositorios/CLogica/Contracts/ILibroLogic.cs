using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface ILibroLogic
    {
        void AltaLibro(string isbn, string titulo, string descripcion, DateTime fechaPublicacion, float previoVenta, Editorial editorial, List<int> autores);
        Task ModificarLibro(string idLibro, string isbn, string titulo, string descripcion, DateTime fechaPublicacion, float previoVenta, Editorial editorial, List<int> autores);

        Task EliminarLibro(string idLibro);
        Libro ConsultaLibro(string titulo, Libro libroBuscado);
        IEnumerable<Libro> ObtenerLibros();
        Libro ObtenerPorIdLibro(string idLibro);
    }
}
