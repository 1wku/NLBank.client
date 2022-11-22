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
using NLBank.client.BUS;
using NLBank.client.user.employee;
using NLBank.client.views.user;

namespace NLBank.client.components
{
    public partial class KVItemUser : UserControl
    {
        KhoanVayDTO kv = new KhoanVayDTO();
        KHDTO kh = new KHDTO();
        public KVItemUser(KhoanVayDTO hdtd, KHDTO kh)
        {
            this.kv = hdtd;
            this.kh = kh;
            InitializeComponent();
        }

        private void HDTDItemUser_Load(object sender, EventArgs e)
        {
            lb_mucdich.Text = kv.MucDich.ToString();
            lb_sotienvay.Text = kv.SoTienVay.ToString();
        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            new SuaKhoanVay(kv, kh).Show();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (KVBUS.XoaKV(kv.MaKV))
            {
                MessageBox.Show("Xóa thành công khoản vay");
            }
            else
            {
                MessageBox.Show("Xóa thất bại khoản vay");
            }
        }
    }
}
