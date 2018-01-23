namespace GdzieIzKim.DAL
{
    using GdzieIzKim.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class contextDB : DbContext
    {
        // Your context has been configured to use a 'contextDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GdzieIzKim.DAL.contextDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'contextDB' 
        // connection string in the application configuration file.
        public contextDB()
            : base("name=contextDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Lokalizacja> Lokalizacje { get; set; }
        public virtual DbSet<Kategoria> Kategoriee { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}