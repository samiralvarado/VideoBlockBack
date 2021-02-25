using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VideoBlock.DL.DTOS
{
   public  class clienteDTO
    {
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int clienteID { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int telefono { get; set; }
    }
}
