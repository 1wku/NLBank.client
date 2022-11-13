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
    public partial class HdtdItem : UserControl
    {
        KHDTO kh = new KHDTO(); 
        HDTDDTO hdtDD = new HDTDDTO();  
        TSDBDTO tsdb = new TSDBDTO();
        Boolean datoihan = false; 

        public HdtdItem(HDTDDTO hdtDD, TSDBDTO tsdb, KHDTO kh )
        {
            InitializeComponent();
            this.hdtDD = hdtDD;
            this.tsdb = tsdb;
            this.kh = kh; 
        }

        private void tstdItem_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new ChitietHopDongForm(hdtDD, tsdb, kh).Show();
        }
    }
}
