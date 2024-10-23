using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IEditorialLogic
    {
        void AltaEditorial(string descripcion, string contacto, string direccion);
        void ModificarEditorial(string idEditorial, string descripcion, string contacto, string direccion);
        void BajaEditorial(string idEditorial);
        IEnumerable<Editorial> ObtenerEditoriales();
        Editorial ObtenerPorIdEditorial(string idEditorial);



    }
}
