namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AltercaoDuvida : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Duvidas", "URLVideo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Duvidas", "URLVideo");
        }
    }
}
