using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnLTW.DTO;
using DoAnLTW.DAL;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace DoAnLTW.DAL
{
    public class DatPhongDAO : DbConnection
    {
        public bool DatPhong(DatPhong dp)
        {
            string SQL = string.Format("INSERT INTO DatPhong(DatPhongID , KhachSanID, PhongID, NguoiDungID, NgayDat, NgayTra, TrangThai, HinhThucThanhToan, Gia) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', N'{6}', N'{7}', {8})"
                    , dp.DatPhongID, dp.KhachSanID, dp.PhongID, dp.NguoiDungID, dp.NgayDat, dp.NgayTra, dp.TrangThai, dp.HinhThucThanhToan, dp.Gia);
            return ThucThi(SQL);
        }
        public bool Sua(DatPhong dp)
        {
            string SQL = string.Format("UPDATE DatPhong SET NgayDat = '{0}', NgayTra ='{1}' , HinhThucThanhToan = N'{2}' " +
                "WHERE DatPhongID = '{3}'", dp.NgayDat, dp.NgayTra, dp.HinhThucThanhToan, BienDungChung.idDatPhong.DatPhongID);
            return ThucThi(SQL);
        }
        public bool Xoa()
        {
            string SQL = string.Format("DELETE FROM DatPhong WHERE DatPhongID = '{0}'", BienDungChung.idDatPhong.DatPhongID);
            return ThucThi(SQL);
        }
        public List<DatPhong> TimPhongDat(string key)
        {
            OpenConnection();
            List<DatPhong> list = new List<DatPhong>();
            string query = "SELECT * FROM DatPhong Where DatPhongID LIKE @DatPhongID";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@DatPhongID", key + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DatPhong dp = new DatPhong(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4),
                            reader.GetDateTime(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8));
                    list.Add(dp);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            CloseConnection();
            return list;
        }
        public List<DatPhong> LayThongTinChung()
        {
            OpenConnection();
            string query = "SELECT DatPhongID, KhachSanID, PhongID, NguoiDungID, NgayDat, NgayTra, TrangThai, HinhThucThanhToan, Gia FROM DatPhong";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<DatPhong> results = new List<DatPhong>();

                    while (reader.Read())
                    {
                        DatPhong dp = new DatPhong(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4),
                            reader.GetDateTime(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8));
                        results.Add(dp);
                    }
                    CloseConnection();
                    return results;
                }
            }
        }
        public DatPhong LayThongTinRieng(string idDP)
        {
            OpenConnection();
            DatPhong dp = null;
            string query = "SELECT DatPhongID, KhachSanID, PhongID, NguoiDungID, NgayDat, NgayTra, " +
                "TrangThai, HinhThucThanhToan, Gia FROM DatPhong WHERE DatPhongID = @Id";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Id", idDP);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dp = new DatPhong(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4),
                            reader.GetDateTime(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8));
                    }
                    CloseConnection();
                    return dp;
                }
            }
        }
        public List<DatPhong> LayDonDatTheoNgay(DateTime ngayDat, DateTime ngayTra)
        {
            OpenConnection();
            string query = "SELECT DatPhongID, KhachSanID, PhongID, NguoiDungID, NgayDat, NgayTra, TrangThai, HinhThucThanhToan, Gia " +
                "FROM DatPhong " +
                "WHERE ((NgayDat > @nTra) OR (NgayTra < @nDat)) ";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@nTra", ngayTra);
                command.Parameters.AddWithValue("@nDat", ngayDat);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<DatPhong> results = new List<DatPhong>();
                    while (reader.Read())
                    {
                        DatPhong dp = new DatPhong(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4),
                            reader.GetDateTime(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8));
                        results.Add(dp);
                    }
                    CloseConnection();
                    return results;
                }
            }
        }
        public void CapNhatTrangThai(string idDat, string trangThaiMoi)
        {
            OpenConnection();
            string query = "UPDATE DatPhong SET TrangThai = @trangThaiMoi WHERE DatPhongID = @idDat";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@trangThaiMoi", trangThaiMoi);
                command.Parameters.AddWithValue("@idDat", idDat);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }
}
