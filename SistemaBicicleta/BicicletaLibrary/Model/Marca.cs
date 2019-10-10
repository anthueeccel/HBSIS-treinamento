using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Model
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public int Descricao { get; set; }


    }
}
