using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IVentaLogic
    {
        void AltaVenta(Venta ventaAgregar);
        Task ModificarVenta(Venta ventaModificar, int idVenta);
        Task Eliminarventa(int idVenta);
        Task<Venta> ConsultaVentaId(int idVenta);
        IEnumerable<Venta> ObtenerVentasPorFecha(DateTime fecha);
    }
}
