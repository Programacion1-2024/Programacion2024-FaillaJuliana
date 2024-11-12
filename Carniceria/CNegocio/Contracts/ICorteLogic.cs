using CEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Contracts
{
    public interface ICorteLogic
    {
         List<dynamic> ObtenerCortes();
    }
}
