using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class CaixaConfiguration : EntityTypeConfiguration<Caixa>
    {

        public CaixaConfiguration()
        {
            ToTable("caixa");

            HasKey(c => c.CaiId);

            Property(c => c.CaiId).HasColumnName("cai_id").HasColumnType("int").IsRequired();
            Property(c => c.FunId).HasColumnName("fun_id").HasColumnType("int").IsRequired();
            Property(c => c.FunIdFechamento).HasColumnName("cai_idfechamento").HasColumnType("int");
            Property(c => c.CaiValorInicial).HasColumnName("cai_valorinicial").HasColumnType("decimal").IsRequired();
            Property(c => c.CaiValorFinal).HasColumnName("cai_valorfinal").HasColumnType("decimal");
            Property(c => c.CaiDataInicial).HasColumnName("cai_datainicial").HasColumnType("date");
            Property(c => c.CaiDataFinal).HasColumnName("cai_datafinal").HasColumnType("date");
            Property(c => c.CaiHoraInicial).HasColumnName("cai_horainicial").HasColumnType("datetime2");
            Property(c => c.CaiHoraFinal).HasColumnName("cai_horafinal").HasColumnType("datetime2");
            Property(c => c.CaiStatus).HasColumnName("cai_status").HasColumnType("int");
            Property(c => c.CaiInformacao).HasColumnName("cai_informacao").HasColumnType("varchar").HasMaxLength(100);
            Property(c => c.CaiNumero).HasColumnName("cai_numero").HasColumnType("int");
        }

    }
}
