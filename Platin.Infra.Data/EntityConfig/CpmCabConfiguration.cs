using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class CpmCabConfiguration : EntityTypeConfiguration<CpmCab>
    {

        public CpmCabConfiguration()
        {
            ToTable("pdv.cpm_cab");

            HasKey(c => c.Ide);

            Property(c => c.Ide).HasColumnName("ide").HasColumnType("int8").IsRequired();
            Property(c => c.Lot).HasColumnName("lot").HasColumnType("int8");
            Property(c => c.Cpm).HasColumnName("cpm").HasColumnType("int8");
            Property(c => c.Dat).HasColumnName("dat").HasColumnType("date");
            Property(c => c.Hor).HasColumnName("hor").HasColumnType("varchar");
            Property(c => c.Ven).HasColumnName("ven").HasColumnType("bool");
            Property(c => c.Cod).HasColumnName("cod").HasColumnType("int8");
            Property(c => c.Grp).HasColumnName("grp").HasColumnType("varchar");
            Property(c => c.Txt).HasColumnName("txt").HasColumnType("int8");
            Property(c => c.Tes).HasColumnName("tes").HasColumnType("bool");
            Property(c => c.Dtm).HasColumnName("dtm").HasColumnType("date");
            Property(c => c.Upd).HasColumnName("upd").HasColumnType("int2");
            Property(c => c.Fna).HasColumnName("fna").HasColumnType("int8");

        }
    }
}
