using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class FuncionarioConfiguration : EntityTypeConfiguration<Funcionario>
    {

        public FuncionarioConfiguration()
        {
            ToTable("funcionario");

            HasKey(f => f.FunId);

            Property(f => f.FunId).HasColumnName("fun_id").HasColumnType("int").IsRequired();
            Property(f => f.FunNome).HasColumnName("fun_nome").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(f => f.FunTelefone1).HasColumnName("fun_telefone1").HasColumnType("varchar").HasMaxLength(15);
            Property(f => f.FunTelefone2).HasColumnName("fun_telefone2").HasColumnType("varchar").HasMaxLength(15);
            Property(f => f.FunTelefone3).HasColumnName("fun_telefone3").HasColumnType("varchar").HasMaxLength(15);
            Property(f => f.FunCpf).HasColumnName("fun_cpf").HasColumnType("varchar").HasMaxLength(15);
            Property(f => f.FunRg).HasColumnName("fun_rg").HasColumnType("varchar").HasMaxLength(15);
            Property(f => f.FunSexo).HasColumnName("fun_sexo").HasColumnType("varchar").HasMaxLength(1);
            Property(f => f.FunEndereco).HasColumnName("fun_endereco").HasColumnType("varchar").HasMaxLength(100);
            Property(f => f.FunNumero).HasColumnName("fun_numero").HasColumnType("varchar").HasMaxLength(10);
            Property(f => f.FunBairro).HasColumnName("fun_bairro").HasColumnType("varchar").HasMaxLength(50);
            Property(f => f.FunCep).HasColumnName("fun_cep").HasColumnType("varchar").HasMaxLength(9);
            Property(f => f.FunUsuario).HasColumnName("fun_usuario").HasColumnType("varchar").HasMaxLength(15).IsRequired();
            Property(f => f.FunSenha).HasColumnName("fun_senha").HasColumnType("varchar").HasMaxLength(15).IsRequired();
            Property(f => f.FunNivel).HasColumnName("fun_nivel").HasColumnType("varchar").HasMaxLength(15).IsRequired();
            Property(f => f.FunInformacao).HasColumnName("fun_informacao").HasColumnType("varchar").HasMaxLength(100);
            Property(f => f.FunEmail).HasColumnName("fun_email").HasColumnType("varchar").HasMaxLength(100);
            Property(f => f.FunStatus).HasColumnName("fun_status").HasColumnType("int");
            Property(f => f.CinId).HasColumnName("cin_id").HasColumnType("int");
            Property(f => f.FunDtNascimento).HasColumnName("fun_dtnascimento").HasColumnType("datetime");
            Property(f => f.FunDDD1).HasColumnName("fun_dd1").HasColumnType("varchar").HasMaxLength(2);
            Property(f => f.FunDDD2).HasColumnName("fun_dd2").HasColumnType("varchar").HasMaxLength(2);
            Property(f => f.FunDDD3).HasColumnName("fun_dd3").HasColumnType("varchar").HasMaxLength(2);
            Property(f => f.FunBiometria).HasColumnName("fun_biometria").HasColumnType("varchar").HasMaxLength(4000);


        }
    }
}
