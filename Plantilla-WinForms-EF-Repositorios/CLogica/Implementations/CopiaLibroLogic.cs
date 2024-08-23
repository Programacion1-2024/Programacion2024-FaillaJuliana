using CDatos.Repositories.Contracts;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class CopialibroLogic : ICopiaLibroLogic
    {
        ICopiaLibroRepository _copiaLibroRepository;
        public CopialibroLogic(ICopiaLibroRepository copiaLibroRepository)
        {
            _copiaLibroRepository = copiaLibroRepository;
        }
    }
}
