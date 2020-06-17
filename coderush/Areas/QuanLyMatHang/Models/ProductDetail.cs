namespace coderush.Areas.QuanLyMatHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductDetail")]
    public partial class ProductDetail
    {
        [StringLength(10)]
        public string ProductDetailID { get; set; }

        [StringLength(10)]
        public string ProductID { get; set; }

        [StringLength(10)]
        public string SizeID { get; set; }

        public virtual Product Product { get; set; }

        public virtual Size Size { get; set; }
    }
}
