namespace coderush.Areas.QuanLyKhachHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Oders = new HashSet<Oder>();
        }

        [StringLength(10)]
        public string CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(10)]
        public string CustomerPassword { get; set; }

        [StringLength(30)]
        public string CustomerEmail { get; set; }

        public int? CustomerPhone { get; set; }

        [StringLength(100)]
        public string CustomerAddress { get; set; }

        [StringLength(50)]
        public string AVATAR { get; set; }
        [StringLength(10)]
        public string GIOITINH { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oder> Oders { get; set; }
    }
}
