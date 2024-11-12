using CDatos.Contracts;
using CEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repository
{
    public class CorteRepository:ICorteRepository
    {
        private readonly CarniceriaContext _context;

        public CorteRepository(CarniceriaContext context)
        {
            _context = context;
        }

        public IQueryable<Corte> GetAll()
        {
            return _context.Corte; 
        }
    }
}
