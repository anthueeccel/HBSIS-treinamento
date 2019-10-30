namespace SistemaRegistroImoveis.Migrations
{
    using SistemaRegistroImoveis.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaRegistroImoveis.Models.ProprietarioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SistemaRegistroImoveis.Models.ProprietarioContext";
            ContextKey = "SistemaRegistroImoveis.Models.ImovelContext";
        }

        protected override void Seed(SistemaRegistroImoveis.Models.ProprietarioContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Proprietarios.AddOrUpdate(new Proprietario()
            {
                Nome = "Admin",
                DtNascimento = DateTime.Now.AddYears(-30).AddDays(-15).AddMonths(-5),
                Email = "admin@admin.com"
            });


            context.Imovels.AddOrUpdate(new Imovel()
            {
                Logradouro = "Rua 15 de Novembro",
                Bairro = "Centro",
                Municipio = "Blumenau",
                Numero = 140,
                Cep = "89010-000",
                Complemento = "ao lado do predio",
                ProprietarioId = 1,

            }) ;

        }




    }
}
