﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTBuoi3
{
    class HangThucPham
    {
        private string MaHang;
        public string MaHang1
        {
            get { return MaHang; }
            set { MaHang = value; }
        }

        private string TenHang;
        public string TenHang1
        {
            get { return TenHang; }
            set { TenHang = "XXX"; }
        }

        private double DonGia;
        public double DonGia1
        {
            get { return DonGia; }
            set { DonGia = value; }
        }

        private DateTime NgaySX;
        public DateTime NgaySX1
        {
            get { return NgaySX; }
            set { NgaySX = DateTime.Now; }
        }

        private string NgayHH;
        public string NgayHH1
        {
            get { return NgayHH; }
            set { NgayHH = value; }
        }

        public HangThucPham()
        {
            MaHang = "MH001";
            TenHang = "May hut bui";
            DonGia = 15000000;
            NgaySX = DateTime.Now;
            NgayHH = "21/12/2023";
        }

        public HangThucPham(string MaHang, string TenHang, double DonGia, DateTime NgaySX, string NgayHH)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.DonGia = DonGia;
            this.NgaySX = NgaySX;
            this.NgayHH = NgayHH;
        }

        public void Nhap(){
            string MaHang, TenHang, NgayHH;
            double DonGia;
            DateTime NgaySX;
            Console.WriteLine("Nhap ma hang: ");
            MaHang = Console.ReadLine();
            Console.WriteLine("Nhap ten hang: ");
            TenHang = Console.ReadLine();
            Console.WriteLine("Nhap don gia: ");
            DonGia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap ngay san xuat: ");
            NgaySX = DateTime.Now;
            Console.WriteLine("Nhap ngay het han: ");
            NgayHH = Console.ReadLine();
        }


    }
}
