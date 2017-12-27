using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class CupomConfiguration : EntityTypeConfiguration<Cupom>
    {
        public CupomConfiguration()
        {
            ToTable("cupom");

            HasKey(c => c.CupId);

            Property(c => c.CupId).HasColumnName("cup_id").HasColumnType("int").IsRequired();
            Property(c => c.CupCodigo).HasColumnName("cup_codigo").HasColumnType("varchar").HasMaxLength(30);
            Property(c => c.CupProduto).HasColumnName("cup_produto").HasColumnType("varchar").HasMaxLength(100);
            Property(c => c.CupAliquota).HasColumnName("cup_aliquota").HasColumnType("varchar").HasMaxLength(3);
            Property(c => c.CupQuantidade).HasColumnName("cup_quantidade").HasColumnType("varchar").HasMaxLength(4);
            Property(c => c.CupData).HasColumnName("cup_data").HasColumnType("date").IsRequired();
            Property(c => c.CupHora).HasColumnName("cup_hora").HasColumnType("time");
            Property(c => c.CupTotal).HasColumnName("cup_total").HasColumnType("decimal");

        }
    }
}
