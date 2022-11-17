using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLBank.client.DAL;

namespace NLBank.client.BUS
{
    public class GNNBUS
    {
        public static DataTable GetGNN(int makh)
        {
            return GNNDAL.GetGNN(makh);
        }
    }
}
