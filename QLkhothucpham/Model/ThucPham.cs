namespace QLkhothucpham.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThucPham")]
    public partial class ThucPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThucPham()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
        }

        [Key]
        [StringLength(10)]
        public string Mathucpham { get; set; }

        [Required]
        [StringLength(200)]
        public string Tenthucpham { get; set; }

        [Required]
        [StringLength(10)]
        public string Maloaithucpham { get; set; }

        public double Giathanh { get; set; }

        [Required]
        [StringLength(50)]
        public string Tendonvi { get; set; }

        public int Soluong { get; set; }

        public virtual LoaiThucPham LoaiThucPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
    }
}
