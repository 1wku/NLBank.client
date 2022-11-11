using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class ChitietKhoanVayForm : MaterialForm
    {
        KhoanVayDTO kv = new KhoanVayDTO(); 
        public ChitietKhoanVayForm(KhoanVayDTO kv)
        {
            this.kv = kv;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void ChitietKhoanVayForm_Load(object sender, EventArgs e)
        {
          //  makh.Text = 
        }
    }
}
