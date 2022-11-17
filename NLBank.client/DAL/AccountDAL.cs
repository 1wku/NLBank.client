using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NLBank.client.DAL
{
    public class AccountDAL
    {
        public static int login(string email, string password)
        {
            return (int)Connection.Instance.ExecuteScalar($"select dbo.f_login_getRoleID('{email}', '{password}')");
        }

        public static KHDTO GetKhachHangByEmail(string email)
        {
            KHDTO khdto = new KHDTO();
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand($"select * from f_GetKHByEmail('{email}') ", Conn);

            Conn.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    khdto.Dia_chi = reader["Dia_chi"].ToString(); 
                    khdto.Email = reader["Email"].ToString(); 
                    khdto.Ten = reader["Ten"].ToString(); 
                    khdto.Sdt = reader["Sdt"].ToString();
                    khdto.RoleID = Int32.Parse(reader["RoleID"].ToString());  
                }
            }
            
            Conn.Close();
            return khdto; 

        }

        public static NhanvienDTO GetNhanVienByEmail(string email)
        {
            NhanvienDTO nv = new NhanvienDTO();
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand($" select * from f_GetNVByEmail('{email}') ", Conn);

            Conn.Open();
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    nv.Dia_chi = reader["Dia_chi"].ToString();
                    nv.Email = reader["Email"].ToString();
                    nv.Ten = reader["Ten"].ToString();
                    nv.Sdt = reader["Sdt"].ToString();
                    nv.MaCV = Int32.Parse(reader["MaCV"].ToString());
                    nv.CCCD = reader["CCCD"].ToString(); 
                }
            }

            Conn.Close();
            return nv;

        }
        public static int ChangePassword(string email, string oldpassword, string newpassword)
        {
           return (int) Connection.Instance.ExcuteQuery($"DECLARE @result int\r\n\r\nEXEC sp_DoiMatKhau \r\n\t'{email}', \r\n\t'{oldpassword}', \r\n\t'{newpassword}', \r\n\t@result OUTPUT\r\n\r\nSELECT @result\r\n").Rows[0][0];
           

        }
    }
}
