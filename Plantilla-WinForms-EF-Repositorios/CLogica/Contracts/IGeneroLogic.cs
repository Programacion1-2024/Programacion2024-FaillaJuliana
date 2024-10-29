using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IGeneroLogic
    {
        void AltaGenero(string descripcion, string nombre, List<int> libros);
        IEnumerable<Genero> ObtenerGeneros();
        void EliminarGenero(string IdGenero);
        void ModificarGenero(string idGenero, string descripcion, string nombre, List<int> libros);
        Genero ObtenerPorId(string IdGenero);

    }
}
