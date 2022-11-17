using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLBank.client.views
{
    public partial class ChangePasswordForm : MaterialForm
    {
        string email = ""; 
        public ChangePasswordForm(string email)
        {
            this.email = email; 
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            oldpassword_input.Password = true;  
            newpassword_input.Password = true;  
            newpassword_re_input.Password = true;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (oldpassword_input.Text=="" || newpassword_input.Text =="" || newpassword_re_input.Text == "")
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (newpassword_input.Text == newpassword_re_input.Text)
            {
                int result = AccountDAL.ChangePassword(email, oldpassword_input.Text, newpassword_input.Text);
                switch (result) {
                    case 1:
                        MessageBox.Show("Đỏi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); 
                        break;
                    case 0:
                        MessageBox.Show("Mật khẩu cũ không được trùng với mật khẩu mới. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                    case -1:
                        MessageBox.Show("Mật khẩu cũ sai. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break; 
                }
                
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newpassword_input.Clear();
                newpassword_re_input.Clear(); 
            }
        }
    }
}
