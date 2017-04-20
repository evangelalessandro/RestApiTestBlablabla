using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace dbSqlDati.App_model
{
    
    public class MachineDbContext : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'dbSqlDati.App_model.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public MachineDbContext()
            : base("name=ModelMachine")
        {
            Database.SetInitializer<MachineDbContext>(new DropCreateDatabaseIfModelChanges<MachineDbContext>());

        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Riferimento> Riferimenti { get; set; }
        public virtual DbSet<Spazio> Spazi { get; set; }

        //public virtual DbSet<ViaggioMachine> ViaggiMachine { get; set; }

        public virtual DbSet<CronoPosizione> CronoPosizioni { get; set; }

        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<Machine> Machine { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            //Configure domain classes using Fluent API here

            base.OnModelCreating(modelBuilder);
        }
    }
    [Table("Space")]
    public class Spazio
    {
        [Key]
        public Guid Id
        { get; set; } = Guid.NewGuid();

        public TipoSpazio TipoSpazio
        { get; set; }

        public int? Quantita
        { get; set; }
    }
    [Table("Riferimenti")]
    public class Riferimento
    {
        [Key]
        public Guid Id
        { get; set; } = Guid.NewGuid();

        public TipoRiferimento TipoRiferimento
        { get; set; }

        public string Dato
        { get; set; } = "";
    }
}