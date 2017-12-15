namespace Platin.Domain.Entities
{
    public class Product : EntityBase
    {
        public int Id { get; set; }

        public int ProductTypeId { get; set; }

        public int ParentGroupedProductId { get; set; }

        public bool VisibleIndividually { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public string AdminComment { get; set; }

        public int ProductTemplateId { get; set; }

        public int VendorId { get; set; }

        public bool ShowOnHomePage { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public bool AllowCustomerReviews { get; set; }

        public int ApprovedRatingSum { get; set; }

        public int NotApprovedRatingSum { get; set; }

        public int ApprovedTotalReviews { get; set; }

        public int NotApprovedTotalReviews { get; set; }

        public bool SubjectToAcl { get; set; }

        public bool LimitedToStores { get; set; }

        public int MyProperty { get; set; }
    }
}
