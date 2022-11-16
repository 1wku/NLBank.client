using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAL
{
    class CommonDAL
    {
        public static DataTable getLoaiTS()
        {
            String sql = "SELECT * FROM LOAITSDB";
            return Connection.Instance.ExcuteQuery(sql);
        }
        public static DataTable getChinhNhanh()
        {
            String sql = "SELECT Chi_nhanh ,Dia_chi FROM CHINHANH";
            return Connection.Instance.ExcuteQuery(sql);
        }

    }
}
