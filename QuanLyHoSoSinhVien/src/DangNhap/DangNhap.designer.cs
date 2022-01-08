namespace QuanLyHoSoSinhVien.src.DangNhap
{
    partial class DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tk_txt = new System.Windows.Forms.TextBox();
            this.mk_txt = new System.Windows.Forms.TextBox();
            this.remember = new System.Windows.Forms.CheckBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.dangnhap_btn = new System.Windows.Forms.Button();
            this.thoat_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(35, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(35, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // tk_txt
            // 
            this.tk_txt.Location = new System.Drawing.Point(119, 171);
            this.tk_txt.Name = "tk_txt";
            this.tk_txt.Size = new System.Drawing.Size(187, 23);
            this.tk_txt.TabIndex = 2;
            // 
            // mk_txt
            // 
            this.mk_txt.Location = new System.Drawing.Point(119, 214);
            this.mk_txt.Name = "mk_txt";
            this.mk_txt.Size = new System.Drawing.Size(187, 23);
            this.mk_txt.TabIndex = 3;
            this.mk_txt.UseSystemPasswordChar = true;
            // 
            // remember
            // 
            this.remember.AutoSize = true;
            this.remember.BackColor = System.Drawing.Color.Transparent;
            this.remember.Location = new System.Drawing.Point(190, 247);
            this.remember.Name = "remember";
            this.remember.Size = new System.Drawing.Size(106, 20);
            this.remember.TabIndex = 4;
            this.remember.Text = "Nhớ tài khoản";
            this.remember.UseVisualStyleBackColor = false;
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.BackColor = System.Drawing.Color.Transparent;
            this.showpass.Location = new System.Drawing.Point(190, 276);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(110, 20);
            this.showpass.TabIndex = 5;
            this.showpass.Text = "Hiện mật Khẩu";
            this.showpass.UseVisualStyleBackColor = false;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // dangnhap_btn
            // 
            this.dangnhap_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.admin1;
            this.dangnhap_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dangnhap_btn.Location = new System.Drawing.Point(39, 305);
            this.dangnhap_btn.Name = "dangnhap_btn";
            this.dangnhap_btn.Size = new System.Drawing.Size(144, 58);
            this.dangnhap_btn.TabIndex = 6;
            this.dangnhap_btn.Text = "Đăng Nhập";
            this.dangnhap_btn.UseVisualStyleBackColor = true;
            this.dangnhap_btn.Click += new System.EventHandler(this.dangnhap_btn_Click);
            // 
            // thoat_btn
            // 
            this.thoat_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Exit;
            this.thoat_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoat_btn.Location = new System.Drawing.Point(215, 305);
            this.thoat_btn.Name = "thoat_btn";
            this.thoat_btn.Size = new System.Drawing.Size(147, 58);
            this.thoat_btn.TabIndex = 7;
            this.thoat_btn.Text = "Thoát";
            this.thoat_btn.UseVisualStyleBackColor = true;
            this.thoat_btn.Click += new System.EventHandler(this.thoat_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyHoSoSinhVien.Properties.Resources.admin2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 153);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AcceptButton = this.dangnhap_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLyHoSoSinhVien.Properties.Resources.bg_admin;
            this.ClientSize = new System.Drawing.Size(402, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.thoat_btn);
            this.Controls.Add(this.dangnhap_btn);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.remember);
            this.Controls.Add(this.mk_txt);
            this.Controls.Add(this.tk_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tk_txt;
        private System.Windows.Forms.TextBox mk_txt;
        private System.Windows.Forms.CheckBox remember;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Button dangnhap_btn;
        private System.Windows.Forms.Button thoat_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}