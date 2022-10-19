namespace QLkhothucpham.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaPhanPhoi")]
    public partial class NhaPhanPhoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaPhanPhoi()
        {
            LoaiThucPhams = new HashSet<LoaiThucPham>();
        }

        [Key]
        [StringLength(10)]
        public string Manhaphanphoi { get; set; }

        [Required]
        [StringLength(200)]
        public string Tennhaphanphoi { get; set; }

        [Required]
        [StringLength(200)]
        public string Diachi { get; set; }

        [Required]
        [StringLength(20)]
        public string SoDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoaiThucPham> LoaiThucPhams { get; set; }
    }
}
