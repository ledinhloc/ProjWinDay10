using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DoAnLTW.DAL;
using DoAnLTW.DTO;

namespace DoAnLTW
{
    public partial class FThongTinDatPhong : Form
    {
        List<UCDonDatPhong> listUCDP = new List<UCDonDatPhong>();
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        public FThongTinDatPhong()
        {
            InitializeComponent();
            LoadDonDat();
        }    

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FDangNhap fDangnhap = new FDangNhap();
            fDangnhap.Show();
            this.Hide();
        }

        private void btnThongtincanhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan fthongtincanhan = new FThongTinCaNhan();
            fthongtincanhan.Show();
            this.Hide();
        }

        private void btnChonkhachsan_Click(object sender, EventArgs e)
        {
            foreach (UCDonDatPhong ucDP in listUCDP)
            {
                if (ucDP.cbDonDat.Checked)
                    BienDungChung.idDatPhong = datPhongDAO.LayThongTinRieng(ucDP.lblIDdat.Text);
            }
            FChinhSuaPhong fSuaThongTinDat = new FChinhSuaPhong();
            fSuaThongTinDat.ShowDialog();
        }
        public void LoadDonDat()
        {
            foreach (DatPhong dp in datPhongDAO.LayThongTinChung())
            {
                UCDonDatPhong uCDonDatPhong = new UCDonDatPhong();
                uCDonDatPhong.lblIDdat.Text = dp.DatPhongID;
                uCDonDatPhong.dtNgaydat.Value = dp.NgayDat;
                uCDonDatPhong.dtNgaytra.Value = dp.NgayTra;
                uCDonDatPhong.lblTinhTrang.Text = dp.TrangThai;
                listUCDP.Add(uCDonDatPhong);
                pnlDP.Controls.Add(uCDonDatPhong);
            }
        }
        private void btnTatca_Click(object sender, EventArgs e)
        {
            pnlDP.Controls.Clear();
            LoadDonDat();       
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            //for (int i = 0; i < 3; i++)
            //{
            //    if (phong[i].Tinhtrang == "Hoàn Tất")
            //    {
            //        UCDonDatPhong uCDonDatPhong = new UCDonDatPhong();
            //        uCDonDatPhong.txtMa.Text = phong[i].Bookingid;
            //        uCDonDatPhong.dtNgaydat.Value = phong[i].Ngaydat;
            //        uCDonDatPhong.dtNgaytra.Value = phong[i].Ngayhuy;
            //        uCDonDatPhong.txtTinhtrang.Text = phong[i].Tinhtrang;
            //        if (uCDonDatPhong.txtTinhtrang.Text == "Hoàn Tất")
            //            uCDonDatPhong.txtTinhtrang.FillColor = Color.Green;
            //        if (uCDonDatPhong.txtTinhtrang.Text == "Đang Chờ")
            //            uCDonDatPhong.txtTinhtrang.FillColor = Color.Yellow;
            //        if (uCDonDatPhong.txtTinhtrang.Text == "Đã Hủy")
            //            uCDonDatPhong.txtTinhtrang.FillColor = Color.Red;
            //        flowLayoutPanel1.Controls.Add(uCDonDatPhong);
            //    }                   
            //}
        }

        private void btnDahuy_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            //for (int i = 0; i < 3; i++)
            //{
            //    if (phong[i].Tinhtrang == "Đã Hủy")
            //    {
            //        UCDonDatPhong uCDonDatPhong = new UCDonDatPhong();
            //        uCDonDatPhong.txtMa.Text = phong[i].Bookingid;
            //        uCDonDatPhong.dtNgaydat.Value = phong[i].Ngaydat;
            //        uCDonDatPhong.dtNgaytra.Value = phong[i].Ngayhuy;
            //        uCDonDatPhong.txtTinhtrang.Text = phong[i].Tinhtrang;
            //        if (uCDonDatPhong.txtTinhtrang.Text == "Hoàn Tất")
            //            uCDonDatPhong.txtTinhtrang.FillColor = Color.Green;
            //        if (uCDonDatPhong.txtTinhtrang.Text == "Đang Chờ")
            //            uCDonDatPhong.txtTinhtrang.FillColor = Color.Yellow;
            //        if (uCDonDatPhong.txtTinhtrang.Text == "Đã Hủy")
            //            uCDonDatPhong.txtTinhtrang.FillColor = Color.Red;
            //        flowLayoutPanel1.Controls.Add(uCDonDatPhong);
            //    }
            //}
        }

        private void btnDangcho_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            //for (int i = 0; i < 3; i++)
            //{
            //    if (phong[i].Tinhtrang == "Đang Chờ")
            //    {
            //        UCDonDatPhong uCDonDatPhong = new UCDonDatPhong();
            //        uCDonDatPhong.txtMa.Text = phong[i].Bookingid;
            //        uCDonDatPhong.dtNgaydat.Value = phong[i].Ngaydat;
            //        uCDonDatPhong.dtNgaytra.Value = phong[i].Ngayhuy;
            //        uCDonDatPhong.txtTinhtrang.Text = phong[i].Tinhtrang;
            //        if (uCDonDatPhong.txtTinhtrang.Text == "Hoàn Tất")
            //            uCDonDatPhong.txtTinhtrang.FillColor = Color.Green;
            //        if (uCDonDatPhong.txtTinhtrang.Text == "Đang Chờ")
            //            uCDonDatPhong.txtTinhtrang.FillColor = Color.Yellow;
            //        if (uCDonDatPhong.txtTinhtrang.Text == "Đã Hủy")
            //            uCDonDatPhong.txtTinhtrang.FillColor = Color.Red;
            //        flowLayoutPanel1.Controls.Add(uCDonDatPhong);
            //    }
            //}
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            FTrangChu fTrangChu = new FTrangChu();
            fTrangChu.Show();
            this.Hide();
        }

        private void btnThongTinChuKhach_Click(object sender, EventArgs e)
        {
            if (!bcCanhan.Visible) bunifuTransition1.ShowSync(bcCanhan);
            else bunifuTransition1.HideSync(bcCanhan);
        }

        private void txtDatphong_TextChanged(object sender, EventArgs e)
        {
            if (txtDatphong.TextLength >= 1)
            {
                UCTimDonDat uCTimDonDat = new UCTimDonDat();
                List<UCTimDonDat> listucDonDatPhong = uCTimDonDat.TimPhongDat(txtDatphong.Text);
                pnlKQTim.Controls.Clear();
                foreach (UCTimDonDat ucDon in listucDonDatPhong)
                {
                    pnlKQTim.Controls.Add(ucDon);
                    pnlKQTim.Height = pnlKQTim.Controls.Count * 49;
                }
            }
            else
            {
                pnlKQTim.Height = 0;
            }
        }

        private void btnĐanhGia_Click(object sender, EventArgs e)
        {
            foreach (UCDonDatPhong ucDP in listUCDP)
            {
                if (ucDP.cbDonDat.Checked)
                    BienDungChung.idDatPhong = datPhongDAO.LayThongTinRieng(ucDP.lblIDdat.Text);
            }
            FDanhGia fdanhgia = new FDanhGia();
            fdanhgia.ShowDialog();
        }
    }
}
