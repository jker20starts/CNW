namespace coderush.Areas.QuanLyKhachHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OderDetail")]
    public partial class OderDetail
    {
        [StringLength(10)]
        public string OderDetailID { get; set; }

        public int? Amount { get; set; }

        [StringLength(10)]
        public string OderID { get; set; }

        [StringLength(10)]
        public string SizeID { get; set; }

        [StringLength(10)]
        public string ProductID { get; set; }

        public virtual Oder Oder { get; set; }
    }
}
