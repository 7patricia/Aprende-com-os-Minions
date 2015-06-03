namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        UtilizadorID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        NrRespostasCertas = c.Int(nullable: false),
                        NrRespostasErradas = c.Int(nullable: false),
                        NrTestesRealizados = c.Int(nullable: false),
                        NrSessoesEstudo = c.Int(nullable: false),
                        GrauDif = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UtilizadorID);
            
            AddColumn("dbo.Exercicios", "Cotacao", c => c.Single(nullable: false));
            AddColumn("dbo.Perguntas", "Cotacao", c => c.Single(nullable: false));
            AddColumn("dbo.Testes", "Cotacao", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Testes", "Cotacao");
            DropColumn("dbo.Perguntas", "Cotacao");
            DropColumn("dbo.Exercicios", "Cotacao");
            DropTable("dbo.Utilizadors");
        }
    }
}
