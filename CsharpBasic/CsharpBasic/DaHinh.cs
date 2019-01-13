using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 * @author Bu Bu Huy
*/
namespace CsharpBasic
{
    class DaHinh
    {
        void print(int i)
        {
            Console.WriteLine("In so nguyen: {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("In so thuc: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("In chuoi: {0}", s);
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Tinh da hinh trong C#");
        //    Console.WriteLine("--------------------------");
        //    //tao doi tuong TestCsharp
        //    DaHinh p = new DaHinh();

        //    // goi ham print()
        //    p.print(5);
        //    p.print(500.263);
        //    p.print("Hoc C# co ban va nang cao");
        //    Console.ReadKey();
        //}
    }
}
