using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            ToTable("produto");

            HasKey(p => p.ProId);

            Property(p => p.ProId).HasColumnName("pro_id").HasColumnType("int").IsRequired();
            Property(p => p.ProNome).HasColumnName("pro_nome").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(p => p.ProDescricacao).HasColumnName("pro_descricao").HasColumnType("varchar").HasMaxLength(100);
            Property(p => p.ProValor).HasColumnName("pro_valor").HasColumnType("decimal").IsRequired();
            Property(p => p.ProCodigo).HasColumnName("pro_codigo").HasColumnType("varchar").HasMaxLength(15);
            Property(p => p.ProQuantidade).HasColumnName("pro_quantidade").HasColumnType("decimal");
            Property(p => p.CatId).HasColumnName("cat_id").HasColumnType("int");
            Property(p => p.ProEstoque).HasColumnName("pro_estoque").HasColumnType("int");
            Property(p => p.ProUnidade).HasColumnName("pro_unidade").HasColumnType("varchar").HasMaxLength(10);
            Property(p => p.ProStatus).HasColumnName("pro_status").HasColumnType("int");
            Property(p => p.ProImagem).HasColumnName("pro_imagem").HasColumnType("varbinary");
            Property(p => p.ProNcm).HasColumnName("pro_ncm").HasColumnType("varchar").HasMaxLength(10);
            Property(p => p.MarId).HasColumnName("mar_id").HasColumnType("int");
            Property(p => p.ProAliquota).HasColumnName("pro_aliquota").HasColumnType("varchar").HasMaxLength(30);
            Property(p => p.ProCfop).HasColumnName("pro_cfop").HasColumnType("varchar").HasMaxLength(10);
            Property(p => p.ProPorcentagemTributo).HasColumnName("pro_porcentagemtributo").HasColumnType("decimal");
            Property(p => p.ProOrigem).HasColumnName("pro_origem").HasColumnType("int");
            Property(p => p.ProCsosn).HasColumnName("pro_csosn").HasColumnType("varchar").HasMaxLength(10);
            Property(p => p.ProCst).HasColumnName("pro_cst").HasColumnType("varchar").HasMaxLength(10);
            Property(p => p.ProCest).HasColumnName("pro_cest").HasColumnType("varchar").HasMaxLength(7);
            Property(p => p.ProCustMedio).HasColumnName("pro_cust_medio").HasColumnType("decimal");
            Property(p => p.ProUltimoCust).HasColumnName("pro_ultimo_cust").HasColumnType("decimal");

        }
    }
}
