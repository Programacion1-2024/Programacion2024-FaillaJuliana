using CDatos.Contracts;
using CEntidades;
using CNegocio.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Logic
{
    public class CorteLogic :ICorteLogic
    {
        private readonly ICorteRepository _corteRepository;

        public CorteLogic(ICorteRepository corteRepository)
        {
            _corteRepository = corteRepository;
        }

        public List<dynamic> ObtenerCortes()
        {
            return _corteRepository.GetAll()
                          .Select(c => new
                          {
                              c.Nombre_Juridico,
                              c.Descripcion,
                              c.Stock_Corte,
                              c.Precio
                          })
                          .ToList<dynamic>(); 
        }
    }
}
