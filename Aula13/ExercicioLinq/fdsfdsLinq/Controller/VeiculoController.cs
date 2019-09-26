using Linq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Controller
{
    public class VeiculoController
    {
        VeiculoContext veiculoContext = new VeiculoContext();

        /// <summary>
        /// Método que lista os veículos cadastrados no sitema
        /// </summary>
        /// <returns></returns>
        public List<Veiculo> listaVeiculos()
        {
            return veiculoContext.carregaLista();
        }

        public List<Veiculo> RelatorioDeVeiculosPorMes(int mes)
        {
            return listaVeiculos().Where(m => m.Data.Month == mes).ToList();
        }
    }
}
