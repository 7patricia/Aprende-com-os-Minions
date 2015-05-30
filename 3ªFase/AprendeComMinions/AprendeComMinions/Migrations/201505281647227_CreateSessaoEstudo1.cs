namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSessaoEstudo1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
        }
    }
}
