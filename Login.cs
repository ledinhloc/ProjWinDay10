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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        dbConnect db = new dbConnect();

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FCreateAccount form = new FCreateAccount();
            form.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string strSql = $"Select * From NguoiDung WHERE TenDangNhap = '{txtTenDN.Text}' AND MatKhau = '{txtMK.Text}' ";
            DataTable table = db.TryVan(strSql);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {

                    NguoiDung ngDung = new NguoiDung();
                    ngDung.NguoiDungID = dr["NguoiDungID"].ToString();
                    ngDung.HoTen = dr["HoTen"].ToString();
                    ngDung.Cmnd = dr["Cmnd"].ToString();
                    ngDung.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]).Date;
                    ngDung.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);

                    ngDung.DiaChi = dr["DiaChi"].ToString();
                    ngDung.DienThoai = dr["DienThoai"].ToString();
                    ngDung.Email = dr["Email"].ToString();
                    ngDung.TenDangNhap = dr["TenDangNhap"].ToString();
                    ngDung.MatKhau = dr["MatKhau"].ToString();
                    ngDung.KhachSanID = dr["KhachSanID"]?.ToString() ?? "";


                    if (ngDung.KhachSanID == "")
                    {

                    }
                    else
                    {
                        FTrangChu fTrangChu = new FTrangChu();
                        fTrangChu.ShowDialog();
                    }
                }
            }
            else
            {
                Console.WriteLine("Không có dữ liệu.");
            }
        }
    }
}
