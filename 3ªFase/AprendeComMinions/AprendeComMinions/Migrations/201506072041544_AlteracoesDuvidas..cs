namespace AprendeComMinions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracoesDuvidas : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Duvidas", "Descricao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Duvidas", "Descricao", c => c.String());
        }
    }
}
