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
        public EmployeeHome()
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
           
           
        }

        private void EmployeeHome_Load(object sender, EventArgs e)
        {
            ds_khoanvay = KhoanVayDAL.getAll();
            for (int i = 0; i < ds_khoanvay.Count; i++)
            {
                all_kv_panel.Controls.Add(new KhoanVayItem(ds_khoanvay[i]));

            }
            list_hdtd_gridview.DataSource = KhoanVayDAL.getView();
            tsdb_gridview.DataSource = TSDBDAL.getView(); 


        }

        private void materialLabel16_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void OpenEdit(object sender, DataGridViewCellEventArgs e)
        {   
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (list_hdtd_gridview.CurrentCell.ColumnIndex == list_hdtd_gridview.Columns.IndexOf(list_hdtd_gridview.Columns[5]))
                {
                    DataGridViewCell cell = list_hdtd_gridview[5, e.RowIndex];
                    list_hdtd_gridview.CurrentCell = cell;
                    list_hdtd_gridview.BeginEdit(true);
                }
            }
        }
    }
}
