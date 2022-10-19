using QLkhothucpham.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLkhothucpham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            formDangNhap formDangNhap = new formDangNhap();
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
                formDangNhap.Show();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( r == DialogResult.Yes)
            this.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {           
            Model1 context = new Model1();
            List<ThucPham> ListThucPham = context.ThucPhams.ToList();
            List<LoaiThucPham> ListLoaiTP = context.LoaiThucPhams.ToList();
            List<LoaiThucPham> ListLoaiTP2 = context.LoaiThucPhams.ToList();
            BindcmbTK(ListLoaiTP2);
            Bindcmb(ListLoaiTP);
            cmbLoaiTP.Text = "";
            cmbTKLoaiTP.Text = "";
           // BindcmbTK(ListLoaiTP);
            BindGrid(ListThucPham);
        }
        private void Bindcmb(List<LoaiThucPham> ListLoaiTP)
        {
            cmbLoaiTP.DataSource = ListLoaiTP;
            cmbLoaiTP.DisplayMember = "Tenloaithucpham";
            cmbLoaiTP.ValueMember = "Maloaithucpham";
        }
        private void BindcmbTK(List<LoaiThucPham> ListLoaiTP)
        {
            cmbTKLoaiTP.DataSource = ListLoaiTP;
            cmbTKLoaiTP.DisplayMember = "Tenloaithucpham";
            cmbTKLoaiTP.ValueMember = "Maloaithucpham";
        }
        private void BindGrid(List<ThucPham> ListThucPham)
        {
            dgvThucpham.Rows.Clear();
            foreach (var item in ListThucPham)
            {
                int index = dgvThucpham.Rows.Add();
                dgvThucpham.Rows[index].Cells[0].Value = item.Mathucpham;
                dgvThucpham.Rows[index].Cells[1].Value = item.Tenthucpham;
                dgvThucpham.Rows[index].Cells[2].Value = item.Tendonvi;
                dgvThucpham.Rows[index].Cells[3].Value = item.LoaiThucPham.Tenloaithucpham;
                dgvThucpham.Rows[index].Cells[4].Value = item.Giathanh;
                dgvThucpham.Rows[index].Cells[5].Value = item.Soluong;
            }
        }
        

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<ThucPham> ListThucPham = context.ThucPhams.ToList();
            List<ThucPham> ListTimKiem = ListThucPham.Where(p => p.Tenthucpham.ToLower().Contains(txtTimkiem.Text.ToLower())).ToList();
            BindGrid(ListTimKiem); 
        }
        private void btnHienthi_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<ThucPham> ListThucPham = context.ThucPhams.ToList();
            List<LoaiThucPham> ListLoaiTP = context.LoaiThucPhams.ToList();
            BindGrid(ListThucPham);
            Bindcmb(ListLoaiTP);
            txtMaTP.Text = "";
            txtMaTPM.Text = "";
            txtTenTP.Text = "";
            txtTenTPM.Text = "";
            txtDonVi.Text = "";
            cmbLoaiTP.Text = "";
            txtGiaThanh.Text = "";
            txtSoLuong.Text = "";
            lbSoLuong.Text = "";
            txtTenKH.Text = "";
            txtSoLuongM.Text = "";
            txtDCKH.Text = "";
            txtSDTKH.Text = "";
        }

        private void btnThemTP_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            ThucPham t = new ThucPham()
            {
                Mathucpham = txtMaTP.Text,
                Tenthucpham = txtTenTP.Text,
                Tendonvi = txtDonVi.Text,
                Maloaithucpham = cmbLoaiTP.SelectedValue.ToString(),
                Giathanh = float.Parse(txtGiaThanh.Text),
                Soluong = int.Parse(txtSoLuong.Text)
            };
            context.ThucPhams.Add(t);
            context.SaveChanges();
            List<ThucPham> ListThucPham = context.ThucPhams.ToList();
            BindGrid(ListThucPham);
        }
        private void btnSuaTP_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            ThucPham update = context.ThucPhams.FirstOrDefault(p => p.Mathucpham == txtMaTP.Text);
            if(update != null)
            {
                update.Tenthucpham = txtTenTP.Text;
                update.Tendonvi = txtDonVi.Text;
                update.Maloaithucpham = cmbLoaiTP.SelectedValue.ToString();
                update.Giathanh = float.Parse(txtGiaThanh.Text);
                update.Soluong = int.Parse(txtSoLuong.Text);
                context.SaveChanges();
            }
            List<ThucPham> ListThucPham = context.ThucPhams.ToList();
            BindGrid(ListThucPham);
        }
        private void btnXoaTP_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            ThucPham delete = context.ThucPhams.FirstOrDefault(p => p.Mathucpham == txtMaTP.Text);
            if(delete != null)
            {
                context.ThucPhams.Remove(delete);
                context.SaveChanges();
            }
            List<ThucPham> ListThucPham = context.ThucPhams.ToList();
            BindGrid(ListThucPham);
        }
        private void dgvThucpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if(dgvThucpham.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvThucpham.CurrentRow.Selected = true;
                txtMaTP.Text = dgvThucpham.Rows[e.RowIndex].Cells["colMaTP"].FormattedValue.ToString();
                txtTenTP.Text = dgvThucpham.Rows[e.RowIndex].Cells["colTenTP"].FormattedValue.ToString();
                txtTenTPM.Text = dgvThucpham.Rows[e.RowIndex].Cells["colTenTP"].FormattedValue.ToString();
                txtDonVi.Text = dgvThucpham.Rows[e.RowIndex].Cells["colDonVi"].FormattedValue.ToString();
                cmbLoaiTP.Text = dgvThucpham.Rows[e.RowIndex].Cells["colLoaiTP"].FormattedValue.ToString();
                txtGiaThanh.Text = dgvThucpham.Rows[e.RowIndex].Cells["colGia"].FormattedValue.ToString();
                txtSoLuong.Text = dgvThucpham.Rows[e.RowIndex].Cells["colSoLuong"].FormattedValue.ToString();
                lbSoLuong.Text = dgvThucpham.Rows[e.RowIndex].Cells["colDonVi"].FormattedValue.ToString();
            }*/
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvThucpham.Rows[e.RowIndex];
                txtMaTP.Text = row.Cells[0].Value.ToString();
                txtMaTPM.Text = row.Cells[0].Value.ToString();
                txtTenTP.Text = row.Cells[1].Value.ToString();
                txtTenTPM.Text = row.Cells[1].Value.ToString();
                txtDonVi.Text = row.Cells[2].Value.ToString();
                cmbLoaiTP.Text = row.Cells[3].Value.ToString();
                txtGiaThanh.Text = row.Cells[4].Value.ToString();
                txtSoLuong.Text = row.Cells[5].Value.ToString();
                lbSoLuong.Text = row.Cells[2].Value.ToString();
            }
        }

        private void thêmLoạiThựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemLoaiTP fm = new FormThemLoaiTP();
            fm.Show();
        }

        private void cmbTKLoaiTP_TextChanged(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<ThucPham> ListThucPham = context.ThucPhams.ToList();
            List<ThucPham> ListTimKiem = ListThucPham.Where(p => p.LoaiThucPham.Tenloaithucpham.ToLower().Contains(cmbTKLoaiTP.Text.ToLower())).ToList();
            BindGrid(ListTimKiem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<ThucPham> ListThucPham = context.ThucPhams.ToList();
            List<ThucPham> ListTimKiem = ListThucPham.Where(p => p.Mathucpham.ToLower().Contains(txtTKMaTP.Text.ToLower())).ToList();
            BindGrid(ListTimKiem);
        }
        public static string MaTPM = "";
        public static string TenTPM = "";
        public static string SoLuongM = "";
        public static string TenKH = "";
        public static string SDTKH = "";
        public static string DiaChiKH = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaTPM.Text == "" || txtTenTPM.Text == "" || txtSoLuongM.Text == "" || txtTenKH.Text == "" || txtSDTKH.Text == "" || txtDCKH.Text == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MaTPM = txtMaTPM.Text;
                TenKH = txtTenKH.Text;
                TenTPM = txtTenTPM.Text;
                SoLuongM = txtSoLuongM.Text;
                SDTKH = txtSDTKH.Text;
                DiaChiKH = txtDCKH.Text;
                FormThanhTien fm = new FormThanhTien();
                fm.Show();
            }
        }

        private void thêmNhàPhânPhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemNhaPhanPhoi fm = new FormThemNhaPhanPhoi();
            fm.Show();
        }

        private void theoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLichSuGiaoDich fm = new FormLichSuGiaoDich();
            fm.Show();
        }
    }
}


