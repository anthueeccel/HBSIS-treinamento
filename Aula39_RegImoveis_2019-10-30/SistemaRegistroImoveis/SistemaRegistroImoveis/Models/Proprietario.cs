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
        [CustomValidator("Nome")]
        public string Nome { get; set; }
        
        
        [CustomValidator("DtNascimento")]
        public DateTime DtNascimento { get; set; }




        [StringLength(50)]
        [CustomValidator("Email")]
        [EmailAddress]
        public string Email { get; set; }

    }
}