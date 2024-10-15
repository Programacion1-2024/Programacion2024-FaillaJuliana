using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IImagenLogic
    {
        void GuardarImagenEnBaseDeDatos(string rutaArchivo, string formularioOrigen);
        List<Imagen> ObtenerImagenesPorOrigen(string formularioOrigen);
    }
}
