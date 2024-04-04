namespace DoAnLTW
{
    partial class UCTimKS
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
            this.lblTenKS = new System.Windows.Forms.Label();
            this.lblDiaChi = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIDKS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenKS
            // 
            this.lblTenKS.AutoSize = true;
            this.lblTenKS.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKS.Location = new System.Drawing.Point(61, 4);
            this.lblTenKS.Name = "lblTenKS";
            this.lblTenKS.Size = new System.Drawing.Size(107, 23);
            this.lblTenKS.TabIndex = 0;
            this.lblTenKS.Text = "Khách Sạn A";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(139)))), ((int)(((byte)(248)))));
            this.lblDiaChi.Location = new System.Drawing.Point(62, 25);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(157, 17);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Thành Phố Hồ Chí Minh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnLTW.Properties.Resources.hotel3;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblIDKS
            // 
            this.lblIDKS.AutoSize = true;
            this.lblIDKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDKS.Location = new System.Drawing.Point(239, 23);
            this.lblIDKS.Name = "lblIDKS";
            this.lblIDKS.Size = new System.Drawing.Size(52, 20);
            this.lblIDKS.TabIndex = 5;
            this.lblIDKS.Text = "IDKS";
            this.lblIDKS.Visible = false;
            // 
            // UCTimKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblIDKS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenKS);
            this.Name = "UCTimKS";
            this.Size = new System.Drawing.Size(294, 55);
            this.Click += new System.EventHandler(this.UCTimKS_Click);
            this.MouseLeave += new System.EventHandler(this.UCTimKS_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UCTimKS_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTenKS;
        public Guna.UI.WinForms.GunaLabel lblDiaChi;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblIDKS;
    }
}
