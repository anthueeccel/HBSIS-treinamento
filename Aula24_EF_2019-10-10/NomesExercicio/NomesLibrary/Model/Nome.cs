using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesLibrary.Model
{
    public class Nome
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string ONome { get; set; }

    }
}
