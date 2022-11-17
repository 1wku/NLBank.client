using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.DAL;
using NLBank.client.DTO;
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

namespace NLBank.client.views.employee
{
    public partial class ThamdinhTSDB : MaterialForm
    {
        List<LoaiTSDTO> allTS = new List<LoaiTSDTO>(); 


        TSDBDTO ts = new TSDBDTO(); 
        public ThamdinhTSDB(TSDBDTO ts)
        {
            this.ts = ts; 
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ThamdinhTSDB_Load(object sender, EventArgs e)
        {
            tents.Text = ts.TenTSDB; 
            htdambao.Text = ts.HinhThucDB;
            idkh.Text = ts.MaKH.ToString();
            trigia_input.Text = ts.TriGiaTS.ToString(); 
            foreach (DataRow row in Common.getLoaiTS().Rows) {
                allTS.Add(new LoaiTSDTO(int.Parse(row["MaLoaiTSDB"].ToString()), (string)row["TenLoaiTSDB"])); 
                loaits_combobox.Items.Add((string)row["TenLoaiTSDB"]); 
            }
            loaits_combobox.SelectedItem = allTS.Find(a=>a.MaLoaiTS==ts.MaLoaiTSDB).LoaiTS; 
        }

        Boolean checkData()
        {
            try {
                ts.TriGiaTS = Int32.Parse(trigia_input.Text);
                return true; 
            }
            catch(Exception e)
            {
                return false;
            }
           
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận lưu thẩm định tài sản.", "Chấp nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (checkData())
                {
                    ts.MaLoaiTSDB = allTS.Find(a => a.LoaiTS == loaits_combobox.SelectedItem).MaLoaiTS;
                    TSDBDAL.SuaTSDB(ts);

                    MessageBox.Show("Thẩm định tài sản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 

                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            
        }

        private void ko_dat_yeu_cau_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận tài sản không đạt yêu cầu. Loại bỏ tài sản?", "Chấp nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                TSDBDAL.XoaTSDB(ts.MaTSDB);
            }
            
        }
    }
}
