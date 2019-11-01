using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TraducaoRelatorios.Models
{
    [Table("BibliotecaMensagem")]
    public class BibliotecaMensagem
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }


        public virtual ICollection<BibliotecaMensagem> Mensagens { get; set; }

    }
}