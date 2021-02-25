using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoBlock.DL.Model
{
    public enum Grade
    {

        A, B, C, D, E

    }
    [Table("Alquiler", Schema = "dbo")]
    public class Alquiler
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int alquilerID { get; set; }


        [ForeignKey("Clientes")]
        public int clienteID { get; set; }


        public DateTime fechaAlquiler { get; set; }

        public DateTime fechaDevolucion { get; set; }

        public int valorAlquiler { get; set; }

        public int cantidad { get; set; }

        public Cliente Clientes { get; set; }
    }
}
