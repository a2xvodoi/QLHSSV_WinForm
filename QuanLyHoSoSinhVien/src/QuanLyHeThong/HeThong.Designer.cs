namespace QuanLyHoSoSinhVien.src.QuanLyHeThong
{
    partial class HeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong));
            this.taottk_btn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.xoatk_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // taottk_btn
            // 
            this.taottk_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Users;
            this.taottk_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taottk_btn.Location = new System.Drawing.Point(12, 203);
            this.taottk_btn.Name = "taottk_btn";
            this.taottk_btn.Size = new System.Drawing.Size(120, 56);
            this.taottk_btn.TabIndex = 1;
            this.taottk_btn.Text = "Tạo tài khoản";
            this.taottk_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taottk_btn.UseVisualStyleBackColor = true;
            this.taottk_btn.Click += new System.EventHandler(this.taottk_btn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Delete;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(290, 203);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 56);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // xoatk_btn
            // 
            this.xoatk_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Trash;
            this.xoatk_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoatk_btn.Location = new System.Drawing.Point(151, 203);
            this.xoatk_btn.Name = "xoatk_btn";
            this.xoatk_btn.Size = new System.Drawing.Size(120, 56);
            this.xoatk_btn.TabIndex = 2;
            this.xoatk_btn.Text = "Xóa tài khoản";
            this.xoatk_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xoatk_btn.UseVisualStyleBackColor = true;
            this.xoatk_btn.Click += new System.EventHandler(this.xoatk_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HeThong
            // 
            this.AcceptButton = this.taottk_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(388, 289);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.xoatk_btn);
            this.Controls.Add(this.taottk_btn);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hệ thống";
            this.Load += new System.EventHandler(this.HeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button taottk_btn;
        private System.Windows.Forms.Button xoatk_btn;
        private System.Windows.Forms.Button btnBack;
    }
}