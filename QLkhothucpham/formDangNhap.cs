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
    public partial class formDangNhap : Form
    {
        string taikhoan = "admin";
        string matkhau = "123456";
        public formDangNhap()
        {
            InitializeComponent();
        }
        private void BntHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == taikhoan && txtMatKhau.Text == matkhau)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sai Tài Khoản, Mật Khẩu!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtTaiKhoan.Text == taikhoan && txtMatKhau.Text == matkhau)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Sai Tài Khoản, Mật Khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}
