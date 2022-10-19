
namespace QLkhothucpham
{
    partial class FormThemLoaiTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemLoaiTP));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLoaiTP = new System.Windows.Forms.TextBox();
            this.txtTenLoaiTP = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvLoaiTP = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbNhaPP = new System.Windows.Forms.ComboBox();
            this.colMaLoaiTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Thực Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Loại Thực Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Loại Thực Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhà Phân Phối";
            // 
            // txtMaLoaiTP
            // 
            this.txtMaLoaiTP.Location = new System.Drawing.Point(286, 337);
            this.txtMaLoaiTP.Name = "txtMaLoaiTP";
            this.txtMaLoaiTP.Size = new System.Drawing.Size(197, 22);
            this.txtMaLoaiTP.TabIndex = 2;
            // 
            // txtTenLoaiTP
            // 
            this.txtTenLoaiTP.Location = new System.Drawing.Point(286, 365);
            this.txtTenLoaiTP.Name = "txtTenLoaiTP";
            this.txtTenLoaiTP.Size = new System.Drawing.Size(197, 22);
            this.txtTenLoaiTP.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(109, 447);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Thêm";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(249, 495);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 30);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvLoaiTP
            // 
            this.dgvLoaiTP.AllowUserToAddRows = false;
            this.dgvLoaiTP.AllowUserToDeleteRows = false;
            this.dgvLoaiTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoaiTP,
            this.colTenLoaiTP,
            this.colNhaPP});
            this.dgvLoaiTP.Location = new System.Drawing.Point(13, 68);
            this.dgvLoaiTP.Name = "dgvLoaiTP";
            this.dgvLoaiTP.ReadOnly = true;
            this.dgvLoaiTP.RowHeadersWidth = 51;
            this.dgvLoaiTP.RowTemplate.Height = 24;
            this.dgvLoaiTP.Size = new System.Drawing.Size(572, 254);
            this.dgvLoaiTP.TabIndex = 4;
            this.dgvLoaiTP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiTP_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbNhaPP
            // 
            this.cmbNhaPP.FormattingEnabled = true;
            this.cmbNhaPP.Location = new System.Drawing.Point(286, 394);
            this.cmbNhaPP.Name = "cmbNhaPP";
            this.cmbNhaPP.Size = new System.Drawing.Size(196, 24);
            this.cmbNhaPP.TabIndex = 6;
            // 
            // colMaLoaiTP
            // 
            this.colMaLoaiTP.HeaderText = "Mã Loại Thực Phẩm";
            this.colMaLoaiTP.MinimumWidth = 6;
            this.colMaLoaiTP.Name = "colMaLoaiTP";
            this.colMaLoaiTP.ReadOnly = true;
            // 
            // colTenLoaiTP
            // 
            this.colTenLoaiTP.HeaderText = "Tên Loại Thực Phẩm";
            this.colTenLoaiTP.MinimumWidth = 6;
            this.colTenLoaiTP.Name = "colTenLoaiTP";
            this.colTenLoaiTP.ReadOnly = true;
            this.colTenLoaiTP.Width = 125;
            // 
            // colNhaPP
            // 
            this.colNhaPP.HeaderText = "Nhà Phân Phối";
            this.colNhaPP.MinimumWidth = 6;
            this.colNhaPP.Name = "colNhaPP";
            this.colNhaPP.ReadOnly = true;
            this.colNhaPP.Width = 150;
            // 
            // FormThemLoaiTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 541);
            this.Controls.Add(this.cmbNhaPP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLoaiTP);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenLoaiTP);
            this.Controls.Add(this.txtMaLoaiTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThemLoaiTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Thực Phẩm";
            this.Load += new System.EventHandler(this.FormThemLoaiTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLoaiTP;
        private System.Windows.Forms.TextBox txtTenLoaiTP;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvLoaiTP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbNhaPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaPP;
    }
}