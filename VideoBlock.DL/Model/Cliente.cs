using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoBlock.DL.Model
{
    [Table("Cliente", Schema = "dbo")]
    public class Cliente

    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int clienteID { get; set; }

        public string nombre { get; set; }

        public string direccion { get; set; }

        public int telefono { get; set; }
    }

}
