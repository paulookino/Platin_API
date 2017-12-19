//using Platin.Domain.Entities;
using Platin.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Platin.Infra.Data.Context
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext() : base("PlatinPostgreSQLConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<PrdCab> PrdCab { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            //modelBuilder.Entity<PrdCab>().ToTable("prd_cab", "estoque");

            //modelBuilder.Conventions.Remove<StoreGeneratedIdentityKeyConvention>();

            modelBuilder.Configurations.Add(new EntityConfig.PrdCabConfiguration());

            //modelBuilder.Entity<CalculoSimulacao>().HasKey<decimal>(k => k.Valor);
            //modelBuilder.Entity<Cliente>().Ignore(d => d.EhCliente);
            //modelBuilder.Entity<Cliente>().Ignore(d => d.EstaExposto);
            //modelBuilder.Entity<Cliente>().Ignore(d => d.EstaImpedido);
            //modelBuilder.Entity<ClienteDadosBancarios>().Ignore(d => d.NumeroBanco);
            //modelBuilder.Entity<Simulacao>().Ignore(d => d.DataInclusao);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
