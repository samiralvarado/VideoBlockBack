using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoBlock.DL.Model;
using VideoBlock.DL.Repositories;

namespace VideoBlock.DL.Serivces.Implements
{

    public class TipoPeliculasService : GenericService<TipoPelicula>, ITipopeliculaService
    {
        private readonly ITipopeliculasRepository tipopeliculaRepository;
        public TipoPeliculasService(ITipopeliculasRepository tipopeliculaRepository) : base(tipopeliculaRepository)
        {

            this.tipopeliculaRepository = tipopeliculaRepository;
        }

        //public async Task<bool> DeleteCheckOnEntity(int id)
        //{
        //    var flag = await tipopeliculaRepository.DeleteCheckOnEntity(id);
        //    return flag;
        //}

    }
}
