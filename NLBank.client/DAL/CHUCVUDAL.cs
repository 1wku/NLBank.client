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
    public class ChucVuDAL
    {
        public static ChucVuDTO GetChucVu(int id)
        {
            DataTable result = Connection.Instance.ExcuteQuery("select * from CHUCVU where MaCV="+ id);
            foreach (DataRow dr in result.Rows)
            {
                return new ChucVuDTO((int)dr["MaCV"], (string)dr["TenCV"], (decimal)dr["HSLuong"]);

            }
            return new ChucVuDTO(); 
        }

    }
}
