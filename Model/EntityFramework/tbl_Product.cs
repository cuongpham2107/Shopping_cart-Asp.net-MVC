namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string SeoTitle { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Column(TypeName = "text")]
        public string Images { get; set; }

        [Column(TypeName = "text")]
        public string ListImages { get; set; }

        public double? Price { get; set; }

        public double? PromotionPrice { get; set; }

        public int? VAT { get; set; }

        public int? Quantity { get; set; }

        public int? Warranty { get; set; }

        public DateTime? Hot { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public string Detail { get; set; }

        public int? ViewCount { get; set; }

        public int? CateID { get; set; }

        public int? BrandID { get; set; }

        public int? Supplier { get; set; }

        [StringLength(250)]
        public string MateKeywords { get; set; }

        [StringLength(250)]
        public string MateDescription { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
