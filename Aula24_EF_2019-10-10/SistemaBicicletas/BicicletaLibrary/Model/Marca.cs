using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Model
{
    [Table("Marcas")]
    public class Marca : UserControls
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        [Display(Name="Descrição")]
        public string Descricao { get; set; }


    }
}
