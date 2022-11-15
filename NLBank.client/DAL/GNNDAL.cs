using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLBank.client.DTO;

namespace NLBank.client.DAL
{
    class GNNDAL
    {
        public static DataTable GetGNN(int makh)
        {
            string sql = "Select * from GiayNhacNo where MaKH =" + makh;
            return Connection.Instance.ExcuteQuery(sql);
        }
    }
}
