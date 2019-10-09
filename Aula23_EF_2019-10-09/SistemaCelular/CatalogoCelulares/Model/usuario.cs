using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class Usuario : ControleUsuario
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Deve conter {0} no mínimo {2} caracteres.", MinimumLength = 6)]
        public string Nome { get; set; }
        [StringLength(30, ErrorMessage = "Deve conter {0} no mínimo {2} caracteres.", MinimumLength = 4)]
        [Required]
        public string Login { get; set; }
        [StringLength(30, ErrorMessage = "Deve conter {0} no mínimo {2} caracteres.", MinimumLength = 4)]
        [Required]
        public string Senha { get; set; }


    }
}
