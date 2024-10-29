using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories.Contracts
{
    public interface ILibroRepository : IRepository<Libro>
    {
        Task<List<Libro>> GetAll();
        Libro ObtenerPorId(string idLibro);
        List<Libro> ObtenerPorIdLista(List<int> ids);

    }

}
