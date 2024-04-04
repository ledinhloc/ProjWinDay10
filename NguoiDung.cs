using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace DoAnLTW
{
    public class NguoiDung
    {
        private string nguoiDungID;
        private string hoTen;
        private string cmnd;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string diaChi;
        private string dienThoai;
        private string email;
        private string tenDangNhap;
        private string matKhau;
        private string khachSanID;
        public NguoiDung()
        {

        }

        public NguoiDung(string id, string ten, string cmnd, DateTime ngaySinh, bool gioiTinh, string dc, string dienThoai, string email, string tendn, string mk, string khachSanid)
        {
            this.NguoiDungID = id;
            this.HoTen = ten;
            this.Cmnd = cmnd;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = dc;
            this.DienThoai = dienThoai;
            this.Email = email;
            this.TenDangNhap = tendn;
            this.matKhau = mk;
            this.KhachSanID = khachSanid;
        }
        public string NguoiDungID { get => nguoiDungID; set => nguoiDungID = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string KhachSanID { get => khachSanID; set => khachSanID = value; }
    }
}
