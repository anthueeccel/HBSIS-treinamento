using LocacaoBiblioteca.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Usuario : UsersControls
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Login { get; set; }
        [StringLength(50)]
        public string Senha { get; set; }

    }
}
