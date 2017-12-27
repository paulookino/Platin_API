using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class VendaConfiguration : EntityTypeConfiguration<Venda>
    {

        public VendaConfiguration()
        {
            ToTable("venda");

            HasKey(v => v.VenId);


            Property(v => v.VenId).HasColumnName("ven_id").HasColumnType("int").IsRequired();
            Property(v => v.CliId).HasColumnName("cli_id").HasColumnType("int");
            Property(v => v.FunId).HasColumnName("fun_id").HasColumnType("int").IsRequired();
            Property(v => v.VenData).HasColumnName("ven_data").HasColumnType("date").IsRequired();
            Property(v => v.VenHora).HasColumnName("ven_hora").HasColumnType("time");
            Property(v => v.VenTotal).HasColumnName("ven_total").HasColumnType("decimal").IsRequired();
            Property(v => v.VenDesconto).HasColumnName("ven_desconto").HasColumnType("decimal");
            Property(v => v.VenStatus).HasColumnName("ven_status").HasColumnType("int");
            Property(v => v.VenSenha).HasColumnName("ven_senha").HasColumnType("varchar").HasMaxLength(10);
            Property(v => v.VenEntrega).HasColumnName("ven_entrega").HasColumnType("decimal");
            Property(v => v.MesNumero).HasColumnName("mes_numero").HasColumnType("int");
            Property(v => v.EntNumero).HasColumnName("ent_numero").HasColumnType("int");
            Property(v => v.VenViagem).HasColumnName("ven_viagem").HasColumnType("int");
            Property(v => v.VenImpresso).HasColumnName("ven_impresso").HasColumnType("int");
            Property(v => v.CaiId).HasColumnName("cai_id").HasColumnType("int").IsRequired();

        }
    }
}
