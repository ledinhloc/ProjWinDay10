namespace DoAnLTW
{
    partial class UCDonDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDonDatPhong));
            this.dtNgaytra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtNgaydat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblIDdat = new System.Windows.Forms.Label();
            this.cbDonDat = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtNgaytra
            // 
            this.dtNgaytra.BackColor = System.Drawing.Color.Transparent;
            this.dtNgaytra.BorderRadius = 10;
            this.dtNgaytra.Checked = true;
            this.dtNgaytra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.dtNgaytra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgaytra.ForeColor = System.Drawing.Color.White;
            this.dtNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtNgaytra.Location = new System.Drawing.Point(259, 103);
            this.dtNgaytra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgaytra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgaytra.Name = "dtNgaytra";
            this.dtNgaytra.Size = new System.Drawing.Size(378, 38);
            this.dtNgaytra.TabIndex = 69;
            this.dtNgaytra.Value = new System.DateTime(2024, 3, 7, 9, 52, 27, 126);
            // 
            // dtNgaydat
            // 
            this.dtNgaydat.BackColor = System.Drawing.Color.Transparent;
            this.dtNgaydat.BorderRadius = 10;
            this.dtNgaydat.Checked = true;
            this.dtNgaydat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtNgaydat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgaydat.ForeColor = System.Drawing.Color.Black;
            this.dtNgaydat.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtNgaydat.Location = new System.Drawing.Point(259, 59);
            this.dtNgaydat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgaydat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgaydat.Name = "dtNgaydat";
            this.dtNgaydat.Size = new System.Drawing.Size(378, 38);
            this.dtNgaydat.TabIndex = 68;
            this.dtNgaydat.Value = new System.DateTime(2024, 3, 7, 9, 52, 27, 126);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DoAnLTW.Properties.Resources.thiet_ke_noi_that_can_ho_chung_cu_vinhomes_metropolis_chi_nga_9_1024x683;
            this.gunaPictureBox1.Location = new System.Drawing.Point(13, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(227, 176);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 37;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lblIDdat
            // 
            this.lblIDdat.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDdat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblIDdat.Location = new System.Drawing.Point(443, 12);
            this.lblIDdat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDdat.Name = "lblIDdat";
            this.lblIDdat.Size = new System.Drawing.Size(129, 37);
            this.lblIDdat.TabIndex = 70;
            this.lblIDdat.Text = "ID Đặt";
            // 
            // cbDonDat
            // 
            this.cbDonDat.AllowBindingControlAnimation = true;
            this.cbDonDat.AllowBindingControlColorChanges = false;
            this.cbDonDat.AllowBindingControlLocation = true;
            this.cbDonDat.AllowCheckBoxAnimation = false;
            this.cbDonDat.AllowCheckmarkAnimation = true;
            this.cbDonDat.AllowOnHoverStates = true;
            this.cbDonDat.AutoCheck = true;
            this.cbDonDat.BackColor = System.Drawing.Color.Transparent;
            this.cbDonDat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbDonDat.BackgroundImage")));
            this.cbDonDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbDonDat.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbDonDat.BorderRadius = 12;
            this.cbDonDat.Checked = false;
            this.cbDonDat.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.cbDonDat.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbDonDat.CustomCheckmarkImage = null;
            this.cbDonDat.Location = new System.Drawing.Point(607, 162);
            this.cbDonDat.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbDonDat.Name = "cbDonDat";
            this.cbDonDat.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cbDonDat.OnCheck.BorderRadius = 12;
            this.cbDonDat.OnCheck.BorderThickness = 2;
            this.cbDonDat.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.cbDonDat.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.cbDonDat.OnCheck.CheckmarkThickness = 2;
            this.cbDonDat.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.cbDonDat.OnDisable.BorderRadius = 12;
            this.cbDonDat.OnDisable.BorderThickness = 2;
            this.cbDonDat.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbDonDat.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.cbDonDat.OnDisable.CheckmarkThickness = 2;
            this.cbDonDat.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbDonDat.OnHoverChecked.BorderRadius = 12;
            this.cbDonDat.OnHoverChecked.BorderThickness = 2;
            this.cbDonDat.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbDonDat.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbDonDat.OnHoverChecked.CheckmarkThickness = 2;
            this.cbDonDat.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbDonDat.OnHoverUnchecked.BorderRadius = 12;
            this.cbDonDat.OnHoverUnchecked.BorderThickness = 1;
            this.cbDonDat.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbDonDat.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.cbDonDat.OnUncheck.BorderRadius = 12;
            this.cbDonDat.OnUncheck.BorderThickness = 1;
            this.cbDonDat.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbDonDat.Size = new System.Drawing.Size(30, 30);
            this.cbDonDat.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbDonDat.TabIndex = 72;
            this.cbDonDat.ThreeState = false;
            this.cbDonDat.ToolTipText = null;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblTinhTrang.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTinhTrang.Location = new System.Drawing.Point(259, 162);
            this.lblTinhTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(2, 25);
            this.lblTinhTrang.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(252, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 73;
            this.label1.Text = "Đơn Đặt:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // UCDonDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDonDat);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.lblIDdat);
            this.Controls.Add(this.dtNgaytra);
            this.Controls.Add(this.dtNgaydat);
            this.Controls.Add(this.gunaPictureBox1);
            this.Name = "UCDonDatPhong";
            this.Size = new System.Drawing.Size(667, 207);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtNgaytra;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtNgaydat;
        public System.Windows.Forms.Label lblIDdat;
        public Bunifu.UI.WinForms.BunifuCheckBox cbDonDat;
        public System.Windows.Forms.Label lblTinhTrang;
        public System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
