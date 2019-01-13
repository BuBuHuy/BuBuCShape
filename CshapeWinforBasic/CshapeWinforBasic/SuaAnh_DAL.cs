using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CshapeWinforBasic
{
    class SuaAnh_DAL
    {
        public void luuAnh_DAL(string ID, byte[] a)
        {
            using (imageEntities db = new imageEntities())
            {
                GiangVien img = (from c in db.GiangViens
                               where c.ID == ID
                               select c).SingleOrDefault();
                img.Image = a;
                db.SaveChanges();
            }
        }
        public byte[] loadAnh(string ID)
        {
            using (imageEntities db = new imageEntities())
            {
                GiangVien img = (from c in db.GiangViens
                                 where c.ID == ID
                                 select c).SingleOrDefault();
                if (img == null) return null;
                else return img.Image.ToArray();
            }
        }
    }
}
