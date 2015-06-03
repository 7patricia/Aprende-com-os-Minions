namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lixo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.TesteSessaoEstudoes", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.ExercicioSessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.ExercicioSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropIndex("dbo.SessaoEstudoAulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "Aula_AulaID" });
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "Teste_TesteID" });
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.ExercicioSessaoEstudoes", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.ExercicioSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            AddColumn("dbo.SessoesEstudo", "Teste_TesteID", c => c.Int());
            AddColumn("dbo.SessoesEstudo", "Exercicio_ExercicioID", c => c.Int());
            AddColumn("dbo.SessoesEstudo", "Aula_AulaID", c => c.Int());
            AddColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            AddColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1");
            CreateIndex("dbo.SessoesEstudo", "Teste_TesteID");
            CreateIndex("dbo.SessoesEstudo", "Exercicio_ExercicioID");
            CreateIndex("dbo.SessoesEstudo", "Aula_AulaID");
            CreateIndex("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1");
            CreateIndex("dbo.Testes", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.Testes", "SessaoEstudo_SessaoEstudoID1");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.SessoesEstudo", "Teste_TesteID", "dbo.Testes", "TesteID");
            AddForeignKey("dbo.SessoesEstudo", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo", "SessaoEstudoID");
            AddForeignKey("dbo.SessoesEstudo", "Aula_AulaID", "dbo.Aulas", "AulaID");
            DropColumn("dbo.SessoesEstudo", "Tema");
            DropTable("dbo.SessaoEstudoAulas");
            DropTable("dbo.TesteSessaoEstudoes");
            DropTable("dbo.ExercicioSessaoEstudoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ExercicioSessaoEstudoes",
                c => new
                    {
                        Exercicio_ExercicioID = c.Int(nullable: false),
                        SessaoEstudo_SessaoEstudoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Exercicio_ExercicioID, t.SessaoEstudo_SessaoEstudoID });
            
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
            
            AddColumn("dbo.SessoesEstudo", "Tema", c => c.String());
            DropForeignKey("dbo.SessoesEstudo", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropForeignKey("dbo.SessoesEstudo", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.SessoesEstudo", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", "dbo.SessoesEstudo");
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo");
            DropIndex("dbo.Testes", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.Testes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.Exercicios", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.Exercicios", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.SessoesEstudo", new[] { "Aula_AulaID" });
            DropIndex("dbo.SessoesEstudo", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.SessoesEstudo", new[] { "Teste_TesteID" });
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID");
            DropColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID");
            DropColumn("dbo.SessoesEstudo", "Aula_AulaID");
            DropColumn("dbo.SessoesEstudo", "Exercicio_ExercicioID");
            DropColumn("dbo.SessoesEstudo", "Teste_TesteID");
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.ExercicioSessaoEstudoes", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.ExercicioSessaoEstudoes", "Exercicio_ExercicioID");
            CreateIndex("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.TesteSessaoEstudoes", "Teste_TesteID");
            CreateIndex("dbo.SessaoEstudoAulas", "Aula_AulaID");
            CreateIndex("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID");
            AddForeignKey("dbo.ExercicioSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID", cascadeDelete: true);
            AddForeignKey("dbo.ExercicioSessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID", cascadeDelete: true);
            AddForeignKey("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID", cascadeDelete: true);
            AddForeignKey("dbo.TesteSessaoEstudoes", "Teste_TesteID", "dbo.Testes", "TesteID", cascadeDelete: true);
            AddForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas", "AulaID", cascadeDelete: true);
            AddForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessoesEstudo", "SessaoEstudoID", cascadeDelete: true);
        }
    }
}
