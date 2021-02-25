using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoBlock.DL.Model
{
    [Table("Peliculas", Schema = "dbo")]
    public   class Pelicula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_peliculas { get; set; }

        [ForeignKey("tiposPelicula")]
        public int tipopeliculaID { get; set; }

        [ForeignKey("Actor")] 
        public int actorID { get; set; }

        public TipoPelicula tiposPelicula { get; set; }
        public Actor Actor { get; set; }


    }
}
