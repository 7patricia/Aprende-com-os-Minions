namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upSessaoEstudo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SessaoEstudoes", "AulasVistas", c => c.Int(nullable: false));
            AddColumn("dbo.SessaoEstudoes", "TestesResolvidos", c => c.Int(nullable: false));
            AddColumn("dbo.SessaoEstudoes", "ExerciciosResolvidos", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SessaoEstudoes", "ExerciciosResolvidos");
            DropColumn("dbo.SessaoEstudoes", "TestesResolvidos");
            DropColumn("dbo.SessaoEstudoes", "AulasVistas");
        }
    }
}
