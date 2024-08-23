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
        void AltaLibro(Libro libro);
        void  ModificarLibro(string titulo, Libro libroModificar);
        void EliminarLibro(string titulo, Libro libroEliminar);
        Libro ConsultaLibro(string titulo, Libro libroBuscado);
    }
}
