﻿using MaterialSkin;
using MaterialSkin.Controls;
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
using System.Data.SqlClient;

namespace NLBank.client.views.user
{
    public partial class SuaKhoanVay : MaterialForm
    {
        KhoanVayDTO kv = new KhoanVayDTO();
        KHDTO kh = new KHDTO();
        public SuaKhoanVay(KhoanVayDTO kv, KHDTO kh)
        {
            this.kv = kv;
            this.kh = kh;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void DangKyKhoanVay_Form_Load(object sender, EventArgs e)
        {
            cbx_loaikv.DataSource = KVBUS.GetLoaiKV();
            cbx_loaikv.DisplayMember = "TenKV";
            cbx_loaikv.ValueMember = "MaLoaiKV";
            cbx_loaitien.DataSource = KVBUS.GetLoaiTien();
            cbx_loaitien.DisplayMember = "LoaiTien";
            cbx_loaitien.ValueMember = "MaloaiTien";
            dg_tsdb.DataSource = TSDBBUS.GetListTSDBChuaSD(kh.MaKH);

            txt_mucdich.Text = kv.MucDich;
            txt_sotienvay.Text = kv.SoTienVay.ToString();
            cbx_loaikv.SelectedIndex = cbx_loaikv.FindStringExact(kv.MaLoaiKV.ToString());
            cbx_loaitien.SelectedValue = kv.LoaiTien;
        }

        

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(txt_sotienvay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền cần vay");
                return;
            }
            int sotienvay;
            if (!int.TryParse(txt_sotienvay.Text, out sotienvay))
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ");
                return;
            }
            if(txt_mucdich.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mục đích vay");
                return;
            }
            if (cbx_loaikv.SelectedValue == null)
            {
                MessageBox.Show("Chọn loại khoản vay hợp lệ");
                return;
            }
            if(dg_tsdb.CurrentRow == null )
            {
                if (KVBUS.SuaKV(new KhoanVayDTO(kv.MaKV, kh.MaKH, kv.MaTSDB, Int32.Parse(cbx_loaikv.SelectedValue.ToString()),
                                txt_mucdich.Text, sotienvay, cbx_loaitien.SelectedValue.ToString())))
                {
                    MessageBox.Show("Sửa Khoản vay thành công");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa Khoản vay thất bại");
                }
                return;
            }
            if (KVBUS.SuaKV(new KhoanVayDTO(kv.MaKV, kh.MaKH, Int32.Parse(dg_tsdb.Rows[dg_tsdb.CurrentRow.Index].Cells[0].Value.ToString()), Int32.Parse(cbx_loaikv.SelectedValue.ToString()),
                                txt_mucdich.Text, sotienvay, cbx_loaitien.SelectedValue.ToString())))
            {
                MessageBox.Show("Sửa Khoản vay thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa Khoản vay thất bại");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
