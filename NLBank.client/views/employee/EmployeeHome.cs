using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.components;
using NLBank.client.DAL;
using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLBank.client.views.employee
{
    public partial class EmployeeHome : MaterialForm
    {
        List<KhoanVayDTO> ds_khoanvay = new List<KhoanVayDTO>();
        DataTable hdtd_data;
        DataTable tsdb_data; 
        public EmployeeHome()
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
           
           
        }

        void updateViewHDTD(DataTable hdtd_data)
        {
            var hdtd_value = new HDTDDTO();
            var kh_value = new KHDTO();
            var tsdb_value = new TSDBDTO();
            foreach (DataRow row in hdtd_data.Rows)
            {
                Console.WriteLine(row.ToString());
                kh_value.Ten = (string)row["Ten"];
                kh_value.MaKH = (string)row["MaKH"];
                hdtd_value.SoHDTD = (string)row["SoHDTD"];
                hdtd_value.Muc_dich = (string)row["Muc_dich"];
                hdtd_value.LaiQuaHan = (decimal)row["LaiQuaHan"];
                hdtd_value.LaiSuat = (decimal)row["LaiSuat"];
                hdtd_value.ThoiHanVay = (int)row["ThoiHanVay"];
                hdtd_value.PhuongThucTra = (string)row["PhuongThucTra"];
                hdtd_value.MucPhi = (int)row["MucPhi"];
                hdtd_value.TGGiaiNgan = (DateTime)row["TGGiaiNgan"];
                hdtd_value.NgayKi = (DateTime)row["NgayKi"];
                hdtd_value.SoTienVay = (int)row["SoTienVay"];

                tsdb_value.MaLoaiTSDB = (string)row["TenLoaiTSDB"];
                tsdb_value.TenTSDB = (string)row["TenTSDB"];
                tsdb_value.TriGiaTS = row["TrigiaTS"] != DBNull.Value ? (int)row["TrigiaTS"] : 0;
                tsdb_value.HinhThucDB = row["HinhThucDB"] != DBNull.Value ? (string)row["HinhThucDB"] : "Chưa cập nhập";

                all_hdtd_panel.Controls.Add(new HdtdItem(hdtd_value, tsdb_value, kh_value));

            }
        }
        void updateViewTSDB(DataTable tsdb_data)
        {
            foreach (DataRow row in tsdb_data.Rows)
            {
                Console.WriteLine(row["TriGiaTS"]);

                tsdb_panel.Controls.Add(new TsdbItem(new TSDBDTO(
                    (string)row["MaTSDB"],
                    (string)row["MaLoaiTSDB"],
                    (string)row["TenTSDB"],

                    (string)row["MaKH"],
                    row["TrigiaTS"] != DBNull.Value ? (int)row["TrigiaTS"] : 0,

                row["HinhThucDB"] != DBNull.Value ? (string)row["HinhThucDB"] : "Chưa cập nhập"
                    )));

            }
        }

        private void EmployeeHome_Load(object sender, EventArgs e)
        {
            ds_khoanvay = KhoanVayDAL.getAll();
            for (int i = 0; i < ds_khoanvay.Count; i++)
            {
                all_kv_panel.Controls.Add(new KhoanVayItem(ds_khoanvay[i]));
            }
            //
             hdtd_data = HDTDDAL.getView();
            updateViewHDTD(hdtd_data); 
            //
            ls_thanhtoan_gridview.DataSource = CTTNDAL.getView();
            //
             tsdb_data = TSDBDAL.getView();
            updateViewTSDB(tsdb_data); 
            
        }

        private void search_cttn_btn_Click(object sender, EventArgs e)
        {

        }

        private void search_tsdb_btn_Click(object sender, EventArgs e)
        {
          //  tsdb_data= tsdb_data.AsEnumerable()
          //.Where(row => row.Field<String>("MaLoaiTSDB") == maloaitsdb_input.Text)
          //.CopyToDataTable();
            updateViewTSDB(tsdb_data);
        }
    }
}
