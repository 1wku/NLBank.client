using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.BUS;
using NLBank.client.DAL;
using NLBank.client.DTO;
using NLBank.client.views.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLBank.client.user.employee
{
    public partial class HDTDInfoUser : MaterialForm
    {


        HDTDDTO hdtd = new HDTDDTO(); 
        public HDTDInfoUser(HDTDDTO hdtd)
        {
            this.hdtd = hdtd; 
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ThamdinhTSDB_Load(object sender, EventArgs e)
        {
            lb_sohdtd.Text = hdtd.SoHDTD.ToString();
            lb_ngayky.Text = hdtd.NgayKi.ToString();
            lb_loaitien.Text = hdtd.LoaiTien;
            lb_laisuat.Text = hdtd.LaiSuat.ToString();
            lb_laiquahan.Text = hdtd.LaiQuaHan.ToString();
            lb_mucdich.Text = hdtd.Muc_dich.ToString();
            lb_mucphi.Text = hdtd.MucPhi.ToString();
            lb_ptgn.Text = hdtd.TGGiaiNgan.ToString();
            lb_thoihanvay.Text = hdtd.ThoiHanVay.ToString() + " ngày";
            lb_phuongthuctra.Text = hdtd.PhuongThucTra;

            DataTable kv = KVBUS.getKVBySoHDTD(hdtd.SoHDTD);
            foreach (DataRow row in kv.Rows)
            {
                lb_sotienvay.Text = (row["SoTienVay"] != DBNull.Value ? (int)row["SoTienVay"] : 0).ToString() + "VNĐ";
            }

            int maloaitsdb = 0;
            DataTable tsdb = TSDBBUS.GetTSDBBySoHDTD(hdtd.SoHDTD);
            foreach (DataRow row in tsdb.Rows)
            {
                lb_trigiatsdb.Text = (row["TrigiaTS"] != DBNull.Value ? (int)row["TrigiaTS"] : 0).ToString() + "VNĐ";
                lb_tentsdb.Text = row["TenTSDB"] != DBNull.Value ? (string)row["TenTSDB"] : "Chưa cập nhật";
                lb_hinhthucdb.Text = row["HinhThucDB"] != DBNull.Value ? (string)row["HinhThucDB"] : "Chưa cập nhật";
                maloaitsdb = (int)row["MaLoaiTSDB"];
            }

            foreach (DataRow row in TSDBBUS.GetLoaiTSDB().Rows)
            {
                if ((int)row["MaLoaiTSDB"] == maloaitsdb)
                {
                    lb_loaitsdb.Text = (String)row["TenLoaiTSDB"];
                    break;
                }
            }
        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
