using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloresLibrary.Model
{
    public class FlorContextDb : DbContext
    {        
        public DbSet<Flor> Flores { get; set; }
    }
}
