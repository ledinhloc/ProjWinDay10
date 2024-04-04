using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Common;
using DoAnLTW.DAL;
using System.Resources;
using DoAnLTW.DTO;

namespace DoAnLTW
{
    public partial class FChuThongTin : Form
    {
        NguoiDung nd;
        NguoiDungDAO nguoiDungDAO = new NguoiDungDAO();
        string fileName="";
        public FChuThongTin()
        {
            InitializeComponent();
            LayThongTinND();
        }
        public void LayThongTinND()
        {
            nd = nguoiDungDAO.LayThongTinRieng(BienDungChung.idNguoiDung.Nguoidungid);
            txtHovaTen.Text = nd.Hoten;
            txtCMND.Text = nd.Cmnd;
            dtpNgaySinh.Value = nd.Ngaysinh;
            if (nd.Gioitinh == "Nam")
            {
                rbtNam.Checked = true;
            }
            else
            {
                rbtNu.Checked = true;
            }
            txtDiaChi.Text = nd.Diachi;
            txtDienThoai.Text = nd.Dienthoai;
            txtEmail.Text = nd.Email;
            pbNguoiDung.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(nd.Hinhanh);
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NguoiDung NguoiDungNew = new NguoiDung(BienDungChung.idNguoiDung.Nguoidungid,txtHovaTen.Text,txtCMND.Text,
                dtpNgaySinh.Value,GioiTinh(),txtDiaChi.Text,txtDienThoai.Text, txtEmail.Text, "", "", fileName,"KS001");
            nguoiDungDAO.CapNhat(NguoiDungNew);

        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy tên của tệp được chọn đầu tiên
                fileName = Path.GetFileName(openFileDialog.FileNames[0]);

                // Tìm vị trí của dấu "." cuối cùng trong tên tệp
                int lastDotIndex = fileName.LastIndexOf('.');
                if (lastDotIndex != -1)
                {
                    // Cắt chuỗi từ đầu đến vị trí của dấu "."
                    fileName = fileName.Substring(0, lastDotIndex);
                }
            }
            pbNguoiDung.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(fileName);
            MessageBox.Show("Thêm ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string GioiTinh()
        {
            if (rbtNam.Checked)
            {
                return "Nam";
            }
            else
            {
                return "Nữ";
            }
        }
    }
}
