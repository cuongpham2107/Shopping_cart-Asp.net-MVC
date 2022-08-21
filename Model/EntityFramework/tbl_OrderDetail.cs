namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_OrderDetail
    {
        [Key]
        public int OrderID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(250)]
        public string ProductName { get; set; }

        public double? Price { get; set; }

        public int? Quantity { get; set; }
    }
}
