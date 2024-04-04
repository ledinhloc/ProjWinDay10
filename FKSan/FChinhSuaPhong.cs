using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLTW.DAL;
using DoAnLTW.DTO;

namespace DoAnLTW
{
    public partial class FChinhSuaPhong : Form
    {
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        PhongDAO phongDAO = new PhongDAO();
        public FChinhSuaPhong()
        {
            InitializeComponent();
            LayThongTin();
        }
        public void LayThongTin()
        {
            txtIDPhong.Text = BienDungChung.idDatPhong.PhongID;
            txtIDKS.Text = BienDungChung.idDatPhong.KhachSanID;
            txtHoVaTen.Text = BienDungChung.idNguoiDung.Hoten;
            txtEmail.Text = BienDungChung.idNguoiDung.Email;
            txtSoDienThoai.Text = BienDungChung.idNguoiDung.Dienthoai;
            cbThanhToan.SelectedItem = BienDungChung.idDatPhong.HinhThucThanhToan;
            dtNgayDat.Value = BienDungChung.idDatPhong.NgayDat;
            dtNgayTra.Value = BienDungChung.idDatPhong.NgayTra;
            lblGia.Text = BienDungChung.idDatPhong.Gia + "";
        }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            BienDungChung.idDatPhong.NgayDat = dtNgayDat.Value;
            BienDungChung.idDatPhong.NgayTra = dtNgayTra.Value;
            BienDungChung.idDatPhong.HinhThucThanhToan = cbThanhToan.Text;
            try
            {
                if (datPhongDAO.Sua(BienDungChung.idDatPhong))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: ", ex.Message);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (datPhongDAO.Xoa())
                {
                    phongDAO.CapNhatTangSoPhong(txtIDPhong.Text);
                    MessageBox.Show("Xóa thành công");
                    BienDungChung.idDatPhong = null;
                }
                else
                    MessageBox.Show("Xóa thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: ", ex.Message);
            }          
        }
    }
}
