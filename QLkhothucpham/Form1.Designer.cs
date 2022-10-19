
namespace QLkhothucpham
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLoạiThựcPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvThucpham = new System.Windows.Forms.DataGridView();
            this.colMaTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLoaiTP = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaThanh = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtTenTP = new System.Windows.Forms.TextBox();
            this.txtMaTP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaTP = new System.Windows.Forms.Button();
            this.btnSuaTP = new System.Windows.Forms.Button();
            this.btnThemTP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDCKH = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSoLuongM = new System.Windows.Forms.TextBox();
            this.txtTenTPM = new System.Windows.Forms.TextBox();
            this.txtMaTPM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbTKLoaiTP = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTKMaTP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.thêmNhàPhânPhốiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.xuấtThốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1662, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLoạiThựcPhẩmToolStripMenuItem,
            this.thêmNhàPhânPhốiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.chứcNăngToolStripMenuItem.Text = "chức năng";
            // 
            // thêmLoạiThựcPhẩmToolStripMenuItem
            // 
            this.thêmLoạiThựcPhẩmToolStripMenuItem.Name = "thêmLoạiThựcPhẩmToolStripMenuItem";
            this.thêmLoạiThựcPhẩmToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.thêmLoạiThựcPhẩmToolStripMenuItem.Text = "Thêm Loại Thực Phẩm";
            this.thêmLoạiThựcPhẩmToolStripMenuItem.Click += new System.EventHandler(this.thêmLoạiThựcPhẩmToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // xuấtThốngKêToolStripMenuItem
            // 
            this.xuấtThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoNgàyToolStripMenuItem});
            this.xuấtThốngKêToolStripMenuItem.Name = "xuấtThốngKêToolStripMenuItem";
            this.xuấtThốngKêToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.xuấtThốngKêToolStripMenuItem.Text = "Xuất thống kê";
            // 
            // theoNgàyToolStripMenuItem
            // 
            this.theoNgàyToolStripMenuItem.Name = "theoNgàyToolStripMenuItem";
            this.theoNgàyToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.theoNgàyToolStripMenuItem.Text = "Xuất Lịch Sử Giao Dịch";
            this.theoNgàyToolStripMenuItem.Click += new System.EventHandler(this.theoNgàyToolStripMenuItem_Click);
            // 
            // dgvThucpham
            // 
            this.dgvThucpham.AllowUserToAddRows = false;
            this.dgvThucpham.AllowUserToDeleteRows = false;
            this.dgvThucpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTP,
            this.colTenTP,
            this.colDonVi,
            this.colLoaiTP,
            this.colGia,
            this.colSoLuong});
            this.dgvThucpham.Location = new System.Drawing.Point(322, 138);
            this.dgvThucpham.Name = "dgvThucpham";
            this.dgvThucpham.ReadOnly = true;
            this.dgvThucpham.RowHeadersWidth = 51;
            this.dgvThucpham.RowTemplate.Height = 24;
            this.dgvThucpham.Size = new System.Drawing.Size(1196, 641);
            this.dgvThucpham.TabIndex = 1;
            this.dgvThucpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucpham_CellClick);
            // 
            // colMaTP
            // 
            this.colMaTP.HeaderText = "Mã Thực Phẩm";
            this.colMaTP.MinimumWidth = 6;
            this.colMaTP.Name = "colMaTP";
            this.colMaTP.ReadOnly = true;
            this.colMaTP.Width = 125;
            // 
            // colTenTP
            // 
            this.colTenTP.FillWeight = 300F;
            this.colTenTP.HeaderText = "Tên Thực Phẩm";
            this.colTenTP.MinimumWidth = 6;
            this.colTenTP.Name = "colTenTP";
            this.colTenTP.ReadOnly = true;
            this.colTenTP.Width = 250;
            // 
            // colDonVi
            // 
            this.colDonVi.FillWeight = 75F;
            this.colDonVi.HeaderText = "Đơn Vị";
            this.colDonVi.MinimumWidth = 6;
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.ReadOnly = true;
            this.colDonVi.Width = 125;
            // 
            // colLoaiTP
            // 
            this.colLoaiTP.HeaderText = "Loại Thực Phẩm";
            this.colLoaiTP.MinimumWidth = 6;
            this.colLoaiTP.Name = "colLoaiTP";
            this.colLoaiTP.ReadOnly = true;
            this.colLoaiTP.Width = 125;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá Thành";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            this.colGia.Width = 125;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FillWeight = 80F;
            this.colSoLuong.HeaderText = "Số Lượng Còn";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 105;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1381, 785);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 49);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLoaiTP);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtGiaThanh);
            this.groupBox1.Controls.Add(this.txtDonVi);
            this.groupBox1.Controls.Add(this.txtTenTP);
            this.groupBox1.Controls.Add(this.txtMaTP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 256);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cmbLoaiTP
            // 
            this.cmbLoaiTP.FormattingEnabled = true;
            this.cmbLoaiTP.Location = new System.Drawing.Point(145, 144);
            this.cmbLoaiTP.Name = "cmbLoaiTP";
            this.cmbLoaiTP.Size = new System.Drawing.Size(153, 24);
            this.cmbLoaiTP.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(145, 216);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(153, 22);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtGiaThanh
            // 
            this.txtGiaThanh.Location = new System.Drawing.Point(145, 180);
            this.txtGiaThanh.Name = "txtGiaThanh";
            this.txtGiaThanh.Size = new System.Drawing.Size(153, 22);
            this.txtGiaThanh.TabIndex = 1;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(145, 104);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(153, 22);
            this.txtDonVi.TabIndex = 1;
            // 
            // txtTenTP
            // 
            this.txtTenTP.Location = new System.Drawing.Point(145, 70);
            this.txtTenTP.Name = "txtTenTP";
            this.txtTenTP.Size = new System.Drawing.Size(153, 22);
            this.txtTenTP.TabIndex = 1;
            // 
            // txtMaTP
            // 
            this.txtMaTP.Location = new System.Drawing.Point(145, 35);
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Size = new System.Drawing.Size(153, 22);
            this.txtMaTP.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá Thành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại Thực Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn Vị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Thực Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Thực Phẩm";
            // 
            // btnXoaTP
            // 
            this.btnXoaTP.Location = new System.Drawing.Point(72, 445);
            this.btnXoaTP.Name = "btnXoaTP";
            this.btnXoaTP.Size = new System.Drawing.Size(175, 39);
            this.btnXoaTP.TabIndex = 0;
            this.btnXoaTP.Text = "Xóa Thực Phẩm";
            this.btnXoaTP.UseVisualStyleBackColor = true;
            this.btnXoaTP.Click += new System.EventHandler(this.btnXoaTP_Click);
            // 
            // btnSuaTP
            // 
            this.btnSuaTP.Location = new System.Drawing.Point(168, 400);
            this.btnSuaTP.Name = "btnSuaTP";
            this.btnSuaTP.Size = new System.Drawing.Size(142, 39);
            this.btnSuaTP.TabIndex = 0;
            this.btnSuaTP.Text = "Thay Đổi Thông Tin";
            this.btnSuaTP.UseVisualStyleBackColor = true;
            this.btnSuaTP.Click += new System.EventHandler(this.btnSuaTP_Click);
            // 
            // btnThemTP
            // 
            this.btnThemTP.Location = new System.Drawing.Point(10, 400);
            this.btnThemTP.Name = "btnThemTP";
            this.btnThemTP.Size = new System.Drawing.Size(152, 39);
            this.btnThemTP.TabIndex = 0;
            this.btnThemTP.Text = "Thêm Thực Phẩm";
            this.btnThemTP.UseVisualStyleBackColor = true;
            this.btnThemTP.Click += new System.EventHandler(this.btnThemTP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh Sách Thực Phẩm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(356, 22);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(187, 22);
            this.txtTimkiem.TabIndex = 5;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập tên";
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(1403, 93);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(115, 27);
            this.btnHienthi.TabIndex = 7;
            this.btnHienthi.Text = "Làm mới";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // btn
            // 
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn.Location = new System.Drawing.Point(1245, 785);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(130, 49);
            this.btn.TabIndex = 4;
            this.btn.Text = "Đăng Xuất";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDCKH);
            this.groupBox2.Controls.Add(this.txtSDTKH);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.txtSoLuongM);
            this.groupBox2.Controls.Add(this.txtTenTPM);
            this.groupBox2.Controls.Add(this.txtMaTPM);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lbSoLuong);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(12, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 203);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mua Hàng";
            // 
            // txtDCKH
            // 
            this.txtDCKH.Location = new System.Drawing.Point(145, 172);
            this.txtDCKH.Name = "txtDCKH";
            this.txtDCKH.Size = new System.Drawing.Size(153, 22);
            this.txtDCKH.TabIndex = 2;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(145, 141);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(153, 22);
            this.txtSDTKH.TabIndex = 2;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(145, 110);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(153, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtSoLuongM
            // 
            this.txtSoLuongM.Location = new System.Drawing.Point(145, 79);
            this.txtSoLuongM.Name = "txtSoLuongM";
            this.txtSoLuongM.Size = new System.Drawing.Size(90, 22);
            this.txtSoLuongM.TabIndex = 2;
            // 
            // txtTenTPM
            // 
            this.txtTenTPM.Location = new System.Drawing.Point(145, 49);
            this.txtTenTPM.Name = "txtTenTPM";
            this.txtTenTPM.Size = new System.Drawing.Size(153, 22);
            this.txtTenTPM.TabIndex = 2;
            // 
            // txtMaTPM
            // 
            this.txtMaTPM.Location = new System.Drawing.Point(145, 21);
            this.txtMaTPM.Name = "txtMaTPM";
            this.txtMaTPM.Size = new System.Drawing.Size(153, 22);
            this.txtMaTPM.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Địa Chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Số Điện Thoại";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(241, 82);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(44, 17);
            this.lbSoLuong.TabIndex = 0;
            this.lbSoLuong.Text = "         ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên Khách Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số Lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên Thực Phẩm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã Thực Phẩm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thành Tiền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(549, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Loại Thực Phẩm";
            // 
            // cmbTKLoaiTP
            // 
            this.cmbTKLoaiTP.FormattingEnabled = true;
            this.cmbTKLoaiTP.Location = new System.Drawing.Point(666, 20);
            this.cmbTKLoaiTP.Name = "cmbTKLoaiTP";
            this.cmbTKLoaiTP.Size = new System.Drawing.Size(109, 24);
            this.cmbTKLoaiTP.TabIndex = 10;
            this.cmbTKLoaiTP.SelectedValueChanged += new System.EventHandler(this.cmbTKLoaiTP_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mã Thực Phẩm";
            // 
            // txtTKMaTP
            // 
            this.txtTKMaTP.Location = new System.Drawing.Point(125, 22);
            this.txtTKMaTP.Name = "txtTKMaTP";
            this.txtTKMaTP.Size = new System.Drawing.Size(153, 22);
            this.txtTKMaTP.TabIndex = 1;
            this.txtTKMaTP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTKMaTP);
            this.groupBox3.Controls.Add(this.cmbTKLoaiTP);
            this.groupBox3.Controls.Add(this.txtTimkiem);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(614, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 57);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // thêmNhàPhânPhốiToolStripMenuItem
            // 
            this.thêmNhàPhânPhốiToolStripMenuItem.Name = "thêmNhàPhânPhốiToolStripMenuItem";
            this.thêmNhàPhânPhốiToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.thêmNhàPhânPhốiToolStripMenuItem.Text = "Thêm Nhà Phân Phối";
            this.thêmNhàPhânPhốiToolStripMenuItem.Click += new System.EventHandler(this.thêmNhàPhânPhốiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1003);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemTP);
            this.Controls.Add(this.btnSuaTP);
            this.Controls.Add(this.btnXoaTP);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvThucpham);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho Thực Phẩm Đông Lạnh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvThucpham;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaTP;
        private System.Windows.Forms.Button btnSuaTP;
        private System.Windows.Forms.Button btnThemTP;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.ToolStripMenuItem xuấtThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoNgàyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ComboBox cmbLoaiTP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaThanh;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtTenTP;
        private System.Windows.Forms.TextBox txtMaTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDCKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSoLuongM;
        private System.Windows.Forms.TextBox txtTenTPM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem thêmLoạiThựcPhẩmToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTKMaTP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTKLoaiTP;
        private System.Windows.Forms.TextBox txtMaTPM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhàPhânPhốiToolStripMenuItem;
    }
}

