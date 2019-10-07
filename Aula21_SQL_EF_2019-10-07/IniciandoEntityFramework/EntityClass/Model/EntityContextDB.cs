using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : DbContext
    {
        //DbSet especifica a tabela no BD
        public DbSet<Pessoa> ListaDePessoas { get; set; }

    }
}
