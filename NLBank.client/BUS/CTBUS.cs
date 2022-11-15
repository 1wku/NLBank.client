using NLBank.client.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.BUS
{
    class CTBUS
    {
        public static DataTable getListGN(int makh)
        {
            return CTGNDAL.GetListGN(makh);
        }
        public static DataTable getListNN(int makh)
        {
            return CTNNDAL.GetListNN(makh);
        }
        public static DataTable getListTN(int makh)
        {
            return CTTNDAL.GetListTN(makh);
        }
    }
}
