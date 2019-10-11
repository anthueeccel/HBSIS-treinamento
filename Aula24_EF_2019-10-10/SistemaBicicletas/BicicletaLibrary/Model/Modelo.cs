using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Model
{
    [Table("Modelos")]
    public class Modelo : UserControls
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Id")]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }


        [StringLength(30)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }



    }
}
