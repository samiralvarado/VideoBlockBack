using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoBlock.DL.Model;
using VideoBlock.DL.Repositories;
using VideoBlock.DL.Serivces;
using VideoBlock.DL.Serivces.Implements;

namespace VideoBlock.DL.Services.Implements
{
   public class ClienteService : GenericService<Cliente>, IClienteService
    {
        private readonly IClienteRepository clienteRepository;
        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {

            this.clienteRepository = clienteRepository;
        }
    }
}
