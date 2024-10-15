using CDatos.Repositories;
using CDatos.Repositories.CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class VentaLogic : IVentaLogic
    {
        IVentaRepository _ventaRepository;

        public VentaLogic(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;
        }

        public void AltaVenta (Venta ventaAgregar)
        {

            List<string> camposErroneos = new List<string>();

            if (ventaAgregar.FechaVenta == DateTime.MinValue || !LibroLogic.IsValidFecha(ventaAgregar.FechaVenta))
            {
                camposErroneos.Add("Fecha Venta");
            }
            if (ventaAgregar.FormaDePago == null)
            {
                camposErroneos.Add("Forma de Pago");
            }
            if (ventaAgregar.Cliente == null)
            {
                camposErroneos.Add("Cliente");
            }
            if (ventaAgregar.Libro == null)
            {
                camposErroneos.Add("Libro");
            }
            if (ventaAgregar.Empleado == null)
            {
                camposErroneos.Add("Empleado");
            }

            if (camposErroneos.Count > 0)
            {
                throw new Exception("Campos incorrectos: " + string.Join(", ", camposErroneos));
            }

            Venta ventaNueva = new Venta();

            ventaNueva.FechaVenta = ventaAgregar.FechaVenta;
            ventaNueva.FormaDePago = ventaAgregar.FormaDePago;
            ventaNueva.Cliente = ventaAgregar.Cliente;
            ventaNueva.Libro = ventaAgregar.Libro;
            ventaNueva.Empleado = ventaAgregar.Empleado;

            _ventaRepository.Create(ventaNueva);
            _ventaRepository.Save();
        }

        public async Task ModificarVenta(Venta ventaModificar,int idVenta)
        {
            List<string> camposErroneos = new List<string>();

            if (ventaModificar.FechaVenta == DateTime.MinValue || !LibroLogic.IsValidFecha(ventaModificar.FechaVenta))
            {
                camposErroneos.Add("Fecha Venta");
            }
            if (ventaModificar.FormaDePago == null)
            {
                camposErroneos.Add("Forma de Pago");
            }
            if (ventaModificar.Cliente == null)
            {
                camposErroneos.Add("Cliente");
            }
            if (ventaModificar.Libro == null)
            {
                camposErroneos.Add("Libro");
            }
            if (ventaModificar.Empleado == null)
            {
                camposErroneos.Add("Empleado");
            }

            if (camposErroneos.Count > 0)
            {
                throw new Exception("Campos incorrectos: " + string.Join(", ", camposErroneos));
            }

            Venta ventaExistente = await _ventaRepository.GetById(idVenta);

            if (ventaExistente == null)
            {
                throw new Exception("Venta no encontrada.");
            }

            ventaExistente.FechaVenta = ventaModificar.FechaVenta;
            ventaExistente.FormaDePago = ventaModificar.FormaDePago;
            ventaExistente.Cliente = ventaModificar.Cliente;
            ventaExistente.Libro = ventaModificar.Libro;
            ventaExistente.Empleado = ventaModificar.Empleado;
           
            _ventaRepository.Update(ventaExistente);
            _ventaRepository.Save();
        }

        public async Task Eliminarventa (int idVenta)
        {
            Venta ventaEliminar = await _ventaRepository.GetById(idVenta);

            if (ventaEliminar == null)
            {
                throw new Exception("Venta no encontrada.");
            }

            _ventaRepository.Delete(ventaEliminar);
            _ventaRepository.Save();
        }
        public async Task<Venta> ConsultaVentaId(int idVenta)
        {
            Venta ventaConsultada = await _ventaRepository.GetById(idVenta);

            if (ventaConsultada == null)
            {
                throw new Exception("Venta no encontrada.");
            }

             return ventaConsultada;

        }
        public IEnumerable<Venta> ObtenerVentasPorFecha(DateTime fecha)
        {
            return _ventaRepository.FindByCondition(v => v.FechaVenta.Date == fecha.Date);
        }
    }
}
