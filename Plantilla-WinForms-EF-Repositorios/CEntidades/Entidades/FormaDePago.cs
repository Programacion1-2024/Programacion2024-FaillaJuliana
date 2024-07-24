using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class FormaDePago
    {
        public int IdFormaDePago { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Venta> Venta { get; set; }
        public ICollection<Prestamo> Prestamo { get; set; }


    }
}
