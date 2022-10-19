using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLkhothucpham.Model;

namespace QLkhothucpham
{
    public partial class FormThanhTien : Form
    {
        public FormThanhTien()
        {
            InitializeComponent();
        }
        
        private void FormThanhTien_Load(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            Model1 context = new Model1();
            List<ThucPham> ListThucPham = context.ThucPhams.ToList();
            float ThanhTien = 0;
            lbMaTPM.Text = Form1.MaTPM;
            lbTenTPM.Text = Form1.TenTPM;
            lbSoLuongM.Text = Form1.SoLuongM;
            lbTenKH.Text = Form1.TenKH;
            lbSDTKH.Text = Form1.SDTKH;
            lbDiaChiKH.Text = Form1.DiaChiKH;
            int SLM = 0;
            int.TryParse(Form1.SoLuongM, out SLM);
            ThucPham mua = context.ThucPhams.FirstOrDefault(p => p.Mathucpham == lbMaTPM.Text);
            if(mua != null)
            {
                ThanhTien = float.Parse(mua.Giathanh.ToString()) * SLM;
            }
            lbThanhTien.Text = ThanhTien.ToString("F20").TrimEnd('0');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<Khachhang> ListKhachHang = context.Khachhangs.ToList();
            List<HoaDon> ListHoaDon = context.HoaDons.ToList();
            List<Chitiethoadon> ListCTHD = context.Chitiethoadons.ToList();
            List<ThucPham> ListThucPham = context.ThucPhams.ToList();
                Random rd = new Random();
                int ma = rd.Next(10000, 99999);
                String gMaKH = "KH"+ma.ToString();
                string gMaHD = "HD" + ma.ToString();
            Khachhang k = new Khachhang()
            {
                Makhachhang = gMaKH,
                Tenkhachhang = lbTenKH.Text,
                Diachi = lbDiaChiKH.Text,
                SoDT = lbSDTKH.Text
            };
            context.Khachhangs.Add(k);
            HoaDon hd = new HoaDon()
            {
                Mahoadon = gMaHD,
                Makhachhang = gMaKH,
                Ngaylap = DateTime.Now.Date,
                Tongtien = float.Parse(lbThanhTien.Text)
            };
            context.HoaDons.Add(hd);
            Chitiethoadon cthd = new Chitiethoadon()
            {
                Mahoadon = gMaHD,
                Soluong = int.Parse(lbSoLuongM.Text),
                Mathucpham = lbMaTPM.Text
            };
            context.Chitiethoadons.Add(cthd);
            ThucPham ch = context.ThucPhams.FirstOrDefault(p => p.Mathucpham == lbMaTPM.Text);
            if (ch != null)
            {
                ch.Soluong = ch.Soluong - int.Parse(lbSoLuongM.Text);
            }
            context.SaveChanges();
            MessageBox.Show("Thành Công", "", MessageBoxButtons.OK);
        }
    }
}
