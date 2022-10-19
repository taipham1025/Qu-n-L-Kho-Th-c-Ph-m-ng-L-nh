
namespace QLkhothucpham
{
    partial class FormThemNhaPhanPhoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemNhaPhanPhoi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvNhaPP = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNHaPP = new System.Windows.Forms.TextBox();
            this.txtTenNhaPP = new System.Windows.Forms.TextBox();
            this.txtDiaChiNPP = new System.Windows.Forms.TextBox();
            this.txtSTDNPP = new System.Windows.Forms.TextBox();
            this.colMaNhapp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaPP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(237, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhà Phân Phối";
            // 
            // dgvNhaPP
            // 
            this.dgvNhaPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhapp,
            this.colTenNhaPP,
            this.colDiaChi,
            this.colSDT});
            this.dgvNhaPP.Location = new System.Drawing.Point(10, 53);
            this.dgvNhaPP.Name = "dgvNhaPP";
            this.dgvNhaPP.RowHeadersWidth = 51;
            this.dgvNhaPP.RowTemplate.Height = 24;
            this.dgvNhaPP.Size = new System.Drawing.Size(583, 247);
            this.dgvNhaPP.TabIndex = 1;
            this.dgvNhaPP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaPP_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(391, 451);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 30);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(255, 451);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 30);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(255, 499);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 30);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(115, 451);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 30);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Nhà Phân Phối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Nhà Phân Phối";
            // 
            // txtMaNHaPP
            // 
            this.txtMaNHaPP.Location = new System.Drawing.Point(277, 318);
            this.txtMaNHaPP.Name = "txtMaNHaPP";
            this.txtMaNHaPP.Size = new System.Drawing.Size(190, 25);
            this.txtMaNHaPP.TabIndex = 18;
            // 
            // txtTenNhaPP
            // 
            this.txtTenNhaPP.Location = new System.Drawing.Point(277, 349);
            this.txtTenNhaPP.Name = "txtTenNhaPP";
            this.txtTenNhaPP.Size = new System.Drawing.Size(190, 25);
            this.txtTenNhaPP.TabIndex = 18;
            // 
            // txtDiaChiNPP
            // 
            this.txtDiaChiNPP.Location = new System.Drawing.Point(277, 380);
            this.txtDiaChiNPP.Name = "txtDiaChiNPP";
            this.txtDiaChiNPP.Size = new System.Drawing.Size(190, 25);
            this.txtDiaChiNPP.TabIndex = 18;
            // 
            // txtSTDNPP
            // 
            this.txtSTDNPP.Location = new System.Drawing.Point(277, 411);
            this.txtSTDNPP.Name = "txtSTDNPP";
            this.txtSTDNPP.Size = new System.Drawing.Size(190, 25);
            this.txtSTDNPP.TabIndex = 18;
            // 
            // colMaNhapp
            // 
            this.colMaNhapp.HeaderText = "Mã Nhà Phân Phối";
            this.colMaNhapp.MinimumWidth = 6;
            this.colMaNhapp.Name = "colMaNhapp";
            this.colMaNhapp.Width = 80;
            // 
            // colTenNhaPP
            // 
            this.colTenNhaPP.HeaderText = "Tên Nhà Phân Phối";
            this.colTenNhaPP.MinimumWidth = 6;
            this.colTenNhaPP.Name = "colTenNhaPP";
            this.colTenNhaPP.Width = 125;
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 125;
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.Width = 125;
            // 
            // FormThemNhaPhanPhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 547);
            this.Controls.Add(this.txtSTDNPP);
            this.Controls.Add(this.txtDiaChiNPP);
            this.Controls.Add(this.txtTenNhaPP);
            this.Controls.Add(this.txtMaNHaPP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNhaPP);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormThemNhaPhanPhoi.IconOptions.LargeImage")));
            this.Name = "FormThemNhaPhanPhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemNhaPhanPhoi";
            this.Load += new System.EventHandler(this.FormThemNhaPhanPhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaPP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgvNhaPP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNHaPP;
        private System.Windows.Forms.TextBox txtTenNhaPP;
        private System.Windows.Forms.TextBox txtDiaChiNPP;
        private System.Windows.Forms.TextBox txtSTDNPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhapp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhaPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
    }
}