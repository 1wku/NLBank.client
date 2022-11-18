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
using NLBank.client.views;

namespace NLBank.client.components
{
    public partial class ChinhSuaCaNhan : UserControl
    {
        KHDTO kh = new KHDTO();
        public ChinhSuaCaNhan(KHDTO kh)
        {
            this.kh = kh;
            InitializeComponent();
        }

        private void ChinhSuaCaNhan_Load(object sender, EventArgs e)
        {
            CANHANDTO canhan = TTTKBUS.getCaNhan(kh.MaKH);
            txt_ten.Text = kh.Ten;
            txt_diachi.Text = kh.Dia_chi;
            txt_email.Text = kh.Email;
            txt_sdt.Text = kh.Sdt;

            txt_cccd.Text = canhan.CCCD;
            txt_fico.Text += canhan.FICO_score;
            dtp_ngaysinh.Value = canhan.NgaySinh.Date;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            KHDTO updateKH = new KHDTO(kh.MaKH, txt_ten.Text, txt_diachi.Text, txt_email.Text, txt_sdt.Text, kh.RoleID);
            CANHANDTO updateCanhan = new CANHANDTO(kh.MaKH, dtp_ngaysinh.Value.Date, txt_cccd.Text, Int32.Parse(txt_fico.Text));
            if (TTTKBUS.SuaCaNhan(updateCanhan, updateKH))
            {
                MessageBox.Show("Thay đổi thông tin cá nhân thành công");
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin cá nhân thất bại");
            }
        }

        private void btn_changePasswd_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm(kh.Email.Replace(" ", String.Empty)).Show();
        }
    }
}
