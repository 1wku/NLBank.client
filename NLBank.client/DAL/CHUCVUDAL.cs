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
    public class CHUCVUDAL
    {
        public static void ThemCV(CHUCVUDTO cv)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_themChucVu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaCV", SqlDbType.Char);
            command.Parameters.Add("@TenCV", SqlDbType.NVarChar);
            command.Parameters.Add("@HSLuong", SqlDbType.Decimal);

            command.Parameters["@MaCV"].Value = cv.MaCV;
            command.Parameters["@TenCV"].Value = cv.TenCV;
            command.Parameters["@HSLuong"].Value = cv.HSLuong;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void SuaCV(CHUCVUDTO cv)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_suaChucVu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaCV", SqlDbType.Char);
            command.Parameters.Add("@TenCV", SqlDbType.NVarChar);
            command.Parameters.Add("@HSLuong", SqlDbType.Decimal);

            command.Parameters["@MaCV"].Value = cv.MaCV;
            command.Parameters["@TenCV"].Value = cv.TenCV;
            command.Parameters["@HSLuong"].Value = cv.HSLuong;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaCV(CHUCVUDTO cv)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("proc_xoaChucVu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaCV", SqlDbType.Char);
            
            command.Parameters["@MaCV"].Value = cv.MaCV;
            
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

    }
}
