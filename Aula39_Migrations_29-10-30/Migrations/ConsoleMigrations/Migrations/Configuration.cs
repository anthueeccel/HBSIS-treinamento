namespace ConsoleMigrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleMigrations.Model.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsoleMigrations.Model.MigrationContext";
        }

        protected override void Seed(ConsoleMigrations.Model.MigrationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Usuarios.AddOrUpdate(x => x.Nome,new Model.Usuario() {
                Nome = "Anthue",
                Login = "admin",
                Senha = "admin",
                Email = "admin@admin.com.br",
                Nivel = Model.Nivel.Administrador

            });

            //context.Usuarios.AddOrUpdate(new Model.Usuario()
            //{
            //    Nome = "Anthue",
            //    Login = "admin",
            //    Senha = "admin",
            //    Email = "admin@admin.com.br"

            //});


        }
    }
}
