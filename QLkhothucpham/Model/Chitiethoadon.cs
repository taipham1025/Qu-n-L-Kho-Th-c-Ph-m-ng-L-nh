namespace QLkhothucpham.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chitiethoadon")]
    public partial class Chitiethoadon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Soluong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Mahoadon { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Mathucpham { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual ThucPham ThucPham { get; set; }
    }
}
