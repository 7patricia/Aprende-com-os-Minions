namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracoesResposta : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas");
            DropIndex("dbo.SessaoEstudoAulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "Aula_AulaID" });
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            AddColumn("dbo.SessaoEstudoes", "Aula_AulaID", c => c.Int());
            AddColumn("dbo.Respostas", "RespD", c => c.Int(nullable: false));
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1");
            CreateIndex("dbo.SessaoEstudoes", "Aula_AulaID");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes", "SessaoEstudoID");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes", "SessaoEstudoID");
            AddForeignKey("dbo.SessaoEstudoes", "Aula_AulaID", "dbo.Aulas", "AulaID");
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
            
            DropForeignKey("dbo.SessaoEstudoes", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropIndex("dbo.SessaoEstudoes", new[] { "Aula_AulaID" });
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropColumn("dbo.Respostas", "RespD");
            DropColumn("dbo.SessaoEstudoes", "Aula_AulaID");
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.SessaoEstudoAulas", "Aula_AulaID");
            CreateIndex("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID");
            AddForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas", "AulaID", cascadeDelete: true);
            AddForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes", "SessaoEstudoID", cascadeDelete: true);
        }
    }
}
