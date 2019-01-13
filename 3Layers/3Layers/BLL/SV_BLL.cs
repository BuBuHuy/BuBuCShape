using _3Layers.DAL;
using _3Layers.DTO;
using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;

namespace _3Layers.BLL
{
    public class SV_BLL
    {
        public SV_DAL dal { get; set; }
        public SV_BLL()
        {
            this.dal = new SV_DAL();
        }
        public List<SV> GetListSV_BLL()
        {
            return dal.GetListSV();
        }
        public void AddSV_BLL(SV s)
        {
            dal.AddSV(s);
        }
        public List<string> GetListAddress()
        {
            return dal.getListAddressSV();
        }
        public SV getSVByMssv_BLL(string b_mssv)
        {
            return dal.GetSVByMssv(b_mssv);
        }
        public void UpdateSv_BLL(SV s)
        {
            dal.UpdateSV(s);
        }
        public void DeleteSv_BLL(List<string> lsMs)
        {
            dal.DeleteSv(lsMs);
        }
        public List<SV> SearchSV_BLL(string s)
        {
            return dal.SearchListSV(s);
        }
       
    }
}
