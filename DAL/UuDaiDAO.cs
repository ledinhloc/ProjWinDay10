using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnLTW.DTO;

namespace DoAnLTW.DAL
{
    public class UuDaiDAO : DbConnection
    {
        public bool Them(UuDai ud)
        {
            string SQL = string.Format("INSERT INTO UuDai(KhachSanID, MaUuDai, PhanTram, HSD) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}')"
                    , ud.KhachSanID, ud.MaUuDai, ud.PhanTram, ud.HSD);
            return ThucThi(SQL);
        }
        public bool Sua(UuDai ud)
        {
            string SQL = string.Format("UPDATE UuDai SET KhachSanID = '{0}', PhanTram = {1}, HSD = {2} " +
                "WHERE MaUuDai = '{3}'", ud.KhachSanID, ud.PhanTram, ud.HSD, ud.MaUuDai);
            return ThucThi(SQL);
        }
        public bool Xoa(string maUD)
        {
            string SQL = string.Format("DELETE FROM UuDai WHERE MaUuDai = '{0}'", maUD);
            return ThucThi(SQL);
        }
        public List<UuDai> LayUDTheoKS(string idKS)
        {
            OpenConnection();
            string query = "SELECT KhachSanID, MaUuDai, PhanTram, HSD FROM UuDai WHERE KhachSanID = @Id";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Id", idKS);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<UuDai> results = new List<UuDai>();

                    while (reader.Read())
                    {
                        UuDai ud = new UuDai(reader.GetString(0), reader.GetString(1),
                            reader.GetDecimal(2), reader.GetInt32(3));
                        results.Add(ud);
                    }
                    CloseConnection();
                    return results;
                }
            }
        }
    }
}
