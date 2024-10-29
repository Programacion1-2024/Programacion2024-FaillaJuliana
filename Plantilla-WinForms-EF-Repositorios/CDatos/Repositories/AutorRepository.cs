using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CDatos.Repositories
{
    public class AutorRepository : Repository<Autor>, IAutorRepository
    {

        public AutorRepository(LibreriaContext context) : base(context)
        {
            
        }

        public async Task<List<Autor>> GetAll()
        {
            try
            {
                return await _context.Autor.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Autor> ObtenerAutores()
        {
            return _context.Autor.Include(u => u.Persona).ToList();
        }
        public void CrearAutor(Autor autor)
        {
            _context.Autor.Attach(autor);
            _context.SaveChanges();
        }
        public Autor GetByNombreYApellido(string nombre, string apellido)
        {
            return _context.Autor
                           .Include(a => a.Persona) 
                           .FirstOrDefault(a => a.Persona.Nombre == nombre && a.Persona.Apellido == apellido);
        }
        public Autor ObtenerPorId(string idAutor)
        {
            if (int.TryParse(idAutor, out int id))
            {
                return _context.Autor
                    .Include(a => a.Persona) 
                    .FirstOrDefault(a => a.IdAutor == id);
            }
            return null;
        }
        public List<Autor> ObtenerPorIdLista(List<int> ids)
        {
            return _context.Autor.Where(a => ids.Contains(a.IdAutor)).ToList();
        }

    }
}
