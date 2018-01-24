namespace GdzieIzKim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5krok : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lokalizacjas", "zkim", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lokalizacjas", "zkim", c => c.String());
        }
    }
}
