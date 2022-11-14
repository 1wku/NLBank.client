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
    public partial class TsdbItem : UserControl
    {
        TSDBDTO ts = new TSDBDTO(); 
        public TsdbItem(TSDBDTO ts)
        {
            this.ts = ts; 
            InitializeComponent();

        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            new ThamdinhTSDB(ts).Show(); 
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TsdbItem_Load(object sender, EventArgs e)
        {
            lb_tentsdb_item.Text = ts.TenTSDB;
            lb_maloaitsdb_item.Text = ts.MaLoaiTSDB.ToString(); 
        }
    }
}
