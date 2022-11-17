using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            DataTable data = Connection.Instance.ExcuteQuery($"select * from f_GetKHByEmail('{email}')");
            foreach (DataRow item in data.Rows)
            {
                KHDTO khachHang = new KHDTO(item);
                return khachHang;
            }
            return null;
        }

        public static NhanvienDTO GetNhanVienByEmail(string email)
        {
            DataTable data = Connection.Instance.ExcuteQuery($"select * from f_GetNVByEmail('{email}')");
            foreach (DataRow item in data.Rows)
            {
                NhanvienDTO khachHang = new NhanvienDTO(item);
                return khachHang;
            }
            return null;
        }
        public static int ChangePassword(string email, string oldpassword, string newpassword)
        {
           return (int) Connection.Instance.ExcuteQuery($"DECLARE @result int\r\n\r\nEXEC sp_DoiMatKhau \r\n\t'{email}', \r\n\t'{oldpassword}', \r\n\t'{newpassword}', \r\n\t@result OUTPUT\r\n\r\nSELECT @result\r\n").Rows[0][0];
           

        }
    }
}
