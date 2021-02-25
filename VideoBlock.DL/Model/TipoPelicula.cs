using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VideoBlock.DL.Model
{
    [Table("TipoPelicula", Schema = "dbo")]
    public class TipoPelicula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tipopeliculaID { get; set; }

        public string categoria { get; set; }

        public string titulo { get; set; }

        public virtual ICollection<Pelicula> Pelicula { get; set; }
    }
}
