namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Slide
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        public int? Sort { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
