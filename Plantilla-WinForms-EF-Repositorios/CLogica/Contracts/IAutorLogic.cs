using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IAutorLogic
    {
        void AltaAutor(Autor autor);
        void ModificarAutor(string documento, Autor autorModificar);
        void BajaAutor(string documento);
        Autor ConsultaAutor(string documento);     
        Task<List<Autor>> ConsultaTodosLosAutoresAsync(); 
    }

}
