using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLBank.client.DTO;
using NLBank.client.DAL;
using System.Data;

namespace NLBank.client.BUS
{
    class TSDBBUS
    {
        public static Boolean ThemTSDB(TSDBDTO tsdb)
        {
            return TSDBDAL.ThemTSDB(tsdb);
        }
        public static void SuaTSDB(TSDBDTO tsdb)
        {
            TSDBDAL.SuaTSDB(tsdb);
        }
        public static void XoaTSDB(int matsdb)
        {
            TSDBDAL.XoaTSDB(matsdb);
        }
        public static DataTable GetHinhThucDB()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("HinhThuc");
            dt.Columns.Add("MaHinhThuc");
            DataRow row1 = dt.NewRow();
            row1["HinhThuc"] = "Niêm Phong";
            row1["MaHinhThuc"] = "Niêm Phong";
            dt.Rows.Add(row1);
            DataRow row2 = dt.NewRow();
            row2["HinhThuc"] = "Thế Chấp";
            row2["MaHinhThuc"] = "Thế Chấp";
            dt.Rows.Add(row2);
            DataRow row3 = dt.NewRow();
            row3["HinhThuc"] = "...";
            row3["MaHinhThuc"] = "...";
            dt.Rows.Add(row3);

            return dt;
        }
        public static DataTable GetTriGiaTS()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("TriGia");
            dt.Columns.Add("MaTriGia");
            DataRow row1 = dt.NewRow();
            row1["TriGia"] = "10 triệu";
            row1["MaTriGia"] = "10000000";
            dt.Rows.Add(row1);
            DataRow row2 = dt.NewRow();
            row2["TriGia"] = "50 triệu";
            row2["MaTriGia"] = "50000000";
            dt.Rows.Add(row2);
            DataRow row3 = dt.NewRow();
            row3["TriGia"] = "100 triệu";
            row3["MaTriGia"] = "100000000";
            dt.Rows.Add(row3);
            DataRow row4 = dt.NewRow();
            row4["TriGia"] = "1 ty";
            row4["MaTriGia"] = "1000000000";
            dt.Rows.Add(row4);

            return dt;
        }
        public static DataTable GetLoaiTSDB()
        {
            return TSDBDAL.getLoaiTSDB();
        }
        public static DataTable GetListTSDB(int makh)
        {
            return TSDBDAL.GetListTSDB(makh);
        }
             public static DataTable GetListTSDBChuaSD(int makh)
        {
            return TSDBDAL.GetListTSDBChuaSD(makh);
        }

        public static DataTable GetListTSDBDaSD(int makh)
        {
            return TSDBDAL.GetListTSDBDaSD(makh);
        }
        public static DataTable GetListTSDBbyName(String searchString, int makh)
        {
            return TSDBDAL.GetListTSDBbyName(searchString, makh);
        }
        public static DataTable GetListTSDBbyLoaiTSDB(int maLoaiTSDB)
        {
            return TSDBDAL.GetListTSDBbyLoaiTSDB(maLoaiTSDB);
        }
        public static DataTable GetTSDBBySoHDTD(int sohdtd)
        {
            return TSDBDAL.getTSDBBySoHDTD(sohdtd);
        }
    }
}
