using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext 
    {
        public int idContadorLivro { get; set; } = 1;
        public int idContadorUsuario { get; set; } = 1;



        /// <summary>
        /// Método construtos que prepara nossa calsse LocacaoContext
        /// </summary>
        public LocacaoContext()
        {
            //Popula a lista de livros
            ListaDeLivros = new List<Livro>();
            ListaDeLivros.Add(
           new Livro()
           {
               Id = ++idContadorLivro,
               Nome = "Use a Cabeça C#",
               Ativo = true
           });
            ListaDeLivros.Add(
            new Livro()
            {
                Id = ++idContadorLivro,
                Nome = "Use a Cabeça SQL",
                Ativo = true
            });
            ListaDeLivros.Add(
            new Livro()
            {
                Id = ++idContadorLivro,
                Nome = "Guia do Mochileiro das Galáxias",
                Ativo = true
            });
            ListaDeLivros.Add(
            new Livro()
            {
                Id = ++idContadorLivro,
                Nome = "Aprendendo Lógica de Programação",
                Ativo = true
            });

            // Popula a lista de usuarios
            ListaDeUsuarios = new List<Usuario>();
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = ++idContadorUsuario,
                Login = "admin",
                Senha = "admin",
                Ativo = true
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = ++idContadorUsuario,
                Login = "anthue",
                Senha = "1234",
                Ativo = true
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = ++idContadorUsuario,
                Login = "usuario1",
                Senha = "1234",
                Ativo = true
            });

        }
                
        public List<Usuario> ListaDeUsuarios { get; set; }
        public List<Livro> ListaDeLivros { get; set; }


        ///// <summary>
        ///// Popula lista de Usuarios
        ///// </summary>
        //public List<Usuario> PopulaListaUsuarios()
        //{
        //    ListaDeUsuarios = new List<Usuario>();

        //    ListaDeUsuarios.Add(new Usuario()
        //    {
        //        Id = ++idContador,
        //        Login = "admin",
        //        Senha = "admin",
        //        Ativo = true
        //    });
        //    ListaDeUsuarios.Add(new Usuario()
        //    {
        //        Id = ++idContador,
        //        Login = "anthue",
        //        Senha = "1234",
        //        Ativo = true
        //    });
        //    ListaDeUsuarios.Add(new Usuario()
        //    {
        //        Id = ++idContador,
        //        Login = "usuario1",
        //        Senha = "1234",
        //        Ativo = true
        //    });
        //    return ListaDeUsuarios;
        //}


        ///// <summary>
        ///// Popula lista de Livros
        ///// </summary>
        //public List<Livro> PopulaListaLivros()
        //{

        //    //Popula a lista de livros
        //    ListaDeLivros = new List<Livro>();

        //    ListaDeLivros.Add(
        //   new Livro()
        //   {
        //       Id = ++idContador,
        //       Nome = "Use a Cabeça C#",
        //       Ativo = true
        //   });
        //    ListaDeLivros.Add(
        //    new Livro()
        //    {
        //        Id = ++idContador,
        //        Nome = "Use a Cabeça SQL",
        //        Ativo = true
        //    });
        //    ListaDeLivros.Add(
        //    new Livro()
        //    {
        //        Id = ++idContador,
        //        Nome = "Guia do Mochileiro das Galáxias",
        //        Ativo = true
        //    });
        //    ListaDeLivros.Add(
        //    new Livro()
        //    {
        //        Id = ++idContador,
        //        Nome = "Aprendendo Lógica de Programação",
        //        Ativo = true
        //    });
        //    return ListaDeLivros;
        //}


    }
}
