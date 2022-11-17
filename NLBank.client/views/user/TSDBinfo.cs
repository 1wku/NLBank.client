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
    public partial class TSDBinfo : MaterialForm
    {


        TSDBDTO ts = new TSDBDTO(); 
        public TSDBinfo(TSDBDTO ts)
        {
            this.ts = ts; 
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ThamdinhTSDB_Load(object sender, EventArgs e)
        {
            lb_ten.Text = ts.TenTSDB; 
            lb_hinhthuc.Text = ts.HinhThucDB;
            lb_makh.Text = ts.MaKH.ToString();
            txt_trigia.Text = ts.TriGiaTS.ToString();
            foreach (DataRow row in TSDBBUS.GetLoaiTSDB().Rows)
            {
                if((int)row["MaLoaiTSDB"] == ts.MaLoaiTSDB)
                {
                    txt_loai.Text = (String)row["TenLoaiTSDB"];
                    break;
                }
            }
        }

       
    }
}
