namespace coderush.Areas.QuanLyKhachHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Oder")]
    public partial class Oder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oder()
        {
            OderDetails = new HashSet<OderDetail>();
        }

        [StringLength(10)]
        public string OderID { get; set; }

        public DateTime? OderDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int? OderPrice { get; set; }

        [StringLength(10)]
        public string OderStatusID { get; set; }

        [StringLength(10)]
        public string CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual OderStatu OderStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OderDetail> OderDetails { get; set; }
    }
}
