namespace TraducaoRelatorios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BibliotecaMensagemAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.BibliotecaMensagem",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Message = c.String(),
                   BibliotecaMensagem_Id = c.Int(),
               })
               .PrimaryKey(t => t.Id)
               .ForeignKey("dbo.BibliotecaMensagem", t => t.BibliotecaMensagem_Id)
               .Index(t => t.BibliotecaMensagem_Id);


            AddColumn("dbo.BibliotecaMensagem", "teste", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BibliotecaMensagem", "teste");
            DropForeignKey("dbo.BibliotecaMensagem", "BibliotecaMensagem_Id", "dbo.BibliotecaMensagem");
            DropTable("dbo.BibliotecaMensagem");
            DropIndex("dbo.BibliotecaMensagem", new[] { "BibliotecaMensagem_Id" });
        }
    }
}
