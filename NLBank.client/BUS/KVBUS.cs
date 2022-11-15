using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLBank.client.DAL;
using NLBank.client.DTO;
namespace NLBank.client.BUS
{
    class KVBUS
    {
        public static DataTable GetLoaiKV()
        {
            return KhoanVayDAL.GetLoaiKV();
        }
        public static DataTable GetLoaiTien()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("LoaiTien");
            dt.Columns.Add("MaloaiTien");
            DataRow row1 = dt.NewRow();
            row1["LoaiTien"] = "VNĐ";
            row1["MaloaiTien"] = "VND";
            dt.Rows.Add(row1);
            DataRow row2 = dt.NewRow();
            row2["LoaiTien"] = "USD";
            row2["MaloaiTien"] = "USD";
            dt.Rows.Add(row2);
            DataRow row3 = dt.NewRow();
            row3["LoaiTien"] = "UER";
            row3["MaloaiTien"] = "UER";
            dt.Rows.Add(row3);

            return dt;
        }
        public static DataTable GetListTSDB(int makh)
        {
            return TSDBBUS.GetListTSDB(makh);
        }

        

        public static void ThemKV(KhoanVayDTO kv)
        {
            KhoanVayDAL.ThemKhoanVay(kv);
        }
    }
}
