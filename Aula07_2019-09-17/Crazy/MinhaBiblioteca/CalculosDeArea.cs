using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {
        /// <summary>
        /// Método para retornar a área de um quadrado
        /// </summary>
        /// <param name="ladoDoQuadrado">Lado do quadro <Double></Double></param>
        /// <returns>Retorna a área toda do quadrado <Double></returns>
        public double CalculaAreaDoQuadrado(double ladoDoQuadrado)
        {
            return Math.Pow(ladoDoQuadrado,2);
        }

      
    }
}
