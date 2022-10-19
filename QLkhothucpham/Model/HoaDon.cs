namespace QLkhothucpham.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
            LSgiaodiches = new HashSet<LSgiaodich>();
        }

        [Key]
        [StringLength(10)]
        public string Mahoadon { get; set; }

        [Required]
        [StringLength(10)]
        public string Makhachhang { get; set; }

        public DateTime Ngaylap { get; set; }

        public double Tongtien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }

        public virtual Khachhang Khachhang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LSgiaodich> LSgiaodiches { get; set; }
    }
}
