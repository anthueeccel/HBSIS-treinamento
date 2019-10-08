using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    [Table("Cervejas", Schema = "SistemaCervejasEF")]
    public class Cerveja
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage ="Min 3 e Máx 50 caracteres", MinimumLength = 3)]
        [Required]
        public string Nome { get; set; }
        [StringLength(30, ErrorMessage = "Min 3 e Máx 30 caracteres", MinimumLength = 3)]
        public string Tipo { get; set; }
        public double Teor { get; set; }


    }
}
