using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoBlock.DL.DTOS
{
   public   class AlquilerDTO
    {
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int alquilerID { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int clienteID { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public DateTime fechaAlquiler { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public DateTime fechaDevolucion { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int valorAlquiler { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int cantidad { get; set; }
    }
}
