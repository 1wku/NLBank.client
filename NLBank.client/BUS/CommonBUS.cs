using NLBank.client.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.BUS
{
    class CommonBUS
    {
        public static DataTable GetChiNhanh()
        {
            return CommonDAL.getChinhNhanh();
        }
    }
}
