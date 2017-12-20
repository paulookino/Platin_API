using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class VFunUadCabConfiguration : EntityTypeConfiguration<VFunUadCab>
    {

        public VFunUadCabConfiguration()
        {
            ToTable("web.v_fun_uad_cab");

            HasKey(v => v.Cod);

            Property(v => v.Cod).HasColumnName("cod").HasColumnType("int4");
            Property(v => v.Fun).HasColumnName("fun").HasColumnType("varchar");
            Property(v => v.Uad).HasColumnName("uad").HasColumnType("int4");
            Property(v => v.Ide).HasColumnName("ide").HasColumnType("int8");
            Property(v => v.Ccm).HasColumnName("ccm").HasColumnType("int4");
            Property(v => v.Cgo).HasColumnName("cgo").HasColumnType("varchar");
        }
    }
}
