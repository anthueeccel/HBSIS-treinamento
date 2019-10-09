using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;

namespace CellDu
{
    class Program
    {
        static CelularController celController = new CelularController();
     
        static void Main(string[] args)
        {
            var option = int.MinValue;
            while (option != 0)
            {
                Console.Clear();

                Console.WriteLine("=====================");
                Console.WriteLine("1 - INSERIR CELULAR  ");
                Console.WriteLine("2 - LISTAR CELULARES");
                Console.WriteLine("3 - ATUALIZAR CELULAR");
                Console.WriteLine("4 - REMOVER CELULAR");
                Console.WriteLine("0 - SAIR DO SISTEMA");
                Console.WriteLine("Escolha uma opção: ");

                option = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        InserirCelular();

                        break;
                    case 2:
                        Console.Clear();
                        ListarCelulares();
                        break;
                    case 3:
                        Console.Clear();
                        AtualizarCelular();
                        break;
                    case 4:
                        Console.Clear();
                        RemoverCelular();
                        break;



                }

                Console.ReadKey(true);

            }

        }

        /// <summary>
        /// Método que adiciona objeto<T> ao banco
        /// </summary>
        public static void InserirCelular()
        {
            Console.WriteLine("-- Inserir Celular --");
            Console.Write("Informe a Marca: ");
            var marca = Console.ReadLine();
            Console.Write("Informe a Modelo: ");
            var modelo = Console.ReadLine();
            Console.Write("Informe a Valor: ");
            var preco = double.Parse(Console.ReadLine());

            var resultado = celController.AddCelular(new Celular
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });
            if (resultado)
                Console.WriteLine("Celular cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar aparelho!");

        }

        /// <summary>
        /// Método para listar os celulares do sistema.
        /// </summary>
        public static void ListarCelulares()
        {
            celController.GetCelulares()
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Id}, {x.Marca}, {x.Modelo}, {x.Preco}"));
        }

        /// <summary>
        /// Método que atualiza um ou mais dados de um celular
        /// </summary>
        public static void AtualizarCelular()
        {
            ListarCelulares();
            
            Console.Write("Informe o ID para alterar: ");
            var id = int.Parse(Console.ReadLine());
            Celular celular = celController.GetCelulares().FirstOrDefault(x => x.Id == id);
            Console.Write("Informe a Marca: ");
            celular.Marca = Console.ReadLine();
            Console.Write("Informe a Modelo: ");
            celular.Modelo = Console.ReadLine();
            Console.Write("Informe a Valor: ");
            celular.Preco = double.Parse(Console.ReadLine());

            if (celController.UpdateCelular(celular))
                Console.WriteLine("Registro atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar aparelho!");

        }

        public static void RemoverCelular()
        {
            ListarCelulares();
            Console.Write("Informe o Id do registro para remover: ");
            var id = int.Parse(Console.ReadLine());

            if (celController.DeleteCelular(id))
                Console.WriteLine("ID: {0} removido com sucesso!", id);
            else
                Console.WriteLine("Erro ao remover i ID " + id);
        }

    }
}
