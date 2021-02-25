using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoBlock.DL.DTOS
{
    public class actorDTO
    {
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int actorID { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string nombreActor { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public DateTime fechaNacimiento { get; set; }
    }
}
