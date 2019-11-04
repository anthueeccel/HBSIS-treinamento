using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoPesoWebApi.Models
{
    public class CalcContext : DbContext
    {
        public CalcContext(DbContextOptions<CalcContext> options)
            : base (options)
        {
        }

        public DbSet<Calculadora> calculos { get; set; }
    }
}
