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
    }
}
