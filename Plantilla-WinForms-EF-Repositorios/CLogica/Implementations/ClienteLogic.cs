using CDatos.Repositories.Contracts;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class ClienteLogic : ICLienteLogic
    {
        IClienteRepository _clienteRepository;
        public ClienteLogic(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
