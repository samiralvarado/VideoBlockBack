using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoBlock.DL.Data;
using VideoBlock.DL.Model;

namespace VideoBlock.DL.Repositories.Implements
{
   public  class TipopeliculasRepository : GenericRepository<TipoPelicula>, ITipopeliculasRepository
    {
        private readonly VideoBlockContext videoblockContext;
        public TipopeliculasRepository(VideoBlockContext videoblockContext) : base(videoblockContext)
        {
            this.videoblockContext = videoblockContext;
        }

        //    public async Task<bool> DeleteCheckOnEntity(int id)
        //    {
        //        var flag = await universityContext.Enrollments.AnyAsync(x => x.CourseID == id);
        //        return flag;
        //    }
    }
}
