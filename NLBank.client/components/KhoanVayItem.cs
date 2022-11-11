using NLBank.client.DTO;
using NLBank.client.views.employee;
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
    public partial class KhoanVayItem : UserControl
    {
        KhoanVayDTO khoanVayDTO = new KhoanVayDTO();
        public KhoanVayItem(KhoanVayDTO kv)
        {
            khoanVayDTO = kv;
            InitializeComponent();
            lb_id_kv_item.Text = kv.MaKV; 
        }

     
        private void KhoanVayItem_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new ChitietKhoanVayForm(khoanVayDTO).Show(); 
        }
    }
}
