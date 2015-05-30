namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasUpdates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Respostas",
                c => new
                    {
                        RespostaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Pergunta_PerguntaID = c.Int(),
                        RespostaCerta_RespostaID = c.Int(),
                    })
                .PrimaryKey(t => t.RespostaID)
                .ForeignKey("dbo.Perguntas", t => t.Pergunta_PerguntaID)
                .ForeignKey("dbo.Respostas", t => t.RespostaCerta_RespostaID)
                .Index(t => t.Pergunta_PerguntaID)
                .Index(t => t.RespostaCerta_RespostaID);
            
            CreateTable(
                "dbo.ExercicioSessaoEstudoes",
                c => new
                    {
                        Exercicio_ExercicioID = c.Int(nullable: false),
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Exercicio_ExercicioID, t.SessaoEstudo_SessaoEstudoID })
                .ForeignKey("dbo.Exercicios", t => t.Exercicio_ExercicioID, cascadeDelete: true)
                .ForeignKey("dbo.SessoesEstudo", t => t.SessaoEstudo_SessaoEstudoID, cascadeDelete: true)
                .Index(t => t.Exercicio_ExercicioID)
                .Index(t => t.SessaoEstudo_SessaoEstudoID);
            
            AddColumn("dbo.Perguntas", "Teste_TesteID", c => c.Int());
            CreateIndex("dbo.Perguntas", "Teste_TesteID");
            AddForeignKey("dbo.Perguntas", "Teste_TesteID", "dbo.Testes", "TesteID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExercicioSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.ExercicioSessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.Perguntas", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.Respostas", "RespostaCerta_RespostaID", "dbo.Respostas");
            DropForeignKey("dbo.Respostas", "Pergunta_PerguntaID", "dbo.Perguntas");
            DropIndex("dbo.ExercicioSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.ExercicioSessaoEstudoes", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.Respostas", new[] { "RespostaCerta_RespostaID" });
            DropIndex("dbo.Respostas", new[] { "Pergunta_PerguntaID" });
            DropIndex("dbo.Perguntas", new[] { "Teste_TesteID" });
            DropColumn("dbo.Perguntas", "Teste_TesteID");
            DropTable("dbo.ExercicioSessaoEstudoes");
            DropTable("dbo.Respostas");
        }
    }
}
