using Platin.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Platin.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {

        public ProductConfiguration()
        {
            ToTable("Product");

            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("Id").HasColumnType("int").IsRequired();
            Property(c => c.ProductTypeId).HasColumnName("ProductTypeId").HasColumnType("int").IsRequired();
            Property(c => c.ParentGroupedProductId).HasColumnName("ParentGroupedProductId").HasColumnType("int").IsRequired();
            Property(c => c.VisibleIndividually).HasColumnName("VisibleIndividually").HasColumnType("bit").IsRequired();
            Property(c => c.Name).HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(400).IsRequired();
            Property(c => c.ShortDescription).HasColumnName("ShortDescription").HasColumnType("nvarchar");
            Property(c => c.FullDescription).HasColumnName("FullDescription").HasColumnType("nvarchar");
            Property(c => c.AdminComment).HasColumnName("AdminComment").HasColumnType("nvarchar");
            Property(c => c.ProductTemplateId).HasColumnName("ProductTemplateId").HasColumnType("int").IsRequired();
            Property(c => c.VendorId).HasColumnName("VendorId").HasColumnType("int").IsRequired();
            Property(c => c.ShowOnHomePage).HasColumnName("ShowOnHomePage").HasColumnType("bit").IsRequired();
            Property(c => c.MetaKeywords).HasColumnName("MetaKeywords").HasColumnType("nvarchar").HasMaxLength(400);
            Property(c => c.MetaDescription).HasColumnName("MetaDescription").HasColumnType("nvarchar");
            Property(c => c.MetaTitle).HasColumnName("MetaTitle").HasColumnType("nvarchar").HasMaxLength(400);
            Property(c => c.AllowCustomerReviews).HasColumnName("AllowCustomerReviews").HasColumnType("bit").IsRequired();




        }
    }
}
