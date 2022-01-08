namespace QuanLyHoSoSinhVien.src.QuanLyHeThong
{
    partial class TaoTK
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttk_txt = new System.Windows.Forms.TextBox();
            this.mk2_txt = new System.Windows.Forms.TextBox();
            this.remk2_txt = new System.Windows.Forms.TextBox();
            this.huy_btn = new System.Windows.Forms.Button();
            this.tao_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(199, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(34, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(34, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // ttk_txt
            // 
            this.ttk_txt.Location = new System.Drawing.Point(244, 90);
            this.ttk_txt.Name = "ttk_txt";
            this.ttk_txt.Size = new System.Drawing.Size(223, 23);
            this.ttk_txt.TabIndex = 6;
            // 
            // mk2_txt
            // 
            this.mk2_txt.Location = new System.Drawing.Point(244, 155);
            this.mk2_txt.Name = "mk2_txt";
            this.mk2_txt.Size = new System.Drawing.Size(223, 23);
            this.mk2_txt.TabIndex = 7;
            this.mk2_txt.UseSystemPasswordChar = true;
            // 
            // remk2_txt
            // 
            this.remk2_txt.Location = new System.Drawing.Point(244, 219);
            this.remk2_txt.Name = "remk2_txt";
            this.remk2_txt.Size = new System.Drawing.Size(223, 23);
            this.remk2_txt.TabIndex = 8;
            this.remk2_txt.UseSystemPasswordChar = true;
            // 
            // huy_btn
            // 
            this.huy_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huy_btn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.huy_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Delete;
            this.huy_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.huy_btn.Location = new System.Drawing.Point(377, 295);
            this.huy_btn.Name = "huy_btn";
            this.huy_btn.Size = new System.Drawing.Size(167, 61);
            this.huy_btn.TabIndex = 5;
            this.huy_btn.Text = "Hủy bỏ";
            this.huy_btn.UseVisualStyleBackColor = true;
            this.huy_btn.Click += new System.EventHandler(this.huy_btn_Click);
            // 
            // tao_btn
            // 
            this.tao_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tao_btn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.tao_btn.Image = global::QuanLyHoSoSinhVien.Properties.Resources.Add;
            this.tao_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tao_btn.Location = new System.Drawing.Point(89, 295);
            this.tao_btn.Name = "tao_btn";
            this.tao_btn.Size = new System.Drawing.Size(166, 61);
            this.tao_btn.TabIndex = 4;
            this.tao_btn.Text = "Tạo tài khoản";
            this.tao_btn.UseVisualStyleBackColor = true;
            this.tao_btn.Click += new System.EventHandler(this.tao_btn_Click);
            // 
            // TaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(571, 380);
            this.Controls.Add(this.remk2_txt);
            this.Controls.Add(this.mk2_txt);
            this.Controls.Add(this.ttk_txt);
            this.Controls.Add(this.huy_btn);
            this.Controls.Add(this.tao_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaoTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tao_btn;
        private System.Windows.Forms.Button huy_btn;
        private System.Windows.Forms.TextBox mk2_txt;
        private System.Windows.Forms.TextBox remk2_txt;
        public System.Windows.Forms.TextBox ttk_txt;
    }
}