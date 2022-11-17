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
    public partial class ThemKhachHangForm : MaterialForm
    {
        public ThemKhachHangForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }

        private void ThemKhachHangForm_Load(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var kh = new KHDTO();
            kh.Sdt = sdt_input.Text;
            kh.Ten = ten_input.Text;
            kh.Email = email_input.Text;
            kh.Dia_chi = diachi_input.Text;
            kh._canhan.CCCD = cccd_input.Text;
            kh.Password = password_input.Text;
            kh._doanhNghiep.MADN = (MaDN_input.Text);
            kh._canhan.NgaySinh = ngaysinh_picker.Value;
            kh.RoleID = loaitk_combobox.SelectedIndex;
            DialogResult result = MessageBox.Show("Xác nhận Thêm khách hàng.", "Chấp nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (checkData())
                {
                    KHDAL.ThemKH(kh);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng thử lại hoặc báo cho quản trị viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            

           
        }
        Boolean checkData()
        {
            if (ten_input.Text =="" || email_input.Text == "" || diachi_input.Text == "" || sdt_input.Text =="" || password_input.Text =="")
            {
                return false; 
            }
            if (loaitk_combobox.SelectedIndex == 0)
            {
                if(ngaysinh_picker.Value.Year > DateTime.Now.Year - 18)
                {
                    MessageBox.Show("Khách hàng phải lớn hơn 18 tuổi. Vui lòng thử lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
                if (cccd_input.Text == "")
                {
                    MessageBox.Show("Tài khoản cá nhân phải có thông tin CCCD/CMND. Vui lòng thử lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
            }
            if (loaitk_combobox.SelectedIndex == 1)
            {
                if (MaDN_input.Text == "")
                {
                    MessageBox.Show("Tài khoản doanh nghiệp phải có thông tin Mã Doanh Nghiệp. Vui lòng thử lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true; 
        }
    }
}
