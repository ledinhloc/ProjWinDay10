using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTW.DTO
{
    public class NguoiDung
    {
        private string nguoidungid;
        private string hoten;
        private string cmnd;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private string dienthoai;
        private string email;
        private string tendangnhap;
        private string matkhau;
        private string hinhanh;
        private string khachsanid;

        public NguoiDung(string nguoidungid)
        {
            this.nguoidungid = nguoidungid;
        }

        public NguoiDung(string nguoidungid, string hoten, string cmnd, DateTime ngaysinh, string gioitinh, string diachi, string dienthoai, 
            string email, string tendangnhap, string matkhau, string hinhanh, string khachsanid)
        {
            this.Nguoidungid = nguoidungid;
            this.Hoten = hoten;
            this.Cmnd = cmnd;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Dienthoai = dienthoai;
            this.Email = email;
            this.Tendangnhap = tendangnhap;
            this.Matkhau = matkhau;
            this.Hinhanh = hinhanh;
            this.Khachsanid = khachsanid;
        }

        public string Nguoidungid { get => nguoidungid; set => nguoidungid = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Email { get => email; set => email = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Khachsanid { get => khachsanid; set => khachsanid = value; }

        public bool ktraThongTin()
        {
            if (string.IsNullOrEmpty(Hoten) || string.IsNullOrEmpty(Cmnd) || string.IsNullOrEmpty(Gioitinh) || string.IsNullOrEmpty(Dienthoai)
                || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Một số thông tin chưa được cập nhật đủ !");
            }
            else
            {
                if (!Regex.IsMatch(Dienthoai, @"^\d{3}-\d{4}-\d{3}$"))
                    MessageBox.Show("Số điện thoại không hợp lệ !");
                else
                        if (!Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                    MessageBox.Show("Email không hợp lệ !");
                else
                    return true;
            }
            return false;
        }
    }
}
