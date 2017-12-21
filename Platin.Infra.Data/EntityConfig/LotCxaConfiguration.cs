using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class LotCxaConfiguration : EntityTypeConfiguration<LotCxa>
    {
        public LotCxaConfiguration()
        {
            ToTable("pdv.lot_cxa");

            HasKey(l => l.Ide);

            Property(l => l.Ide).HasColumnName("ide").HasColumnType("int8");
            Property(l => l.Lot).HasColumnName("lot").HasColumnType("int8").IsRequired();
            Property(l => l.Uad).HasColumnName("uad").HasColumnType("int2").IsRequired();
            Property(l => l.Ope).HasColumnName("ope").HasColumnType("varchar");
            Property(l => l.Ger).HasColumnName("ger").HasColumnType("varchar");
            Property(l => l.Maq).HasColumnName("maq").HasColumnType("varchar").IsRequired();
            Property(l => l.Dat).HasColumnName("dat").HasColumnType("date").IsRequired();
            Property(l => l.Hor).HasColumnName("hor").HasColumnType("varchar");
            Property(l => l.Vlc).HasColumnName("vlc").HasColumnType("float8");
            Property(l => l.Mov).HasColumnName("mov").HasColumnType("float8");
            Property(l => l.Vap).HasColumnName("vap").HasColumnType("varchar");
            Property(l => l.Dta).HasColumnName("dta").HasColumnType("timestamp");
            Property(l => l.Stt).HasColumnName("stt").HasColumnType("varchar");
            Property(l => l.Cod).HasColumnName("cod").HasColumnType("int8");
            Property(l => l.Grp).HasColumnName("grp").HasColumnType("varchar");
            Property(l => l.Txt).HasColumnName("txt").HasColumnType("int8");
            Property(l => l.Log).HasColumnName("log").HasColumnType("int4");
            Property(l => l.Lg2).HasColumnName("lg2").HasColumnType("int4");

        }
    }
}
