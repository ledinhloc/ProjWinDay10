using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnLTW.DTO;

namespace DoAnLTW.DAL
{
    public class KhachSanDAO : DbConnection
    {
        public DataTable layThongTinNguoi(string KhachSanID)
        {
            string sqlStr = $"select  NguoiDung.HinhAnh, NguoiDung.HoTen,NguoiDung.Cmnd , NguoiDung.DiaChi, NguoiDung.DienThoai, DatPhong.PhongID from DatPhong inner join NguoiDung on DatPhong.NguoiDungID = NguoiDung.NguoiDungID where DatPhong.KhachSanID = '{KhachSanID}'";

            return Load(sqlStr);
        }
        public bool ThemKhachSanID(string id)
        {
            string sql = $"insert into KhachSan(KhachSanID) VALUES ('{id}')";
            return ThucThi(sql);
        }
        public KhachSan LayThongTinRieng(string idKS)
        {
            OpenConnection();
            KhachSan ks = null;
            string query = "SELECT KhachSanID, TenKhachSan, DiaChi, TongQuan, Sao, TienNghi, HinhAnh, HinhThucThanhToan, Loai, Tinh FROM KhachSan WHERE KhachSanID = @Id";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Id", idKS);              
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ks = new KhachSan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), 
                            reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9));                                        
                    }
                }
            }
            CloseConnection();
            return ks;
        }
        public string LayIDTiepTheo()
        {
            OpenConnection();
            string sqlStr = "SELECT TOP 1 KhachSanID FROM KhachSan ORDER BY KhachSanID DESC";
            SqlCommand command = new SqlCommand(sqlStr, conn);
            object result = command.ExecuteScalar();
            int idTiep = 0;
            if (result != null)
            {
                int id = Convert.ToInt32(result.ToString().Substring(2));
                idTiep = id + 1;
            }
            CloseConnection();
            return "KS" + idTiep.ToString();
        }
        public KhachSan LayThongTinTheoTinh(string tinh)
        {
            OpenConnection();
            KhachSan ks = null;
            string query = "SELECT KhachSanID, TenKhachSan, DiaChi, TongQuan, Sao, TienNghi, HinhAnh, HinhThucThanhToan, Loai, Tinh FROM KhachSan WHERE Tinh = @Tinh";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Tinh", tinh);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ks = new KhachSan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9));
                    }
                }
            }
            CloseConnection();
            return ks;
        }

        public List<KhachSan> LayThongTinChung()
        {
            OpenConnection();
            string query = "SELECT KhachSanID, TenKhachSan, DiaChi, TongQuan, Sao, TienNghi, HinhAnh, HinhThucThanhToan, Loai, Tinh FROM KhachSan";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<KhachSan> results = new List<KhachSan>();

                    while (reader.Read())
                    {
                        KhachSan ks = new KhachSan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9));
                        results.Add(ks);
                    }
                    CloseConnection();
                    return results;
                }
            }
        }
        public List<KhachSan> TimKS(string key)
        {
            OpenConnection();
            List<KhachSan> list = new List<KhachSan>();
            string query = "SELECT * FROM KhachSan Where TenKhachSan LIKE @TenKhachSan";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@TenKhachSan", key + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    KhachSan ks = new KhachSan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9));
                    list.Add(ks);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            CloseConnection();
            return list;
        }
        public List<KhachSan> LayPhongChuaDuocDat()
        {
            OpenConnection();
            string query = "SELECT ks.KhachSanID, ks.TenKhachSan, ks.DiaChi, ks.TongQuan, ks.Sao, ks.TienNghi, ks.HinhAnh, ks.HinhThucThanhToan, ks.Loai, ks.Tinh " +
        "FROM KhachSan ks LEFT JOIN DatPhong dp ON ks.KhachSanID = dp.KhachSanID WHERE dp.KhachSanID IS NULL";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<KhachSan> results = new List<KhachSan>();

                    while (reader.Read())
                    {
                        KhachSan ks = new KhachSan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9));
                        results.Add(ks);
                    }
                    CloseConnection();
                    return results;
                }
            }
        }
        public bool CapNhat(KhachSan KhachSanNew)
        {
            string SQL = $"UPDATE KHACHSAN SET TenKhachSan=N'{KhachSanNew.TenKhachSan}', DiaChi=N'{KhachSanNew.DiaChi}', TongQuan=N'{KhachSanNew.TongQuan}', Sao={KhachSanNew.Sao}, " +
                $"TienNghi=N'{KhachSanNew.TienNghi}', HinhAnh='{KhachSanNew.HinhAnh}', HinhThucThanhToan=N'{KhachSanNew.HinhThucThanhToan}', Loai='{KhachSanNew.Loai}' WHERE KhachSanID='{KhachSanNew.KhachSanID}'";
            return ThucThi(SQL);
        }
        public void Them(KhachSan ks)
        {
            string sqlStr = string.Format("INSERT INTO KhachSan (KhachSanID, TenKhachSan, DiaChi, TongQuan, Sao, TienNghi, HinhAnh, HinhThucThanhToan, Loai, Tinh) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}')",
                ks.KhachSanID, ks.TenKhachSan, ks.DiaChi, ks.TongQuan, ks.Sao, ks.TienNghi, ks.HinhAnh, ks.HinhThucThanhToan, ks.Loai, ks.Tinh);
            ThucThi(sqlStr);
        }
    }
}
