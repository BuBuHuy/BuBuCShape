using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySV_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            QLSV_LINQDataContext db = new QLSV_LINQDataContext();
            var sv = from p in db.SinhViens
                     select p;
            dataGrid.DataSource = sv.ToList();
        }
    }
}
