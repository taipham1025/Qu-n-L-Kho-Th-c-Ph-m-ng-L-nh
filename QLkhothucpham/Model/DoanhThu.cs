namespace QLkhothucpham.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanhThu")]
    public partial class DoanhThu
    {
        [Key]
        [StringLength(10)]
        public string MaDoanhThu { get; set; }

        public DateTime Ngay { get; set; }

        [Required]
        [StringLength(10)]
        public string Mathucpham { get; set; }

        public int Soluong { get; set; }

        [Required]
        [StringLength(10)]
        public string Malichsugd { get; set; }

        public virtual LSgiaodich LSgiaodich { get; set; }
    }
}
