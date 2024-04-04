using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTW.DTO
{
    public class Phong
    {
        private string phongID;
        private string khachSanID;
        private string thongTinChung;
        private string phanLoai;
        private string tienNghi;
        private int gia;
        private decimal dienTich;
        private int nguoiLon;
        private int treEm;
        private int giuongLon;
        private int giuongNho;
        private string dSHinhAnh;
        private int soPhong;

        public Phong(string phongID)
        {
            this.PhongID = phongID;
        }

        public Phong(string phongID, string khachSanID, string thongTinChung, string phanLoai, string tienNghi, int gia, decimal dienTich, int nguoiLon, 
            int treEm, int giuongLon, int giuongNho, string dSHinhAnh, int soPhong)
        {
            this.phongID = phongID;
            this.khachSanID = khachSanID;
            this.thongTinChung = thongTinChung;
            this.phanLoai = phanLoai;
            this.tienNghi = tienNghi;
            this.gia = gia;
            this.dienTich = dienTich;
            this.nguoiLon = nguoiLon;
            this.treEm = treEm;
            this.giuongLon = giuongLon;
            this.giuongNho = giuongNho;
            this.dSHinhAnh = dSHinhAnh;
            this.soPhong = soPhong;
        }

        public string PhongID { get => phongID; set => phongID = value; }
        public string KhachSanID { get => khachSanID; set => khachSanID = value; }
        public string ThongTinChung { get => thongTinChung; set => thongTinChung = value; }
        public string PhanLoai { get => phanLoai; set => phanLoai = value; }
        public string TienNghi { get => tienNghi; set => tienNghi = value; }
        public int Gia { get => gia; set => gia = value; }
        public int NguoiLon { get => nguoiLon; set => nguoiLon = value; }
        public int TreEm { get => treEm; set => treEm = value; }
        public int GiuongLon { get => giuongLon; set => giuongLon = value; }
        public int GiuongNho { get => giuongNho; set => giuongNho = value; }
        public decimal DienTich { get => dienTich; set => dienTich = value; }
        public string DSHinhAnh { get => dSHinhAnh; set => dSHinhAnh = value; }
        public int SoPhong { get => soPhong; set => soPhong = value; }
    }
}
