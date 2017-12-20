using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class CpmIteConfiguration : EntityTypeConfiguration<CpmIte>
    {
        public CpmIteConfiguration()
        {
            ToTable("pdv.cpm_ite");

            HasKey(c => c.Ide);

            Property(c => c.Ide).HasColumnName("ide").HasColumnType("int8").IsRequired();
            Property(c => c.Lot).HasColumnName("lot").HasColumnType("int8");
            Property(c => c.Cpm).HasColumnName("cpm").HasColumnType("int8");
            Property(c => c.Seq).HasColumnName("seq").HasColumnType("int2");
            Property(c => c.Prd).HasColumnName("prd").HasColumnType("int8");
            Property(c => c.Qtd).HasColumnName("qtd").HasColumnType("float8");
            Property(c => c.Vlr).HasColumnName("vlr").HasColumnType("float8");
            Property(c => c.Vld).HasColumnName("vld").HasColumnType("float8");
            Property(c => c.Can).HasColumnName("can").HasColumnType("bool");
            Property(c => c.Cod).HasColumnName("cod").HasColumnType("int8");
            Property(c => c.Grp).HasColumnName("grp").HasColumnType("varchar");
            Property(c => c.Txt).HasColumnName("txt").HasColumnType("int8");
            Property(c => c.Dev).HasColumnName("dev").HasColumnType("bool");
            Property(c => c.Cum).HasColumnName("cum").HasColumnType("float8");
            Property(c => c.Cls).HasColumnName("cls").HasColumnType("int2");
            Property(c => c.Bal).HasColumnName("bal").HasColumnType("int4");
            Property(c => c.Cmb).HasColumnName("cmb").HasColumnType("float8");
            Property(c => c.Cba).HasColumnName("cba").HasColumnType("int8");
            Property(c => c.Upd).HasColumnName("upd").HasColumnType("int2");
            Property(c => c.Vli).HasColumnName("vli").HasColumnType("float8");
            Property(c => c.Tbo).HasColumnName("tbo").HasColumnType("int2");

        }
    }
}
