namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSessaoEstudo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.SessaoEstudoes", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.SessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.SessaoEstudoes", "Aula_AulaID", "dbo.Aulas");
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.Aulas", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.SessaoEstudoes", new[] { "Teste_TesteID" });
            DropIndex("dbo.SessaoEstudoes", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.SessaoEstudoes", new[] { "Aula_AulaID" });
            DropIndex("dbo.Exercicios", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.Exercicios", new[] { "SessaoEstudo_SessaoEstudoID1" });
            DropIndex("dbo.Testes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.Testes", new[] { "SessaoEstudo_SessaoEstudoID1" });
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
            
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            DropColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.SessaoEstudoes", "Teste_TesteID");
            DropColumn("dbo.SessaoEstudoes", "Exercicio_ExercicioID");
            DropColumn("dbo.SessaoEstudoes", "Aula_AulaID");
            DropColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID");
            DropColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1");
            DropColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID");
            DropColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            AddColumn("dbo.Testes", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            AddColumn("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            AddColumn("dbo.SessaoEstudoes", "Aula_AulaID", c => c.Int());
            AddColumn("dbo.SessaoEstudoes", "Exercicio_ExercicioID", c => c.Int());
            AddColumn("dbo.SessaoEstudoes", "Teste_TesteID", c => c.Int());
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", c => c.Int());
            AddColumn("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", c => c.Int());
            DropForeignKey("dbo.ExercicioSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.ExercicioSessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropForeignKey("dbo.TesteSessaoEstudoes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropForeignKey("dbo.TesteSessaoEstudoes", "Teste_TesteID", "dbo.Testes");
            DropForeignKey("dbo.SessaoEstudoAulas", "Aula_AulaID", "dbo.Aulas");
            DropForeignKey("dbo.SessaoEstudoAulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes");
            DropIndex("dbo.ExercicioSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.ExercicioSessaoEstudoes", new[] { "Exercicio_ExercicioID" });
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropIndex("dbo.TesteSessaoEstudoes", new[] { "Teste_TesteID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "Aula_AulaID" });
            DropIndex("dbo.SessaoEstudoAulas", new[] { "SessaoEstudo_SessaoEstudoID" });
            DropTable("dbo.ExercicioSessaoEstudoes");
            DropTable("dbo.TesteSessaoEstudoes");
            DropTable("dbo.SessaoEstudoAulas");
            CreateIndex("dbo.Testes", "SessaoEstudo_SessaoEstudoID1");
            CreateIndex("dbo.Testes", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1");
            CreateIndex("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID");
            CreateIndex("dbo.SessaoEstudoes", "Aula_AulaID");
            CreateIndex("dbo.SessaoEstudoes", "Exercicio_ExercicioID");
            CreateIndex("dbo.SessaoEstudoes", "Teste_TesteID");
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1");
            CreateIndex("dbo.Aulas", "SessaoEstudo_SessaoEstudoID");
            AddForeignKey("dbo.SessaoEstudoes", "Aula_AulaID", "dbo.Aulas", "AulaID");
            AddForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes", "SessaoEstudoID");
            AddForeignKey("dbo.Testes", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes", "SessaoEstudoID");
            AddForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes", "SessaoEstudoID");
            AddForeignKey("dbo.Exercicios", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes", "SessaoEstudoID");
            AddForeignKey("dbo.SessaoEstudoes", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
            AddForeignKey("dbo.SessaoEstudoes", "Teste_TesteID", "dbo.Testes", "TesteID");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID1", "dbo.SessaoEstudoes", "SessaoEstudoID");
            AddForeignKey("dbo.Aulas", "SessaoEstudo_SessaoEstudoID", "dbo.SessaoEstudoes", "SessaoEstudoID");
        }
    }
}
