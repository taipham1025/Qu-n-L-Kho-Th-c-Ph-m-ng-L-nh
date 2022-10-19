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
    public partial class FormThemLoaiTP : Form
    {
        public FormThemLoaiTP()
        {
            InitializeComponent();
        }
        private void BindLoaiTP(List<LoaiThucPham> ListLoaiTP)
        {
            dgvLoaiTP.Rows.Clear();
            foreach(var item in ListLoaiTP)
            {
                int index = dgvLoaiTP.Rows.Add();
                dgvLoaiTP.Rows[index].Cells[0].Value = item.Maloaithucpham;
                dgvLoaiTP.Rows[index].Cells[1].Value = item.Tenloaithucpham;
                dgvLoaiTP.Rows[index].Cells[2].Value = item.NhaPhanPhoi.Tennhaphanphoi;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<LoaiThucPham> ListLoaiTP = context.LoaiThucPhams.ToList();
            List<NhaPhanPhoi> ListNhaPP = context.NhaPhanPhois.ToList();
            LoaiThucPham tp = new LoaiThucPham()
            {
                Maloaithucpham = txtMaLoaiTP.Text,
                Tenloaithucpham = txtTenLoaiTP.Text,
                Manhaphanphoi = cmbNhaPP.SelectedValue.ToString()
            };
            context.LoaiThucPhams.Add(tp);
            context.SaveChanges();
            BindLoaiTP(ListLoaiTP);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            LoaiThucPham updtp = context.LoaiThucPhams.FirstOrDefault(p => p.Maloaithucpham == txtMaLoaiTP.Text);
            if(updtp != null)
            {
                updtp.Maloaithucpham = txtMaLoaiTP.Text;
                updtp.Tenloaithucpham = txtTenLoaiTP.Text;
                updtp.Manhaphanphoi = cmbNhaPP.SelectedValue.ToString();
                context.SaveChanges();
            }
            List<LoaiThucPham> ListLoaiTP = context.LoaiThucPhams.ToList();
            BindLoaiTP(ListLoaiTP);
        }
        private void FormThemLoaiTP_Load(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<LoaiThucPham> ListLoaiTP = context.LoaiThucPhams.ToList();
            List<NhaPhanPhoi> ListNhaPP = context.NhaPhanPhois.ToList();
            cmbNhaPP.DataSource = ListNhaPP;
            cmbNhaPP.DisplayMember = "Tennhaphanphoi";
            cmbNhaPP.ValueMember = "Manhaphanphoi";
            BindLoaiTP(ListLoaiTP);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLoaiTP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvLoaiTP.Rows[e.RowIndex];
                txtMaLoaiTP.Text = row.Cells[0].Value.ToString();
                txtTenLoaiTP.Text = row.Cells[1].Value.ToString();
                cmbNhaPP.Text = row.Cells[2].Value.ToString();           
            }
        }
    }
}
