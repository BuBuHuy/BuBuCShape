using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySV
{
    class QLSV
    {
        List<SV> listSV;
        public QLSV()
        {
            this.listSV = new List<SV>();
            SV s1 = new SV();
            SV s2 = new SV("102160999", "Luu Van Huy", DateTime.Now.Date, "TNV", true);
            SV s3 = new SV("102160777", "Bu Bu 1", DateTime.Now.Date, "TNV", true);
            this.listSV.Add(s1);
            this.listSV.Add(s2);
            this.listSV.Add(s3);
        }
        public List<SV> getListSV()
        {
            return this.listSV;
        }
        //https://stackoverflow.com/questions/3545731/problems-removing-elements-from-a-list-when-iterating-through-the-list
        public List<SV> delSV(string ms)
        {

            for (int i = 0; i < listSV.Count; i++)
            {
                if (listSV[i].mssv == ms)
                {
                    this.listSV.RemoveAt(i);
                    i--;
                    break;
                }
            }
            //foreach (SV i in listSV.ToArray())
            //{
            //    if (i.mssv == ms)
            //    {
            //        listSV.Remove(i);
            //        break;
            //    }
            //}
            return listSV.ToList();
        }
        public List<SV> Update(SV s)
        {
            int i = 0;
            for (; i < listSV.Count; i++)
            {
                if (listSV[i].mssv == s.mssv)
                {
                    listSV[i].name = s.name;
                    listSV[i].birthday = s.birthday;
                    listSV[i].address = s.address;
                    listSV[i].gender = s.gender;
                }
            }
            return this.listSV;
        }
        public List<SV> AddSV(SV s)
        {
            listSV.Add(s);
            return this.listSV;
        }
        public List<SV> ListSearch(string txt)
        {
            List<SV> lsSV = new List<SV>(); 
            int i = 0;
            for (; i < listSV.Count; i++)
            {
                if((listSV[i].mssv.Contains(txt)) ||(listSV[i].name.Contains(txt)) ||(listSV[i].address.Contains(txt)))
                {
                    lsSV.Add(listSV[i]);
                }
            }
            return lsSV;
        }
    }
}
