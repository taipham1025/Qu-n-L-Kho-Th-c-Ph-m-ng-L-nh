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
    public partial class FormThemNhaPhanPhoi : DevExpress.XtraEditors.XtraForm
    {
        public FormThemNhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThemNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<NhaPhanPhoi> ListNhaPP = context.NhaPhanPhois.ToList();
            bindgrid(ListNhaPP);
        }
        private void bindgrid(List<NhaPhanPhoi> ListNhaPP)
        {
            foreach (var item in ListNhaPP)
            {
                int index = dgvNhaPP.Rows.Add();
                dgvNhaPP.Rows[index].Cells[0].Value = item.Manhaphanphoi;
                dgvNhaPP.Rows[index].Cells[1].Value = item.Tennhaphanphoi;
                dgvNhaPP.Rows[index].Cells[2].Value = item.Diachi;
                dgvNhaPP.Rows[index].Cells[3].Value = item.SoDT;
            }
        }
        private void dgvNhaPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvNhaPP.Rows[e.RowIndex];
                txtMaNHaPP.Text = row.Cells[0].Value.ToString();
                txtTenNhaPP.Text = row.Cells[1].Value.ToString();
                txtDiaChiNPP.Text = row.Cells[2].Value.ToString();
                txtSTDNPP.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<NhaPhanPhoi> ListNhaPP = context.NhaPhanPhois.ToList();
            NhaPhanPhoi npp = new NhaPhanPhoi()
            {
                Manhaphanphoi = txtMaNHaPP.Text,
                Tennhaphanphoi = txtTenNhaPP.Text,
                Diachi = txtDiaChiNPP.Text,
                SoDT = txtSTDNPP.Text
            };
            context.NhaPhanPhois.Add(npp);
            context.SaveChanges();
            bindgrid(ListNhaPP);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<NhaPhanPhoi> ListNhaPP = context.NhaPhanPhois.ToList();
            NhaPhanPhoi upd = context.NhaPhanPhois.FirstOrDefault(p => p.Manhaphanphoi == txtMaNHaPP.Text);
            if(upd != null)
            {
                upd.Manhaphanphoi = txtMaNHaPP.Text;
                upd.Tennhaphanphoi = txtTenNhaPP.Text;
                upd.Diachi = txtTenNhaPP.Text;
                upd.SoDT = txtSTDNPP.Text;
                context.SaveChanges();
            }
            bindgrid(ListNhaPP);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<NhaPhanPhoi> ListNhaPP = context.NhaPhanPhois.ToList();
            NhaPhanPhoi dl = context.NhaPhanPhois.FirstOrDefault(p => p.Manhaphanphoi == txtMaNHaPP.Text);
            if (dl != null)
            {
                context.NhaPhanPhois.Remove(dl);
                context.SaveChanges();
            }
            bindgrid(ListNhaPP);
        }
    }
}