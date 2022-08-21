namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PostCategory
    {
        [Key]
        public int CateID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string SeoTitle { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? Sort { get; set; }

        public int? ParentID { get; set; }

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
