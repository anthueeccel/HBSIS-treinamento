using ClassLibrary.Controller;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoInterface
{
    class Program
    {
        public static AlunoController alunoController = new AlunoController();
        static void Main(string[] args)
        {
            MenuInical();

        }

        /// <summary>
        /// Método do Menu inicial do sistema
        /// </summary>
        private static void MenuInical()
        {
            int opcao = int.MinValue;

            while (opcao != 0)
            {

            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("1 - Listar Alunos");
            Console.WriteLine("2 - Adicionar Aluno");
            Console.WriteLine("3 - Exluir Aluno");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Selecione a opção: ");
            opcao = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                switch (opcao)
                {
                    case 1:
                        GetAlunos();
                        Console.ReadKey();
                        break;
                    case 2:
                        AddAluno();
                        Console.ReadKey();
                        break;
                        case 3:
                        DelAluno();
                        Console.ReadKey();
                        break;

                    default:
                        break;

                }
            }
        }

        public static void GetAlunos()
        {
            string template = "Id: {0,3} | Nome: {1,-15} | Idade: {2,3}";
                       
            Console.WriteLine("\n\nLista de Alunos");
            alunoController.GetAlunos()
                .ToList<Aluno>()
                .ForEach(x => Console.WriteLine(String.Format(template, x.Id, x.Nome,  x.Idade.ToString())));
                       
        }

        public static void AddAluno()
        {
            Console.WriteLine("\n");
            Aluno aluno = new Aluno();
            Console.Write("[NOVO] Informe o nome: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("[NOVO] Informe a idade: ");
            aluno.Idade = int.Parse(Console.ReadLine());

            bool isSave = alunoController.AddAluno(aluno);
            if(isSave)
                Console.WriteLine($"Aluno {aluno.Nome} inserido com sucesso! Pressione qualque tecla...");
            else
                Console.WriteLine("!!Erro ao gravar no Banco de Dados!! Pressione qualquer tecla...");
        }

        public static void DelAluno()
        {
            GetAlunos();
            Console.Write("[EXCLUIR ]Informe o ID: ");
            int id = int.Parse(Console.ReadKey().KeyChar.ToString());
            alunoController.DelAluno(id);

        }



    }
}
