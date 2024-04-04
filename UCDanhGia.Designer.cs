namespace DoAnLTW
{
    partial class UCDanhGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pbNguoiDung = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblDanhGia = new Guna.UI.WinForms.GunaLabel();
            this.rtSao = new Bunifu.UI.WinForms.BunifuRating();
            this.dtNgayDanhGia = new Guna.UI.WinForms.GunaDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // pbNguoiDung
            // 
            this.pbNguoiDung.BaseColor = System.Drawing.Color.White;
            this.pbNguoiDung.Image = global::DoAnLTW.Properties.Resources.profile;
            this.pbNguoiDung.Location = new System.Drawing.Point(14, 36);
            this.pbNguoiDung.Name = "pbNguoiDung";
            this.pbNguoiDung.Size = new System.Drawing.Size(103, 98);
            this.pbNguoiDung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNguoiDung.TabIndex = 10;
            this.pbNguoiDung.TabStop = false;
            this.pbNguoiDung.UseTransfarantBackground = false;
            // 
            // lblDanhGia
            // 
            this.lblDanhGia.AutoSize = true;
            this.lblDanhGia.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhGia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhGia.ForeColor = System.Drawing.Color.Black;
            this.lblDanhGia.Location = new System.Drawing.Point(123, 72);
            this.lblDanhGia.Name = "lblDanhGia";
            this.lblDanhGia.Size = new System.Drawing.Size(262, 85);
            this.lblDanhGia.TabIndex = 13;
            this.lblDanhGia.Text = "“Excellent location. The staff were\r\nreally friendly and helpful. \r\nGood shower, " +
    "comfy bed and \r\nspotlessly clean. \r\nWould definitely recommend this hotel.”";
            // 
            // rtSao
            // 
            this.rtSao.BackColor = System.Drawing.Color.Transparent;
            this.rtSao.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rtSao.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.rtSao.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rtSao.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rtSao.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rtSao.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rtSao.InnerRadius = 2F;
            this.rtSao.Location = new System.Drawing.Point(126, 3);
            this.rtSao.Name = "rtSao";
            this.rtSao.OuterRadius = 10F;
            this.rtSao.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rtSao.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.rtSao.ReadOnly = false;
            this.rtSao.RightClickToClear = true;
            this.rtSao.Size = new System.Drawing.Size(121, 22);
            this.rtSao.TabIndex = 14;
            this.rtSao.Text = "bunifuRating1";
            this.rtSao.Value = 2;
            // 
            // dtNgayDanhGia
            // 
            this.dtNgayDanhGia.BaseColor = System.Drawing.Color.White;
            this.dtNgayDanhGia.BorderColor = System.Drawing.Color.Silver;
            this.dtNgayDanhGia.CustomFormat = null;
            this.dtNgayDanhGia.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtNgayDanhGia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtNgayDanhGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgayDanhGia.ForeColor = System.Drawing.Color.Black;
            this.dtNgayDanhGia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDanhGia.Location = new System.Drawing.Point(126, 36);
            this.dtNgayDanhGia.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgayDanhGia.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgayDanhGia.Name = "dtNgayDanhGia";
            this.dtNgayDanhGia.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtNgayDanhGia.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtNgayDanhGia.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtNgayDanhGia.OnPressedColor = System.Drawing.Color.Black;
            this.dtNgayDanhGia.Size = new System.Drawing.Size(225, 27);
            this.dtNgayDanhGia.TabIndex = 148;
            this.dtNgayDanhGia.Text = "3/28/2024";
            this.dtNgayDanhGia.Value = new System.DateTime(2024, 3, 28, 0, 0, 0, 0);
            // 
            // UCDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtNgayDanhGia);
            this.Controls.Add(this.rtSao);
            this.Controls.Add(this.lblDanhGia);
            this.Controls.Add(this.pbNguoiDung);
            this.Name = "UCDanhGia";
            this.Size = new System.Drawing.Size(491, 180);
            ((System.ComponentModel.ISupportInitialize)(this.pbNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaElipse gunaElipse1;
        public Guna.UI.WinForms.GunaCirclePictureBox pbNguoiDung;
        public Guna.UI.WinForms.GunaLabel lblDanhGia;
        public Bunifu.UI.WinForms.BunifuRating rtSao;
        public Guna.UI.WinForms.GunaDateTimePicker dtNgayDanhGia;
    }
}
