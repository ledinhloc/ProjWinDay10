using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLTW.FQuanLyKS;

namespace DoAnLTW
{
    public partial class FChuKhachSan : Form
    {       
        FChuTrangChu f2 = new FChuTrangChu();    
        FYeuCauDonDat f4 = new FYeuCauDonDat();    
        FPhong fphong = new FPhong();
        FChuThongTin fthongtin = new FChuThongTin();
        FThemUuDai fthemUuDai = new FThemUuDai();
        FKhachHang fKhachHang = new FKhachHang();
        public FChuKhachSan()
        {
            InitializeComponent();
            AddFormToPanel(f2);
        }
        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            FChuThongTin f1 = new FChuThongTin();
            AddFormToPanel(f1);
        }

        private void btnThongTinKhachSan_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            FThongTinKhachSan f3 = new FThongTinKhachSan();
            AddFormToPanel(f3);
        }

        private void AddFormToPanel(Form form)
        {
            pnlHienThi.Controls.Clear();
            form.TopLevel = false;
            form.Visible = true;
            pnlHienThi.Controls.Add(form);
            form.Size = pnlHienThi.Size;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            AddFormToPanel(fphong);
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            AddFormToPanel(f2);
        }

        private void btnYeuCau_Click(object sender, EventArgs e)
        {
            AddFormToPanel(f4);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            AddFormToPanel(fKhachHang);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FDangNhap fDangnhap = new FDangNhap();
            fDangnhap.Show();
            this.Hide();
        }

        private void btnUuDai_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            AddFormToPanel(fthemUuDai);
        }
    }
}
