namespace TraducaoRelatorios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BibliotecaMensagemUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BibliotecaMensagem", "BibliotecaMensagem_Id", "dbo.BibliotecaMensagem");
            DropIndex("dbo.BibliotecaMensagem", new[] { "BibliotecaMensagem_Id" });
            AddColumn("dbo.BibliotecaMensagem", "Key", c => c.String());
            DropColumn("dbo.BibliotecaMensagem", "teste");
            DropColumn("dbo.BibliotecaMensagem", "BibliotecaMensagem_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BibliotecaMensagem", "BibliotecaMensagem_Id", c => c.Int());
            AddColumn("dbo.BibliotecaMensagem", "teste", c => c.String());
            DropColumn("dbo.BibliotecaMensagem", "Key");
            CreateIndex("dbo.BibliotecaMensagem", "BibliotecaMensagem_Id");
            AddForeignKey("dbo.BibliotecaMensagem", "BibliotecaMensagem_Id", "dbo.BibliotecaMensagem", "Id");
        }
    }
}
