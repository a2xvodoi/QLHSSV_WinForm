namespace QuanLyHoSoSinhVien.src.QuanLySinhVien
{
    partial class DanhSachSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.danhsach_dg = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Que = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLopHoc = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.chitiet_btn = new System.Windows.Forms.Button();
            this.them_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.thoat_btn = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.danhsach_dg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.Location = new System.Drawing.Point(370, 102);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(225, 27);
            this.cbKhoaHoc.TabIndex = 38;
            this.cbKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbKhoaHoc_SelectedIndexChanged);
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(666, 102);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(34, 19);
            this.lbLop.TabIndex = 37;
            this.lbLop.Text = "Lớp";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(222, 109);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(69, 19);
            this.lbKhoa.TabIndex = 36;
            this.lbKhoa.Text = "Khoá học";
            // 
            // danhsach_dg
            // 
            this.danhsach_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsach_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.GioiTinh,
            this.NgaySinh,
            this.Que,
            this.QuocTich,
            this.DienThoai});
            this.danhsach_dg.Location = new System.Drawing.Point(222, 140);
            this.danhsach_dg.Name = "danhsach_dg";
            this.danhsach_dg.RowTemplate.Height = 24;
            this.danhsach_dg.Size = new System.Drawing.Size(1032, 583);
            this.danhsach_dg.TabIndex = 29;
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
            this.TenSV.HeaderText = "Tên sinh viên";
            this.TenSV.Name = "TenSV";
            this.TenSV.Width = 200;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.FalseValue = "";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.TrueValue = "";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.NgaySinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NgaySinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Que
            // 
            this.Que.DataPropertyName = "Que";
            this.Que.HeaderText = "Quê quán";
            this.Que.Name = "Que";
            this.Que.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Que.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Que.Width = 300;
            // 
            // QuocTich
            // 
            this.QuocTich.DataPropertyName = "QuocTich";
            this.QuocTich.HeaderText = "Quốc tịch";
            this.QuocTich.Name = "QuocTich";
            this.QuocTich.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuocTich.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DienThoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Danh Sách Sinh Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chitiet_btn);
            this.panel1.Controls.Add(this.them_btn);
            this.panel1.Controls.Add(this.xoa_btn);
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.thoat_btn);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 711);
            this.panel1.TabIndex = 27;
            // 
            // cbLopHoc
            // 
            this.cbLopHoc.FormattingEnabled = true;
            this.cbLopHoc.Location = new System.Drawing.Point(816, 102);
            this.cbLopHoc.Name = "cbLopHoc";
            this.cbLopHoc.Size = new System.Drawing.Size(225, 27);
            this.cbLopHoc.TabIndex = 39;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLoc.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Search;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(1057, 102);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(111, 27);
            this.btnLoc.TabIndex = 30;
            this.btnLoc.Text = "Tìm kiếm";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // chitiet_btn
            // 
            this.chitiet_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.chitiet_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Edit;
            this.chitiet_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chitiet_btn.Location = new System.Drawing.Point(16, 82);
            this.chitiet_btn.Name = "chitiet_btn";
            this.chitiet_btn.Size = new System.Drawing.Size(170, 62);
            this.chitiet_btn.TabIndex = 31;
            this.chitiet_btn.Text = "Chi Tiết";
            this.chitiet_btn.UseVisualStyleBackColor = false;
            this.chitiet_btn.Click += new System.EventHandler(this.chitiet_btn_Click);
            // 
            // them_btn
            // 
            this.them_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.them_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Create;
            this.them_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_btn.Location = new System.Drawing.Point(16, 223);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(170, 62);
            this.them_btn.TabIndex = 32;
            this.them_btn.Text = "Thêm";
            this.them_btn.UseVisualStyleBackColor = false;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // xoa_btn
            // 
            this.xoa_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.xoa_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Trash;
            this.xoa_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_btn.Location = new System.Drawing.Point(16, 364);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(170, 62);
            this.xoa_btn.TabIndex = 33;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = false;
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.back_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Delete;
            this.back_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_btn.Location = new System.Drawing.Point(16, 505);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(170, 62);
            this.back_btn.TabIndex = 34;
            this.back_btn.Text = "Quay Lại";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // thoat_btn
            // 
            this.thoat_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.thoat_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Exit;
            this.thoat_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoat_btn.Location = new System.Drawing.Point(16, 646);
            this.thoat_btn.Name = "thoat_btn";
            this.thoat_btn.Size = new System.Drawing.Size(170, 62);
            this.thoat_btn.TabIndex = 35;
            this.thoat_btn.Text = "Thoát";
            this.thoat_btn.UseVisualStyleBackColor = false;
            this.thoat_btn.Click += new System.EventHandler(this.thoat_btn_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(222, 105);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(116, 19);
            this.lbSearch.TabIndex = 40;
            this.lbSearch.Text = "Từ khoá tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(370, 102);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(438, 26);
            this.txtSearch.TabIndex = 41;
            // 
            // DanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1262, 735);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.cbLopHoc);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cbKhoaHoc);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.lbKhoa);
            this.Controls.Add(this.danhsach_dg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Peru;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.DanhSachSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhsach_dg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Button thoat_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.Button chitiet_btn;
        private System.Windows.Forms.DataGridView danhsach_dg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Que;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLopHoc;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}