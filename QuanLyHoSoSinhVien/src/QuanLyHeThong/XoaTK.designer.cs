namespace QuanLyHoSoSinhVien.src.QuanLyHeThong
{
    partial class XoaTK
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
            this.xoa_btn = new System.Windows.Forms.Button();
            this.huybo2_btn = new System.Windows.Forms.Button();
            this.danhsach_dg = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.xtk_txt = new System.Windows.Forms.TextBox();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.danhsach_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xóa Tài Khoản";
            // 
            // xoa_btn
            // 
            this.xoa_btn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.ForeColor = System.Drawing.Color.Turquoise;
            this.xoa_btn.Location = new System.Drawing.Point(34, 283);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(130, 62);
            this.xoa_btn.TabIndex = 7;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = true;
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // huybo2_btn
            // 
            this.huybo2_btn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huybo2_btn.ForeColor = System.Drawing.Color.Turquoise;
            this.huybo2_btn.Location = new System.Drawing.Point(233, 283);
            this.huybo2_btn.Name = "huybo2_btn";
            this.huybo2_btn.Size = new System.Drawing.Size(130, 62);
            this.huybo2_btn.TabIndex = 8;
            this.huybo2_btn.Text = "Hủy Bỏ";
            this.huybo2_btn.UseVisualStyleBackColor = true;
            this.huybo2_btn.Click += new System.EventHandler(this.huybo2_btn_Click);
            // 
            // danhsach_dg
            // 
            this.danhsach_dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.danhsach_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsach_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTK,
            this.UserName});
            this.danhsach_dg.Location = new System.Drawing.Point(70, 95);
            this.danhsach_dg.Name = "danhsach_dg";
            this.danhsach_dg.RowTemplate.Height = 24;
            this.danhsach_dg.Size = new System.Drawing.Size(264, 173);
            this.danhsach_dg.TabIndex = 9;
            this.danhsach_dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsach_dg_CellClick);
            this.danhsach_dg.SelectionChanged += new System.EventHandler(this.danhsach_dg_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên tài khoản";
            // 
            // xtk_txt
            // 
            this.xtk_txt.Location = new System.Drawing.Point(161, 53);
            this.xtk_txt.Name = "xtk_txt";
            this.xtk_txt.Size = new System.Drawing.Size(201, 23);
            this.xtk_txt.TabIndex = 11;
            // 
            // MaTK
            // 
            this.MaTK.DataPropertyName = "MaTK";
            this.MaTK.HeaderText = "Mã tài khoản";
            this.MaTK.Name = "MaTK";
            this.MaTK.Width = 110;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên tài khoản";
            this.UserName.Name = "UserName";
            this.UserName.Width = 110;
            // 
            // XoaTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(406, 361);
            this.Controls.Add(this.xtk_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.danhsach_dg);
            this.Controls.Add(this.huybo2_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XoaTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa tài Khoản";
            this.Load += new System.EventHandler(this.XoaAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhsach_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.Button huybo2_btn;
        private System.Windows.Forms.DataGridView danhsach_dg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xtk_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}