namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_InvoiceDetail
    {
        [Key]
        public int InvoiceID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(250)]
        public string ProductName { get; set; }

        public int? Quantity { get; set; }

        public double? Price { get; set; }
    }
}
