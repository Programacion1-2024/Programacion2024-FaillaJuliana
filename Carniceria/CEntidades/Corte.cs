using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class Corte
    {
        public int Id { get; set; }
        public string Nombre_Juridico {  get; set; }
        public string Descripcion { get; set; }
        public double Stock_Corte { get; set; }
        public double Precio {  get; set; }
    }
}
