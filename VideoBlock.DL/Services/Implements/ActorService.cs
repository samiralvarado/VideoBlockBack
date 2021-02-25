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
    public class ActorService : GenericService<Actor>, IActorService
    {
        private readonly IActorRepository actorRepository;
        public ActorService(IActorRepository actorRepository) : base(actorRepository)
        {

            this.actorRepository = actorRepository;
        }
    }
}
