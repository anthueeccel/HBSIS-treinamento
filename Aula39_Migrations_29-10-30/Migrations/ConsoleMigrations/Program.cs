using ConsoleMigrations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMigrations
{
    class Program
    {
        static MigrationContext context = new MigrationContext();
        static void Main(string[] args)
        {
            context.Usuarios.ToList().ForEach(x => Console.WriteLine($"Nome {x.Nome} Login {x.Login} Nivel {x.Nivel}"));

            Console.ReadKey();
        }
    }
}
