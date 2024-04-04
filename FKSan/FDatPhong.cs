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
using DoAnLTW.FKSan;

namespace DoAnLTW
{
    public partial class FDatPhong : Form
    {
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        Random random = new Random();
        PhongDAO phongDAO = new PhongDAO();
        UuDaiDAO uuDaiDAO = new UuDaiDAO();
        public FDatPhong()
        {
            InitializeComponent();
            LayThongTin();
        }
        public void LayThongTin()
        {
            txtHoVaTen.Text = BienDungChung.idNguoiDung.Hoten;
            txtEmail.Text = BienDungChung.idNguoiDung.Email;
            txtSoDienThoai.Text = BienDungChung.idNguoiDung.Dienthoai;
            lblGiaTien.Text = Convert.ToString(BienDungChung.idPhongChon.Gia);
            lblSoPhong.Text = Convert.ToString(BienDungChung.idPhongChon.SoPhong);
        }
        public UuDai KiemTraMUD(string mauD)
        {
            foreach (UuDai ud in uuDaiDAO.LayUDTheoKS(BienDungChung.idKSChon.KhachSanID))
            {
                if (ud.MaUuDai == mauD)
                {
                    return ud;
                }
            }
            return null;
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (BienDungChung.idPhongChon.SoPhong > 0)
                {
                    int giaTien = 0;
                    UuDai ud = KiemTraMUD(txtMaUD.Text);
                    if (ud != null)
                    {
                        giaTien = Convert.ToInt32(lblGiaTien.Text) * Convert.ToInt32(ud.PhanTram) / 100;
                    }
                    string randomNumber = random.Next(1, 1001) + "";
                    DatPhong dp = new DatPhong(randomNumber, BienDungChung.idKSChon.KhachSanID, BienDungChung.idPhongChon.PhongID,
                        BienDungChung.idNguoiDung.Nguoidungid, dtNgayDat.Value, dtNgayTra.Value, "Đang Chờ",
                        cbThanhToan.Text, giaTien);
                    if (datPhongDAO.DatPhong(dp))
                    {
                        MessageBox.Show("Đặt thành công. " + "Mã đơn của bạn là" + randomNumber);
                        phongDAO.CapNhatGiamSoPhong(BienDungChung.idPhongChon.PhongID);
                    }
                    else
                        MessageBox.Show("Đặt thất bại");
                }    
                else
                {
                    MessageBox.Show("Đã hết phòng!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: ", ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            FUuDai fud = new FUuDai();
            fud.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int giaTien = 0;
            UuDai ud = KiemTraMUD(txtMaUD.Text);
            if (ud != null)
            {
                giaTien = Convert.ToInt32(lblGiaTien.Text) * Convert.ToInt32(ud.PhanTram) / 100;
            }
            lblGiaTien.Text = Convert.ToString(giaTien);
        }
    }
}
