using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoBlock.DL.Model;
using VideoBlock.DL.Repositories;
using VideoBlock.DL.Serivces.Implements;

namespace VideoBlock.DL.Services.Implements
{
    public class AlquilerService : GenericService<Alquiler>, IAlquilerService
    {
        private readonly IAlquilerRepository alquilerRepository;
        public AlquilerService(IAlquilerRepository alquilerRepository) : base(alquilerRepository)
        {

            this.alquilerRepository = alquilerRepository;
        }
    }
}
