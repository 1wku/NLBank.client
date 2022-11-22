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
using NLBank.client.user.employee;
using NLBank.client.views.user;

namespace NLBank.client.components
{
    public partial class HDTDItemUser : UserControl
    {
        HDTDDTO hdtd = new HDTDDTO();
        public HDTDItemUser(HDTDDTO hdtd)
        {
            this.hdtd = hdtd;
            InitializeComponent();
        }

        private void HDTDItemUser_Load(object sender, EventArgs e)
        {
            lb_soHDTD.Text = hdtd.SoHDTD.ToString();
            lb_laisuat.Text = hdtd.LaiSuat.ToString();
            lb_ngayky.Text = hdtd.NgayKi.ToString();
            txt_mucdich.Text = hdtd.Muc_dich;
        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            new HDTDInfoUser(hdtd).Show();
        }
    }
}
