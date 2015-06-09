namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpDates2 : DbMigration
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
                    })
                .PrimaryKey(t => t.ExercicioID);
            
            AddColumn("dbo.Perguntas", "Exercicio_ExercicioID", c => c.Int());
            CreateIndex("dbo.Perguntas", "Exercicio_ExercicioID");
            AddForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios", "ExercicioID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Perguntas", "Exercicio_ExercicioID", "dbo.Exercicios");
            DropIndex("dbo.Perguntas", new[] { "Exercicio_ExercicioID" });
            DropColumn("dbo.Perguntas", "Exercicio_ExercicioID");
            DropTable("dbo.Exercicios");
        }
    }
}
