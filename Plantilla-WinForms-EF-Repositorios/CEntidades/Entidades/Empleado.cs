using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Puesto {  get; set; }
        public long Sueldo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Persona Persona { get; set; }
        public ICollection<Prestamo> Prestamos { get; set; }
        public ICollection<Venta>Ventas { get; set; }   
    }

}
