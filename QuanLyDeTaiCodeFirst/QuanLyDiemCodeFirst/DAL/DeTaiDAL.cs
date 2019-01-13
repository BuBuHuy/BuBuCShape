using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QuanLyDiemCodeFirst.Entity;
namespace QuanLyDiemCodeFirst.DAL
{
    public class DeTaiDAL
    {
        public DataTable getListDT_dal()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã đề tài");
            tb.Columns.Add("Tên đề tài");
            tb.Columns.Add("Tình trạng");
            tb.Columns.Add("Ngày nhận");
            tb.Columns.Add("Chủ nhiệm");
            tb.Columns.Add("Mã cấp đề tài");
            using (Context m = new Context())
            {
                var v = m.DeTais.Select(p => p);
                foreach (var x in v)
                {
                    DataRow r = tb.NewRow();
                    r["Mã đề tài"] = x.MaDeTai.Trim();
                    r["Tên đề tài"] = x.TenDeTai;
                    r["Tình trạng"] = x.TinhTrang;
                    r["Ngày nhận"] = x.NgayNhanDeTai;
                    r["Chủ nhiệm"] = x.ChuNhiem;
                    r["Mã cấp đề tài"] = x.MaCapDeTai;
                    tb.Rows.Add(r);
                }
                return tb;
            }
        }
        public List<string> loadTenCDT_dal()
        {
            Context m  = new Context();
            List<string> list = new List<string>();
            var v = from s in m.CapDeTais
                    orderby s.TenCapDeTai
                    select s.TenCapDeTai;
            foreach (var x in v)
            {
                list.Add(x);
            }
            return list;
        }

        public List<string> loadTenCN_dal()
        {
            Context m = new Context();
            List<string> list = new List<string>();
            var v = from s in m.DeTais
                    orderby s.ChuNhiem
                    select s.ChuNhiem;
            foreach (var x in v.Distinct())
            {
                list.Add(x);
            }
            return list;
        }

        public void addDeTai_dal(Entity.DeTai dt)
        {
            using (Context m = new Context())
            {
                m.DeTais.Add(new DeTai
                {
                    MaDeTai = dt.MaDeTai,
                    TenDeTai = dt.TenDeTai,
                    TinhTrang = dt.TinhTrang,
                    NgayNhanDeTai = dt.NgayNhanDeTai,
                    ChuNhiem = dt.ChuNhiem,
                    MaCapDeTai = dt.MaCapDeTai
                });
                m.SaveChanges();
            }
        }
        public string getMaCDTFormTenCDT_dal(string tenCDT)
        {
            using (Context m = new Context())
            {
                var v = m.CapDeTais.Where(p => p.TenCapDeTai == tenCDT).Select(p => p.MaCapDeTai).SingleOrDefault();
                return v.ToString().Trim();

            }
        }
        public bool checkExist_dal(string ma)
        {
            using (Context m = new Context())
            {
                var v = m.DeTais.Select(s => s).Where(s => s.MaDeTai.Trim() == ma).Count();
                return Convert.ToInt16(v) > 0;
            }
        }
        public void updateDeTai_dal(Entity.DeTai dt)
        {
            using(Context m = new Context()){
                DeTai dtUp = m.DeTais.Find(dt.MaDeTai);
                dtUp.TenDeTai = dt.TenDeTai;
                dtUp.TinhTrang = dt.TinhTrang;
                dtUp.NgayNhanDeTai = dt.NgayNhanDeTai;
                dtUp.ChuNhiem = dt.ChuNhiem;
                dtUp.MaCapDeTai = dt.MaCapDeTai;
                m.SaveChanges();
            }
        }
        public DataTable searchByMaDT_dal(string mDT)
        {
            using(Context m  = new Context())
            {
                var v = m.DeTais.Find(mDT);
                DataTable tb = new DataTable();
                tb.Columns.Add("Mã đề tài");
                tb.Columns.Add("Tên đề tài");
                tb.Columns.Add("Tình trạng");
                tb.Columns.Add("Ngày nhận");
                tb.Columns.Add("Chủ nhiệm");
                tb.Columns.Add("Mã cấp đề tài");
                DataRow r = tb.NewRow();
                r["Mã đề tài"] = v.MaDeTai.Trim();
                r["Tên đề tài"] = v.TenDeTai;
                r["Tình trạng"] = v.TinhTrang;
                r["Ngày nhận"] = v.NgayNhanDeTai;
                r["Chủ nhiệm"] = v.ChuNhiem;
                r["Mã cấp đề tài"] = v.MaCapDeTai;
                tb.Rows.Add(r);

                return tb;
            }
        }
        public string getTenCDTFormMa_dal(string maCDT)
        {
            using(Context m = new Context())
            {
                return m.CapDeTais.Where(p => p.MaCapDeTai == maCDT).Select(p => p.TenCapDeTai).SingleOrDefault().ToString();
            }
        }
        public void deleteDeTai_dal(string maDT)
        {
            using(Context m = new Context())
            {
                DeTai dt = m.DeTais.Find(maDT);
                if (dt != null)
                {
                    m.DeTais.Remove(dt);
                }
                m.SaveChanges();
            }
        }
        public DataTable Sort_dal(int type)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã đề tài");
            tb.Columns.Add("Tên đề tài");
            tb.Columns.Add("Tình trạng");
            tb.Columns.Add("Ngày nhận");
            tb.Columns.Add("Chủ nhiệm");
            tb.Columns.Add("Mã cấp đề tài");
            using (Context m = new Context())
            {
                if (type == 0)
                {
                    var v = m.DeTais.Select(p => p).OrderBy(p => p.TenDeTai);
                    foreach (var x in v)
                    {
                        DataRow r = tb.NewRow();
                        r["Mã đề tài"] = x.MaDeTai.Trim();
                        r["Tên đề tài"] = x.TenDeTai;
                        r["Tình trạng"] = x.TinhTrang;
                        r["Ngày nhận"] = x.NgayNhanDeTai;
                        r["Chủ nhiệm"] = x.ChuNhiem;
                        r["Mã cấp đề tài"] = x.MaCapDeTai;
                        tb.Rows.Add(r);
                    }
                }
                if (type == 1)
                {
                    var v1 = m.DeTais.Select(p => p).OrderBy(p => p.MaCapDeTai);
                    foreach (var x in v1)
                    {
                        DataRow r = tb.NewRow();
                        r["Mã đề tài"] = x.MaDeTai.Trim();
                        r["Tên đề tài"] = x.TenDeTai;
                        r["Tình trạng"] = x.TinhTrang;
                        r["Ngày nhận"] = x.NgayNhanDeTai;
                        r["Chủ nhiệm"] = x.ChuNhiem;
                        r["Mã cấp đề tài"] = x.MaCapDeTai;
                        tb.Rows.Add(r);
                    }
                }

                return tb;
            }
        }
        public DataTable searchDT_dal(string str)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã đề tài");
            tb.Columns.Add("Tên đề tài");
            tb.Columns.Add("Tình trạng");
            tb.Columns.Add("Ngày nhận");
            tb.Columns.Add("Chủ nhiệm");
            tb.Columns.Add("Mã cấp đề tài");
            using (Context m = new Context())
            {
                var v = m.DeTais.Where(p=>p.TenDeTai.Contains(str)||p.ChuNhiem.Contains(str)).Select(p => p);
                foreach (var x in v)
                {
                    DataRow r = tb.NewRow();
                    r["Mã đề tài"] = x.MaDeTai.Trim();
                    r["Tên đề tài"] = x.TenDeTai;
                    r["Tình trạng"] = x.TinhTrang;
                    r["Ngày nhận"] = x.NgayNhanDeTai;
                    r["Chủ nhiệm"] = x.ChuNhiem;
                    r["Mã cấp đề tài"] = x.MaCapDeTai;
                    tb.Rows.Add(r);
                }
                return tb;
            }
        }
    }
   
}
