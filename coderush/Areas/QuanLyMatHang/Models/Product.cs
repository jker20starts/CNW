namespace coderush.Areas.QuanLyMatHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductDetails = new HashSet<ProductDetail>();
        }

        [StringLength(10)]
        public string ProductID { get; set; }

        [StringLength(10)]
        public string ProductName { get; set; }

        [StringLength(10)]
        public string ProductTT { get; set; }

        public int? ProductPrice { get; set; }

        public int? ProductGG { get; set; }

        [StringLength(500)]
        public string Rating { get; set; }

        [StringLength(10)]
        public string ProductKeyW { get; set; }

        [StringLength(100)]
        public string ProductStatus { get; set; }
        [StringLength(50)]
        public string photo { get; set; }

        [StringLength(10)]
        public string CategoryID { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
