using _3Layers.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace _3Layers.DAL
{
    public class SV_DAL
    {
        public DataHelper dh { get; set; }
        public SV_DAL()
        {
            this.dh = new DataHelper(@"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True");
        }
        //Get list SV
        public List<SV> GetListSV()
        {
            List<SV> list = new List<SV>();
            //to do
            string queryShow = "select * from SinhVien";
            foreach (System.Data.DataRow i in dh.GetTable(queryShow).Rows)
            {
                list.Add(GetSV(i));
            }
            return list;
        }
        public SV GetSV(DataRow d)
        {
            return (new SV
            {
                mssv = d["MSSV"].ToString(),
                name = d["Name"].ToString(),
                birthday = Convert.ToDateTime(d["Birthday"].ToString()),
                address = d["Address"].ToString(),
                gender = Convert.ToBoolean(d["Gender"].ToString())
            });
        }
        public List<string> getListAddressSV()
        {
            List<string> listAdd = new List<string>();
            string queryAdd = " select distinct Address from SinhVien";
            foreach(DataRow r in dh.GetTable(queryAdd).Rows)
            {
                listAdd.Add(r["Address"].ToString());
            }
            return listAdd;
        }
        public void AddSV(SV s)
        {
            string queryInsert = "INSERT INTO SinhVien VALUES('" + s.mssv + "','"
                + s.name + "','"
                + String.Format("{0:yyyy-MM-d }", s.birthday.ToString()) + "','"
                + s.address + "','"
                + s.gender.ToString() + "')";
            dh.excuteMainQuery(queryInsert);
        }
        public SV GetSVByMssv(string str)
        {
            string querySvByMs = "  select *  from SinhVien where MSSV = '" + str + "'";
            return GetSV(dh.GetTable(querySvByMs).Rows[0]);
        }
        public void UpdateSV(SV s)
        {
            string queryUpdate = "update SinhVien set Name = '"
                + s.name + "', Birthday ='" + String.Format("{0:yyyy-MM-dd}",s.birthday)
                + "',Address = '" +s.address + "',Gender =  '" + s.gender + "' where mssv= " + s.mssv;
            dh.excuteMainQuery(queryUpdate);
        }
        public void DeleteSv(List<string> lsMs)
        {
            string queryDelete;
            foreach (string s in lsMs)
            {
                queryDelete = "DELETE FROM SinhVien where " + "MSSV = N'" + s + "' ;";
                dh.excuteMainQuery(queryDelete);
            }
        }
        public List<SV> SearchListSV(string s)
        {
            string querySearch = "select * from SinhVien where Name Like '%" + s + "%'";
            List<SV> listAdd = new List<SV>();
            foreach (DataRow r in dh.GetTable(querySearch).Rows)
            {
                listAdd.Add(GetSV(r));
            }
            return listAdd;
        }
    }
}
