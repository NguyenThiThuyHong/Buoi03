using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTBuoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            HangThucPham a = new HangThucPham();
            a.Nhap();
            a.Xuat();
            Console.ReadKey();
        }
    }
}
