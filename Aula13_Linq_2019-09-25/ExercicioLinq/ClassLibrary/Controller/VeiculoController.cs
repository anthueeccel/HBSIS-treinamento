using ClassLibrary.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClassLibrary.Controller
{
    public class VeiculoController
    {
        VeiculoContext veiculoContext = new VeiculoContext();

        public string[] meses = { "TODOS", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };


        /// <summary>
        /// Método que lista os veículos cadastrados no sitema
        /// </summary>
        /// <returns></returns>
        public List<Veiculo> listaVeiculos()
        {
            return veiculoContext.ListaDeVeiculos;
        }

        /// <summary>
        /// Método que cria um relatório por mês selecionado pelo usuário
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public List<Veiculo> RelatorioDeVeiculosPorMes(int mes)
        {
            if (mes == 0)
                return listaVeiculos();
            else
                return listaVeiculos().Where(m => m.Data.Month == mes).ToList();
        }
        
        /// <summary>
        /// Método para exportar o relatório gerado para o formato desejado [txt, csv, pdf]
        /// </summary>
        /// <param name="mes">mês do relatório</param>
        /// <param name="formato">formato do arquiv</param>
        /// <param name="lista">lista de veículos</param>
        public void ExportaRelatorio(int mes, int formato, List<Veiculo> lista)
        {

            List<Veiculo> relatorio = lista;

            string templateTxt = "ID: {0,3} | Carro: {1,-35} |Valor: {2,10} | Qtde: {3,3} | Data: {4,10}";
            string templateCsv = "ID: {0,0};Carro: {1,0};Valor: {2,0};Qtde: {3,0};Data: {4,0}";
            string template = string.Empty;
            string extensao = string.Empty;

            if (formato == 1)
            {
                template = templateTxt;
                extensao = ".txt";
            }
            else if (formato == 2)
            {
                template = templateCsv;
                extensao = ".csv";
            }
            else if (formato == 3)
            {
                ExportaPdf(mes, lista);
            }
            try
            {
                using (StreamWriter stm = new StreamWriter($"c:/temp/RelatorioMes{meses[mes]}{extensao}"))
                {
                    stm.WriteLine($"============================ Relatório de vendas do mês {meses[mes]} ===================================");
                    relatorio.ForEach(v => stm.WriteLine(String.Format(template, v.Id, v.Carro, v.Valor.ToString("C2"), v.Quantidade, v.Data.ToShortDateString())));
                    stm.WriteLine($"Valor total no mês: {relatorio.Sum(x => (x.Valor * x.Quantidade)).ToString("C2")}");
                    stm.WriteLine($"Valor médio no mês: {relatorio.Average(x => x.Valor).ToString("C2")}");
                    stm.WriteLine($"===========================Fim do Relatório de vendas do mês {meses[mes]} ==============================");
                    stm.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Console.WriteLine(@"Exportado com sucesso! [c:\temp]  Pressione qulquer tecla...");
        }

        /// <summary>
        /// Método para exportar relatório em formato PDF
        /// </summary>
        /// <param name="mes">mês do relatório</param>
        public void ExportaPdf(int mes, List<Veiculo> lista)
        {
            //var lista = RelatorioDeVeiculosPorMes(mes);

            Document docPdf = new Document(PageSize.A4);

            try
            {
                PdfWriter.GetInstance(docPdf, new FileStream($"c:/temp/Relatorio{meses[mes]}.pdf", FileMode.Create));

                string template = "{0,5} | {1,-70} | {2,12} | {3,5} | {4,13}";


                docPdf.Open();
                docPdf.Add(new Paragraph(DateTime.Now.ToLongDateString()));
                docPdf.Add(new Paragraph($"===== Relatório de vendas do mês {meses[mes]} =============================="));
                docPdf.Add(new Paragraph(@"ID    Carro                                                                         Valor           Qtde     Data "));
                foreach (var v in lista)
                    docPdf.Add(new Paragraph(String.Format(template,
                        v.Id,
                        v.Carro,
                        v.Valor.ToString("C2"),
                        v.Quantidade, v.Data.ToShortDateString()
                        )));
                docPdf.Add(new Paragraph("\r\n" + $"Valor total no mês de {meses[mes]}: {lista.Sum(x => (x.Valor * x.Quantidade)).ToString("C2")}"));
                docPdf.Add(new Paragraph($"Valor médio no mês de {meses[mes]}: {lista.Average(x => x.Valor).ToString("C2")}"));
                docPdf.Add(new Paragraph($"===== Fim do Relatório de vendas do mês {meses[mes]} ========================"));

            }
            catch (DocumentException de)
            {
                Console.Error.WriteLine(de.Message);
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }

            docPdf.Close();
            Console.WriteLine(@"Relatório exportado com sucesso! [c:\temp] Pressione qualquer tecla...");
            Console.ReadKey();

        }
    }
}
