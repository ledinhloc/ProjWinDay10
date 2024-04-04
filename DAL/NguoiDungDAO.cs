using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;
using DoAnLTW.DTO;

namespace DoAnLTW.DAL
{
    public class NguoiDungDAO : DbConnection
    {
        public string LayIDTiepTheo()
        {
            OpenConnection();
            string sqlStr = "SELECT TOP 1 NguoiDungID FROM NguoiDung ORDER BY NguoiDungID DESC";
            SqlCommand command = new SqlCommand(sqlStr, conn);
            object result = command.ExecuteScalar();
            int idTiep = 0;
            if (result != null)
            {
                int id = Convert.ToInt32(result.ToString().Substring(2));
                idTiep = id + 1;
            }
            CloseConnection();
            return "ND" + idTiep.ToString();
        }
        public bool Them(NguoiDung NguoiDungNew)
        {
            if (NguoiDungNew.ktraThongTin())
            {
                OpenConnection();

                string sqlStr = "INSERT INTO NguoiDung (NguoiDungID, HoTen, Cmnd, NgaySinh, GioiTinh, DiaChi, DienThoai, Email, TenDangNhap, MatKhau, HinhAnh, KhachSanID) VALUES (@NguoiDungID, @HoTen, @Cmnd, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai, @Email, @TenDangNhap, @MatKhau, @HinhAnh, @KhachSanID)";

                SqlCommand command = new SqlCommand(sqlStr, conn);
                command.Parameters.AddWithValue("@NguoiDungID", NguoiDungNew.Nguoidungid);
                command.Parameters.AddWithValue("@HoTen", NguoiDungNew.Hoten);
                command.Parameters.AddWithValue("@Cmnd", NguoiDungNew.Cmnd);
                command.Parameters.AddWithValue("@NgaySinh", NguoiDungNew.Ngaysinh);
                command.Parameters.AddWithValue("@GioiTinh", NguoiDungNew.Gioitinh);
                command.Parameters.AddWithValue("@DiaChi", NguoiDungNew.Diachi);
                command.Parameters.AddWithValue("@DienThoai", NguoiDungNew.Dienthoai);
                command.Parameters.AddWithValue("@Email", NguoiDungNew.Email);
                command.Parameters.AddWithValue("@TenDangNhap", NguoiDungNew.Tendangnhap);
                command.Parameters.AddWithValue("@MatKhau", NguoiDungNew.Matkhau);
                command.Parameters.AddWithValue("@HinhAnh", NguoiDungNew.Hinhanh);

                // Kiểm tra và truyền giá trị KhachSanID
                if (NguoiDungNew.Khachsanid == null)
                {
                    command.Parameters.AddWithValue("@KhachSanID", DBNull.Value); // Truyền giá trị NULL
                }
                else
                {
                    command.Parameters.AddWithValue("@KhachSanID", NguoiDungNew.Khachsanid);
                }
                command.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            return false;
        }
        public void CapNhat(NguoiDung NguoiDungNew)
        {
            string sqlStr = $"UPDATE NGUOIDUNG SET HoTen=N'{NguoiDungNew.Hoten}',Cmnd ='{NguoiDungNew.Cmnd}',GioiTinh='N{NguoiDungNew.Gioitinh}',NgaySinh='{NguoiDungNew.Ngaysinh.ToString("yyyy-MM-dd")}'" +
                $",DiaChi=N'{NguoiDungNew.Diachi}',DienThoai='{NguoiDungNew.Dienthoai}',Email='{NguoiDungNew.Email}',HinhAnh='{NguoiDungNew.Hinhanh}' WHERE NguoiDungID = {NguoiDungNew.Nguoidungid}";
            ThucThi(sqlStr);
        }
        public NguoiDung LayThongTinRieng(string idNS)
        {
            OpenConnection();
            NguoiDung nd = null;
            string query = "SELECT NguoiDungID, HoTen, Cmnd, NgaySinh, GioiTinh, DiaChi, DienThoai, Email, TenDangNhap, MatKhau, HinhAnh, KhachSanID " +
                               "FROM NGUOIDUNG WHERE NguoiDungID = @Id";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Id", idNS);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nd = new NguoiDung(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3),
                            reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7),
                            reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11));
                    }
                }
                CloseConnection();
                return nd;
            }
        }

        public NguoiDung LayThongTinTheoEmail(string email)
        {
            OpenConnection();
            NguoiDung nd = null;
            string query = "SELECT NguoiDungID, HoTen, Cmnd, NgaySinh, GioiTinh, DiaChi, DienThoai, Email, TenDangNhap, MatKhau, HinhAnh, KhachSanID " +
                               "FROM NGUOIDUNG WHERE Email = @Email";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Email", email);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nd = new NguoiDung(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3),
                            reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7),
                            reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11));
                    }
                }
                CloseConnection();
                return nd;
            }
        }
    }
}
