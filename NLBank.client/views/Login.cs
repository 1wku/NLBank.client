using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.DAL;
using NLBank.client.DTO;
using NLBank.client.views.employee;
using NLBank.client.views.user ;
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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
      
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

       

        private void login_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Login  btn");
            int roleID = AccountDAL.login(txt_email.Text, txt_password.Text);
            Console.WriteLine(roleID);
            switch (roleID)
            {
                case 0:
                case 1:
                    KHDTO kh = AccountDAL.GetKhachHangByEmail(txt_email.Text);
                    if (kh != null)
                    {
                        new UserHome(kh).Show();
                        this.Hide();
                    }
                    break;
                case 2:
                    NhanvienDTO nv = AccountDAL.GetNhanVienByEmail(txt_email.Text);
                    if (nv != null)
                    {
                        new EmployeeHome(nv).Show();
                        this.Hide();
                    }
                    break;
                case -1:
                    MessageBox.Show("Không tồn tại tài khoản này! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case -2:
                    MessageBox.Show("Mật khẩu không đúng! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
