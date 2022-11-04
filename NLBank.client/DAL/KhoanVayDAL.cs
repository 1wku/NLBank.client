using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAL
{
    class KhoanVayDAL
    {
        public static void ThemHoaDon(KhoanVayDTO kv)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("ThemKhoanVay", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKV", SqlDbType.Char);
            command.Parameters.Add("@MaKH", SqlDbType.Char);
            command.Parameters.Add("@MaTSDB", SqlDbType.Char);
            command.Parameters.Add("@MaLoaiKV", SqlDbType.Char);
            command.Parameters.Add("@MucDich", SqlDbType.NVarChar);
            command.Parameters.Add("@SoTienVay", SqlDbType.Int);
            command.Parameters.Add("@LoaiTien", SqlDbType.Char);
            command.Parameters["@MaKV"].Value = kv.MaKV;
            command.Parameters["@MaKH"].Value = kv.MaKH;
            command.Parameters["@MaTSDB"].Value = kv.MaTSDB;
            command.Parameters["@MaLoaiKV"].Value = kv.MaLoaiKV;
            command.Parameters["@MucDich"].Value = kv.MucDich;
            command.Parameters["@SoTienVay"].Value = kv.SoTienVay;
            command.Parameters["@LoaiTien"].Value = kv.LoaiTien;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
