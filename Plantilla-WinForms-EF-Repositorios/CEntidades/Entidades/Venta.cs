using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
         public FormaDePago FormaDePago { get; set; }
        public int IdFormaDePago { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Libro> Libros { get; set; }
        public Empleado Empleado { get; set; }

    }
}
