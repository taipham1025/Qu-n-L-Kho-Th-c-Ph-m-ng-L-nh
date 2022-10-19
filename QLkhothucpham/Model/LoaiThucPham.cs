namespace QLkhothucpham.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiThucPham")]
    public partial class LoaiThucPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiThucPham()
        {
            ThucPhams = new HashSet<ThucPham>();
        }

        [Key]
        [StringLength(10)]
        public string Maloaithucpham { get; set; }

        [Required]
        [StringLength(200)]
        public string Tenloaithucpham { get; set; }

        [Required]
        [StringLength(10)]
        public string Manhaphanphoi { get; set; }

        public virtual NhaPhanPhoi NhaPhanPhoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucPham> ThucPhams { get; set; }
    }
}
