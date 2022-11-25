using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.DTO;
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
    public partial class ThemTSDB : MaterialForm 
    {
        KHDTO kh = new KHDTO();
        public ThemTSDB(KHDTO user)
        {
            kh = user;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tái sản đảm bảo");
                return;
            }
            TSDBDTO tsdb = new TSDBDTO(Int32.Parse(cbx_loai.SelectedValue.ToString()), txt_name.Text, kh.MaKH, 
                Int32.Parse(cbx_value.SelectedValue.ToString()), cbx_hinhthuc.SelectedValue.ToString());
            if (TSDBBUS.ThemTSDB(tsdb))
            {
                MessageBox.Show("Thêm Tài sản đảm bảo thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm tài sản đảm bảo thất bại");
            }
        }

        private void ThemTSDB_Load(object sender, EventArgs e)
        {
            cbx_hinhthuc.DataSource = TSDBBUS.GetHinhThucDB();
            cbx_hinhthuc.DisplayMember = "HinhThuc";
            cbx_hinhthuc.ValueMember = "MaHinhThuc";

            cbx_loai.DataSource = TSDBBUS.GetLoaiTSDB();
            cbx_loai.DisplayMember = "TenLoaiTSDB"; 
            cbx_loai.ValueMember = "MaLoaiTSDB";

            cbx_value.DataSource = TSDBBUS.GetTriGiaTS();
            cbx_value.DisplayMember = "TriGia";
            cbx_value.ValueMember = "MaTriGia";
        }
    }
}
