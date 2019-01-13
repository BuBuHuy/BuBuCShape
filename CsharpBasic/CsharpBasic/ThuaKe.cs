using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * https://vietjack.com/csharp/tinh_ke_thua_trong_csharp.jsp
 * @author Bu Bu Huy
*/
namespace CsharpBasic
{
    class HinhChuNhat
    {
        //cac bien thanh vien
        protected double chieu_dai;
        protected double chieu_rong;
        // constructor
        public HinhChuNhat(double l, double w)
        {
            chieu_dai = l;
            chieu_rong = w;
        }
        //phuong thuc
        public double tinhDienTich()
        {
            return chieu_dai * chieu_rong;
        }

        public void Display()
        {
            Console.WriteLine("Chieu dai: {0}", chieu_dai);
            Console.WriteLine("Chieu rong: {0}", chieu_rong);
            Console.WriteLine("Dien tich: {0}", tinhDienTich());
        }
    }
    class ChiPhiXayDung : HinhChuNhat
    {
        private double cost;
        public ChiPhiXayDung(double l, double w) : base(l, w)
        { }
        public double tinhChiPhi()
        {
            double chi_phi;
            chi_phi = tinhDienTich() * 70;
            return chi_phi;
        }
        public void hienThiThongTin()
        {
            base.Display();
            Console.WriteLine("Chi phi: {0}", tinhChiPhi());
        }
        
    }
    class ThuaKe
    {
        public class TestCsharp
        {
            //public static void Main(string[] args)
            //{
            //    Console.WriteLine("Tinh ke thua trong C#");
            //    Console.WriteLine("Khoi tao lop co so");
            //    Console.WriteLine("------------------------\n");
            //    //tao doi tuong ChiPhiXayDung
            //    ChiPhiXayDung t = new ChiPhiXayDung(4.5, 7.5);
            //    t.hienThiThongTin();
            //    Console.ReadLine();

            //    Console.ReadKey();
            //}
        }
    }
}
