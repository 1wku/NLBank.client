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
       
        DataTable kh_data, nv_data, kv_data, lsthanhtoan_data, tsdb_data, hdtd_data, dieukhoan_data; 
        public EmployeeHome(NhanvienDTO nv)
        {
            this.nv = nv;
            nv.ChucVu = ChucVuDAL.GetChucVu(nv.MaCV); 
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
           
           
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

            //
            updateThongTinCaNhan();
            //
            kh_data = KHDAL.getView();
            updateViewKhachHang(kh_data);

            setupEvent();



        }

        void setupEvent()
        {
            type_kv_combobox.SelectedIndexChanged += (sender, e) =>
            {
                lb_kv_input.Text = ""; 
                switch (type_kv_combobox.SelectedIndex)
                {
                    case 0:
                        updateViewKhoanVay(kv_data);

                        break;
                    case 1:
                        updateViewKhoanVay(KhoanVayDAL.getKVChuaSuDung());

                        break;
                    case 2:
                        updateViewKhoanVay(KhoanVayDAL.getKVDaSuDung());

                        break;
                }
            };
        }
        void updateThongTinCaNhan()
        {
            ten_nv.Text = nv.Ten;
            email_nv.Text = nv.Email;
            sdt_nv.Text = nv.Sdt;
            diachi_nv.Text = nv.Dia_chi; 
            cccd_nv.Text = nv.CCCD;
            hs_luong_nv.Text = nv.ChucVu.HsLuong.ToString();
            chucvu_nv.Text = nv.ChucVu.TenCV;




        }
        void updateViewHDTD(DataTable hdtd_data)
        {
            all_hdtd_panel.Controls.Clear(); 
           var hdtd_value = new HDTDDTO();
            var kh_value = new KHDTO();
            var tsdb_value = new TSDBDTO();
            foreach (DataRow row in hdtd_data.Rows)
            {
                hdtd_value = new HDTDDTO();
                kh_value = new KHDTO();
                tsdb_value = new TSDBDTO();
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
        void updateViewKhachHang(DataTable kh_data)
        {
            khachhang_datagrid.DataSource = kh_data; 
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
        

        private void search_cttn_btn_Click(object sender, EventArgs e)
        {

        }

        private void search_tsdb_btn_Click(object sender, EventArgs e)
        {
            if (tsdb_data.AsEnumerable()
    .Where(r => r.Field<int>("MaLoaiTSDB").ToString().Contains(maloaitsdb_input.Text)).Count() == 0)
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
            tsdb_data = TSDBDAL.getView(); 
            updateViewTSDB(tsdb_data); 
        }

        private void reload_kv_btn_Click(object sender, EventArgs e)
        {
            kv_data = KhoanVayDAL.getView();
            updateViewKhoanVay(kv_data); 
        }

        private void search_hdtd_btn_Click(object sender, EventArgs e)
        {
            if (hdtd_data.AsEnumerable().Where(r => r.Field<int>("SoHDTD").ToString().Contains(hdtd_input.Text)).Count() == 0)
            {
                MessageBox.Show("Mã hợp đồng không tồn tại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                updateViewHDTD(hdtd_data.AsEnumerable().Where(r => r.Field<int>("SoHDTD").ToString().Contains(hdtd_input.Text)).CopyToDataTable());

            }
        }

        private void reaload_hdtd_btn_Click(object sender, EventArgs e)
        {
            hdtd_data = HDTDDAL.getView(); 
            updateViewHDTD(hdtd_data); 
        }

        private void change_password_btn_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm(nv.Email).Show();
        }

        private void create_kh_btn_Click(object sender, EventArgs e)
        {
                new ThemKhachHangForm().Show();

            
        }
       

        private void search_kh_btn_Click(object sender, EventArgs e)
        {

            string searchKHColumn = type_kh_search.GetItemText(type_kh_search.SelectedItem); 
            if (kh_data.AsEnumerable().Where(r => (r.Field<String>(searchKHColumn) != null? r.Field<String>(searchKHColumn).ToLower():"" ).Contains(search_kh_input.Text.ToLower())).Count() == 0)
            {
                MessageBox.Show("Khách hàng không tồn tại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                updateViewKhachHang(kh_data.AsEnumerable().Where(r => (r.Field<String>(searchKHColumn) != null ? r.Field<String>(searchKHColumn).ToLower() : "").Contains(search_kh_input.Text.ToLower())).CopyToDataTable());

            }
        }

        private void reload_kh_btn_Click(object sender, EventArgs e)
        {
            kh_data = KHDAL.getView();
            updateViewKhachHang(kh_data); 
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void giaingan_btn_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát phần mềm ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 
            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void reload_thuno_btn_Click(object sender, EventArgs e)
        {
            lsthanhtoan_data = CTTNDAL.getView();
            updateViewLichSuThanhToan(lsthanhtoan_data);
        }

        private void reload_nv_btn_Click(object sender, EventArgs e)
        {
            nv_data = NhanvienDAL.getView(); 
            updateViewNhanVien(nv_data);
        }

        private void reaload_dieukhoan_btn_Click(object sender, EventArgs e)
        {
            dieukhoan_data = DieuKhoanDAL.getView();
            updateViewDieuKhoan(dieukhoan_data); 
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
            if (kv_data.AsEnumerable().Where(r => r.Field<int>("MaKV").ToString().Contains(lb_kv_input.Text)).Count() == 0)
            {
                MessageBox.Show("Mã khoản vay không tồn tại. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                updateViewKhoanVay(kv_data.AsEnumerable().Where(r => r.Field<int>("MaKV").ToString().Contains(lb_kv_input.Text.ToLower())).CopyToDataTable());

            }
        }
    }
}
