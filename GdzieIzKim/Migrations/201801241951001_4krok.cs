namespace GdzieIzKim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4krok : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lokalizacjas", "adres", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lokalizacjas", "adres", c => c.String());
        }
    }
}
