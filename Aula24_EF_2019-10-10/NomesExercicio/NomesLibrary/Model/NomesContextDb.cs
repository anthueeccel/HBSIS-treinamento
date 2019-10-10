using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesLibrary.Model
{
    public class NomesContextDb : DbContext
    {
        public DbSet<Nome> Nomes { get; set; }


    }
}
