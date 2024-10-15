using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class ImagenRepository : Repository<Imagen>, IIImagenRepository
    {
        public ImagenRepository(LibreriaContext context) : base(context)
        {

        }

        public List<Imagen> ObtenerImagenes()
        {
            return _context.Imagen.ToList();
        }
        public List<Imagen> GetByFormName(string formularioOrigen)
        {
            return  _context.Imagen
                .Where(i => i.FormularioOrigen == formularioOrigen)
                .ToList();
        }
    }
}

