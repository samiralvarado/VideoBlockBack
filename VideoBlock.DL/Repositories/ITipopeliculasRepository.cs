﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoBlock.DL.Model;

namespace VideoBlock.DL.Repositories
{
    public interface ITipopeliculasRepository : IGenericRepository<TipoPelicula>
    {
        //Task<bool> DeleteCheckOnEntity(int id);
    }
}