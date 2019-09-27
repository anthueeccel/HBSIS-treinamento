using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        public SistemaCervejaContext cervejaContext = new SistemaCervejaContext();

        /// <summary>
        /// Método que lista todas as cervejas
        /// </summary>
        /// <returns>Lista de cervejas</returns>
        public List<Cerveja> GetCervejas()
        {
            return cervejaContext.ListaDeCervejas;
        }

        /// <summary>
        /// Método que adiciona uma cerveja a lista de cervejas
        /// </summary>
        /// <param name="cerveja">Objeto com parâmentros da Cerveja</param>
        /// <returns>Verdadeiro(adicionado) ou Falso(erro)</returns>
        public bool AddCerveja(Cerveja cerveja)
        {
            try
            {
                cerveja.Id = cervejaContext.idContadorCerveja++;
                cervejaContext.ListaDeCervejas.Add(cerveja);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
                throw;
            }
        }

        /// <summary>
        /// Método que retornar o valor total de cervejas da lista
        /// </summary>
        /// <returns>Valor (double) do total</returns>
        public double SomaValorCervejas()
        {
            return cervejaContext.ListaDeCervejas.Sum(v => v.Valor);

        }


        /// <summary>
        /// Método que retorna a soma total de litros da lista
        /// </summary>
        /// <returns>Valor total em litros(double)</returns>
        public double SomaCervejasEmLitros()
        {
            return cervejaContext.ListaDeCervejas.Sum(v => v.Litros);
        }

        public double TesteAlcoolometria(double peso, string sexo)
        {
            double coeficientePorSexo = (sexo.Equals('f') ? 0.6 : 0.7);
            double taxaAlcoolSangue = 0;

            cervejaContext.ListaDeCervejas.ForEach(x =>
           {
               taxaAlcoolSangue += ((x.Litros * 1000) * (x.Alcool / 100) / (peso * coeficientePorSexo));
           });
            return taxaAlcoolSangue;
        }
    }
}
