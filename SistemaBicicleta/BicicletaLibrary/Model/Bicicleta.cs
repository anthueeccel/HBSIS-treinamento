using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Model
{
    public class Bicicleta
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Descricao { get; set; }

        //[ForeignKey("Id")]
        public Modelo ModeloId { get; set; }


    }
}
