namespace GdzieIzKim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6krok : DbMigration
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
            
            CreateTable(
                "dbo.Lokalizacjas",
                c => new
                    {
                        LokalizacjaId = c.Int(nullable: false, identity: true),
                        nazwa = c.String(),
                        adres = c.String(nullable: false),
                        opis = c.String(),
                        zkim = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LokalizacjaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lokalizacjas");
            DropTable("dbo.Kategorias");
        }
    }
}
