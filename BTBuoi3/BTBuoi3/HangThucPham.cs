using System;
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

        private string NgaySX;
        public string NgaySX1
        {
            get { return NgaySX; }
            set { NgaySX = value; }
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
            NgaySX = "1/1/2022";
            NgayHH = "21/12/2023";
        }

        public HangThucPham(string MaHang, string TenHang, double DonGia, string NgaySX, string NgayHH)
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
            string NgaySX;
            int n;
            Console.WriteLine("Nhap so luong: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ma hang: ");
                MaHang = Console.ReadLine();
                Console.Write("Nhap ten hang: ");
                TenHang = Console.ReadLine();
                Console.Write("Nhap don gia: ");
                DonGia = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap ngay san xuat: ");
                NgaySX = Console.ReadLine();
                Console.Write("Nhap ngay het han: ");
                NgayHH = Console.ReadLine();
            }
                
        }

        public void Xuat()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Ma_Hang  Ten_Hang      Don_Gia    Ngay_San_Xuat  Ngay_Het_Han  Ghi_Chu");
            Console.WriteLine("{0}  {1}    {2}    {3}       {4}",MaHang1, TenHang1, DonGia1, NgaySX1, NgayHH1);
        }

    }
}
