namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDAtribTeste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Testes", "GrauDif", c => c.Int(nullable: false));
            AddColumn("dbo.Testes", "URL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Testes", "URL");
            DropColumn("dbo.Testes", "GrauDif");
        }
    }
}
