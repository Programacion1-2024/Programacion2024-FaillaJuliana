using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; } 
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaLimite { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public Cliente Cliente { get; set; }
        public FormaDePago FormaDePago { get; set; }
        public CopiaLibro CopiaLibro { get; set; }
        public Empleado Empleado { get; set; }



    }
}
