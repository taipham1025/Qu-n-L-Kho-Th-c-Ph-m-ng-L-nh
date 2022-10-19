using DevExpress.XtraEditors;
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
    public partial class FormLichSuGiaoDich : DevExpress.XtraEditors.XtraForm
    {
        public FormLichSuGiaoDich()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bindgrid(List<HoaDon> ListHoaDon)
        {
            dgvHoaDon.Rows.Clear();
            foreach (var item in ListHoaDon)
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = item.Mahoadon;
                dgvHoaDon.Rows[index].Cells[1].Value = item.Makhachhang;
                dgvHoaDon.Rows[index].Cells[2].Value = item.Ngaylap;
                dgvHoaDon.Rows[index].Cells[3].Value = item.Tongtien;
            }
        }

        private void FormLichSuGiaoDich_Load(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<HoaDon> ListHoaDon = context.HoaDons.ToList();
            bindgrid(ListHoaDon);
        }
        
    }
}