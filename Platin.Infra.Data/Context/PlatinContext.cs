//using Platin.Domain.Entities;
using Platin.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Platin.Infra.Data.Context
{
    public class PlatinContext : DbContext
    {
        public PlatinContext() : base("PlatinConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Product> Product { get; set; }

        public DbSet<Funcionario> Funcionario { get; set; }

        public DbSet<Caixa> Caixa { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Venda> Venda { get; set; }

        public DbSet<ItemVenda> ItemVenda { get; set; }

        public DbSet<Cupom> Cupom { get; set; }

        public DbSet<Inventario> Inventario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new EntityConfig.ProductConfiguration());
            modelBuilder.Configurations.Add(new EntityConfig.FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new EntityConfig.CaixaConfiguration());
            modelBuilder.Configurations.Add(new EntityConfig.CategoriaConfiguration());
            modelBuilder.Configurations.Add(new EntityConfig.ProdutoConfiguration());
            modelBuilder.Configurations.Add(new EntityConfig.VendaConfiguration());
            modelBuilder.Configurations.Add(new EntityConfig.ItemVendaConfiguration());
            modelBuilder.Configurations.Add(new EntityConfig.CupomConfiguration());
            modelBuilder.Configurations.Add(new EntityConfig.InventarioConfiguration());

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
