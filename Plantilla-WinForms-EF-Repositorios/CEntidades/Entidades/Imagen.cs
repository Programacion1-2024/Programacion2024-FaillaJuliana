using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Imagen
    {
            public int IdImagen { get; set; }
            public string Nombre { get; set; }
            public string URL { get; set; }
            public long Tamanio { get; set; }
            public string TipoMime { get; set; }
            public string FormularioOrigen { get; set; }
    }
}
