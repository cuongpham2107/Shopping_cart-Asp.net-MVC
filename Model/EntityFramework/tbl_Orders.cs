namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Orders
    {
        [Key]
        public int OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public bool? Status { get; set; }

        public bool? Delivered { get; set; }

        public DateTime? DeliveredDate { get; set; }

        public int? CustomerID { get; set; }

        public int? Discount { get; set; }
    }
}
