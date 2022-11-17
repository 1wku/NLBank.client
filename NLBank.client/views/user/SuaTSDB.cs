using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLBank.client.BUS;
using NLBank.client.DTO;
using System.Data.SqlClient;

namespace NLBank.client.views.user
{
    public partial class SuaTSDB : MaterialForm
    {
        TSDBDTO ts = new TSDBDTO();
        KHDTO kh = new KHDTO();
        public SuaTSDB(TSDBDTO ts, KHDTO kh)
        {
            this.ts = ts;
            this.kh = kh;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            TSDBDTO tsdb = new TSDBDTO (ts.MaTSDB, int.Parse(cbx_loai.SelectedValue.ToString()), txt_ten.Text, kh.MaKH,
                int.Parse(cbx_giatri.SelectedValue.ToString()), cbx_hinhthuc.SelectedValue.ToString());
            TSDBBUS.SuaTSDB(tsdb);
            this.Close();
        }

        private void SuaTSDB_Load(object sender, EventArgs e)
        {
            txt_ten.Text = ts.TenTSDB;
            cbx_hinhthuc.DataSource = TSDBBUS.GetHinhThucDB();
            cbx_hinhthuc.DisplayMember = "HinhThuc";
            cbx_hinhthuc.ValueMember = "MaHinhThuc";

            cbx_loai.DataSource = TSDBBUS.GetLoaiTSDB();
            cbx_loai.DisplayMember = "TenLoaiTSDB";
            cbx_loai.ValueMember = "MaLoaiTSDB";

            cbx_giatri.DataSource = TSDBBUS.GetTriGiaTS();
            cbx_giatri.DisplayMember = "TriGia";
            cbx_giatri.ValueMember = "MaTriGia";
        }
    }
}
