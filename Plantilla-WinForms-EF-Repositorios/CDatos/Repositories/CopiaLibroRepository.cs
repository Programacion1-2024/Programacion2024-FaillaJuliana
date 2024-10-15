using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class CopiaLibroRepository : Repository<CopiaLibro>, ICopiaLibroRepository
    {
        public CopiaLibroRepository(LibreriaContext context) : base(context)
        {

        }

        public async Task<List<CopiaLibro>> GetAll()
        {
            try
            {
                return await _context.CopiaLibro.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
