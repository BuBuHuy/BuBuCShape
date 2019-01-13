using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace QuanLyHocPhan
{
    class Context : DbContext
    {
        public virtual DbSet<Entity.GiangVien> GiangViens { set; get; }
        public virtual DbSet<Entity.HocPhan> HocPhans { set; get; }
        public virtual DbSet<Entity.GV_HP> GV_HPs { set; get; }
        public Context() : base("QuanLyHPModel")
        {
            Database.SetInitializer<Context>(new DBInitialization());
        }
        public class DBInitialization :     CreateDatabaseIfNotExists<Context>
        {
            protected override void Seed(Context context)
            {
                Entity.GiangVien gv1 = new Entity.GiangVien();
                gv1.MSGV = "GV001";
                gv1.TenGV = "Nguyễn Thu Thảo";
                gv1.GioiTinh = false;
                gv1.HocHam = "Giáo sư";
                gv1.NgaySinh = Convert.ToDateTime("1997-12-12");
                gv1.HocVi = "Tiến sĩ"; ;
                gv1.Khoa = "CNTT";

                Entity.HocPhan hp1 = new Entity.HocPhan();
                hp1.MSHP = "HP001";
                hp1.TenHP = "Lập trình Java";

                Entity.GV_HP gv_hp1 = new Entity.GV_HP();
                gv_hp1.MSGV = "GV001";
                gv_hp1.MSHP = "HP001";

                context.GiangViens.Add(gv1);
                context.HocPhans.Add(hp1);
                context.GV_HPs.Add(gv_hp1);
                context.SaveChanges();
            }
        }
    }
}
