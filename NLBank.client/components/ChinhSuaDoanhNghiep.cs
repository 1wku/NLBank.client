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

namespace NLBank.client.components
{
    public partial class ChinhSuaDoanhNghiep : UserControl
    {
        KHDTO kh = new KHDTO();
        public ChinhSuaDoanhNghiep(KHDTO kh)
        {
            this.kh = kh;
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            KHDTO user = new KHDTO(kh.MaKH, txt_ten.Text, txt_diachi.Text, txt_email.Text, txt_sdt.Text, kh.RoleID);
            DOANHNGHIEPDTO dn = new DOANHNGHIEPDTO(kh.MaKH, txt_madn.Text, Int32.Parse(txt_dbrating.Text));
            Console.WriteLine(txt_madn.Text);
            if (TTTKBUS.SuaDN(dn, user))
            {
                MessageBox.Show("Thay đổi thông tin doanh nghiệp thành công");
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin doanh nghiệp thất bại");
            }
        }

        private void ChinhSuaDoanhNghiep_Load(object sender, EventArgs e)
        {
            DOANHNGHIEPDTO dn = TTTKBUS.getDoanhNghiep(kh.MaKH);
            txt_ten.Text = kh.Ten;
            txt_email.Text = kh.Email;
            txt_diachi.Text = kh.Dia_chi;
            txt_sdt.Text = kh.Sdt;
            txt_madn.Text = dn.MADN;
            txt_dbrating.Text = dn.DnB_rating.ToString();
        }
    }
}
