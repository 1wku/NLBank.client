using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLBank.client.views.user
{
    public partial class ThanhToan : MaterialForm 
    {
        String totaldn, totalnn;
        public ThanhToan(String totaldn, String totalnn)
        {
            this.totaldn = totaldn;
            this.totalnn = totalnn;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            lb_duno.Text = totaldn;
            lb_ttn.Text = totalnn;
            dg_chinhanh.DataSource = CommonBUS.GetChiNhanh();
        }
    }
}
