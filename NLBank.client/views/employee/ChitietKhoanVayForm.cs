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
    public partial class ChitietKhoanVayForm : MaterialForm
    {
        int thoihanvay = 0;
        int mucphi = 0;
        decimal laisuat = 0;
        decimal laiquahan = 0; 
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

        Boolean isValid()
        {
            int number = 0;
            try
            {
                thoihanvay = int.Parse(thoihanvay_input.Text);
                mucphi = int.Parse(mucphi_input.Text);
                laisuat = decimal.Parse(laisuat_input.Text);
                laiquahan = decimal.Parse(laiquahan_input.Text);
                return true; 
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void ChitietKhoanVayForm_Load(object sender, EventArgs e)
        {
            makh.Text = kv.MaKH;
            makv.Text = kv.MaKV;
            sotienvay.Text = kv.SoTienVay.ToString();
            loaikv.Text = kv.MaLoaiKV;
            taisanthechap.Text = kv.MaTSDB;
            mucdich.Text = kv.MucDich; 

            

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                HDTDDTO hDTDDTO = new HDTDDTO();
                hDTDDTO.LoaiTien = kv.LoaiTien;
                hDTDDTO.MaKH = kv.MaKH;
                hDTDDTO.MAKV = kv.MaKV;
                hDTDDTO.Muc_dich = kv.MucDich;
                hDTDDTO.LaiSuat = laisuat;
                hDTDDTO.LaiQuaHan = laiquahan;
                hDTDDTO.ThoiHanVay = thoihanvay;
                hDTDDTO.PhuongThucTra = phuongthuctra_combobox.Text;
                hDTDDTO.NgayKi = ngayky_picker.Value.Date;
                hDTDDTO.TGGiaiNgan = ngaygiaingan_picker.Value.Date;
                hDTDDTO.MucPhi = mucphi;
                var result = HDTDDAL.ThemHDTD(hDTDDTO);
                Console.Write(result);
                MessageBox.Show("Oh noes!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // TODO hien thong bao loi . Nhap lai 
                MessageBox.Show("Oh noes!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            thoihanvay_input.Text = "";
            laiquahan_input.Text = "";
            laisuat_input.Text = "";
            mucphi_input.Text = "";
        }
    }
}
