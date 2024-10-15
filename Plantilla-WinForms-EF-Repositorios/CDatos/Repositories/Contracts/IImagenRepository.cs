using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CDatos.Repositories.Contracts
{
    public interface IIImagenRepository : IRepository<Imagen>
    {
        List<Imagen> ObtenerImagenes();
        List<Imagen> GetByFormName(string formularioOrigen);



    }
}
