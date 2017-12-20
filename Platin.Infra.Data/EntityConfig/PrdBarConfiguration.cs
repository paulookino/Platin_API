using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class PrdBarConfiguration : EntityTypeConfiguration<PrdBar>
    {

        public PrdBarConfiguration()
        {
            ToTable("estoque.prd_bar");

            HasKey(p => p.Ide);

            Property(p => p.Ide).HasColumnName("ide").HasColumnType("int8").IsRequired();
            Property(p => p.Cod).HasColumnName("cod").HasColumnType("int4");
            Property(p => p.Bar).HasColumnName("bar").HasColumnType("varchar");
            Property(p => p.Val).HasColumnName("val").HasColumnType("bool");
        }
    }
}
