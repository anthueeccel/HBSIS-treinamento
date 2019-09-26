using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class VeiculoContext
    {


        public VeiculoContext()
        {
            carregaLista();
        }


        private List<Veiculo> carregaLista() { 
            //Instância da lista que será preenchida
            ListaDeVeiculosPrivada = new List<Veiculo>();

            //Retorna todas as linhas do arquivo em um array
            //de string, onde cada linha será um índice do array
            string[] array = File.ReadAllLines(@"C:\Users\900066\source\repos\anthueeccel\proway\Aula13\Sep-25-2019.txt");
            if (array.Equals(null))
                Console.WriteLine("Arquivo ou caminho inválido");
            else
            {
                //percorre o array e para cada linha
                for (int i = 0; i < array.Length; i++)
                {
                    //cria um objeto do tipo Pessoa
                    Veiculo c = new Veiculo();

                    //Split para 'quebrar' as linhas da Array em um Array auxiliar 
                    //do arquivo txt carregado, separando por ';'. Cada índice 
                    // representa uma propriedade da Classe                
                    string[] auxiliar = array[i].Split(';');

                    // Preencher os dados da Array nas propriedades da Classe
                    // na List<Pessoa>
                    c.Id = Convert.ToInt32(auxiliar[0]);

                    c.Carro = auxiliar[1].Trim();
                    var convertValor = auxiliar[2].Replace(",",".");
                    c.Valor = double.Parse(convertValor);
                    c.Quantidade = Convert.ToInt32(auxiliar[3]);
                    c.Data = DateTime.Parse(auxiliar[4]);

                    ListaDeVeiculosPrivada.Add(c);
                }
                
                return ListaDeVeiculosPrivada;
            }
            return null;
        }


        public List<Veiculo> ListaDeVeiculos { get { return ListaDeVeiculosPrivada;} }
        private List<Veiculo> ListaDeVeiculosPrivada { get; set; }


      

    }
}

