

using CEntidades.Entidades;

namespace CDatos.Repositories.Contracts
{
    public interface IAutorRepository : IRepository<Autor>
    {
        Task<List<Autor>> GetAll();
        void CrearAutor(Autor autor);
        List<Autor> ObtenerAutores();
        Autor GetByNombreYApellido(string nombre, string apellido);
        Autor ObtenerPorId(string idAutor);
         List<Autor> ObtenerPorIdLista(List<int> ids);


    }
}
