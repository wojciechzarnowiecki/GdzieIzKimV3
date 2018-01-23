namespace GdzieIzKim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2krok : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lokalizacjas", "opis", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lokalizacjas", "opis");
        }
    }
}
