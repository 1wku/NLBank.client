﻿using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAL
{
    public class KhoanVayDAL
    {
        public static void ThemKhoanVay(KhoanVayDTO kv)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("ThemKhoanVay", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKV", SqlDbType.Char);
            command.Parameters.Add("@MaKH", SqlDbType.Char);
            command.Parameters.Add("@MaTSDB", SqlDbType.Char);
            command.Parameters.Add("@MaLoaiKV", SqlDbType.Char);
            command.Parameters.Add("@MucDich", SqlDbType.NVarChar);
            command.Parameters.Add("@SoTienVay", SqlDbType.Int);
            command.Parameters.Add("@LoaiTien", SqlDbType.Char);
            command.Parameters["@MaKV"].Value = kv.MaKV;
            command.Parameters["@MaKH"].Value = kv.MaKH;
            command.Parameters["@MaTSDB"].Value = kv.MaTSDB;
            command.Parameters["@MaLoaiKV"].Value = kv.MaLoaiKV;
            command.Parameters["@MucDich"].Value = kv.MucDich;
            command.Parameters["@SoTienVay"].Value = kv.SoTienVay;
            command.Parameters["@LoaiTien"].Value = kv.LoaiTien;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void SuaKhoanVay(KhoanVayDTO kv)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("SuaKhoanVay", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKV", SqlDbType.Char);
            command.Parameters.Add("@MaKH", SqlDbType.Char);
            command.Parameters.Add("@MaTSDB", SqlDbType.Char);
            command.Parameters.Add("@MaLoaiKV", SqlDbType.Char);
            command.Parameters.Add("@MucDich", SqlDbType.NVarChar);
            command.Parameters.Add("@SoTienVay", SqlDbType.Int);
            command.Parameters.Add("@LoaiTien", SqlDbType.Char);
            command.Parameters["@MaKV"].Value = kv.MaKV;
            command.Parameters["@MaKH"].Value = kv.MaKH;
            command.Parameters["@MaTSDB"].Value = kv.MaTSDB;
            command.Parameters["@MaLoaiKV"].Value = kv.MaLoaiKV;
            command.Parameters["@MucDich"].Value = kv.MucDich;
            command.Parameters["@SoTienVay"].Value = kv.SoTienVay;
            command.Parameters["@LoaiTien"].Value = kv.LoaiTien;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaKhoanVay(KhoanVayDTO kv)
        {
            SqlConnection Conn = Connection.KetNoi();
            SqlCommand command = new SqlCommand("XoaKhoanVay", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKV", SqlDbType.Char);

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}