
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
    public class KHDAL
    {
        public static DataTable getView()
        {
            String cmd = "Select * from Select * From DSKhachHang";
            SqlConnection Con = Connection.KetNoi();
            SqlCommand command = new SqlCommand(cmd, Con);
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Con.Close();
            return dt;
        }
        public static void ThemKH(KHDTO kh)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("ThemKhachHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKH", SqlDbType.Char);
            command.Parameters.Add("@Ten", SqlDbType.NVarChar);
            command.Parameters.Add("@Dia_chi", SqlDbType.NVarChar);
            command.Parameters.Add("@Email", SqlDbType.Char);
            command.Parameters.Add("@Sdt", SqlDbType.Char);

            command.Parameters["@MaKH"].Value = kh.MaKH;
            command.Parameters["@Ten"].Value = kh.Ten;
            command.Parameters["@Dia_chi"].Value = kh.Dia_chi;
            command.Parameters["@Email"].Value = kh.Email;
            command.Parameters["@Sdt"].Value = kh.Sdt;
            
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static Boolean SuaKH(KHDTO kh)
        {
            try
            {
                SqlConnection Conn = Connection.KetNoi();
                SqlCommand command = new SqlCommand("sp_SuaKhachHang", Conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@MaKH", SqlDbType.Int);
                command.Parameters.Add("@Ten", SqlDbType.NVarChar);
                command.Parameters.Add("@Dia_chi", SqlDbType.NVarChar);
                command.Parameters.Add("@Email", SqlDbType.Char);
                command.Parameters.Add("@Sdt", SqlDbType.Char);
                command.Parameters["@MaKH"].Value = kh.MaKH;
                command.Parameters["@Ten"].Value = kh.Ten;
                command.Parameters["@Dia_chi"].Value = kh.Dia_chi;
                command.Parameters["@Email"].Value = kh.Email;
                command.Parameters["@Sdt"].Value = kh.Sdt;

                Conn.Open();
                command.ExecuteNonQuery();
                Conn.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public static void XoaKH(KHDTO kh)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("XoaKhachHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKH", SqlDbType.Char);

            command.Parameters["@MaKH"].Value = kh.MaKH;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
