using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DoAnLTW.DAL;
using DoAnLTW.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DoAnLTW
{
    public partial class FTrangChu : Form
    {
        List<UCChonKS> listUCKS = new List<UCChonKS>();
        KhachSanDAO khachSanDAO = new KhachSanDAO();
        PhongDAO phongDAO = new PhongDAO();
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        UuDaiDAO uuDaiDAO = new UuDaiDAO();
        public FTrangChu()
        {
            InitializeComponent();
            lblMinGia.Text = tbMinGia.Minimum.ToString();
            lblMaxGia.Text = tbMaxGia.Minimum.ToString();
            LayKhachSan();
        }

        public void LayKhachSan()
        {
            foreach (KhachSan ks in khachSanDAO.LayThongTinChung())
            {
                UCChonKS uCChonKS = new UCChonKS();
                uCChonKS.lblIdKS.Text = ks.KhachSanID;
                uCChonKS.lblTenKS.Text = ks.TenKhachSan;
                uCChonKS.rtKS.Value = Convert.ToInt32(ks.Sao);
                uCChonKS.lblDiaChi.Text = ks.DiaChi;
                uCChonKS.lblTienNghi.Text = ks.TienNghi;
                uCChonKS.lblThanhToan.Text = ks.HinhThucThanhToan;
                uCChonKS.lblGiaPhong.Text = "" + phongDAO.LayMinMaxGia(ks.KhachSanID)[0] + "-" + phongDAO.LayMinMaxGia(ks.KhachSanID)[1];
                uCChonKS.lblTinh.Text = ks.Tinh;
                if (uuDaiDAO.LayUDTheoKS(ks.KhachSanID).Count > 0)
                    uCChonKS.lblUuDai.Text = "Giảm Đến " + Convert.ToString(uuDaiDAO.LayUDTheoKS(ks.KhachSanID)[0].PhanTram) + "%";
                listUCKS.Add(uCChonKS);
                pnlKS.Controls.Add(uCChonKS);
            }
        }

        private void btnThongtincanhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan fthongtincanhan = new FThongTinCaNhan();
            fthongtincanhan.Show();
            this.Hide();
        }

        private void btnDondat_Click(object sender, EventArgs e)
        {
            FThongTinDatPhong fthongtindatphong = new FThongTinDatPhong();
            fthongtindatphong.Show();
            this.Hide();
        }

        private void btnChonkhachsan_Click(object sender, EventArgs e)
        {
            foreach (UCChonKS ucKS in listUCKS)
            {
                if (ucKS.cbKS.Checked)
                    BienDungChung.idKSChon = khachSanDAO.LayThongTinRieng(ucKS.lblIdKS.Text);
            }    
            FKhachSan fkhachsan = new FKhachSan();
            fkhachsan.Show();
            this.Hide();
        }

        private void btnThongTinChuKhach_Click(object sender, EventArgs e)
        {
            if (!bcCanhan.Visible) bunifuTransition1.ShowSync(bcCanhan);
            else bunifuTransition1.HideSync(bcCanhan);
        }

        private void btnDXuat_Click(object sender, EventArgs e)
        {
            FDangNhap fDangnhap = new FDangNhap();
            fDangnhap.Show();
            this.Hide();
        }
        CultureInfo culture = new CultureInfo("vi-VN");
        private void tbGia_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            lblMinGia.Text = tbMinGia.Value.ToString("C", culture);
        }

        private void tbMaxGia_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            lblMaxGia.Text = tbMaxGia.Value.ToString("C", culture);
        }

        public bool KiemTraLocNgay(UCChonKS uCKS, DateTime ngayDat, DateTime ngayTra)
        {
            foreach (DatPhong dp in datPhongDAO.LayDonDatTheoNgay(ngayDat, ngayTra))
            {
                if (uCKS.lblIdKS.Text == dp.KhachSanID)
                {
                    return true;
                }
            }
            return false;
        }
        public bool KiemTraPhongTrong(UCChonKS uCKS)
        {
            foreach (KhachSan ks in khachSanDAO.LayPhongChuaDuocDat())
            {
                if (uCKS.lblIdKS.Text == ks.KhachSanID)
                {
                    return true;
                }
            }
            return false;
        }
        public bool KiemTraKSTheoGiuong(UCChonKS uCKS, int soGiuong)
        {
            foreach (Phong phong in phongDAO.LayPhongTheoSoGiuong(soGiuong))
            {
                if (uCKS.lblIdKS.Text == phong.KhachSanID)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbLocGia.Checked)
            {
                foreach (UCChonKS control in pnlKS.Controls)
                {

                    string[] gia = control.lblGiaPhong.Text.Split('-');
                    int minGia = Convert.ToInt32(gia[0]);
                    int maxGia = Convert.ToInt32(gia[1]);
                    if (minGia >= tbMinGia.Value && maxGia <= tbMaxGia.Value)
                    {
                        control.Visible = true;
                    }
                    else
                    {
                        control.Visible = false;
                    }
                }
            }
            else if (cbLocNguoi.Checked)
            {
                int soGiuong = Convert.ToInt32(ucDemNL.txtDem.Text) + Convert.ToInt32(ucDemTE.txtDem.Text);
                foreach (UCChonKS uCKS in pnlKS.Controls)
                {
                    if (KiemTraKSTheoGiuong(uCKS, soGiuong))
                    {
                        uCKS.Visible = true;
                    }
                    else
                    {
                        uCKS.Visible = false;
                    }
                }
            }
            else if (cbLocNgay.Checked)
            {
                foreach (UCChonKS uCKS in pnlKS.Controls)
                {
                    if (KiemTraLocNgay(uCKS, dtNgayDat.Value, dtNgayTra.Value) || (KiemTraPhongTrong(uCKS)))
                    {
                        uCKS.Visible = true;
                    }
                    else
                    {
                        uCKS.Visible = false;
                    }
                }
            }
            else if (cbLocTinh.Checked)
            {
                foreach (UCChonKS uCKS in pnlKS.Controls)
                {
                    if (uCKS.lblIdKS.Text == khachSanDAO.LayThongTinTheoTinh(comboLocTinh.Text).KhachSanID)
                    {
                        uCKS.Visible = true;
                    }
                    else
                    {
                        uCKS.Visible = false;
                    }
                }
            }
            else
            {
                LayKhachSan();
            }
        }

        private void btnSoNguoi_Click(object sender, EventArgs e)
        {
            if (!bcSoNguoi.Visible) bunifuTransition1.ShowSync(bcSoNguoi);
            else bunifuTransition1.HideSync(bcSoNguoi);
        }

        private void btnNgayDat_Click(object sender, EventArgs e)
        {
            if (!bcNgayDat.Visible) bunifuTransition1.ShowSync(bcNgayDat);
            else bunifuTransition1.HideSync(bcNgayDat);
        }

        private void btnNganSach_Click(object sender, EventArgs e)
        {
            if (!bcNganSach.Visible) bunifuTransition1.ShowSync(bcNganSach);
            else bunifuTransition1.HideSync(bcNganSach);
        }
    }
}
