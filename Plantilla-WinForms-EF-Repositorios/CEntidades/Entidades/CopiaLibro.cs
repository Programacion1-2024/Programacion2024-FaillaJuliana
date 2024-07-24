using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class CopiaLibro 
    {
        public int IdCopiaLibro { get; set; }
        public long PrecioPrestamo { get; set; }
        public Prestamo? Prestamo { get; set; }
        public Libro Libro { get; set; }

    }
}
