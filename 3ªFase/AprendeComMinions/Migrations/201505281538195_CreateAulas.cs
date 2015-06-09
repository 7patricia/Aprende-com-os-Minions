namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAulas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aulas",
                c => new
                    {
                        AulaID = c.Int(nullable: false, identity: true),
                        Tema = c.String(),
                        GrauDif = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AulaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aulas");
        }
    }
}
