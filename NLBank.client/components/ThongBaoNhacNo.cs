using NLBank.client.DTO;
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
    public partial class ThongBaoNhacNo : UserControl
    {
        GNNDTO gnn = new GNNDTO();
        public ThongBaoNhacNo(GNNDTO gnn)
        {
            this.gnn = gnn;
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ThongBaoNhacNo_Load(object sender, EventArgs e)
        {
            lb_hdtd.Text += gnn.SoHDTD;
            lb_ngayky.Text += gnn.NgayKi.ToString("yyyy/MM/dd");
            lb_hantrano.Text += gnn.HanTraNo.ToString("yyyy/MM/dd");
            lb_sotienvay.Text += gnn.SoTienVay;
            lb_hanmuctd.Text += gnn.HanMucTinDung;
        }
    }
}
