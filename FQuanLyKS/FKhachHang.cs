using DoAnLTW.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTW.FQuanLyKS
{
    public partial class FKhachHang : Form
    {
        public FKhachHang()
        {
            InitializeComponent();
            KhachSanDAO khachSanDAO = new KhachSanDAO();
            DataTable table = khachSanDAO.layThongTinNguoi("KS001");

            List<UCKhachHang> listUC = new List<UCKhachHang>();
            foreach (DataRow row in table.Rows)
            {
                string anh = row["HinhAnh"]?.ToString() ?? "";
                string ten = row["HoTen"]?.ToString() ?? "";
                string cmnd = row["Cmnd"]?.ToString() ?? "";

                string diaChi = row["DiaChi"]?.ToString() ?? "";
                string dienThoai = row["DienThoai"]?.ToString() ?? "";
                string phongID = row["PhongID"]?.ToString() ?? "";

                UCKhachHang uCKhachHang = new UCKhachHang(anh, ten, cmnd, diaChi, dienThoai, phongID);
                pnl.Controls.Add(uCKhachHang);
            }
        }
        
    }
}
