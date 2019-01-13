using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace QuanLyDiemCodeFirst
{
    class Context : DbContext
    {
        public virtual DbSet<Entity.DeTai> DeTais { set; get; }
        public virtual DbSet<Entity.CapDeTai> CapDeTais { set; get; }
        public Context() : base("name = QuanLyDeTaiModel")
        {
            Database.SetInitializer<Context>(new DBInitialization());
        }
        public class DBInitialization : CreateDatabaseIfNotExists<Context>{
            protected override void Seed(Context context)
            {
                Entity.DeTai dt1 = new Entity.DeTai();
                dt1.MaDeTai = "DT001";
                dt1.TenDeTai = "Lập Trình .NET";
                dt1.TinhTrang = false;
                dt1.MaCapDeTai = "1";
                dt1.NgayNhanDeTai = Convert.ToDateTime("1905-06-28");
                dt1.ChuNhiem = "Đặng Hoài Phương";

                Entity.CapDeTai cdt1 = new Entity.CapDeTai();
                cdt1.MaCapDeTai = "1";
                cdt1.TenCapDeTai = "Cấp Nhà Nước";

                context.DeTais.Add(dt1);
                context.CapDeTais.Add(cdt1);

                context.SaveChanges();
            }
        }
    }
}
