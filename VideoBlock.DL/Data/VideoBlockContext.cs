using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoBlock.DL.Model;

namespace VideoBlock.DL.Data
{
    public class VideoBlockContext : DbContext
    {

        public static VideoBlockContext videoblockContext = null;
        public VideoBlockContext()
            : base("VideoBlockContext")

        {

        }

        public DbSet<TipoPelicula> TipoPelicula { get; set; }
        public DbSet<Alquiler> Alquiler { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Pelicula> Pelicula { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        


        public static VideoBlockContext Create()
        {

            return new VideoBlockContext();


        }
    }
}

