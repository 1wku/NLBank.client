using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.components;
using NLBank.client.DAL;
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

namespace NLBank.client.views.employee
{
    public partial class EmployeeHome : MaterialForm
    {
        NhanvienDTO nv = new NhanvienDTO(); 
       
        DataTable nv_data, kv_data, lsthanhtoan_data, tsdb_data, hdtd_data, dieukhoan_data; 
        public EmployeeHome(NhanvienDTO nv)
        {
            this.nv = nv; 

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
           
           
        }

        void updateViewHDTD(DataTable hdtd_data)
        {
            all_hdtd_panel.Controls.Clear(); 
           var hdtd_value = new HDTDDTO();
            var kh_value = new KHDTO();
            var tsdb_value = new TSDBDTO();
            foreach (DataRow row in hdtd_data.Rows)
            {
                Console.WriteLine(row.ToString());
                kh_value.Ten = (string)row["Ten"];
                kh_value.MaKH = row["MaKH"] != DBNull.Value ? (int)row["MaKH"] : 0; 
                hdtd_value.SoHDTD = row["SoHDTD"] != DBNull.Value ? (int)row["SoHDTD"] : 0; 
                hdtd_value.Muc_dich = (string)row["Muc_dich"];
                hdtd_value.LaiQuaHan = (decimal)row["LaiQuaHan"];
                hdtd_value.LaiSuat = (decimal)row["LaiSuat"];
                hdtd_value.ThoiHanVay = (int)row["ThoiHanVay"];
                hdtd_value.PhuongThucTra = (string)row["PhuongThucTra"];
                hdtd_value.MucPhi = (int)row["MucPhi"];
                hdtd_value.TGGiaiNgan = (DateTime)row["TGGiaiNgan"];
                hdtd_value.NgayKi = (DateTime)row["NgayKi"];
                hdtd_value.SoTienVay = (int)row["SoTienVay"];
                tsdb_value.TenLoaiTSDB = (string)row["TenLoaiTSDB"];
                tsdb_value.TenTSDB = (string)row["TenTSDB"];
                tsdb_value.TriGiaTS = row["TrigiaTS"] != DBNull.Value ? (int)row["TrigiaTS"] : 0;
                tsdb_value.HinhThucDB = row["HinhThucDB"] != DBNull.Value ? (string)row["HinhThucDB"] : "Chưa cập nhập";

                all_hdtd_panel.Controls.Add(new HdtdItem(hdtd_value, tsdb_value, kh_value));

            }
        }
        void updateViewTSDB(DataTable tsdb_data)
        {
            tsdb_panel.Controls.Clear(); 
            foreach (DataRow row in tsdb_data.Rows)
            {

                tsdb_panel.Controls.Add(new TsdbItem(new TSDBDTO(
                    row["MaTSDB"] != DBNull.Value ? (int)row["MaTSDB"] : 0,
                    row["MaLoaiTSDB"] != DBNull.Value ? (int)row["MaLoaiTSDB"] : 0,
                    (string)row["TenTSDB"],
                    row["MaKH"] != DBNull.Value ? (int)row["MaKH"] : 0,
                    row["TrigiaTS"] != DBNull.Value ? (int)row["TrigiaTS"] : 0,

                row["HinhThucDB"] != DBNull.Value ? (string)row["HinhThucDB"] : "Chưa cập nhập"
                    )));

            }
        }
        void updateViewNhanVien(DataTable nv_data)
        {
            nhanvien_gridview.DataSource = nv_data; 
        }
        void updateViewKhoanVay(DataTable kv_data)
        {
            all_kv_panel.Controls.Clear();
            foreach (DataRow row in kv_data.Rows)
            {

                all_kv_panel.Controls.Add(new KhoanVayItem(new KhoanVayDTO(
                    row["MaKV"] != DBNull.Value ? (int)row["MaKV"] : 0,
                    row["MaKH"] != DBNull.Value ? (int)row["MaKH"] : 0,
                    row["MaTSDB"] != DBNull.Value ? (int)row["MaTSDB"] : 0,
                    row["MaLoaiKV"] != DBNull.Value ? (int)row["MaLoaiKV"] : 0,
                    row["MucDich"]!= DBNull.Value ? (string)row["MucDich"] : "Chưa cập nhập" ,
                    row["SoTienVay"] != DBNull.Value ? (int)row["SoTienVay"] : 0,
                    row["LoaiTien"] != DBNull.Value ? (string)row["LoaiTien"] : "Chưa cập nhập"
                    )));;

            }
            
        }

        void updateViewDieuKhoan(DataTable dieukhoan_data)
        {
            dieukhoan_gridview.DataSource = dieukhoan_data; 
        }

        void updateViewLichSuThanhToan(DataTable lstt_data)
        {
            ls_thanhtoan_gridview.DataSource = lstt_data; 
        }
        private void EmployeeHome_Load(object sender, EventArgs e)
        {
            kv_data = KhoanVayDAL.getView(); 
            updateViewKhoanVay(kv_data); 
            //
             hdtd_data = HDTDDAL.getView();
            updateViewHDTD(hdtd_data); 
            //
            lsthanhtoan_data = CTTNDAL.getView();
            updateViewLichSuThanhToan(lsthanhtoan_data);
            //
             tsdb_data = TSDBDAL.getView();
            updateViewTSDB(tsdb_data);

            //
            nv_data = NhanvienDAL.getView();
            updateViewNhanVien(nv_data);

            //
            dieukhoan_data = DieuKhoanDAL.getView();
            updateViewDieuKhoan(dieukhoan_data);
            
        }

        private void search_cttn_btn_Click(object sender, EventArgs e)
        {

        }

        private void search_tsdb_btn_Click(object sender, EventArgs e)
        {
            if (tsdb_data.AsEnumerable()
    .Where(r => r.Field<String>("MaLoaiTSDB").Contains(maloaitsdb_input.Text)).Count() == 0)
            {
                MessageBox.Show("Mã TSDB không tồn tại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                updateViewTSDB(tsdb_data.AsEnumerable()
   .Where(r => r.Field<String>("MaLoaiTSDB").Contains(maloaitsdb_input.Text)).CopyToDataTable());

            }


        }

        private void search_nv_btn_Click(object sender, EventArgs e)
        {
             
            updateViewNhanVien(nv_data.Select("Ten LIKE '%" + nv_input.Text + "%'").CopyToDataTable()); 
        }

        private void Reload_TSDB_Click(object sender, EventArgs e)
        {
            updateViewTSDB(tsdb_data); 
        }

        private void reload_kv_btn_Click(object sender, EventArgs e)
        {
            updateViewKhoanVay(kv_data); 
        }

        private void search_hdtd_btn_Click(object sender, EventArgs e)
        {
            if (hdtd_data.AsEnumerable().Where(r => r.Field<String>("SoHDTD").Contains(hdtd_input.Text)).Count() == 0)
            {
                MessageBox.Show("Mã hợp đồng không tồn tại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                updateViewHDTD(hdtd_data.AsEnumerable().Where(r => r.Field<String>("SoHDTD").Contains(hdtd_input.Text)).CopyToDataTable());

            }
        }

        private void reaload_hdtd_btn_Click(object sender, EventArgs e)
        {
            updateViewHDTD(hdtd_data); 
        }

        private void reload_thuno_btn_Click(object sender, EventArgs e)
        {
            updateViewLichSuThanhToan(lsthanhtoan_data);
        }

        private void reload_nv_btn_Click(object sender, EventArgs e)
        {
            updateViewNhanVien(nv_data);
        }

        private void reaload_dieukhoan_btn_Click(object sender, EventArgs e)
        {

        }

        private void search_thuno_btn_Click(object sender, EventArgs e)
        {
            //if (lsthanhtoan_data.AsEnumerable().Where(r => r.Field<String>("MaKV").Contains(lb_kv_input.Text)).Count() == 0)
            //{
            //    MessageBox.Show("Mã khoản vay không tồn tại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else
            //{
            //    updateViewKhoanVay(kv_data.AsEnumerable().Where(r => r.Field<String>("MaKV").Contains(lb_kv_input.Text)).CopyToDataTable());

            //}
        }

        private void search_kv_btn_Click(object sender, EventArgs e)
        {
            if (kv_data.AsEnumerable().Where(r => r.Field<String>("MaKV").Contains(lb_kv_input.Text)).Count() == 0)
            {
                MessageBox.Show("Mã khoản vay không tồn tại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                updateViewKhoanVay(kv_data.AsEnumerable().Where(r => r.Field<String>("MaKV").Contains(lb_kv_input.Text)).CopyToDataTable());

            }
        }
    }
}
