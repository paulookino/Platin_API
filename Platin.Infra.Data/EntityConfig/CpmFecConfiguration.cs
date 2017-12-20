using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class CpmFecConfiguration : EntityTypeConfiguration<CpmFec>
    {
        public CpmFecConfiguration()
        {
            ToTable("pdv.cpm_fec");

            HasKey(c => c.Ide);

            Property(c => c.Ide).HasColumnName("ide").HasColumnType("int8").IsRequired();
            Property(c => c.Lot).HasColumnName("lot").HasColumnType("int8");
            Property(c => c.Cpm).HasColumnName("cpm").HasColumnType("int8");
            Property(c => c.Tpg).HasColumnName("tpg").HasColumnType("varchar");
            Property(c => c.Vlt).HasColumnName("vlt").HasColumnType("float8");
            Property(c => c.Vcp).HasColumnName("vcp").HasColumnType("float8");
            Property(c => c.Stt).HasColumnName("stt").HasColumnType("varchar");
            Property(c => c.Tpo).HasColumnName("tpo").HasColumnType("varchar");
            Property(c => c.Ins).HasColumnName("ins").HasColumnType("bool");
            Property(c => c.Cod).HasColumnName("cod").HasColumnType("int8");
            Property(c => c.Grp).HasColumnName("grp").HasColumnType("varchar");
            Property(c => c.Txt).HasColumnName("txt").HasColumnType("int8");
            Property(c => c.Atv).HasColumnName("atv").HasColumnType("bool");
            Property(c => c.Vsq).HasColumnName("vsq").HasColumnType("float8");
            Property(c => c.Frc).HasColumnName("frc").HasColumnType("varchar");
            Property(c => c.Upd).HasColumnName("upd").HasColumnType("int2");
            Property(c => c.Vtr).HasColumnName("vtr").HasColumnType("float8");

        }
    }
}
