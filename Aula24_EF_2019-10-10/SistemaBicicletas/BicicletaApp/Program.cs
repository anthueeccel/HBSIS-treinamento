using BicicletaLibrary.Controller;
using BicicletaLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicicletaApp
{
    class Program
    {
        static MarcaController marcaController = new MarcaController();
        static ModeloController modeloController = new ModeloController();
        static BicicletaController bicicletaController = new BicicletaController();
        static Bicicleta bicicleta = new Bicicleta();
        static Marca marca = new Marca();
        static Modelo modelo = new Modelo();

        #region Método Main
        static void Main(string[] args)
        {
            
            MostraMenuSistema();

            Console.ReadKey();
        }
        /// <summary>
        /// Mostra o Menu inicial do sistema (console)
        /// </summary>
        private static void MostraMenuSistema()
        {
            int opcao = int.MinValue;
            while (opcao != 99)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 2.0.1");
                Console.WriteLine("Menu sistema");
                Console.WriteLine("Bicicleta==========");
                Console.WriteLine("1 - Listar bicicleta");
                Console.WriteLine("2 - Cadastra bicicleta");
                Console.WriteLine("3 - Excluir bicicleta");
                Console.WriteLine("4 - Editar bicicleta");
                Console.WriteLine("Marca==============");
                Console.WriteLine("11 - Listar marcas");
                Console.WriteLine("12 - Cadastrar marca");
                Console.WriteLine("13 - Excluir marca");
                Console.WriteLine("14 - Editar marca");
                Console.WriteLine("Modelo=============");
                Console.WriteLine("21 - Listar modelo");
                Console.WriteLine("22 - Cadastra modelo");
                Console.WriteLine("23 - Excluir modelo");
                Console.WriteLine("24 - Editar modelo");
                Console.WriteLine("===================");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        ListarBicicletas();
                        Console.ReadKey();
                        break;
                    case 2:
                        CadastraBicicleta();
                        Console.ReadKey();
                        break;
                    case 3:
                        ExcluiBicicletaPorId();
                        Console.ReadKey();
                        break;
                    case 4:
                        AtualizaBibicleta();
                        Console.ReadKey();
                        break;
                    case 11:
                        ListaMarcas();
                        Console.ReadKey();
                        break;
                    case 12:
                        CadastraMarcas();
                        Console.ReadKey();
                        break;
                    case 13:
                        ExcluiMarcaPorId();
                        Console.ReadKey();
                        break;
                    case 14:
                        AtualizaMarca();
                        Console.ReadKey();
                        break;
                    case 21:
                        ListaModelos();
                        Console.ReadKey();
                        break;
                    case 22:
                        CadastraModelo();
                        Console.ReadKey();
                        break;
                    case 23:
                        ExcluiModeloPorId();
                        Console.ReadKey();
                        break;
                    case 24:
                        AtualizaModelo();
                        Console.ReadKey();
                        break;


                    case 0:
                        Console.Write("\nEncerrando sistema");
                        opcao = 99;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
             

        /// <summary>
        /// Método que lista os bicicletas cadastrados no sistema
        /// </summary>
        private static void ListarBicicletas()
        {
            Console.WriteLine("Lista de bicicletas:");
            bicicletaController.GetBicicletas()
                .ToList()
                .ForEach(s => Console.WriteLine($"ID: {s.Id} NOME: {s.Descricao}"));

        }

        /// <summary>
        /// Método que cadastra bicicleta no sistema
        /// </summary>
        private static void CadastraBicicleta()
        {
            bicicleta = new Bicicleta();

            Console.Write("Informe a descrição: ");
            bicicleta.Descricao = Console.ReadLine();
            modeloController.GetModelos()
                .ToList<Modelo>()
                .ForEach(x => Console.WriteLine($"ID: {x.Id} MODELO: {x.Descricao}"));
            Console.Write("Informe o ID do modelo: ");
            bicicleta.ModeloId = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor: R$");
            bicicleta.Valor = double.Parse(Console.ReadLine());

            new Bicicleta()
            {
                Descricao = bicicleta.Descricao,
                ModeloId = bicicleta.ModeloId,
                Valor = bicicleta.Valor
            };

            if (bicicletaController.AddBicicleta(bicicleta))
                Console.WriteLine("Usuário cadastrado com sucesso! (Press any key...)");
            else
                Console.WriteLine("Erro ao cadastrar");
        }

        /// <summary>
        /// Inativa Bicicleta por Id
        /// </summary>
        private static void ExcluiBicicletaPorId()
        {
            ListarBicicletas();
            Console.WriteLine("Informe o ID: ");
            int id = int.Parse(Console.ReadLine());
            bicicletaController.GetBicicleta(bicicleta);
            Console.Write("Confirma desativar este registro? (S/N)");
            var confirmaExclusao = Console.ReadKey().KeyChar.ToString().ToLower();
            if (confirmaExclusao == "s")
                bicicletaController.RemoverBicicletaPorId(id);
        }

        private static void AtualizaBibicleta()
        {
            ListarBicicletas();
            Console.Write("Informe o ID para atualizar: ");
            bicicleta.Id = int.Parse(Console.ReadLine());
            var livro = bicicletaController.GetBicicletas()
                .ToList()
                .SingleOrDefault(x => x.Id == bicicleta.Id);
            Console.Write("Descrição: ");
            bicicleta.Descricao = Console.ReadLine();
            Console.Write("Senha: ");
            bicicleta.ModeloId = int.Parse(Console.ReadLine());
            if (bicicletaController.UpdateBicicleta(bicicleta))
                Console.WriteLine("Usuario Atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao salvar alteração");
        }
        
        /// <summary>
        /// Método que lista Marcas cadastradas no sistema
        /// </summary>               
        private static void ListaMarcas()
        {

            Console.WriteLine("Lista de marcas cadastrads:");
            marcaController.GetMarcas()
                .ToList<Marca>()
                .ForEach(x => Console.WriteLine($"ID: {x.Id}| NOME: {x.Descricao}"));
        }

        /// <summary>
        /// Método que cadastra um Marca no sistema
        /// </summary>
        private static void CadastraMarcas()
        {
            Console.WriteLine("Cadastrar marca no sistema");
            Console.Write("Informe  o nome da marca: ");
            var descricao = Console.ReadLine();

            marcaController.AddMarca(new Marca()
            {
                Descricao = descricao,
                Ativo = true

            });
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        /// <summary>
        /// Método que Exclui/Inativa um livro do sistema
        /// </summary>
        private static void ExcluiMarcaPorId()
        {
            ListaMarcas();
            Console.WriteLine("Informe o ID: ");
            int id = int.Parse(Console.ReadLine());
            //livrosController.ListarLivros();
            Console.Write("Confirma inativar esta Marca? (S/N)");
            var confirmaExclusao = Console.ReadKey().KeyChar.ToString().ToLower();
            if (confirmaExclusao == "s")
                marcaController.RemoverMarcaPorId(id);
        }

        /// <summary>
        /// Método que atualiza os dados da Marca no sistema
        /// </summary>
        private static void AtualizaMarca()
        {

            ListaMarcas();
            Console.Write("Informe o ID para atualizar: ");
            int id = int.Parse(Console.ReadLine());
            var marca = marcaController.GetMarcas().ToList()
                .SingleOrDefault(x => x.Id == id);
            Console.Write("Nome: ");
            marca.Descricao = Console.ReadLine();
            if (marcaController.UpdateMarca(marca))
                Console.WriteLine("Livro Atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao salvar alteração");

        }

        /// <summary>
        /// Método que lista Marcas cadastradas no sistema
        /// </summary>               
        private static void ListaModelos()
        {

            Console.WriteLine("Lista de modelo cadastrads:");
            modeloController.GetModelos()
                .ToList<Modelo>()
                .ForEach(x => Console.WriteLine($"ID: {x.Id}| NOME: {x.Descricao}"));
        }

        /// <summary>
        /// Método que cadastra um Marca no sistema
        /// </summary>
        private static void CadastraModelo()
        {
            Console.WriteLine("Cadastrar modelo no sistema");
            Console.Write("Informe  a descrição modelo: ");
            var descricao = Console.ReadLine();

            modeloController.AddModelo(new Modelo()
            {
                Descricao = descricao,

            });
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        /// <summary>
        /// Método que Exclui/Inativa um Modelo do sistema
        /// </summary>
        private static void ExcluiModeloPorId()
        {
            ListaModelos();
            Console.WriteLine("Informe o ID: ");
            int id = int.Parse(Console.ReadLine());
            //livrosController.ListarLivros();
            Console.Write("Confirma inativar esta Modelo? (S/N)");
            var confirmaExclusao = Console.ReadKey().KeyChar.ToString().ToLower();
            if (confirmaExclusao == "s")
                marcaController.RemoverMarcaPorId(id);
        }

        /// <summary>
        /// Método que atualiza os dados do Modelo no sistema
        /// </summary>
        private static void AtualizaModelo()
        {

            ListaModelos();
            Console.Write("Informe o ID para atualizar: ");
            int id = int.Parse(Console.ReadLine());
            ListaMarcas();
            Console.Write("Modelo: ");
            modelo.Descricao = Console.ReadLine();
            if (marcaController.UpdateMarca(marca))
                Console.WriteLine("Modelo Atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao salvar alteração");

        }







    }
}

