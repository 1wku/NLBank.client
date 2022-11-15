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
using NLBank.client.DTO;
using NLBank.client.BUS;
namespace NLBank.client.views.user
{
    public partial class DangKyKhoanVay_Form : MaterialForm
    {
        KHDTO kh = new KHDTO();
        public DangKyKhoanVay_Form(KHDTO user)
        {
            this.kh = user;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void DangKyKhoanVay_Form_Load(object sender, EventArgs e)
        {
            cbx_loaikv.DataSource = KVBUS.GetLoaiKV();
            cbx_loaikv.DisplayMember = "TenKV";
            cbx_loaikv.ValueMember = "MaLoaiKV";
            cbx_loaitien.DataSource = KVBUS.GetLoaiTien();
            cbx_loaitien.DisplayMember = "LoaiTien";
            cbx_loaitien.ValueMember = "MaloaiTien";
            dg_tsdb.DataSource = KVBUS.GetListTSDB(kh.MaKH);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            KVBUS.ThemKV(new KhoanVayDTO(kh.MaKH, Int32.Parse(dg_tsdb.SelectedRows[0].Cells[0].Value.ToString()), Int32.Parse(cbx_loaikv.SelectedValue.ToString()), txt_mucdich.Text, Int32.Parse(txt_sotienvay.Text), cbx_loaitien.SelectedValue.ToString()));
        }
    }
}
