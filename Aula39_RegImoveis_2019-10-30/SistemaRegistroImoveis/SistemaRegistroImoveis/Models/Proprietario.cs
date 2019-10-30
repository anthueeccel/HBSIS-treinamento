using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaRegistroImoveis.Models
{
    public class Proprietario
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        [StringLength(50)]
        public string Email { get; set; }

    }
}