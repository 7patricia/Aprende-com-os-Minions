namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAllTablesofMinions : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.TesteSessaoEstudoes", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropIndex("dbo.SessaoEstudoAulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "Aula_AulaID" });
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "Teste_TesteID" });
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            CreateTable(
                "dbo.Exercicios",
                c => new
                    {
                        ExercicioID = c.Int(nullable: false, identity: true),
                        GrauDif = c.Int(nullable: false),
                        Tema = c.String(),
                        SessaoEstudo_SessaoEstudoID = c.Int(),
                        SessaoEstudo_SessaoEstudoID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ExercicioID)
                .ForeignKey("dbo.SessoesEstudo", t => t.SessaoEstudo_SessaoEstudoID)
                .ForeignKey("dbo.SessoesEstudo", t => t.SessaoEstudo_SessaoEstudoID1)
                .Index(t => t.SessaoEstudo_SessaoEstudoID)
                .Index(t => t.SessaoEstudo_SessaoEstudoID1);
            
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
                "dbo.Duvidas",
                c => new
                    {
                        DuvidaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.DuvidaID);
            
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
            
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            AddColumn("dbo.SessoesEstudo", "Teste_TesteID", c => c.Int());
            AddColumn("dbo.SessoesEstudo", "Exercicio_ExercicioID", c => c.Int());
            AddColumn("dbo.SessoesEstudo", "Aula_AulaID", c => c.Int());
            AddColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            AddColumn("dbo.Perguntas", "Teste_TesteID", c => c.Int());
            AddColumn("dbo.Perguntas", "Exercicio_ExercicioID", c => c.Int());
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1");
            CreateIndex("dbo.SessoesEstudo", "Teste_TesteID");
            CreateIndex("dbo.SessoesEstudo", "Exercicio_ExercicioID");
            CreateIndex("dbo.SessoesEstudo", "Aula_AulaID");
            CreateIndex("dbo.Perguntas", "Teste_TesteID");
            CreateIndex("dbo.Perguntas", "Exercicio_ExercicioID");
            CreateIndex("dbo.Testes", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.Testes", "SessaoEstudo_SessaoEstudoID1");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.Perguntas", "Teste_TesteID", "dbo.Testes", "TesteID");
            AddForeignKey("dbo.SessoesEstudo", "Teste_TesteID", "dbo.Testes", "TesteID");
            AddForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.SessoesEstudo", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.SessoesEstudo", "Aula_AulaID", "dbo.Aulas", "AulaID");
            DropTable("dbo.SessaoEstudoAulas");
            DropTable("dbo.TesteSessaoEstudoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TesteSessaoEstudoes",
                c => new
                    {
                        Teste_TesteID = c.Int(nullable: false),
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teste_TesteID, t.SessaoEstudo_SessaoEstudoID });
            
            CreateTable(
                "dbo.SessaoEstudoAulas",
                c => new
                    {
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                        Aula_AulaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SessaoEstudo_SessaoEstudoID, t.Aula_AulaID });
            
            DropForeignKey("dbo.SessoesEstudo", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.SessoesEstudo", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.SessoesEstudo", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.Perguntas", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.Respostas", "RespostaCerta_RespostaID", "dbo.Respostas");
            DropForeignKey("dbo.Respostas", "Pergunta_PerguntaID", "dbo.Perguntas");
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropIndex("dbo.Testes", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.Testes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.Respostas", new[] { "RespostaCerta_RespostaID" });
            DropIndex("dbo.Respostas", new[] { "Pergunta_PerguntaID" });
            DropIndex("dbo.Perguntas", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.Perguntas", new[] { "Teste_TesteID" });
            DropIndex("dbo.Exercicios", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.Exercicios", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.SessoesEstudo", new[] { "Aula_AulaID" });
            DropIndex("dbo.SessoesEstudo", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.SessoesEstudo", new[] { "Teste_TesteID" });
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropColumn("dbo.Perguntas", "Exercicio_ExercicioID");
            DropColumn("dbo.Perguntas", "Teste_TesteID");
            DropColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID");
            DropColumn("dbo.SessoesEstudo", "Aula_AulaID");
            DropColumn("dbo.SessoesEstudo", "Exercicio_ExercicioID");
            DropColumn("dbo.SessoesEstudo", "Teste_TesteID");
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            DropTable("dbo.Utilizadors");
            DropTable("dbo.Duvidas");
            DropTable("dbo.Respostas");
            DropTable("dbo.Exercicios");
            CreateIndex("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.TesteSessaoEstudoes", "Teste_TesteID");
            CreateIndex("dbo.SessaoEstudoAulas", "Aula_AulaID");
            CreateIndex("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID");
            AddForeignKey("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID", cascadeDelete: true);
            AddForeignKey("dbo.TesteSessaoEstudoes", "Teste_TesteID", "dbo.Testes", "TesteID", cascadeDelete: true);
            AddForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas", "AulaID", cascadeDelete: true);
            AddForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID", cascadeDelete: true);
        }
    }
}
