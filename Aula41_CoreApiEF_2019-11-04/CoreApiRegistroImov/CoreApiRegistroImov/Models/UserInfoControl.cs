using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiRegistroImov.Models
{
    public class UserInfoControl
    {
        public bool Ativo { get; set; }
        public int UsuarioCriacao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
