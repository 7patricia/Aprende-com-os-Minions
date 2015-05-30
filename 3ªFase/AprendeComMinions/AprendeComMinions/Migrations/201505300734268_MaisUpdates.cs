namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaisUpdates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Duvidas",
                c => new
                    {
                        DuvidaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.DuvidaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Duvidas");
        }
    }
}
