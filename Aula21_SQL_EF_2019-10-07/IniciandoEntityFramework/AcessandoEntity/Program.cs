using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoaController = new PessoaController();

        static void Main(string[] args)
        {
            AddPessoa();


            GetPessoas();


            Console.ReadKey();
        }

        /// <summary>
        /// Lista as pessoas
        /// </summary>
        public static void GetPessoas()
        {
            pessoaController.GetPessoas()
                .ToList<Pessoa>()
                .ForEach(x => Console.WriteLine(x.Nome));
        }

        /// <summary>
        /// Método que adiciona pessoa no BD
        /// </summary>
        public static void AddPessoa()
        {
            Pessoa pessoa = new Pessoa { Nome = "Gian" };
            pessoaController.AddPessoa(pessoa);
        }





    }
}
