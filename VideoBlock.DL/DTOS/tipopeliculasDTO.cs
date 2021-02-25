using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VideoBlock.DL.DTOS
{
   public  class tipopeliculasDTO
    {
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int tipopeliculaID { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(50)]

        public string categoria { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string titulo { get; set; }







    }
}
