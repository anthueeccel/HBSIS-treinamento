using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaRegistroImoveis.Models
{
    public class Imovel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(9)]
        public string Cep { get; set; }
        [StringLength(50)]
        public string Logradouro { get; set; }
        [StringLength(30)]
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public int Numero { get; set; }
        [StringLength(50)]
        public string Complemento { get; set; }
        public int ProprietarioId { get; set; }

    }
}