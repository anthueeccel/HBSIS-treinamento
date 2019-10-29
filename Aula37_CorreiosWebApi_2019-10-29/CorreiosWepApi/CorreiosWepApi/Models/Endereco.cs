using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CorreiosWepApi.Models
{
    public class Endereco
    {

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Logradouro { get; set; }
        [StringLength(30)]
        public string Bairro { get; set; }
        [StringLength(9)]
        public string Cep { get; set; }
        [StringLength(30)]
        public string Uf { get; set; }
        [StringLength(50)]
        public string Municipio { get; set; }
        [StringLength(50)]
        public string Complemento { get; set; }



    }
}