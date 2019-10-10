using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Model
{
    public class Modelo
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Id")]
        public Marca IdMarca { get; set; }
        [StringLength(30)]
        public int Descricao { get; set; }



    }
}
