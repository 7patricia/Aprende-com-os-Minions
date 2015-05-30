namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpDates : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            CreateTable(
                "dbo.Perguntas",
                c => new
                    {
                        PerguntaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.PerguntaID);
            
            CreateTable(
                "dbo.SessaoEstudoAulas",
                c => new
                    {
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                        Aula_AulaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SessaoEstudo_SessaoEstudoID, t.Aula_AulaID })
                .ForeignKey("dbo.SessoesEstudo", t => t.SessaoEstudo_SessaoEstudoID, cascadeDelete: true)
                .ForeignKey("dbo.Aulas", t => t.Aula_AulaID, cascadeDelete: true)
                .Index(t => t.SessaoEstudo_SessaoEstudoID)
                .Index(t => t.Aula_AulaID);
            
            CreateTable(
                "dbo.TesteSessaoEstudoes",
                c => new
                    {
                        Teste_TesteID = c.Int(nullable: false),
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teste_TesteID, t.SessaoEstudo_SessaoEstudoID })
                .ForeignKey("dbo.Testes", t => t.Teste_TesteID, cascadeDelete: true)
                .ForeignKey("dbo.SessoesEstudo", t => t.SessaoEstudo_SessaoEstudoID, cascadeDelete: true)
                .Index(t => t.Teste_TesteID)
                .Index(t => t.SessaoEstudo_SessaoEstudoID);
            
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            DropForeignKey("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.TesteSessaoEstudoes", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "Teste_TesteID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "Aula_AulaID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropTable("dbo.TesteSessaoEstudoes");
            DropTable("dbo.SessaoEstudoAulas");
            DropTable("dbo.Perguntas");
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID");
        }
    }
}
