using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Populando a lista cestaDeFrutas
            var cestaDeFrutas = new List<Fruta>();

            //Tomate
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            //Goiaba
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            //Manga
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 325
            });
            #endregion

            #region Exemplo de #region (início)
            cestaDeFrutas
                .OrderByDescending(x => x.Id)
                .ToList()
                .ForEach(i => Console.WriteLine($"Id: {i.Id}| Nome: {i.Nome}| Peso: {i.Peso}"));
            #endregion
            Console.WriteLine("\n--------------------------------");
            cestaDeFrutas
                .OrderBy(x => x.Id)
                .ToList()
                .ForEach(i => Console.WriteLine($"Id: {i.Id}| Nome: {i.Nome}| Peso: {i.Peso}"));
            Console.WriteLine("\n--------------------- Filtro Peso > 100");

            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome);
            filtroCesta.ToList<Fruta>()
                .ForEach(x => Console.WriteLine($"Id: {x.Id}| Nome {x.Nome}| Peso: {x.Peso}"));

            Console.WriteLine("\n--------------------- Filtro Nome = Manga");
            var outroFiltro = from frutinha in cestaDeFrutas
                              where frutinha.Nome == "Manga" && frutinha.Peso > 100
                              select frutinha;
            outroFiltro.ToList<Fruta>().ForEach(f => Console.WriteLine($"Id: {f.Id}| Nome {f.Nome}| Peso: {f.Peso}"));

            Console.WriteLine("\n----------------Outro Filtro Nome = Manga");
            (from frutinha in cestaDeFrutas
             where frutinha.Nome == "Manga" && frutinha.Peso > 100
             select frutinha).ToList<Fruta>()
                              .ForEach(f => Console.WriteLine($"Id: {f.Id}| Nome {f.Nome}| Peso: {f.Peso}"));

            Console.WriteLine("\n--------------------- Filtro Find");
            var filtroFind = cestaDeFrutas.Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            Console.WriteLine($"Id: {filtroFind.Id}| Nome {filtroFind.Nome}| Peso: {filtroFind.Peso}");

            Console.WriteLine("\n--------------------- Filtro FindAll");
            cestaDeFrutas.FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho")
                .ForEach(f => Console.WriteLine($"Id: {f.Id}| Nome {f.Nome}| Peso: {f.Peso}"));

            Console.WriteLine("\n--------------------- Filtro Find com OrderBy");
            var cestaDeFrutasFindOrder = cestaDeFrutas
                .OrderBy(c => c.Nome)
                .ToList<Fruta>()
                .Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id: {cestaDeFrutasFindOrder.Id} Nome: {cestaDeFrutasFindOrder.Nome}");

            Console.ReadKey();

        }
    }
}
