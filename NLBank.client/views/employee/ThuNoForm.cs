using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class ThuNoForm : MaterialForm
    {
        CTTNDTO thuno = new CTTNDTO();
        public ThuNoForm(HDTDDTO hd)
        {
            thuno.SoHDTD = hd.SoHDTD;
            thuno.hd = hd; 

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void ThuNoForm_Load(object sender, EventArgs e)
        {
            soduno.Text = CTNNDAL.GetSoduNo(thuno.SoHDTD).ToString();
            hdtd_id.Text = thuno.hd.SoHDTD.ToString(); 
            hdtd_laiquahan.Text = thuno.hd.LaiQuaHan.ToString();
            hdtd_laisuat.Text = thuno.hd.LaiSuat.ToString();
            hdtd_phuongthuctra.Text = thuno.hd.PhuongThucTra;
            hdtd_mucphi.Text = thuno.hd.MucPhi.ToString();
            hdtd_ngaygiaingan.Text = thuno.hd.TGGiaiNgan.ToShortDateString();
            hdtd_ngayky.Text = thuno.hd.NgayKi.ToShortDateString();
            hdtd_sotienvay.Text = thuno.hd.SoTienVay.ToString();
            hdtd_mucdich.Text = thuno.hd.Muc_dich; 
        }

        private void thu_btn_Click(object sender, EventArgs e)
        {
            if (!checkData())
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return; 
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xác nhận đã thu tiền", "Chấp nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                CTTNDAL.ThemCTTN(thuno.hd.SoHDTD , Int32.Parse(machinhanh_input.Text) ,Int32.Parse(sotientra_input.Text) );
            }
           
        }
        Boolean checkData()
        {
            try
            {
                int k = Int32.Parse(sotientra_input.Text); 
                 k = Int32.Parse(machinhanh_input.Text);
            }
            catch(Exception e)
            {
                return false; 
            }
            return true; 
        }
    }
}
