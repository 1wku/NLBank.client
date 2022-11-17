using NLBank.client.DAL;
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
            this.hdtDD = hdtDD;
            this.tsdb = tsdb;
            this.kh = kh;
            InitializeComponent();
            
        }

        private void tstdItem_Load(object sender, EventArgs e)
        {
            id_tstd_lb.Text = hdtDD.SoHDTD.ToString();
            datoihan = HDTDDAL.CheckOverTimeHDTD(hdtDD.SoHDTD);
            if (datoihan)
            {
                id_isOver_lb.Text="Đã tới hạn";
            }
            else
            {
                id_isOver_lb.Text = "Chưa tới hạn";

            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new ChitietHopDongForm(hdtDD, tsdb, kh).Show();
        }

        private void id_ts_Click(object sender, EventArgs e)
        {

        }

        private void thuno_btn_Click(object sender, EventArgs e)
        {

            new ThuNoForm(hdtDD).Show(); 
        }
    }
}
