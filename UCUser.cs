using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTW
{
    public partial class UCUser : UserControl
    {
        private NguoiDung ngDung;
        dbConnect db = new dbConnect();
        public event EventHandler<NguoiDung> PicDelete_Click;

        public Guna2PictureBox PicDelete
        {
            get{ return picDelete; }
        }
        public UCUser(NguoiDung ngDung)
        {
            InitializeComponent();
            this.ngDung = ngDung;
            lblCmnd.Text = ngDung.Cmnd;
            lblHoTen.Text = ngDung.HoTen;
            lblNgaySinh.Text = ngDung.NgaySinh.ToString("yyyy-MM-dd");
            if (ngDung.GioiTinh == true)
            {
                lblGT.Text = "Nam";
            }
            else
            {
                lblGT.Text = "Nu";
            }
            lblDiaChi.Text = ngDung.DiaChi;
            this.MouseMove += UCUser_MouseMove;
            this.MouseLeave += UCUser_MouseLeave;
            this.Click += UCUser_Click;
        }

        private void UCUser_Click(object sender, EventArgs e)
        {
            FSuaNguoiDung form = new FSuaNguoiDung(ngDung);
            form.ShowDialog();
        }

        private void UCUser_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UCUser_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void UCUser_Load(object sender, EventArgs e)
        {
            
        }

        

        private void picDelete_Click(object sender, EventArgs e)
        {
        }
    }

}
