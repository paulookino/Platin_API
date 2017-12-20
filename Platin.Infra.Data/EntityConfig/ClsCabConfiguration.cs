using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class ClsCabConfiguration : EntityTypeConfiguration<ClsCab>
    {
        public ClsCabConfiguration()
        {
            ToTable("estoque.cls_cab");

            HasKey(c => c.Ide);


            Property(c => c.Ide).HasColumnName("ide").HasColumnType("int8").IsRequired();
            Property(c => c.Cod).HasColumnName("cod").HasColumnType("int4");
            Property(c => c.Des).HasColumnName("des").HasColumnType("varchar");
            Property(c => c.Sgl).HasColumnName("sgl").HasColumnType("varchar");
            Property(c => c.Tme).HasColumnName("tme").HasColumnType("varchar");
            Property(c => c.Fam).HasColumnName("fam").HasColumnType("int4");
            Property(c => c.Atv).HasColumnName("atv").HasColumnType("bool");
        }
    }
}
