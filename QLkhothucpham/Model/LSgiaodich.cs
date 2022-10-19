namespace QLkhothucpham.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LSgiaodich")]
    public partial class LSgiaodich
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LSgiaodich()
        {
            DoanhThus = new HashSet<DoanhThu>();
        }

        [Key]
        [StringLength(10)]
        public string Malichsugd { get; set; }

        [Required]
        [StringLength(10)]
        public string Mahoadon { get; set; }

        public DateTime Ngaylaphoadon { get; set; }

        public double Tongtien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoanhThu> DoanhThus { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
