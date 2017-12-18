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
            Property(c => c.ApprovedRatingSum).HasColumnName("ApprovedRatingSum").HasColumnType("int").IsRequired();
            Property(c => c.NotApprovedRatingSum).HasColumnName("NotApprovedRatingSum").HasColumnType("int").IsRequired();
            Property(c => c.ApprovedTotalReviews).HasColumnName("ApprovedTotalReviews").HasColumnType("int").IsRequired();
            Property(c => c.NotApprovedTotalReviews).HasColumnName("NotApprovedTotalReviews").HasColumnType("int").IsRequired();
            Property(c => c.SubjectToAcl).HasColumnName("SubjectToAcl").HasColumnType("bit").IsRequired();
            Property(c => c.LimitedToStores).HasColumnName("LimitedToStores").HasColumnType("bit").IsRequired();
            Property(c => c.Sku).HasColumnName("Sku").HasColumnType("nvarchar").HasMaxLength(400);
            Property(c => c.ManufacturerPartNumber).HasColumnName("ManufacturerPartNumber").HasColumnType("nvarchar").HasMaxLength(400);
            Property(c => c.Gtin).HasColumnName("Gtin").HasColumnType("nvarchar").HasMaxLength(400);
            Property(c => c.IsGiftCard).HasColumnName("IsGiftCard").HasColumnType("bit").IsRequired();
            Property(c => c.GiftCardTypeId).HasColumnName("GiftCardTypeId").HasColumnType("int").IsRequired();
            Property(c => c.OverriddenGiftCardAmount).HasColumnName("OverriddenGiftCardAmount").HasColumnType("decimal");
            Property(c => c.RequireOtherProducts).HasColumnName("RequireOtherProducts").HasColumnType("bit").IsRequired();
            Property(c => c.RequiredProductIds).HasColumnName("RequiredProductIds").HasColumnType("nvarchar").HasMaxLength(1000);
            Property(c => c.AutomaticallyAddRequiredProducts).HasColumnName("AutomaticallyAddRequiredProducts").HasColumnType("bit").IsRequired();
            Property(c => c.IsDownload).HasColumnName("IsDownload").HasColumnType("bit").IsRequired();
            Property(c => c.DownloadId).HasColumnName("DownloadId").HasColumnType("int").IsRequired();
            Property(c => c.UnlimitedDownloads).HasColumnName("UnlimitedDownloads").HasColumnType("bit").IsRequired();
            Property(c => c.MaxNumberOfDownloads).HasColumnName("MaxNumberOfDownloads").HasColumnType("int").IsRequired();
            Property(c => c.DownloadExpirationDays).HasColumnName("DownloadExpirationDays").HasColumnType("int");
            Property(c => c.DownloadActivationTypeId).HasColumnName("DownloadActivationTypeId").HasColumnType("int").IsRequired();
            Property(c => c.HasSampleDownload).HasColumnName("HasSampleDownload").HasColumnType("bit").IsRequired();
            Property(c => c.SampleDownloadId).HasColumnName("SampleDownloadId").HasColumnType("int").IsRequired();
            Property(c => c.HasUserAgreement).HasColumnName("HasUserAgreement").HasColumnType("bit").IsRequired();
            Property(c => c.UserAgreementText).HasColumnName("UserAgreementText").HasColumnType("nvarchar");
            Property(c => c.IsRecurring).HasColumnName("IsRecurring").HasColumnType("bit").IsRequired();
            Property(c => c.RecurringCycleLength).HasColumnName("RecurringCycleLength").HasColumnType("int").IsRequired();
            Property(c => c.RecurringCyclePeriodId).HasColumnName("RecurringCyclePeriodId").HasColumnType("int").IsRequired();
            Property(c => c.RecurringTotalCycles).HasColumnName("RecurringTotalCycles").HasColumnType("int").IsRequired();
            Property(c => c.IsRental).HasColumnName("IsRental").HasColumnType("bit").IsRequired();
            Property(c => c.RentalPriceLength).HasColumnName("RentalPriceLength").HasColumnType("int").IsRequired();
            Property(c => c.RentalPricePeriodId).HasColumnName("RentalPricePeriodId").HasColumnType("int").IsRequired();
            Property(c => c.IsShipEnabled).HasColumnName("IsShipEnabled").HasColumnType("bit").IsRequired();
            Property(c => c.IsFreeShipping).HasColumnName("IsFreeShipping").HasColumnType("bit").IsRequired();
            Property(c => c.ShipSeparately).HasColumnName("ShipSeparately").HasColumnType("bit").IsRequired();
            Property(c => c.AdditionalShippingCharge).HasColumnName("AdditionalShippingCharge").HasColumnType("decimal").IsRequired();
            Property(c => c.DeliveryDateId).HasColumnName("DeliveryDateId").HasColumnType("int").IsRequired();
            Property(c => c.IsTaxExempt).HasColumnName("IsTaxExempt").HasColumnType("bit").IsRequired();
            Property(c => c.TaxCategoryId).HasColumnName("TaxCategoryId").HasColumnType("int").IsRequired();
            Property(c => c.IsTelecommunicationsOrBroadcastingOrElectronicServices).HasColumnName("IsTelecommunicationsOrBroadcastingOrElectronicServices").HasColumnType("bit").IsRequired();
            Property(c => c.ManageInventoryMethodId).HasColumnName("ManageInventoryMethodId").HasColumnType("int").IsRequired();
            Property(c => c.ProductAvailabilityRangeId).HasColumnName("ProductAvailabilityRangeId").HasColumnType("int").IsRequired();
            Property(c => c.UseMultipleWarehouses).HasColumnName("UseMultipleWarehouses").HasColumnType("bit").IsRequired();
            Property(c => c.WarehouseId).HasColumnName("WarehouseId").HasColumnType("int").IsRequired();
            Property(c => c.StockQuantity).HasColumnName("StockQuantity").HasColumnType("int").IsRequired();
            Property(c => c.DisplayStockAvailability).HasColumnName("DisplayStockAvailability").HasColumnType("bit").IsRequired();
            Property(c => c.DisplayStockQuantity).HasColumnName("DisplayStockQuantity").HasColumnType("bit").IsRequired();
            Property(c => c.MinStockQuantity).HasColumnName("MinStockQuantity").HasColumnType("int").IsRequired();
            Property(c => c.LowStockActivityId).HasColumnName("LowStockActivityId").HasColumnType("int").IsRequired();
            Property(c => c.NotifyAdminForQuantityBelow).HasColumnName("NotifyAdminForQuantityBelow").HasColumnType("int").IsRequired();
            Property(c => c.BackorderModeId).HasColumnName("BackorderModeId").HasColumnType("int").IsRequired();
            Property(c => c.AllowBackInStockSubscriptions).HasColumnName("AllowBackInStockSubscriptions").HasColumnType("bit").IsRequired();
            Property(c => c.OrderMinimumQuantity).HasColumnName("OrderMinimumQuantity").HasColumnType("int").IsRequired();
            Property(c => c.OrderMaximumQuantity).HasColumnName("OrderMaximumQuantity").HasColumnType("int").IsRequired();
            Property(c => c.AllowedQuantities).HasColumnName("AllowedQuantities").HasColumnType("nvarchar").HasMaxLength(1000);
            Property(c => c.AllowAddingOnlyExistingAttributeCombinations).HasColumnName("AllowAddingOnlyExistingAttributeCombinations").HasColumnType("bit").IsRequired();
            Property(c => c.NotReturnable).HasColumnName("NotReturnable").HasColumnType("bit").IsRequired();
            Property(c => c.DisableBuyButton).HasColumnName("DisableBuyButton").HasColumnType("bit").IsRequired();
            Property(c => c.DisableWishlistButton).HasColumnName("DisableWishlistButton").HasColumnType("bit").IsRequired();
            Property(c => c.AvailableForPreOrder).HasColumnName("AvailableForPreOrder").HasColumnType("bit").IsRequired();
            Property(c => c.PreOrderAvailabilityStartDateTimeUtc).HasColumnName("PreOrderAvailabilityStartDateTimeUtc").HasColumnType("datetime");
            Property(c => c.CallForPrice).HasColumnName("CallForPrice").HasColumnType("bit").IsRequired();
            Property(c => c.Price).HasColumnName("Price").HasColumnType("decimal").IsRequired();
            Property(c => c.OldPrice).HasColumnName("OldPrice").HasColumnType("decimal").IsRequired();
            Property(c => c.ProductCost).HasColumnName("ProductCost").HasColumnType("decimal").IsRequired();
            Property(c => c.CustomerEntersPrice).HasColumnName("CustomerEntersPrice").HasColumnType("bit").IsRequired();
            Property(c => c.MinimumCustomerEnteredPrice).HasColumnName("MinimumCustomerEnteredPrice").HasColumnType("decimal").IsRequired();
            Property(c => c.MaximumCustomerEnteredPrice).HasColumnName("MaximumCustomerEnteredPrice").HasColumnType("decimal").IsRequired();
            Property(c => c.BasepriceEnabled).HasColumnName("BasepriceEnabled").HasColumnType("bit").IsRequired();
            Property(c => c.BasepriceAmount).HasColumnName("BasepriceAmount").HasColumnType("decimal").IsRequired();
            Property(c => c.BasepriceUnitId).HasColumnName("BasepriceUnitId").HasColumnType("int").IsRequired();
            Property(c => c.BasepriceBaseAmount).HasColumnName("BasepriceBaseAmount").HasColumnType("decimal").IsRequired();
            Property(c => c.BasepriceBaseUnitId).HasColumnName("BasepriceBaseUnitId").HasColumnType("int").IsRequired();
            Property(c => c.MarkAsNew).HasColumnName("MarkAsNew").HasColumnType("bit").IsRequired();
            Property(c => c.MarkAsNewStartDateTimeUtc).HasColumnName("MarkAsNewStartDateTimeUtc").HasColumnType("datetime");
            Property(c => c.MarkAsNewEndDateTimeUtc).HasColumnName("MarkAsNewEndDateTimeUtc").HasColumnType("datetime");
            Property(c => c.HasTierPrices).HasColumnName("HasTierPrices").HasColumnType("bit").IsRequired();
            Property(c => c.HasDiscountsApplied).HasColumnName("HasDiscountsApplied").HasColumnType("bit").IsRequired();
            Property(c => c.Weight).HasColumnName("Weight").HasColumnType("decimal").IsRequired();
            Property(c => c.Length).HasColumnName("Length").HasColumnType("decimal").IsRequired();
            Property(c => c.Width).HasColumnName("Width").HasColumnType("decimal").IsRequired();
            Property(c => c.Height).HasColumnName("Height").HasColumnType("decimal").IsRequired();
            Property(c => c.AvailableStartDateTimeUtc).HasColumnName("AvailableStartDateTimeUtc").HasColumnType("datetime");
            Property(c => c.AvailableEndDateTimeUtc).HasColumnName("AvailableEndDateTimeUtc").HasColumnType("datetime");
            Property(c => c.DisplayOrder).HasColumnName("DisplayOrder").HasColumnType("int").IsRequired();
            Property(c => c.Published).HasColumnName("Published").HasColumnType("bit").IsRequired();
            Property(c => c.Deleted).HasColumnName("Deleted").HasColumnType("bit").IsRequired();
            Property(c => c.CreatedOnUtc).HasColumnName("CreatedOnUtc").HasColumnType("datetime").IsRequired();
            Property(c => c.UpdatedOnUtc).HasColumnName("UpdatedOnUtc").HasColumnType("datetime").IsRequired();
        }
    }
}
