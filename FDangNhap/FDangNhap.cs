using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLTW.DAL;
using DoAnLTW.DTO;

namespace DoAnLTW
{
    public partial class FDangNhap : Form
    {
        NguoiDungDAO nguoiDungDAO = new NguoiDungDAO();
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (radNguoiDung.Checked == true)
            {
                BienDungChung.idNguoiDung = nguoiDungDAO.LayThongTinTheoEmail(txtEmail.Text);
                FTrangChu ftrangchu = new FTrangChu();
                ftrangchu.Show();
                this.Hide();
            }        
            else
            {
                BienDungChung.idNguoiDung = nguoiDungDAO.LayThongTinTheoEmail(txtEmail.Text);
                FChuKhachSan ftrangchu = new FChuKhachSan();
                ftrangchu.Show();
                this.Hide();
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            FTaoTaiKhoan fCreateAccount = new FTaoTaiKhoan();
            fCreateAccount.Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
