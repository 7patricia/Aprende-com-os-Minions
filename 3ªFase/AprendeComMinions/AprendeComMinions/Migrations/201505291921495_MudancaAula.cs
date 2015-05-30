namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudancaAula : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas");
            DropIndex("dbo.SessaoEstudoAulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "Aula_AulaID" });
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID");
            DropTable("dbo.SessaoEstudoAulas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SessaoEstudoAulas",
                c => new
                    {
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                        Aula_AulaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SessaoEstudo_SessaoEstudoID, t.Aula_AulaID });
            
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.SessaoEstudoAulas", "Aula_AulaID");
            CreateIndex("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID");
            AddForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas", "AulaID", cascadeDelete: true);
            AddForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID", cascadeDelete: true);
        }
    }
}
