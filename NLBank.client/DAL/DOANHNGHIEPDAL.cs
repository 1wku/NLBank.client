using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLBank.client.DTO;
namespace NLBank.client.DAL
{
    class DOANHNGHIEPDAL
    {
        public static DOANHNGHIEPDTO GetDoanhNghiep(int MaKH)
        {
            DataTable data = Connection.Instance.ExcuteQuery($"SELECT * FROM f_LayDoanhNghiep({MaKH})");
            foreach (DataRow item in data.Rows)
            {
                return new DOANHNGHIEPDTO(item);
            }
            return null;
        }
        public static Boolean SuaDoanhNghiep(DOANHNGHIEPDTO dn)
        {
            try
            {
                SqlConnection Conn = Connection.KetNoi();
                SqlCommand command = new SqlCommand("sp_SuaDoanhNghiep", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaKH", SqlDbType.Int);
                command.Parameters.Add("@MaDN", SqlDbType.Char);
                command.Parameters.Add("@DnB_rating", SqlDbType.Int);
                command.Parameters["@MaKH"].Value = dn.MaKH;
                command.Parameters["@MaDN"].Value = dn.MADN;
                command.Parameters["@DnB_rating"].Value = dn.DnB_rating;

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
    }
}
