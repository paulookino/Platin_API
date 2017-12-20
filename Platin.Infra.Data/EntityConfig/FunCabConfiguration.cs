using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class FunCabConfiguration : EntityTypeConfiguration<FunCab>
    {
        public FunCabConfiguration()
        {
            ToTable("cadastro.fun_cab");

            HasKey(f => f.Ide);

            Property(f => f.Ide).HasColumnName("ide").HasColumnType("int8").IsRequired();
            Property(f => f.Cod).HasColumnName("cod").HasColumnType("varchar");
            Property(f => f.Nom).HasColumnName("nom").HasColumnType("varchar");
            Property(f => f.Uad).HasColumnName("uad").HasColumnType("int2");
            Property(f => f.Sis).HasColumnName("sis").HasColumnType("bool");
            Property(f => f.Log).HasColumnName("log").HasColumnType("varchar");
            Property(f => f.Pco).HasColumnName("pco").HasColumnType("float8");
            Property(f => f.Fix).HasColumnName("fix").HasColumnType("float8");
            Property(f => f.Atv).HasColumnName("atv").HasColumnType("bool");
            Property(f => f.Cpf).HasColumnName("cpf").HasColumnType("varchar");
            Property(f => f.Coa).HasColumnName("coa").HasColumnType("varchar");
            Property(f => f.Upd).HasColumnName("upd").HasColumnType("bool");
            Property(f => f.Sal).HasColumnName("sal").HasColumnType("float8");
            Property(f => f.Sen).HasColumnName("sen").HasColumnType("varchar");
            Property(f => f.Pfl).HasColumnName("pfl").HasColumnType("int2");

        }
    }
}
