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
    public class PeliculaService : GenericService<Pelicula>, IPeliculaService
    {
        private readonly IPeliculaRepository peliculaRepository;
        public PeliculaService(IPeliculaRepository peliculaRepository) : base(peliculaRepository)
        {

            this.peliculaRepository = peliculaRepository;
        }
    }
}
