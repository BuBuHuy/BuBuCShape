using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyHocPhan
{
    class HocPhanBLL
    {
        HocPhanDAL dal = new HocPhanDAL();
        public DataTable getListHP_bll()
        {
            return dal.getListHP_dal();
        }
        public List<string> loadCbb_bll(int type)
        {
            return dal.loadCbb_dal(type);
        }
        public bool ExistedMSGV_bll(string msgv)
        {
            return dal.ExistedMSGV_dal(msgv);
        }
        public bool ExistedPairGV_HP_bll(string msgv, string tenHP)
        {
            return dal.ExistedPairGV_HP_dal(msgv, tenHP);
        }
        public void addGV_bll(Entity.GiangVien gv)
        {
            dal.addGV_dal(gv);
        }
        public void addGV_HP_bll(Entity.GV_HP gvhp)
        {
            dal.addGV_HP_dal(gvhp);
        }
        public string getMSHPFormTenHp_bll(string ten)
        {
            return dal.getMSHPFormTenHp_dal(ten);
        }
        public void delGV_HP_bll(Entity.GV_HP gvhp)
        {
            dal.delGV_HP_dal(gvhp);
        }
    }
}
