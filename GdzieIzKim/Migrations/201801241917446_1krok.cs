namespace GdzieIzKim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1krok : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lokalizacjas", "Kategoria_KategoriaId", "dbo.Kategorias");
            DropIndex("dbo.Lokalizacjas", new[] { "Kategoria_KategoriaId" });
            AddColumn("dbo.Lokalizacjas", "zkim", c => c.String());
            DropColumn("dbo.Lokalizacjas", "Kategoria_KategoriaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lokalizacjas", "Kategoria_KategoriaId", c => c.Int());
            DropColumn("dbo.Lokalizacjas", "zkim");
            CreateIndex("dbo.Lokalizacjas", "Kategoria_KategoriaId");
            AddForeignKey("dbo.Lokalizacjas", "Kategoria_KategoriaId", "dbo.Kategorias", "KategoriaId");
        }
    }
}
