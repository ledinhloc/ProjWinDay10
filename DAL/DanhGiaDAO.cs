using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnLTW.DTO;

namespace DoAnLTW.DAL
{
    public class DanhGiaDAO : DbConnection
    {
        public bool DanhGia(DanhGia dg)
        {
            string SQL = string.Format("INSERT INTO DanhGia(DanhGiaID , KhachSanID, PhongID, NguoiDungID, Sao, NoiDung, Ngay) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', N'{5}', N'{6}')"
                    , dg.DanhGiaID, dg.KhachSanID, dg.PhongID, dg.NguoiDungID, dg.Sao, dg.NoiDung, dg.Ngay);
            return ThucThi(SQL);
        }
        public List<DanhGia> LayThongTinTheoIDKS(string idKS)
        {
            OpenConnection();
            string query = "SELECT DanhGiaID , KhachSanID, PhongID, NguoiDungID, Sao, NoiDung, Ngay FROM DanhGia Where KhachSanID = @Id";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Id", idKS);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<DanhGia> results = new List<DanhGia>();

                    while (reader.Read())
                    {
                        DanhGia dg = new DanhGia(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetInt32(4), reader.GetString(5), reader.GetDateTime(6));
                        results.Add(dg);
                    }
                    CloseConnection();
                    return results;
                }
            }
        }
    }
}
