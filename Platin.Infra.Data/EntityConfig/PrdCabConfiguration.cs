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

            Property(c => c.Ide).HasColumnName("ide").HasColumnType("int8").IsRequired();
            Property(c => c.Cod).HasColumnName("cod").HasColumnType("int4");
            Property(c => c.Des).HasColumnName("des").HasColumnType("varchar").HasMaxLength(80);
            Property(c => c.Tip).HasColumnName("tip").HasColumnType("varchar").HasMaxLength(2);
            Property(c => c.Cls).HasColumnName("cls").HasColumnType("int2");
            Property(c => c.Sec).HasColumnName("sec").HasColumnType("int2");
            Property(c => c.Ipi).HasColumnName("ipi").HasColumnType("int2");
            Property(c => c.Un).HasColumnName("un").HasColumnType("varchar").HasMaxLength(2);
            Property(c => c.Qte).HasColumnName("qte").HasColumnType("int2");
            Property(c => c.Cop).HasColumnName("cop").HasColumnType("int4");
            Property(c => c.Pfa).HasColumnName("pfa").HasColumnType("float8");
            Property(c => c.Pmx).HasColumnName("pmx").HasColumnType("float8");
            Property(c => c.Pac).HasColumnName("pac").HasColumnType("float8");
            Property(c => c.Etq).HasColumnName("etq").HasColumnType("varchar").HasMaxLength(1);
            Property(c => c.Icm).HasColumnName("icm").HasColumnType("int2");
            Property(c => c.Tpl).HasColumnName("tpl").HasColumnType("varchar").HasMaxLength(2);
            Property(c => c.Rem).HasColumnName("rem").HasColumnType("varchar").HasMaxLength(3);
            Property(c => c.Cum).HasColumnName("cum").HasColumnType("float8");
            Property(c => c.Ucu).HasColumnName("ucu").HasColumnType("float8");
            Property(c => c.Pro).HasColumnName("pro").HasColumnType("float8");
            Property(c => c.Loc).HasColumnName("loc").HasColumnType("varchar").HasMaxLength(6);
            Property(c => c.Fti).HasColumnName("fti").HasColumnType("varchar").HasMaxLength(1);
            Property(c => c.Dft).HasColumnName("dft").HasColumnType("varchar").HasMaxLength(11);
            Property(c => c.Cvf).HasColumnName("cvf").HasColumnType("varchar").HasMaxLength(1);
            Property(c => c.Ctr).HasColumnName("ctr").HasColumnType("int2");
            Property(c => c.Dca).HasColumnName("dca").HasColumnType("varchar").HasMaxLength(6);
            Property(c => c.Due).HasColumnName("due").HasColumnType("varchar").HasMaxLength(6);
            Property(c => c.Dus).HasColumnName("dus").HasColumnType("varchar").HasMaxLength(6);
            Property(c => c.Dur).HasColumnName("dur").HasColumnType("varchar").HasMaxLength(6);
            Property(c => c.Eat).HasColumnName("eat").HasColumnType("int4");
            Property(c => c.Fab).HasColumnName("fab").HasColumnType("int4");
            Property(c => c.Dep).HasColumnName("dep").HasColumnType("int4");
            Property(c => c.Ref).HasColumnName("ref").HasColumnType("int4");
            Property(c => c.Gsu).HasColumnName("gsu").HasColumnType("int8");
            Property(c => c.Tbo).HasColumnName("tbo").HasColumnType("varchar").HasMaxLength(1);
            Property(c => c.Bon).HasColumnName("bon").HasColumnType("float8");
            Property(c => c.Lde).HasColumnName("lde").HasColumnType("int2");
            Property(c => c.Str).HasColumnName("str").HasColumnType("varchar").HasMaxLength(1);
            Property(c => c.Tba).HasColumnName("tba").HasColumnType("varchar").HasMaxLength(1);
            Property(c => c.Ivi).HasColumnName("ivi").HasColumnType("float8");
            Property(c => c.Ive).HasColumnName("ive").HasColumnType("float8");
            Property(c => c.Tiv).HasColumnName("tiv").HasColumnType("varchar");
            Property(c => c.Ncm).HasColumnName("ncm").HasColumnType("varchar").HasMaxLength(8);
            Property(c => c.Atv).HasColumnName("atv").HasColumnType("bool");
            Property(c => c.Pic).HasColumnName("pic").HasColumnType("float8");
            Property(c => c.Tst).HasColumnName("tst").HasColumnType("int2");
            Property(c => c.Ori).HasColumnName("ori").HasColumnType("int2");
            Property(c => c.Pis).HasColumnName("pis").HasColumnType("numeric");
            Property(c => c.Cos).HasColumnName("cos").HasColumnType("numeric");
            Property(c => c.Tme).HasColumnName("tme").HasColumnType("varchar").HasMaxLength(1);
            Property(c => c.Upd).HasColumnName("upd").HasColumnType("bool");
            Property(c => c.S2s).HasColumnName("s2s").HasColumnType("bool");
            Property(c => c.FabDiv).HasColumnName("fab_div").HasColumnType("int4");
            Property(c => c.Fat).HasColumnName("fat").HasColumnType("float8");
            Property(c => c.Ebi).HasColumnName("ebi").HasColumnType("float8");
            Property(c => c.DesRed).HasColumnName("des_red").HasColumnType("varchar").HasMaxLength(30);
            Property(c => c.Crv).HasColumnName("crv").HasColumnType("varchar").HasMaxLength(1);
            Property(c => c.Dta).HasColumnName("dta").HasColumnType("date");
            Property(c => c.Dis).HasColumnName("dis").HasColumnType("bool");
            Property(c => c.Acr).HasColumnName("acr").HasColumnType("bool");






        }

    }
}
