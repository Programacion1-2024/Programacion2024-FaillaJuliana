using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IAutorLogic
    {
        void AltaAutor(string nombre, string apellido, string nacionalidad, string telefono, string email, string biografia);
        void ModificarAutor(string nombre, string apellido, string nacionalidad, string telefono, string email, string biografia);
        void BajaAutor(string documento);
        List<Autor> ConsultaTodosLosAutores();
        List<Autor> ObtenerTodosLosAutoresParaListado();
        Autor ObtenerAutorPorNombreYApellido(string nombre, string apellido);

    }

}
