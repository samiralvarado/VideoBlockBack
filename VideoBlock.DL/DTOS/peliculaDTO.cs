using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoBlock.DL.Model;

namespace VideoBlock.DL.DTOS
{
    public class peliculaDTO
    {
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int id_peliculas { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public int tipopeliculaID { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int actorID { get; set; }
        
        
        
    
    }
}

