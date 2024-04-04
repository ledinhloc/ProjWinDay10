﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTW.DTO
{
    public class DatPhong
    {
        private string datPhongID;
        private string khachSanID;
        private string phongID;
        private string nguoiDungID;
        private DateTime ngayDat;
        private DateTime ngayTra;
        private string trangThai;
        private string hinhThucThanhToan;
        private int gia;

        public DatPhong(string datPhongID)
        {
            this.datPhongID = datPhongID;
        }

        public DatPhong(string datPhongID, string khachSanID, string phongID, string nguoiDungID, DateTime ngayDat, 
            DateTime ngayTra, string trangThai, string hinhThucThanhToan, int gia)
        {
            this.DatPhongID = datPhongID;
            this.KhachSanID = khachSanID;
            this.PhongID = phongID;
            this.NguoiDungID = nguoiDungID;
            this.NgayDat = ngayDat;
            this.NgayTra = ngayTra;
            this.TrangThai = trangThai;
            this.HinhThucThanhToan = hinhThucThanhToan;
            this.Gia = gia;
        }

        public string DatPhongID { get => datPhongID; set => datPhongID = value; }
        public string KhachSanID { get => khachSanID; set => khachSanID = value; }
        public string PhongID { get => phongID; set => phongID = value; }
        public string NguoiDungID { get => nguoiDungID; set => nguoiDungID = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string HinhThucThanhToan { get => hinhThucThanhToan; set => hinhThucThanhToan = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
