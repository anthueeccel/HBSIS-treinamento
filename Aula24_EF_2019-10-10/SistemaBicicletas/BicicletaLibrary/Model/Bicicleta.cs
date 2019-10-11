using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Model
{
    [Table("Bicicletas")]
    public class Bicicleta : UserControls
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; } 
        
        [ForeignKey("Id")]
        public int ModeloId  { get; set; }
        public Modelo Modelo { get; set; }

        public double Valor { get; set; }
    }
}
