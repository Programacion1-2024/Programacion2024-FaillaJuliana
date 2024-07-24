using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Cliente 
    {
        public int IdCliente {  get; set; }
        public bool Membrecia {  get; set; }
        public bool Iva { get; set; }
        public Persona Persona { get; set; }
        public ICollection<Prestamo> Prestamos { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}
