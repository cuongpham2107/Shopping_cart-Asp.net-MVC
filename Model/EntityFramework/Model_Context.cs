using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.EntityFramework
{
    public partial class Model_Context : DbContext
    {
        public Model_Context()
            : base("name=Model_Context")
        {
        }

        public virtual DbSet<tbl_About> tbl_About { get; set; }
        public virtual DbSet<tbl_Brand> tbl_Brand { get; set; }
        public virtual DbSet<tbl_Config> tbl_Config { get; set; }
        public virtual DbSet<tbl_Contact> tbl_Contact { get; set; }
        public virtual DbSet<tbl_Feedback> tbl_Feedback { get; set; }
        public virtual DbSet<tbl_Footer> tbl_Footer { get; set; }
        public virtual DbSet<tbl_Invoice> tbl_Invoice { get; set; }
        public virtual DbSet<tbl_InvoiceDetail> tbl_InvoiceDetail { get; set; }
        public virtual DbSet<tbl_Menu> tbl_Menu { get; set; }
        public virtual DbSet<tbl_OrderDetail> tbl_OrderDetail { get; set; }
        public virtual DbSet<tbl_Orders> tbl_Orders { get; set; }
        public virtual DbSet<tbl_Post> tbl_Post { get; set; }
        public virtual DbSet<tbl_PostCategory> tbl_PostCategory { get; set; }
        public virtual DbSet<tbl_Product> tbl_Product { get; set; }
        public virtual DbSet<tbl_ProductCategory> tbl_ProductCategory { get; set; }
        public virtual DbSet<tbl_ProductComment> tbl_ProductComment { get; set; }
        public virtual DbSet<tbl_Slide> tbl_Slide { get; set; }
        public virtual DbSet<tbl_Supplier> tbl_Supplier { get; set; }
        public virtual DbSet<tbl_Tag> tbl_Tag { get; set; }
        public virtual DbSet<tbl_User> tbl_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_About>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_About>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Menu>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Post>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Post>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Post>()
                .Property(e => e.Tags)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Product>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Product>()
                .Property(e => e.ListImages)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Product>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ProductComment>()
                .Property(e => e.Detail)
                .IsUnicode(false);
        }
    }
}
