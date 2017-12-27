using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class ItemVendaConfiguration : EntityTypeConfiguration<ItemVenda>
    {

        public ItemVendaConfiguration()
        {
            ToTable("itemvenda");

            HasKey(i => i.IteId);

            Property(i => i.IteId).HasColumnName("ite_id").HasColumnType("int").IsRequired();
            Property(i => i.ProId).HasColumnName("pro_id").HasColumnType("int").IsRequired();
            Property(i => i.VenId).HasColumnName("ven_id").HasColumnType("int").IsRequired();
            Property(i => i.IteQuantidade).HasColumnName("ite_quantidade").HasColumnType("decimal").IsRequired();
            Property(i => i.IteValor).HasColumnName("ite_valor").HasColumnType("decimal").IsRequired();
            Property(i => i.IteInformacao).HasColumnName("ite_informacao").HasColumnType("varchar").HasMaxLength(100);
            Property(i => i.IteHora).HasColumnName("ite_hora").HasColumnType("time");
            Property(i => i.IteData).HasColumnName("ite_data").HasColumnType("date");



        }
    }
}
