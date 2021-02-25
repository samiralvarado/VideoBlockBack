using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoBlock.DL.Model
{
    [Table("Actor", Schema = "dbo")]
    public class Actor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int actorID { get; set; }

        public string nombreActor { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
