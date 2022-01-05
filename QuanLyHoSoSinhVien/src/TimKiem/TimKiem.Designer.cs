namespace QuanLyHoSoSinhVien.src.TimKiem
{
    partial class TimKiem
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
            this.timkiem_btn = new System.Windows.Forms.Button();
            this.dulieu_txt = new System.Windows.Forms.TextBox();
            this.thongtin_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thoat_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.chitiet_btn = new System.Windows.Forms.Button();
            this.danhsach_dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.danhsach_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // timkiem_btn
            // 
            this.timkiem_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.timkiem_btn.Location = new System.Drawing.Point(760, 104);
            this.timkiem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.timkiem_btn.Name = "timkiem_btn";
            this.timkiem_btn.Size = new System.Drawing.Size(144, 66);
            this.timkiem_btn.TabIndex = 15;
            this.timkiem_btn.Text = "Load";
            this.timkiem_btn.UseVisualStyleBackColor = false;
            // 
            // dulieu_txt
            // 
            this.dulieu_txt.Location = new System.Drawing.Point(466, 159);
            this.dulieu_txt.Margin = new System.Windows.Forms.Padding(4);
            this.dulieu_txt.Name = "dulieu_txt";
            this.dulieu_txt.Size = new System.Drawing.Size(257, 30);
            this.dulieu_txt.TabIndex = 19;
            // 
            // thongtin_cb
            // 
            this.thongtin_cb.FormattingEnabled = true;
            this.thongtin_cb.Items.AddRange(new object[] {
            "Mã Sinh Viên",
            "Tên Sinh Viên",
            "Ngày Sinh",
            "Giới Tính",
            "Quê Quán",
            "Quốc Tịch",
            "Lớp",
            "Trình Độ",
            "Thương Binh Liệt Sĩ",
            "Hộ Nghèo",
            "Tôn Giáo",
            "Dân Tộc",
            "Chức Vụ",
            "Số CMTND"});
            this.thongtin_cb.Location = new System.Drawing.Point(466, 85);
            this.thongtin_cb.Margin = new System.Windows.Forms.Padding(4);
            this.thongtin_cb.Name = "thongtin_cb";
            this.thongtin_cb.Size = new System.Drawing.Size(257, 30);
            this.thongtin_cb.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dữ Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thông Tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(458, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Danh Sách Sinh Viên";
            // 
            // thoat_btn
            // 
            this.thoat_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.thoat_btn.Location = new System.Drawing.Point(1105, 656);
            this.thoat_btn.Margin = new System.Windows.Forms.Padding(4);
            this.thoat_btn.Name = "thoat_btn";
            this.thoat_btn.Size = new System.Drawing.Size(144, 66);
            this.thoat_btn.TabIndex = 20;
            this.thoat_btn.Text = "Thoát";
            this.thoat_btn.UseVisualStyleBackColor = false;
            this.thoat_btn.Click += new System.EventHandler(this.thoat_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.back_btn.Location = new System.Drawing.Point(953, 656);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(144, 66);
            this.back_btn.TabIndex = 21;
            this.back_btn.Text = "Quay Lại";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // xoa_btn
            // 
            this.xoa_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.xoa_btn.Location = new System.Drawing.Point(760, 656);
            this.xoa_btn.Margin = new System.Windows.Forms.Padding(4);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(144, 66);
            this.xoa_btn.TabIndex = 22;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = false;
            // 
            // chitiet_btn
            // 
            this.chitiet_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.chitiet_btn.Location = new System.Drawing.Point(560, 656);
            this.chitiet_btn.Margin = new System.Windows.Forms.Padding(4);
            this.chitiet_btn.Name = "chitiet_btn";
            this.chitiet_btn.Size = new System.Drawing.Size(144, 66);
            this.chitiet_btn.TabIndex = 24;
            this.chitiet_btn.Text = "Chi Tiết";
            this.chitiet_btn.UseVisualStyleBackColor = false;
            // 
            // danhsach_dg
            // 
            this.danhsach_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsach_dg.Location = new System.Drawing.Point(13, 200);
            this.danhsach_dg.Name = "danhsach_dg";
            this.danhsach_dg.RowTemplate.Height = 24;
            this.danhsach_dg.Size = new System.Drawing.Size(1237, 420);
            this.danhsach_dg.TabIndex = 25;
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1262, 735);
            this.Controls.Add(this.danhsach_dg);
            this.Controls.Add(this.chitiet_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.thoat_btn);
            this.Controls.Add(this.timkiem_btn);
            this.Controls.Add(this.dulieu_txt);
            this.Controls.Add(this.thongtin_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Peru;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiem";
            ((System.ComponentModel.ISupportInitialize)(this.danhsach_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timkiem_btn;
        private System.Windows.Forms.TextBox dulieu_txt;
        private System.Windows.Forms.ComboBox thongtin_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoat_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.Button chitiet_btn;
        private System.Windows.Forms.DataGridView danhsach_dg;
    }
}