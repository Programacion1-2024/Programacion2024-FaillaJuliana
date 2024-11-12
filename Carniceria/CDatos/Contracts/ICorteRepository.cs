using CEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Contracts
{
    public interface ICorteRepository
    {
        IQueryable<Corte> GetAll();
    }
}
