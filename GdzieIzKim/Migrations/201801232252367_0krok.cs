namespace GdzieIzKim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0krok : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategorias",
                c => new
                    {
                        KategoriaId = c.Int(nullable: false, identity: true),
                        NazwaKat = c.String(),
                        OpisKat = c.String(),
                    })
                .PrimaryKey(t => t.KategoriaId);
            
            AddColumn("dbo.Lokalizacjas", "adres", c => c.String());
            AddColumn("dbo.Lokalizacjas", "Kategoria_KategoriaId", c => c.Int());
            CreateIndex("dbo.Lokalizacjas", "Kategoria_KategoriaId");
            AddForeignKey("dbo.Lokalizacjas", "Kategoria_KategoriaId", "dbo.Kategorias", "KategoriaId");
            DropColumn("dbo.Lokalizacjas", "szerokosc");
            DropColumn("dbo.Lokalizacjas", "dlugosc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lokalizacjas", "dlugosc", c => c.Double(nullable: false));
            AddColumn("dbo.Lokalizacjas", "szerokosc", c => c.Double(nullable: false));
            DropForeignKey("dbo.Lokalizacjas", "Kategoria_KategoriaId", "dbo.Kategorias");
            DropIndex("dbo.Lokalizacjas", new[] { "Kategoria_KategoriaId" });
            DropColumn("dbo.Lokalizacjas", "Kategoria_KategoriaId");
            DropColumn("dbo.Lokalizacjas", "adres");
            DropTable("dbo.Kategorias");
        }
    }
}
