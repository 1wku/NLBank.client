using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.components;
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
            //Thong tin khach hang
            tabChinhSua.Controls.Add(new ChinhSuaCaNhan());
            lb_name.Text = kh.Ten;
            lb_adress.Text = kh.Dia_chi;
            lb_email.Text = kh.Email;
            lb_phone.Text = kh.Sdt;

            //Thong bao giay nhac no
            DataTable gnn_data = GNNBUS.GetGNN(kh.MaKH);
            pnl_reminder.Controls.Clear();
            foreach (DataRow row in gnn_data.Rows)
            {
                pnl_reminder.Controls.Add(new ThongBaoNhacNo(new GNNDTO(
                    row["SoGNN"] != DBNull.Value ? (int)row["SoGNN"] : 0,
                    (String)row["Ten"],
                    row["MaKH"] != DBNull.Value ? (int)row["MaKH"] : 0,
                    row["SoHDTD"] != DBNull.Value ? (int)row["SoHDTD"] : 0,
                    row["LaiSuat"] != DBNull.Value ? (decimal)row["LaiSuat"] : 0,
                    row["LaiQuaHan"] != DBNull.Value ? (decimal)row["LaiQuaHan"] : 0,
                    row["ThoiHanVay"] != DBNull.Value ? (int)row["ThoiHanVay"] : 0,
                    (String)row["PhuongThucTra"],
                    (String)row["LoaiTien"],
                    (DateTime)row["NgayKi"],
                    row["SoTienVay"] != DBNull.Value ? (int)row["SoTienVay"] : 0,
                    row["HanMucTinDung"] != DBNull.Value ? (int)row["HanMucTinDung"] : 0,
                    (DateTime)row["NgayKyGNN"],
                    (String)row["Chi_nhanh"],
                    (DateTime)row["NgayNN"],
                    (DateTime)row["HanTraNo"]
                    )));
            }
            //Khoan vay
            DataTable ctgn_data = CTBUS.getListGN(kh.MaKH);
            DataTable ctnn_data = CTBUS.getListNN(kh.MaKH);
            DataTable cttn_data = CTBUS.getListTN(kh.MaKH);

            int totalgn = 0;
            int totalnn = 0;
            int totaltn = 0;

            foreach(DataRow row in ctgn_data.Rows)
            {
                totalgn += (int)row["SoTienGiaiNgan"];
            }

            foreach (DataRow row in cttn_data.Rows)
            {
                totalgn += (int)row["SoTienTra"];
            }


            dg_gn.DataSource = ctgn_data;
            dg_nn.DataSource = ctnn_data;
            dg_tn.DataSource = cttn_data;


            //TSDB
            DataTable tsdb_data = TSDBBUS.GetListTSDB(kh.MaKH);
            pnl_TSDB.Controls.Clear();
            foreach (DataRow row in tsdb_data.Rows)
            {
                pnl_TSDB.Controls.Add(new TsdbItem(new TSDBDTO(
                    row["MaTSDB"] != DBNull.Value ? (int)row["MaTSDB"] : 0,
                    row["MaLoaiTSDB"] != DBNull.Value ? (int)row["MaLoaiTSDB"] : 0,
                    (string)row["TenTSDB"],
                    row["MaKH"] != DBNull.Value ? (int)row["MaKH"] : 0,
                    row["TrigiaTS"] != DBNull.Value ? (int)row["TrigiaTS"] : 0,

                row["HinhThucDB"] != DBNull.Value ? (string)row["HinhThucDB"] : "Chưa cập nhập"
                    ))); 
            }
            cbx_loai.DataSource = TSDBBUS.GetLoaiTSDB();
            cbx_loai.DisplayMember = "TenLoaiTSDB";
            cbx_loai.ValueMember = "MaLoaiTSDB";
        }

        private void btn_them_khoan_vay_Click(object sender, EventArgs e)
        {
            new DangKyKhoanVay_Form(kh).Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new ThemTSDB(kh).Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            SuaTSDB suaTSDBForm = new SuaTSDB();
            suaTSDBForm.Show();
        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tab_TSDB_Click(object sender, EventArgs e)
        {
        }



        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            string searchString = "%" + txt_name.Text + "%";

            DataTable tsdb_data = TSDBBUS.GetListTSDBbyName(searchString, kh.MaKH); ;
            pnl_TSDB.Controls.Clear();
            foreach (DataRow row in tsdb_data.Rows)
            {
                pnl_TSDB.Controls.Add(new TsdbItem(new TSDBDTO(
                    row["MaTSDB"] != DBNull.Value ? (int)row["MaTSDB"] : 0,
                    row["MaLoaiTSDB"] != DBNull.Value ? (int)row["MaLoaiTSDB"] : 0,
                    (string)row["TenTSDB"],
                    row["MaKH"] != DBNull.Value ? (int)row["MaKH"] : 0,
                    row["TrigiaTS"] != DBNull.Value ? (int)row["TrigiaTS"] : 0,

                row["HinhThucDB"] != DBNull.Value ? (string)row["HinhThucDB"] : "Chưa cập nhập"
                    )));

            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            int searchString = Int32.Parse(cbx_loai.SelectedValue.ToString());

            DataTable tsdb_data = TSDBBUS.GetListTSDBbyLoaiTSDB(searchString); ;
            pnl_TSDB.Controls.Clear();
            foreach (DataRow row in tsdb_data.Rows)
            {
                pnl_TSDB.Controls.Add(new TsdbItem(new TSDBDTO(
                    row["MaTSDB"] != DBNull.Value ? (int)row["MaTSDB"] : 0,
                    row["MaLoaiTSDB"] != DBNull.Value ? (int)row["MaLoaiTSDB"] : 0,
                    (string)row["TenTSDB"],
                    row["MaKH"] != DBNull.Value ? (int)row["MaKH"] : 0,
                    row["TrigiaTS"] != DBNull.Value ? (int)row["TrigiaTS"] : 0,

                row["HinhThucDB"] != DBNull.Value ? (string)row["HinhThucDB"] : "Chưa cập nhập"
                    )));

            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            new ThanhToan().Show();
        }
    }
}
