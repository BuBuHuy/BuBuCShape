using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySV_DataConnection
{
    class SV
    {
        public string mssv { set; get; }
        public string name { set; get; }
        public DateTime birthday { set; get; }
        public string address { set; get; }
        public bool gender { get; set; }
        public SV(string ms, string na, DateTime bir, string add,bool gen)
        {
            this.mssv = ms;
            this.name = na;
            this.birthday = bir;
            this.address = add;
            this.gender = gen;
        }
         
        public SV()
        {
            this.mssv = "102160247";
            this.name = "Bu Bu Huy";
            this.birthday = DateTime.Now.Date;
            this.address = "GVM";
            this.gender = true;
        }
        //static 

    }

}
