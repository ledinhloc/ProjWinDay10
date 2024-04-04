using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DoAnLTW.DTO;

namespace DoAnLTW.DAL
{
    public class PhongDAO : DbConnection
    {
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        public List<Phong> LayThongTinChung()
        {
            OpenConnection();
            string query = "SELECT PhongID, KhachSanID, ThongTinChung, PhanLoai, TienNghi, Gia, " +
                "DienTich, NguoiLon, TreEm, GiuongLon, GiuongNho, DSHinhAnh, SoPhong FROM Phong";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Phong> results = new List<Phong>();

                    while (reader.Read())
                    {
                        Phong phong = new Phong(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetString(4), reader.GetInt32(5), reader.GetDecimal(6), reader.GetInt32(7), reader.GetInt32(8),
                            reader.GetInt32(9), reader.GetInt32(10), reader.GetString(11), reader.GetInt32(12));
                        results.Add(phong);
                    }
                    CloseConnection();
                    return results;
                }
            }
        }
        public Phong LayThongTinRieng(string idPhong)
        {
            OpenConnection();
            Phong p = null;
            string query = "SELECT PhongID, KhachSanID, ThongTinChung, PhanLoai, TienNghi, Gia, " +
                "DienTich, NguoiLon, TreEm, GiuongLon, GiuongNho, DSHinhAnh, SoPhong FROM Phong WHERE PhongID = @Id";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Id", idPhong);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        p = new Phong(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetString(4), reader.GetInt32(5), reader.GetDecimal(6), reader.GetInt32(7), reader.GetInt32(8),
                            reader.GetInt32(9), reader.GetInt32(10), reader.GetString(11), reader.GetInt32(12));
                    }
                    CloseConnection();
                    return p;
                }
            }
        }
        public int[] LayMinMaxGia(string idKS)
        {
            int[] giatriMinMax = new int[2];
            OpenConnection();
            string query = "SELECT Gia FROM Phong Where KhachSanID = @Id";
            List<int> listGia = new List<int>();

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Id", idKS);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listGia.Add(reader.GetInt32(0));
                    }
                }
            }
            listGia.Sort();
            giatriMinMax[0] = listGia[0];
            giatriMinMax[1] = listGia[listGia.Count - 1];
            CloseConnection();
            return giatriMinMax;
        }
        public List<Phong> LayPhongTheoSoGiuong(int soGiuong)
        {
            OpenConnection();
            string query = "SELECT PhongID, KhachSanID, ThongTinChung, PhanLoai, TienNghi, Gia, " +
                "DienTich, NguoiLon, TreEm, GiuongLon, GiuongNho, DSHinhAnh, SoPhong FROM Phong " +
                "WHERE (GiuongLon * 2 + GiuongNho) >= @soGiuong";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@soGiuong", soGiuong);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Phong> results = new List<Phong>();

                    while (reader.Read())
                    {
                        Phong phong = new Phong(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetString(4), reader.GetInt32(5), reader.GetDecimal(6), reader.GetInt32(7), reader.GetInt32(8),
                            reader.GetInt32(9), reader.GetInt32(10), reader.GetString(11), reader.GetInt32(12));
                        results.Add(phong);
                    }
                    CloseConnection();
                    return results;
                }
            }
        }
        public bool Them(Phong ps)
        {
            string sqlStr = string.Format("INSERT INTO PHONG(PhongID, KhachSanID, ThongTinChung, PhanLoai, TienNghi, Gia, DienTich, NguoiLon, TreEm, GiuongLon, GiuongNho, DSHinhAnh, SoPhong) VALUES('{0}','{1}',N'{2}',N'{3}',N'{4}',{5},{6},{7},{8},{9},{10},'{11}', {12})",
                ps.PhongID, ps.KhachSanID, ps.ThongTinChung, ps.PhanLoai, ps.TienNghi, ps.Gia, ps.DienTich, ps.NguoiLon, ps.TreEm, ps.GiuongLon, ps.GiuongNho, ps.DSHinhAnh, ps.SoPhong);
            return ThucThi(sqlStr);
        }
        public bool Xoa(string idPhong)
        {
            string sqlStr = string.Format("DELETE FROM PHONG WHERE PhongID = '{0}'", idPhong);
            return ThucThi(sqlStr);
        }
        public bool CapNhat(Phong PhongNew)
        {
            string SQL = string.Format("UPDATE PHONG SET ThongTinChung = '{0}', PhanLoai ='{1}' , TienNghi ='{2}', " +
                "Gia = '{3}', DienTich ='{4}' , NguoiLon ='{5}', TreEm ='{6}', GiuongLon ='{7}', GiuongNho = '{8}', DSHinhAnh = '{9}', SoPhong = '{10}'" +
                   "WHERE PhongID = '{11}'", PhongNew.ThongTinChung, PhongNew.PhanLoai, PhongNew.TienNghi, PhongNew.Gia, PhongNew.DienTich, 
                   PhongNew.NguoiLon, PhongNew.TreEm, PhongNew.GiuongLon, PhongNew.GiuongNho, PhongNew.DSHinhAnh, PhongNew.SoPhong, PhongNew.PhongID);
            return ThucThi(SQL);
        }
        public void CapNhatGiamSoPhong(string idPhong)
        {
            OpenConnection();
            string query = "UPDATE Phong SET SoPhong = SoPhong - 1 WHERE PhongID = @idPhong";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@idPhong", idPhong);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
        public void CapNhatTangSoPhong(string idPhong)
        {
            OpenConnection();
            string query = "UPDATE Phong SET SoPhong = SoPhong + 1 WHERE PhongID = @idPhong";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@idPhong", idPhong);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }
}
