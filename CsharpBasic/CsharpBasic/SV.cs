using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpBasic
{
    class SV
    {
        string MSSV;
        string name;
        double DTB;
        int DRL;
        public SV()
        {
            this.MSSV = "1";
            this.name = "NVA";
            this.DTB = 3.0;
            this.DRL = 90;
        }
        public SV(string m, string n, double tb, int rl)
        {
            this.MSSV = m;
            this.name = n;
            this.DTB = tb;
            this.DRL = rl;
        }
        public SV(SV st)
        {
            this.MSSV = st.MSSV;
            this.name = st.name;
            this.DTB = st.DTB;
            this.DRL = st.DRL;
        }
        public string pMSSV
        {
            get { return this.MSSV; }
            set { this.MSSV = value; }
        }
        public string pName
        {
            get { return this.name; }
            set { this.name = value; }

        }
        public double pDTB
        {
            get { return this.DTB; }
            set { this.DTB = value; }
        }
        public int pDRL
        {
            get { return this.DRL; }
            set { this.DRL = value; }
        }
        public void show()
        {
            Console.WriteLine("MSSV :{0},Name :{1},DTB :{2},DRL :{3}", this.MSSV, this.name, this.DTB, this.DRL);
        }
        public static SV inputSV()
        {
            SV sv = new SV();
            Console.Write("Ma so sinh vien : "); sv.MSSV = Console.ReadLine();
            Console.Write("Ten SV          : "); sv.name = Console.ReadLine();
            Console.Write("Diem trung binh : "); sv.DTB = double.Parse(Console.ReadLine());
            Console.Write("Diem ren luyen  : "); sv.DTB = int.Parse(Console.ReadLine());
            return sv;
        }
        public static bool CompareName(object o1, object o2)
        {

            if (string.Compare(((SV)o1).name, ((SV)o2).name) < 0)
            {
                return true;
            }
            return false;
        }
    }
}
