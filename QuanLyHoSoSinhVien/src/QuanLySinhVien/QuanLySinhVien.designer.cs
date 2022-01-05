namespace QuanLyHoSoSinhVien.src.QuanLySinhVien
{
    partial class QuanLySinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySinhVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.danhsachtong_dg = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Que = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.thoat_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.trvKhoa = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachtong_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.trvKhoa);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 580);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // danhsachtong_dg
            // 
            this.danhsachtong_dg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.danhsachtong_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachtong_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.NgaySinh,
            this.GioiTinh,
            this.Que,
            this.QuocTich,
            this.DienThoai});
            this.danhsachtong_dg.Location = new System.Drawing.Point(218, 114);
            this.danhsachtong_dg.Margin = new System.Windows.Forms.Padding(2);
            this.danhsachtong_dg.Name = "danhsachtong_dg";
            this.danhsachtong_dg.RowTemplate.Height = 24;
            this.danhsachtong_dg.Size = new System.Drawing.Size(713, 393);
            this.danhsachtong_dg.TabIndex = 1;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.Name = "MaSV";
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Họ tên";
            this.TenSV.Name = "TenSV";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.NgaySinh.DefaultCellStyle = dataGridViewCellStyle6;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.FalseValue = "Nữ";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinh.TrueValue = "Nam";
            // 
            // Que
            // 
            this.Que.DataPropertyName = "Que";
            this.Que.HeaderText = "Quê quán";
            this.Que.Name = "Que";
            // 
            // QuocTich
            // 
            this.QuocTich.DataPropertyName = "QuocTich";
            this.QuocTich.HeaderText = "Quốc tịch";
            this.QuocTich.Name = "QuocTich";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(423, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // thoat_btn
            // 
            this.thoat_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.thoat_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thoat_btn.Location = new System.Drawing.Point(808, 526);
            this.thoat_btn.Margin = new System.Windows.Forms.Padding(2);
            this.thoat_btn.Name = "thoat_btn";
            this.thoat_btn.Size = new System.Drawing.Size(112, 45);
            this.thoat_btn.TabIndex = 6;
            this.thoat_btn.Text = "Thoát";
            this.thoat_btn.UseVisualStyleBackColor = false;
            this.thoat_btn.Click += new System.EventHandler(this.thoat_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.back_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(692, 526);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(112, 45);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "Quay Lại";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // trvKhoa
            // 
            this.trvKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.trvKhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvKhoa.ForeColor = System.Drawing.Color.White;
            this.trvKhoa.Location = new System.Drawing.Point(15, 114);
            this.trvKhoa.Name = "trvKhoa";
            this.trvKhoa.Size = new System.Drawing.Size(185, 393);
            this.trvKhoa.TabIndex = 8;
            this.trvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvKhoa_AfterSelect);
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(929, 580);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.thoat_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.danhsachtong_dg);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachtong_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView danhsachtong_dg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoat_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Que;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.TreeView trvKhoa;
    }
}