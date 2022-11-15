using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAL
{
    public class ChucVuDAL
    {
        public static Boolean CheckOverTimeHDTD(int id)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("select dbo.f_LaHDTDQuaHan('" + id + "')", Conn);

            Conn.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                // Đọc từng dòng tập kết quả
                while (reader.Read())
                {
                    var data = reader.GetInt32(0);
                    if (data == 0) return false;
                    else return true;

                }
            }
            else
            {
                Console.WriteLine("Không có dữ liệu trả về");
                return true;
            }
            Conn.Close();
            return true;
        }

    }
}
