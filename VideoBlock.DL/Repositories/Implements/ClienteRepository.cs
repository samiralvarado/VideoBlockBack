using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoBlock.DL.Data;
using VideoBlock.DL.Model;

namespace VideoBlock.DL.Repositories.Implements
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly VideoBlockContext videoblockContext;
        public ClienteRepository(VideoBlockContext videoblockContext) : base(videoblockContext)
        {
            this.videoblockContext = videoblockContext;
        }
    }
}
