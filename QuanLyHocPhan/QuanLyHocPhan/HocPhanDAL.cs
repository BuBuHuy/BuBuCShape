using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyHocPhan
{
    class HocPhanDAL
    {
        public DataTable getListHP_dal()
        {
            using(Context m = new Context())
            {

                var v = m.GV_HPs.Select(p => new
                {
                    p.GV.MSGV,
                    p.GV.TenGV,
                    p.GV.NgaySinh,
                    p.GV.GioiTinh,
                    p.GV.HocHam,
                    p.GV.HocVi,
                    p.GV.Khoa,
                    p.HP.TenHP,

                });
                DataTable tb = new DataTable();
                tb.Columns.Add("MSGV");
                tb.Columns.Add("TenGV");
                tb.Columns.Add("NgaySinh");
                tb.Columns.Add("GioiTinh");
                tb.Columns.Add("HocHam");
                tb.Columns.Add("HocVi");
                tb.Columns.Add("Khoa");
                tb.Columns.Add("TenHP");
                foreach(var x in v)
                {
                    DataRow r = tb.NewRow();
                    r["MSGV"] = x.MSGV;
                    r["TenGV"] = x.TenGV;
                    r["NgaySinh"] =x.NgaySinh;
                    r["GioiTinh"] = x.GioiTinh;
                    r["HocHam"] = x.HocHam;
                    r["HocVi"]= x.HocVi;
                    r["Khoa"] = x.Khoa;
                    r["TenHP"] = x.TenHP;
                    tb.Rows.Add(r);
                }
                return tb;
            }
        }
        public List<string> loadCbb_dal(int type)
        {
            List<string> s = new List<string>();
            using (Context m = new Context())
            {
                if (type == 1)
                {
                    var v = m.GiangViens.Select(p => p.Khoa).Distinct();
                    if (v != null)
                    {
                        foreach (var x in v)
                        {
                            s.Add(x);
                        }
                    }
                    return s;
                }
                else
                {
                    var v = m.HocPhans.Select(p => p.TenHP).Distinct();
                    if (v != null)
                    {
                        foreach (var x in v)
                        {
                            s.Add(x);
                        }
                    }
                    return s;
                }
            }
        }
        public bool ExistedMSGV_dal(string msgv)
        {
            using(Context m = new Context())
            {
                return m.GiangViens.Where(p => p.MSGV == msgv).Count() > 0;
            }
        }
        public bool ExistedPairGV_HP_dal(string msgv, string tenHP)
        {
            using (Context m = new Context())
            {
                var v = m.GV_HPs.Where(p=> p.MSGV == msgv).Select(P=>P.HP.TenHP);
                return v.Single() == tenHP;
            }
        }
        public void addGV_dal(Entity.GiangVien gv)
        {
            using (Context m = new Context())
            {
                m.GiangViens.Add(new Entity.GiangVien
                {
                    MSGV = gv.MSGV,
                    TenGV = gv.TenGV,
                    NgaySinh = gv.NgaySinh,
                    GioiTinh = gv.GioiTinh,
                    HocHam = gv.HocHam,
                    HocVi = gv.HocVi,
                    Khoa = gv.Khoa,

                });
                m.SaveChanges();
            }
        }
        public string getMSHPFormTenHp_dal(string ten)
        {
            using (Context m = new Context())
            {
                return m.HocPhans.Where(p => p.TenHP == ten).Select(p => p.MSHP).Single();
            }
        }
        public void addGV_HP_dal(Entity.GV_HP gvhp)
        {
            using (Context m = new Context())
            {
                m.GV_HPs.Add(new Entity.GV_HP
                {
                    MSGV = gvhp.MSGV,
                    MSHP = gvhp.MSHP
                });
                m.SaveChanges();
            }
        }
        ///////////
        public void delGV_HP_dal(Entity.GV_HP gvhp)
        {
            using (Context m = new Context())
            {
                Entity.GV_HP del = m.GV_HPs.Where(p => p.MSGV == gvhp.MSGV && p.MSHP == gvhp.MSHP).Select(p => p).SingleOrDefault();
                if (del != null)
                {
                    m.GV_HPs.Remove(del);
                    m.SaveChanges();
                }
            }
        }
    }
}
