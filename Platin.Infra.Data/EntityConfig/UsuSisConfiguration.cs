using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class UsuSisConfiguration : EntityTypeConfiguration<UsuSis>
    {

        public UsuSisConfiguration()
        {
            ToTable("web.usu_sis");

            HasKey(u => u.Grp);

            Property(u => u.Grp).HasColumnName("grp").HasColumnType("int8");
            Property(u => u.Usu).HasColumnName("usu").HasColumnType("int8");
            Property(u => u.Nom).HasColumnName("nom").HasColumnType("varchar");
            Property(u => u.Log).HasColumnName("log").HasColumnType("varchar");
            Property(u => u.Pas).HasColumnName("pas").HasColumnType("varchar");
            Property(u => u.Eml).HasColumnName("eml").HasColumnType("varchar");
            Property(u => u.Dsc).HasColumnName("dsc").HasColumnType("varchar");

        }
    }
}
