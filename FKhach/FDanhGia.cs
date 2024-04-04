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
    public partial class FDanhGia : Form
    {
        DanhGiaDAO danhGiaDAO = new DanhGiaDAO();
        Random random = new Random();
        public FDanhGia()
        {
            InitializeComponent();
            lblTen.Text = BienDungChung.idNguoiDung.Hoten;
            lblDiaChi.Text = BienDungChung.idNguoiDung.Diachi;
            dtNgayDanhGia.Value = DateTime.Now;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string randomNumber = random.Next(1, 1001) + "";
                DanhGia dg = new DanhGia(randomNumber, BienDungChung.idDatPhong.KhachSanID,
                    BienDungChung.idDatPhong.PhongID, BienDungChung.idNguoiDung.Nguoidungid,
                    rtDanhGia.Value, txtMoTa.Text, dtNgayDanhGia.Value);
                if (danhGiaDAO.DanhGia(dg))
                {
                    MessageBox.Show("Đánh giá thành công");
                }    
                else
                {
                    MessageBox.Show("Đánh giá thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
