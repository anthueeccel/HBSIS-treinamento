using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Models
{
    public class FirstCoreContext : DbContext
    {
        public FirstCoreContext(DbContextOptions<FirstCoreContext> options)
            : base(options)
        {

        }

        public DbSet<Carros> Carros { get; set; }
    }
}
