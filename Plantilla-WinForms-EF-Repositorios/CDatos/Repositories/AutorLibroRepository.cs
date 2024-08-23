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
    public class AutorLibroRepository : Repository<AutorLibro>, IAutorLibroRepository
    {

        public AutorLibroRepository(LibreriaContext context) : base(context)
        {

        }

        public async Task<List<AutorLibro>> GetAll()
        {
            try
            {
                return await _context.AutorLibro.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
