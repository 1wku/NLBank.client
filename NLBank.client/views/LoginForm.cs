using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.BUS;
using NLBank.client.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLBank.client
{
    public partial class LoginForm : MaterialForm
    {
        AuthenticationBUS authenticationBUS = new AuthenticationBUS(); 
        public LoginForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            LoginForm form1 = this;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
        bool IsValid()
        {
            if (input_email_login.Text == "" || input_password_login.Text == "")
            {
                return false; 
            }
            return true; 
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

            }
        }
    }
}
