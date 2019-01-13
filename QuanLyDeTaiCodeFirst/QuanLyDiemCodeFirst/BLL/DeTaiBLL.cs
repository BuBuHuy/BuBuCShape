using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyDiemCodeFirst.BLL
{
    public class DeTaiBLL
    {
        DAL.DeTaiDAL dal = new DAL.DeTaiDAL();
        // list de tai
        public DataTable getListDT_bll()
        {
            return dal.getListDT_dal();
        }
        // update de tai
        public void addDeTai_bll(Entity.DeTai dt)
        {
            dal.addDeTai_dal(dt);
        }
        //load cbb ten de tai
        public List<string> loadTenCDT_bll()
        {
            return dal.loadTenCDT_dal();
        }
        //load cbb chu nhiem
        public List<string> loadTenCN_bll()
        {
            return dal.loadTenCN_dal();
        }
        public string getMaCDTFormTenCDT_bll(string tenCDT)
        {
            return dal.getMaCDTFormTenCDT_dal(tenCDT);
        }
        public bool checkExist_bll(string ma)
        {
            return dal.checkExist_dal(ma);
        }
        public void updateDeTai_bll(Entity.DeTai dt)
        {
            dal.updateDeTai_dal(dt);
        }
        public DataTable searchByMaDT_bll(string mDT)
        {
            return dal.searchByMaDT_dal(mDT);
        }
        public string getTenCDTFormMa_bll(string maCDT)
        {
            return dal.getTenCDTFormMa_dal(maCDT);
        }
        public void deleteDeTai_bll(string maDT)
        {
            dal.deleteDeTai_dal(maDT);
        }
        public DataTable Sort_bll(int type)
        {
            return dal.Sort_dal(type);
        }
        public DataTable searchDT_bll(string str)
        {
            return dal.searchDT_dal(str);
        }
    }
}
