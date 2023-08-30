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
            get
            {
                return MaHang;
            }
            set
            {
                MaHang = value;
            }
        }

        private string TenHang;
        public string TenHang1
        {
            get { return TenHang; }
            set { TenHang = value; }
        }

        private int DonGia;
        public int DonGia1
        {
            get { return DonGia; }
            set { DonGia = value; }
        }

        private bool NgaySX;
        public bool NgaySX1
        {
            get { return NgaySX; }
            set { NgaySX = value; }
        }

        private bool NgayHH;
        public bool NgayHH1
        {
            get { return NgayHH; }
            set { NgayHH = value; }
        }


    }
}
