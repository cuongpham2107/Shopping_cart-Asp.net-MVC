namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Post
    {
        [Key]
        public int PostID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string SeoTitle { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Column(TypeName = "text")]
        public string Image { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(500)]
        public string Detail { get; set; }

        public int? ViewCount { get; set; }

        public int? CateID { get; set; }

        [Column(TypeName = "text")]
        public string Tags { get; set; }

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
