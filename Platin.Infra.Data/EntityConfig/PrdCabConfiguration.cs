using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class PrdCabConfiguration : EntityTypeConfiguration<PrdCab>
    {
        public PrdCabConfiguration()
        {
            ToTable("estoque.prd_cab");

            HasKey(p => p.Ide);

            Property(c => c.Ide).HasColumnName("ide").HasColumnType("bigserial").IsRequired();
            Property(c => c.Cod).HasColumnName("cod").HasColumnType("Integer");
            Property(c => c.Des).HasColumnName("des").HasColumnType("varchar").HasMaxLength(80);
            Property(c => c.Tip).HasColumnName("tip").HasColumnType("char").HasMaxLength(2);
            Property(c => c.Cls).HasColumnName("cls").HasColumnType("smallint");
            Property(c => c.Sec).HasColumnName("sec").HasColumnType("smallint");
            Property(c => c.Ipi).HasColumnName("ipi").HasColumnType("smallint");
            Property(c => c.Un).HasColumnName("un").HasColumnType("char").HasMaxLength(2);
            Property(c => c.Qte).HasColumnName("qte").HasColumnType("smallint");
            Property(c => c.Cop).HasColumnName("cop").HasColumnType("Integer");
            Property(c => c.Pfa).HasColumnName("pfa").HasColumnType("double precision");
            Property(c => c.Pmx).HasColumnName("pmx").HasColumnType("double precision");
            Property(c => c.Pac).HasColumnName("pac").HasColumnType("double precision");
            Property(c => c.Etq).HasColumnName("etq").HasColumnType("char").HasMaxLength(1);
            Property(c => c.Icm).HasColumnName("icm").HasColumnType("smallint");
            Property(c => c.Tpl).HasColumnName("tpl").HasColumnType("char").HasMaxLength(2);
            Property(c => c.Rem).HasColumnName("rem").HasColumnType("char").HasMaxLength(3);
            Property(c => c.Cum).HasColumnName("cum").HasColumnType("double precision");
            Property(c => c.Ucu).HasColumnName("ucu").HasColumnType("double precision");
            Property(c => c.Pro).HasColumnName("pro").HasColumnType("double precision");
            Property(c => c.Loc).HasColumnName("loc").HasColumnType("varchar").HasMaxLength(6);
            Property(c => c.Fti).HasColumnName("fti").HasColumnType("char").HasMaxLength(1);
            Property(c => c.Dft).HasColumnName("dft").HasColumnType("varchar").HasMaxLength(11);
            Property(c => c.Cvf).HasColumnName("cvf").HasColumnType("char").HasMaxLength(1);
            Property(c => c.Ctr).HasColumnName("ctr").HasColumnType("smallint");
            Property(c => c.Dca).HasColumnName("dca").HasColumnType("char").HasMaxLength(6);
            Property(c => c.Due).HasColumnName("due").HasColumnType("char").HasMaxLength(6);
            Property(c => c.Dus).HasColumnName("dus").HasColumnType("char").HasMaxLength(6);
            Property(c => c.Dur).HasColumnName("dur").HasColumnType("char").HasMaxLength(6);
            Property(c => c.Eat).HasColumnName("eat").HasColumnType("Integer");
            Property(c => c.Fab).HasColumnName("fab").HasColumnType("Integer");
            Property(c => c.Dep).HasColumnName("dep").HasColumnType("Integer");
            Property(c => c.Ref).HasColumnName("ref").HasColumnType("Integer");
            Property(c => c.Gsu).HasColumnName("gsu").HasColumnType("bigint");
            Property(c => c.Tbo).HasColumnName("tbo").HasColumnType("char").HasMaxLength(1);
            Property(c => c.Bon).HasColumnName("bon").HasColumnType("double precision");
            Property(c => c.Lde).HasColumnName("lde").HasColumnType("smallint");
            Property(c => c.Str).HasColumnName("str").HasColumnType("char").HasMaxLength(1);
            Property(c => c.Tba).HasColumnName("tba").HasColumnType("char").HasMaxLength(1);
            Property(c => c.Ivi).HasColumnName("ivi").HasColumnType("double precision");
            Property(c => c.Ive).HasColumnName("ive").HasColumnType("double precision");
            Property(c => c.Ncm).HasColumnName("ncm").HasColumnType("varchar").HasMaxLength(8);
            Property(c => c.Atv).HasColumnName("atv").HasColumnType("boolean");
            Property(c => c.Pic).HasColumnName("pic").HasColumnType("double precision");
            Property(c => c.Tst).HasColumnName("tst").HasColumnType("smallint");
            Property(c => c.Ori).HasColumnName("ori").HasColumnType("smallint");
            Property(c => c.Pis).HasColumnName("pis").HasColumnType("numeric");
            Property(c => c.Cos).HasColumnName("cos").HasColumnType("numeric");
            Property(c => c.Tme).HasColumnName("tme").HasColumnType("char").HasMaxLength(1);
            Property(c => c.Upd).HasColumnName("upd").HasColumnType("boolean");
            Property(c => c.S2s).HasColumnName("s2s").HasColumnType("boolean");
            Property(c => c.FabDiv).HasColumnName("fab_div").HasColumnType("Integer");
            Property(c => c.Fat).HasColumnName("fat").HasColumnType("double precision");
            Property(c => c.Ebi).HasColumnName("ebi").HasColumnType("double precision");
            Property(c => c.DesRed).HasColumnName("des_red").HasColumnType("varchar").HasMaxLength(30);
            Property(c => c.Crv).HasColumnName("crv").HasColumnType("char").HasMaxLength(1);
            Property(c => c.Dta).HasColumnName("dta").HasColumnType("date");
            Property(c => c.Dis).HasColumnName("dis").HasColumnType("boolean");
            Property(c => c.Acr).HasColumnName("acr").HasColumnType("boolean");






        }

    }
}
