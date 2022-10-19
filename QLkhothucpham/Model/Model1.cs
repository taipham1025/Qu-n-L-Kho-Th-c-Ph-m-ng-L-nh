using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLkhothucpham.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model2")
        {
        }

        public virtual DbSet<DoanhThu> DoanhThus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<LoaiThucPham> LoaiThucPhams { get; set; }
        public virtual DbSet<LSgiaodich> LSgiaodiches { get; set; }
        public virtual DbSet<NhaPhanPhoi> NhaPhanPhois { get; set; }
        public virtual DbSet<ThucPham> ThucPhams { get; set; }
        public virtual DbSet<Chitiethoadon> Chitiethoadons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoanhThu>()
                .Property(e => e.MaDoanhThu)
                .IsFixedLength();

            modelBuilder.Entity<DoanhThu>()
                .Property(e => e.Mathucpham)
                .IsFixedLength();

            modelBuilder.Entity<DoanhThu>()
                .Property(e => e.Malichsugd)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.Mahoadon)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.Makhachhang)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.Chitiethoadons)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.LSgiaodiches)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khachhang>()
                .Property(e => e.Makhachhang)
                .IsFixedLength();

            modelBuilder.Entity<Khachhang>()
                .Property(e => e.SoDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.Khachhang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiThucPham>()
                .Property(e => e.Maloaithucpham)
                .IsFixedLength();

            modelBuilder.Entity<LoaiThucPham>()
                .Property(e => e.Manhaphanphoi)
                .IsFixedLength();

            modelBuilder.Entity<LoaiThucPham>()
                .HasMany(e => e.ThucPhams)
                .WithRequired(e => e.LoaiThucPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LSgiaodich>()
                .Property(e => e.Malichsugd)
                .IsFixedLength();

            modelBuilder.Entity<LSgiaodich>()
                .Property(e => e.Mahoadon)
                .IsFixedLength();

            modelBuilder.Entity<LSgiaodich>()
                .HasMany(e => e.DoanhThus)
                .WithRequired(e => e.LSgiaodich)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaPhanPhoi>()
                .Property(e => e.Manhaphanphoi)
                .IsFixedLength();

            modelBuilder.Entity<NhaPhanPhoi>()
                .Property(e => e.SoDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhaPhanPhoi>()
                .HasMany(e => e.LoaiThucPhams)
                .WithRequired(e => e.NhaPhanPhoi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThucPham>()
                .Property(e => e.Mathucpham)
                .IsFixedLength();

            modelBuilder.Entity<ThucPham>()
                .Property(e => e.Maloaithucpham)
                .IsFixedLength();

            modelBuilder.Entity<ThucPham>()
                .HasMany(e => e.Chitiethoadons)
                .WithRequired(e => e.ThucPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Chitiethoadon>()
                .Property(e => e.Mahoadon)
                .IsFixedLength();

            modelBuilder.Entity<Chitiethoadon>()
                .Property(e => e.Mathucpham)
                .IsFixedLength();
        }
    }
}
