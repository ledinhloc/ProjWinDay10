using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTW
{
    public partial class UCUserAdmin : UserControl
    {
        public UCUserAdmin()
        {
            InitializeComponent();
            
        }
        List<NguoiDung> listNgDung = new List<NguoiDung>();
        dbConnect db = new dbConnect();
        private void UCUserAdmin_Load(object sender, EventArgs e)
        {
            
            string strSql = "Select * From NguoiDung WHERE KhachSanID is NULL";
            DataTable table = db.TryVan(strSql);

            lblSoLuong.Text = table.Rows.Count.ToString();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    NguoiDung ngDung = new NguoiDung();
                    ngDung.NguoiDungID = dr["NguoiDungID"].ToString();
                    //ngDung.HoTen = dr["HoTen"].ToString();
                    ngDung.HoTen = Encoding.UTF8.GetString(Encoding.Default.GetBytes(dr["HoTen"].ToString()));
                    ngDung.Cmnd = dr["Cmnd"].ToString();
                    ngDung.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]).Date;
                    ngDung.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);

                    ngDung.DiaChi = dr["DiaChi"].ToString();
                    ngDung.DienThoai = dr["DienThoai"].ToString();
                    ngDung.Email = dr["Email"].ToString();
                    ngDung.TenDangNhap = dr["TenDangNhap"].ToString();
                    ngDung.MatKhau = dr["MatKhau"].ToString();
                    ngDung.KhachSanID = dr["KhachSanID"].ToString() ;

                    UCUser uCUser = new UCUser(ngDung);
                    uCUser.PicDelete.Click += PicDelete_Click;
                    //uCUser.PicDelete_Click += PicDelete_Click;
                    panel.Controls.Add(uCUser);
                    listNgDung.Add(ngDung);
                }
            }
            else
            {
                Console.WriteLine("Không có dữ liệu.");
            }

        }

        private void PicDelete_Click(object sender, EventArgs e)
        {
            //string strSql = $"DELETE FROM NguoiDung WHERE NguoiDungID = '{sender.NguoiDungID}'";
            DialogResult result = MessageBox.Show("Ban chac chan muon xoa!");
            if (result == DialogResult.OK)
            {
                //db.ThucThi(strSql);
            }
            UCUserAdmin_Load(sender, e);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSapXep.SelectedIndex)
            {
                case 0:
                    listNgDung.Sort((n1, n2) => n1.Cmnd.CompareTo(n2.Cmnd));
                    break;
                case 1:
                    listNgDung.Sort((n1, n2) => n1.HoTen.CompareTo(n2.HoTen));
                    break;
                case 2:
                    listNgDung.Sort((n1, n2) => n1.NgaySinh.CompareTo(n2.NgaySinh));
                    break;
                case 3:
                    listNgDung.Sort((n1, n2) => n1.DiaChi.CompareTo(n2.DiaChi));
                    break;
                default:
                    break;
            }
            panel.Controls.Clear();
            foreach(NguoiDung tmp in listNgDung)
            {
                panel.Controls.Add(new UCUser(tmp));
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            int dem = 0;
            foreach(NguoiDung tmp in listNgDung)
            {
                //kt tra ko phan biet hoa thuong
                if (tmp.HoTen.ToLower().Contains(txtTim.Text.ToLower()))
                {
                    dem++;
                    panel.Controls.Add(new UCUser(tmp));
                }
            }
            lblSoLuong.Text = dem.ToString();
        }
    }
}
