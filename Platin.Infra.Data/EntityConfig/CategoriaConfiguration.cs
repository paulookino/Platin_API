using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class CategoriaConfiguration : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            ToTable("categoria");

            HasKey(c => c.CatId);

            Property(c => c.CatId).HasColumnName("cat_id").HasColumnType("int").IsRequired();
            Property(c => c.CatNome).HasColumnName("cat_nome").HasColumnType("varchar").HasMaxLength(100);
            Property(c => c.CatImpressora).HasColumnName("cat_impressora").HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
