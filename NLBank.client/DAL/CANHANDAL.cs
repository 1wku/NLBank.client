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
    class CANHANDAL
    {
        public static CANHANDTO GetCaNhan(int MaKH) {
            DataTable data = Connection.Instance.ExcuteQuery($"Select * FROM f_LayCaNhan({MaKH})");
            foreach (DataRow item in data.Rows) { 
                return new CANHANDTO(item);
            }
            return null;
        }
        public static Boolean SuaCaNhan(CANHANDTO canhan)
        {
            try
            {
                SqlConnection Conn = Connection.KetNoi();
                SqlCommand command = new SqlCommand("sp_SuaCaNhan", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaKH", SqlDbType.Int);
                command.Parameters.Add("@NgaySinh", SqlDbType.Date);
                command.Parameters.Add("@CCCD", SqlDbType.Char);
                command.Parameters.Add("@FICO_score", SqlDbType.Int);
                command.Parameters["@MaKH"].Value = canhan.MaKH;
                command.Parameters["@NgaySinh"].Value = canhan.NgaySinh;
                command.Parameters["@CCCD"].Value = canhan.CCCD;
                command.Parameters["@FICO_score"].Value = canhan.FICO_score;

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
