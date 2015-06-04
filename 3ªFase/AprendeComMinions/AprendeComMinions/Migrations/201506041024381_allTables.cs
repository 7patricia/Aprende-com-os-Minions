namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allTables : DbMigration
    {
        public override void Up()
        {
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
                "dbo.Perguntas",
                c => new
                    {
                        PerguntaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Teste_TesteID = c.Int(),
                        Exercicio_ExercicioID = c.Int(),
                    })
                .PrimaryKey(t => t.PerguntaID)
                .ForeignKey("dbo.Testes", t => t.Teste_TesteID)
                .ForeignKey("dbo.Exercicios", t => t.Exercicio_ExercicioID)
                .Index(t => t.Teste_TesteID)
                .Index(t => t.Exercicio_ExercicioID);
            
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
                "dbo.Utilizadors",
                c => new
                    {
                        UtilizadorID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Administrador = c.Boolean(nullable: false),
                        NrRespostasCertas = c.Int(nullable: false),
                        NrRespostasErradas = c.Int(nullable: false),
                        NrTestesRealizados = c.Int(nullable: false),
                        NrSessoesEstudo = c.Int(nullable: false),
                        GrauDif = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UtilizadorID);
            
            CreateTable(
                "dbo.Duvidas",
                c => new
                    {
                        DuvidaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.DuvidaID);
            
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
            
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            AddColumn("dbo.SessoesEstudo", "Teste_TesteID", c => c.Int());
            AddColumn("dbo.SessoesEstudo", "Exercicio_ExercicioID", c => c.Int());
            AddColumn("dbo.SessoesEstudo", "Aula_AulaID", c => c.Int());
            AddColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1");
            CreateIndex("dbo.SessoesEstudo", "Teste_TesteID");
            CreateIndex("dbo.SessoesEstudo", "Exercicio_ExercicioID");
            CreateIndex("dbo.SessoesEstudo", "Aula_AulaID");
            CreateIndex("dbo.Testes", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.Testes", "SessaoEstudo_SessaoEstudoID1");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.SessoesEstudo", "Teste_TesteID", "dbo.Testes", "TesteID");
            AddForeignKey("dbo.SessoesEstudo", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.SessoesEstudo", "Aula_AulaID", "dbo.Aulas", "AulaID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SessoesEstudo", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.SessoesEstudo", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.UtilizadorTestes", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.UtilizadorTestes", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropForeignKey("dbo.UtilizadorExercicios", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.UtilizadorExercicios", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropForeignKey("dbo.UtilizadorAulas", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.UtilizadorAulas", "Utilizador_UtilizadorID", "dbo.Utilizadors");
            DropForeignKey("dbo.SessoesEstudo", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.Perguntas", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.Respostas", "RespostaCerta_RespostaID", "dbo.Respostas");
            DropForeignKey("dbo.Respostas", "Pergunta_PerguntaID", "dbo.Perguntas");
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo");
            DropIndex("dbo.UtilizadorTestes", new[] { "Teste_TesteID" });
            DropIndex("dbo.UtilizadorTestes", new[] { "Utilizador_UtilizadorID" });
            DropIndex("dbo.UtilizadorExercicios", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.UtilizadorExercicios", new[] { "Utilizador_UtilizadorID" });
            DropIndex("dbo.UtilizadorAulas", new[] { "Aula_AulaID" });
            DropIndex("dbo.UtilizadorAulas", new[] { "Utilizador_UtilizadorID" });
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
            DropColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID");
            DropColumn("dbo.SessoesEstudo", "Aula_AulaID");
            DropColumn("dbo.SessoesEstudo", "Exercicio_ExercicioID");
            DropColumn("dbo.SessoesEstudo", "Teste_TesteID");
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1");
            DropTable("dbo.UtilizadorTestes");
            DropTable("dbo.UtilizadorExercicios");
            DropTable("dbo.UtilizadorAulas");
            DropTable("dbo.Duvidas");
            DropTable("dbo.Utilizadors");
            DropTable("dbo.Respostas");
            DropTable("dbo.Perguntas");
            DropTable("dbo.Exercicios");
        }
    }
}
