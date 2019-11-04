using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiRegistroImov.Models
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options)
          : base(options)
        {

        }

        public DbSet<Imovel> imoveis { get; set; }
        public DbSet<Proprietario> proprietarios { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
    }
}
