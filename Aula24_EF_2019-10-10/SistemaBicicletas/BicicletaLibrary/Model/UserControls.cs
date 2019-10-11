using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaLibrary.Model
{
    public class UserControls
    {
        public bool Ativo { get; set; } = true;
        public int userInclusao { get; set; } = 0;
        public int userAlteracao { get; set; } = 0;
        public DateTime dataInclusao { get; set; } = DateTime.Now;
        public DateTime dataAlteracao { get; set; } = DateTime.Now;

    }
}
