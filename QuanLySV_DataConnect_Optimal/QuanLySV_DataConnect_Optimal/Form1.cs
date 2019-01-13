using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySV_DataConnect_Optimal
{
    public partial class Form1 : Form
    {
        DataHelper dh;
        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper(@"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True");
            LoadCBB();
        }
        public void LoadCBB()
        {
            string queryShow = "select Address from SinhVien";
            DataTable dtb = this.dh.getListSV(queryShow);
            foreach(DataRow r in dtb.Rows)
            {
                string diachi = r["Address"].ToString();
                if (cbbAdd.FindStringExact(diachi) < 0)
                    cbbAdd.Items.Add(diachi);
            }
        }
        static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string queryShow = "Select * from SinhVien";
            DataTable dtb = this.dh.getListSV(queryShow);
            //DataTable dtb1 = dtb.Clone();

            //foreach (DataRow dtbOld in dtb.Rows)
            //{

            //        dtb1.ImportRow(dtbOld);
            //}
            //dtb1.Columns.Add("ID", typeof(int));
            //int i = 0;
            //foreach (DataRow r in dtb.Rows)
            //{

            //    r["ID"] = i++;
            //}
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "Column 1", "Column 2", "Column 3" });
            list.Add(new string[] { "Row 2", "Row 2" });
            list.Add(new string[] { "Row 3" });

            // Convert to DataTable.
            DataTable table = ConvertListToDataTable(list);
            dataGrid.DataSource = table;
            //dataGrid.DataSource = dtb;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query1 = "INSERT INTO SinhVien VALUES('" + txtMSSV.Text + "','"
                + txtName.Text + "','"
                + String.Format("{0:yyyy-MM-d }", dpkBirthday.Value) + "','"
                + cbbAdd.SelectedItem.ToString() + "','"
                + rdMale.Checked + "')";
            this.dh.excuteMainQuery(query1);
            string queryShow = "Select * from SinhVien";
            dataGrid.DataSource = this.dh.getListSV(queryShow);
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            string queryRow = "select * from SinhVien where mssv=" + dataGrid.SelectedRows[0].Cells["MSSV"].Value.ToString();
            DataTable dtb = this.dh.getListSV(queryRow);
            foreach(DataRow r in dtb.Rows)
            {
                txtMSSV.Text = r["MSSV"].ToString();
                txtName.Text = r["Name"].ToString();
                dpkBirthday.Value = Convert.ToDateTime(r["Birthday"].ToString());
                cbbAdd.SelectedIndex = cbbAdd.FindStringExact(r["Address"].ToString());
                if (Convert.ToBoolean(r["Gender"]) == true)
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }
            }
        }
       // public delegate void DD(string mssv,string name,string,public DateTime birthday,string address, bool gender)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update SinhVien set Name = '"
                + txtName.Text + "', Birthday ='" + String.Format("{0:yyyy-MM-dd}", dpkBirthday.Value)
                + "',Address = '" + cbbAdd.SelectedItem.ToString() + "',Gender =  '" + rdMale.Checked + "' where mssv= " + txtMSSV.Text;
            this.dh.excuteMainQuery(query);
            string queryShow = "Select * from SinhVien";
            dataGrid.DataSource = this.dh.getListSV(queryShow);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query;
            List<string> list = new List<string>();
            foreach (DataGridViewRow item in dataGrid.SelectedRows)
            {
                list.Add(item.Cells["MSSV"].Value.ToString());
            }
            foreach (string s in list)
            {
                query = "Delete from SinhVien where "
        + "MSSV = '" + s + "' ;";
                this.dh.excuteMainQuery(query);
            }
            string queryShow = "Select * from SinhVien";
            dataGrid.DataSource = this.dh.getListSV(queryShow);
        }
    }
}
