using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class InventarioConfiguration : EntityTypeConfiguration<Inventario>
    {
        public InventarioConfiguration()
        {
            ToTable("Inventario");

            HasKey(i => i.InvId);

            Property(i => i.InvId).HasColumnName("Inv_id").HasColumnType("int").IsRequired();
            Property(i => i.InvCodigo).HasColumnName("Inv_codigo").HasColumnType("varchar").HasMaxLength(15);


        }
    }
}
