using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDeTai_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            QLDT_LINQDataContext db = new QLDT_LINQDataContext();
            var dt0 = from p in db.DeTais
                     select new { p.TenDeTai, p.CapDeTai.TenCapDeTai };

            var dt0_1 = db.DeTais.Select(p => p).ToList();
            //dataGrid.DataSource = dt.ToList();

            //select truong co Pk,FK
            var dt0_2 = db.DeTais.Select(p => new { p.MaDeTai, p.TenDeTai, p.CapDeTai.TenCapDeTai }).ToList();
            //dataGrid.DataSource = dt.ToList();

            var dt1 = from p in db.DeTais
                      orderby p.TenDeTai descending
                      select new { p.TenDeTai, p.CapDeTai.TenCapDeTai };
            //dataGrid.DataSource = dt1;

            var dt2 = from p in db.DeTais
                      where p.MaDeTai == "DT01"
                      select new { p.MaDeTai, p.TenDeTai, p.ChuNhiem };
            //dataGrid.DataSource = dt2;

            var dt3 = db.DeTais.Where(p => p.MaDeTai == "DT01");
            var dt3_1 = db.DeTais.Select(p => p).Where(p => p.MaDeTai == "DT01");
            //dataGrid.DataSource = dt3;
            //dataGrid.DataSource = dt3_1;

            var dt3_2 = from p in db.DeTais
                      where p.TenDeTai.Contains("li")
                      select new { p.MaDeTai, p.TenDeTai, p.CapDeTai.TenCapDeTai };
            //dataGrid.DataSource = dt3_2;

            var dt4 = from p in db.DeTais
                      join k in db.CapDeTais
                      on p.MaCapDeTai equals k.MaCapDeTai
                      select new { p.MaDeTai, p.TenDeTai, k.TenCapDeTai };
            dataGrid.DataSource = dt4;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            QLDT_LINQDataContext db = new QLDT_LINQDataContext();
            try
            {
                DeTai insDetai = new DeTai();
                insDetai.MaDeTai = txtMa.Text.Trim();
                insDetai.TenDeTai = txtTen.Text.Trim();
                if (rdHThanh.Checked) insDetai.TinhTrang = true;
                else insDetai.TinhTrang = false;
                insDetai.NgayNhanDeTai = dpkNgayNhan.Value;
                insDetai.MaCapDeTai = db.CapDeTais.Where(p => p.TenCapDeTai.Equals(cbbCapDeTai.SelectedItem.ToString())).Select(p => p.MaCapDeTai).SingleOrDefault().ToString();
                insDetai.ChuNhiem = cbbChuNhiem.SelectedItem.ToString();
                db.DeTais.InsertOnSubmit(insDetai);
            }
            finally
            {
                db.SubmitChanges();
                MessageBox.Show("Success!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            QLDT_LINQDataContext db = new QLDT_LINQDataContext();
            var xoa = db.DeTais.Where(p => p.MaDeTai.Equals(dataGrid.CurrentRow.Cells[0].Value.ToString()));
            foreach(var i in xoa)
            {
                db.DeTais.DeleteOnSubmit(i);
                db.SubmitChanges();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            QLDT_LINQDataContext db = new QLDT_LINQDataContext();

            var DeTaiUpdate = db.DeTais.Single(p=>p.MaDeTai == dataGrid.CurrentRow.Cells[0].Value.ToString());
            DeTaiUpdate.TenDeTai = txtTen.Text.Trim();
            if (rdHThanh.Checked) DeTaiUpdate.TinhTrang = true;
            else DeTaiUpdate.TinhTrang = false;
            DeTaiUpdate.NgayNhanDeTai = dpkNgayNhan.Value;
            DeTaiUpdate.MaCapDeTai = db.CapDeTais.Where(p => p.TenCapDeTai.Equals(cbbCapDeTai.SelectedItem.ToString())).Select(p => p.MaCapDeTai).SingleOrDefault().ToString();
            DeTaiUpdate.ChuNhiem = cbbChuNhiem.SelectedItem.ToString();
            db.SubmitChanges();
        }

        private void rdHThanh_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Add");
        }
    }
}
