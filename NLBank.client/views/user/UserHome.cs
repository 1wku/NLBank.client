using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.components;
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

namespace NLBank.client.views.user
{
    public partial class UserHome : MaterialForm
    {
        KHDTO kh = new KHDTO(); 
        public UserHome(KHDTO kHDTO)
        {
            kh = kHDTO; 
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            tabChinhSua.Controls.Add(new ChinhSuaCaNhan());

        }

        private void btn_them_khoan_vay_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ThemTSDB themTSDBForm  = new ThemTSDB();
            themTSDBForm.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            SuaTSCB suaTSDBForm  = new SuaTSCB();
            suaTSDBForm.Show();
        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
