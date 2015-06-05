namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createAllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SessaoEstudoes",
                c => new
                    {
                        SessaoEstudoID = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Tema = c.String(),
                        Utilizador_UtilizadorID = c.Int(),
                    })
                .PrimaryKey(t => t.SessaoEstudoID)
                .ForeignKey("dbo.Utilizadors", t => t.Utilizador_UtilizadorID)
                .Index(t => t.Utilizador_UtilizadorID);
            
            CreateTable(
                "dbo.Exercicios",
                c => new
                    {
                        ExercicioID = c.Int(nullable: false),
                        GrauDif = c.Int(nullable: false),
                        Tema = c.String(),
                        URLImagem = c.String(),
                    })
                .PrimaryKey(t => t.ExercicioID)
                .ForeignKey("dbo.Duvidas", t => t.ExercicioID)
                .Index(t => t.ExercicioID);
            
            CreateTable(
                "dbo.Duvidas",
                c => new
                    {
                        DuvidaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.DuvidaID);
            
            CreateTable(
                "dbo.Perguntas",
                c => new
                    {
                        PerguntaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        URLImagem = c.String(),
                        RespCerta = c.String(),
                        Teste_TesteID = c.Int(),
                        Teste_TesteID1 = c.Int(),
                        Exercicio_ExercicioID = c.Int(),
                    })
                .PrimaryKey(t => t.PerguntaID)
                .ForeignKey("dbo.Testes", t => t.Teste_TesteID)
                .ForeignKey("dbo.Testes", t => t.Teste_TesteID1)
                .ForeignKey("dbo.Exercicios", t => t.Exercicio_ExercicioID)
                .Index(t => t.Teste_TesteID)
                .Index(t => t.Teste_TesteID1)
                .Index(t => t.Exercicio_ExercicioID);
            
            CreateTable(
                "dbo.Respostas",
                c => new
                    {
                        RespostaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        RespA = c.Int(nullable: false),
                        RespB = c.Int(nullable: false),
                        RespC = c.Int(nullable: false),
                        Pergunta_PerguntaID = c.Int(),
                    })
                .PrimaryKey(t => t.RespostaID)
                .ForeignKey("dbo.Perguntas", t => t.Pergunta_PerguntaID)
                .Index(t => t.Pergunta_PerguntaID);
            
            CreateTable(
                "dbo.Testes",
                c => new
                    {
                        TesteID = c.Int(nullable: false, identity: true),
                        DataRealizacao = c.DateTime(nullable: false),
                        Classificacao = c.Single(nullable: false),
                        Tema = c.String(),
                        GrauDif = c.Int(nullable: false),
                        URL = c.String(),
                        Pergunta_PerguntaID = c.Int(),
                    })
                .PrimaryKey(t => t.TesteID)
                .ForeignKey("dbo.Perguntas", t => t.Pergunta_PerguntaID)
                .Index(t => t.Pergunta_PerguntaID);
            
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        UtilizadorID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        UtilLigado = c.Int(nullable: false),
                        Administrador = c.Boolean(nullable: false),
                        NrPerguntasResp = c.Int(nullable: false),
                        NrRespostasCertas = c.Int(nullable: false),
                        NrRespostasErradas = c.Int(nullable: false),
                        NrTestesRealizados = c.Int(nullable: false),
                        NrSessoesEstudo = c.Int(nullable: false),
                        GrauDif = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UtilizadorID);
            
            CreateTable(
                "dbo.SessaoEstudoAulas",
                c => new
                    {
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                        Aula_AulaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SessaoEstudo_SessaoEstudoID, t.Aula_AulaID })
                .ForeignKey("dbo.SessaoEstudoes", t => t.SessaoEstudo_SessaoEstudoID, cascadeDelete: true)
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
                .ForeignKey("dbo.SessaoEstudoes", t => t.SessaoEstudo_SessaoEstudoID, cascadeDelete: true)
                .Index(t => t.Teste_TesteID)
                .Index(t => t.SessaoEstudo_SessaoEstudoID);
            
            CreateTable(
                "dbo.UtilizadorAulas",
                c => new
                    {
                        Utilizador_UtilizadorID = c.Int(nullable: false),
                        Aula_AulaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Utilizador_UtilizadorID, t.Aula_AulaID })
                .ForeignKey("dbo.Utilizadors", t => t.Utilizador_UtilizadorID, cascadeDelete: true)
                .ForeignKey("dbo.Aulas", t => t.Aula_AulaID, cascadeDelete: true)
                .Index(t => t.Utilizador_UtilizadorID)
                .Index(t => t.Aula_AulaID);
            
            CreateTable(
                "dbo.UtilizadorExercicios",
                c => new
                    {
                        Utilizador_UtilizadorID = c.Int(nullable: false),
                        Exercicio_ExercicioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Utilizador_UtilizadorID, t.Exercicio_ExercicioID })
                .ForeignKey("dbo.Utilizadors", t => t.Utilizador_UtilizadorID, cascadeDelete: true)
                .ForeignKey("dbo.Exercicios", t => t.Exercicio_ExercicioID, cascadeDelete: true)
                .Index(t => t.Utilizador_UtilizadorID)
                .Index(t => t.Exercicio_ExercicioID);
            
            CreateTable(
                "dbo.UtilizadorTestes",
                c => new
                    {
                        Utilizador_UtilizadorID = c.Int(nullable: false),
                        Teste_TesteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Utilizador_UtilizadorID, t.Teste_TesteID })
                .ForeignKey("dbo.Utilizadors", t => t.Utilizador_UtilizadorID, cascadeDelete: true)
                .ForeignKey("dbo.Testes", t => t.Teste_TesteID, cascadeDelete: true)
                .Index(t => t.Utilizador_UtilizadorID)
                .Index(t => t.Teste_TesteID);
            
            CreateTable(
                "dbo.ExercicioSessaoEstudoes",
                c => new
                    {
                        Exercicio_ExercicioID = c.Int(nullable: false),
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Exercicio_ExercicioID, t.SessaoEstudo_SessaoEstudoID })
                .ForeignKey("dbo.Exercicios", t => t.Exercicio_ExercicioID, cascadeDelete: true)
                .ForeignKey("dbo.SessaoEstudoes", t => t.SessaoEstudo_SessaoEstudoID, cascadeDelete: true)
                .Index(t => t.Exercicio_ExercicioID)
                .Index(t => t.SessaoEstudo_SessaoEstudoID);
            
            AddColumn("dbo.Aulas", "Titulo", c => c.String());
            AddColumn("dbo.Aulas", "URLImagem", c => c.String());
            AddColumn("dbo.Aulas", "URLVideo", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExercicioSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.ExercicioSessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.Testes", "Pergunta_PerguntaID", "dbo.Perguntas");
            DropForeignKey("dbo.Perguntas", "Teste_TesteID1", "dbo.Testes");
            DropForeignKey("dbo.UtilizadorTestes", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.UtilizadorTestes", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropForeignKey("dbo.SessaoEstudoes", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.UtilizadorExercicios", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropForeignKey("dbo.UtilizadorAulas", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.UtilizadorAulas", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropForeignKey("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.TesteSessaoEstudoes", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.Perguntas", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.Respostas", "Pergunta_PerguntaID", "dbo.Perguntas");
            DropForeignKey("dbo.Exercicios", "ExercicioID", "dbo.Duvidas");
            DropForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropIndex("dbo.ExercicioSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.ExercicioSessaoEstudoes", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.UtilizadorTestes", new[] { "Teste_TesteID" });
            DropIndex("dbo.UtilizadorTestes", new[] { "Utilizador_UtilizadorID" });
            DropIndex("dbo.UtilizadorExercicios", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.UtilizadorExercicios", new[] { "Utilizador_UtilizadorID" });
            DropIndex("dbo.UtilizadorAulas", new[] { "Aula_AulaID" });
            DropIndex("dbo.UtilizadorAulas", new[] { "Utilizador_UtilizadorID" });
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "Teste_TesteID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "Aula_AulaID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.Testes", new[] { "Pergunta_PerguntaID" });
            DropIndex("dbo.Respostas", new[] { "Pergunta_PerguntaID" });
            DropIndex("dbo.Perguntas", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.Perguntas", new[] { "Teste_TesteID1" });
            DropIndex("dbo.Perguntas", new[] { "Teste_TesteID" });
            DropIndex("dbo.Exercicios", new[] { "ExercicioID" });
            DropIndex("dbo.SessaoEstudoes", new[] { "Utilizador_UtilizadorID" });
            DropColumn("dbo.Aulas", "URLVideo");
            DropColumn("dbo.Aulas", "URLImagem");
            DropColumn("dbo.Aulas", "Titulo");
            DropTable("dbo.ExercicioSessaoEstudoes");
            DropTable("dbo.UtilizadorTestes");
            DropTable("dbo.UtilizadorExercicios");
            DropTable("dbo.UtilizadorAulas");
            DropTable("dbo.TesteSessaoEstudoes");
            DropTable("dbo.SessaoEstudoAulas");
            DropTable("dbo.Utilizadors");
            DropTable("dbo.Testes");
            DropTable("dbo.Respostas");
            DropTable("dbo.Perguntas");
            DropTable("dbo.Duvidas");
            DropTable("dbo.Exercicios");
            DropTable("dbo.SessaoEstudoes");
        }
    }
}
