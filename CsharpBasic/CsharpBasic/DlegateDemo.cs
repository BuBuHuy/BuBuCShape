using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpBasic
{
    //tim max min 


    class DlegateDemo
    {
        static double maxD(double a, double b)
        {
            if (a > b) return a;
            else return b;
        }
        static double add(double a, double b)
        {
            return a + b;
        }
        static double sub(double a, double b)
        {
            return a - b;
        }
        static double maxD1(double a, double b, delemaxD d)
        {
            return d(a, b);
        }

        public delegate double delemaxD(double a, double b);

        //static void Main(string[] args) 
        //{

        //    delemaxD d = new delemaxD(maxD);
        //    Console.WriteLine(d(5.5, 6.0));//c1
        //    Console.WriteLine(d.Invoke(5.5, 6.0));//c2  
        //    Console.WriteLine(maxD1(5.5, 6, maxD)); // c3


        //    //////////////////////////
        //    d += new delemaxD(add);
        //    d += new delemaxD(sub);
        //    d += new delemaxD(sub); /// tham chieu bi loai bo
        //    d -= new delemaxD(sub);
        //    Console.WriteLine(d.Invoke(5.5, 6.0));
        //    Console.ReadKey();
        //} 
        public delegate bool Com(object o1, object o2);


        static void Sort(object[] o, Com c)
        {

            for (int i = 0; i < o.Length - 1; i++)
                for (int j = i + 1; j < o.Length; j++)
                {
                    if (c(o[i], o[j]))
                    {
                        object temp = o[i];
                        o[i] = o[j];
                        o[j] = temp;
                    }
                }
            foreach (SV i in o)
            {
                i.show();
            }
        }

        //static void Main(string[] args)
        //{
        //    List<SV> l1 = new List<SV>();
        //    SV s1 = new SV("A", "Bu5", 10.0, 90);
        //    SV s2 = new SV("B", "Bu2", 7.5, 80);
        //    SV s3 = new SV("C", "Bu3", 7.5, 96);
        //    SV s4 = new SV("D", "Bu8", 2.0, 20);
        //    SV s5 = new SV("E", "Bu5", 7, 30);
        //    SV s6 = new SV("F", "Bu6", 9.6, 100);
        //    l1.Add(s1);
        //    l1.Add(s2);
        //    l1.Add(s3);
        //    l1.Add(s4);
        //    l1.Add(s5);
        //    l1.Add(s6);

        //    Sort(l1.ToArray(), SV.CompareName);

        //    Console.ReadKey();
        //}

    }
}
