using NLBank.client.DTO;
using NLBank.client.BUS;
using NLBank.client.views.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLBank.client.views.employee;
using NLBank.client.user.employee;

namespace NLBank.client.components
{
    public partial class TSDBitemUser : UserControl
    {
        TSDBDTO ts = new TSDBDTO();
        KHDTO kh = new KHDTO();
        public TSDBitemUser(TSDBDTO ts, KHDTO kh)
        {
            this.ts = ts;
            this.kh = kh;
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new TSDBinfo(ts).Show();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SuaTSDB suaTSDBForm = new SuaTSDB(ts, kh);
            suaTSDBForm.Show();
        }

        private void btn_xoa_click(object sender, EventArgs e)
        {
            TSDBBUS.XoaTSDB(ts.MaTSDB); 
        }

        private void TSDBitemUser_Load(object sender, EventArgs e)
        {
            lb_tentsdb_item.Text = ts.TenTSDB;
            lb_maloaitsdb_item.Text = ts.TenLoaiTSDB;
        }
    }
}
