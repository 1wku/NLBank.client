using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLBank.client.views.employee
{
    public partial class ChitietHopDongForm : MaterialForm
    {
        KHDTO kh = new KHDTO();
        HDTDDTO hdtDD = new HDTDDTO();
        TSDBDTO tsdb = new TSDBDTO();
        public ChitietHopDongForm(HDTDDTO hdtDD, TSDBDTO tsdb, KHDTO kh)
        {
            this.hdtDD = hdtDD;
            this.tsdb = tsdb;
            this.kh = kh;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ChitietHopDongForm_Load(object sender, EventArgs e)
        {
            hdtd_id.Text = hdtDD.SoHDTD.ToString(); 
            hdtd_laisuat.Text = hdtDD.LaiSuat.ToString(); 
            hdtd_laiquahan.Text = hdtDD.LaiQuaHan.ToString(); 
            hdtd_thoihanvay.Text = hdtDD.ThoiHanVay.ToString()+ " ngày"; 
            hdtd_phuongthuctra.Text = hdtDD.PhuongThucTra; 
            hdtd_mucphi.Text = hdtDD.MucPhi.ToString();
            hdtd_ngaygiaingan.Text = hdtDD.TGGiaiNgan.ToShortDateString();
            hdtd_ngayky.Text = hdtDD.NgayKi.ToShortDateString();
            hdtd_sotienvay.Text = hdtDD.SoTienVay.ToString(); 
            //hdtd_loaitien.Text = hdtDD.LoaiTien.ToString(); 
            hdtd_mucdich.Text = hdtDD.Muc_dich.ToString();
            tsdb_ten.Text = tsdb.TenTSDB.ToString();
            tsdb_loai.Text = tsdb.MaLoaiTSDB.ToString();
            tsdb_trigia.Text = tsdb.TriGiaTS.ToString();
            tsdb_hinhthuc.Text = tsdb.HinhThucDB.ToString();
            kh_id.Text = kh.MaKH.ToString();
            kh_ten.Text = kh.Ten.ToString(); 
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
