using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; // chu y

namespace QuanLySV_DataConnection
{
    public partial class SVForm : Form
    {
        public SVForm()
        {
            
            InitializeComponent();
            LoadCBB();
        }
        public void LoadCBB()
        {
            string con = @"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            string query;
            query = "SELECT Address FROM SinhVien";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader r;
            cnn.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                string diachi = r["Address"].ToString();
                if (cbbAdd.FindStringExact(diachi) < 0)
                    cbbAdd.Items.Add(diachi);
            }
            r.Close();
            cnn.Close();
        }
        //show list SV = lenh Select 
        private void btnShow_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            string query1 = "Select * from SinhVien";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, cnn);
            cnn.Open();
            DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //foreach(DataRow i in ds.Tables[0].Rows)
            adapter.Fill(ds,"SV");
            foreach (DataRow i in ds.Tables["SV"].Rows)
            {
                cbbAdd.Items.Add(i["Address"]);
            }
            dataGrid.DataSource = ds.Tables[0];
            //MessageBox.Show(cnn.State.ToString());
            cnn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string con = @"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True";
            ////c1 : 
            ////SqlConnection cnn = new SqlConnection();
            ////cnn.ConnectionString = con;
            /////c2 :
            //SqlConnection cnn = new SqlConnection(con);



            //string query1 = "Select * from SinhVien";
            //SqlCommand cmd1 = new SqlCommand(query1, cnn);
            //SqlDataReader r;
            //cnn.Open();
            //r = cmd1.ExecuteReader();
            //while (r.Read())
            //{
            //    comboBox2.Items.Add(r["Address"]);
            //}
            //r.Close();

            ////MessageBox.Show(cnn.State.ToString());
            //cnn.Close();
            string con = @"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            string query1 = "INSERT INTO SinhVien VALUES('" + txtMSSV.Text + "','"
                + txtName.Text + "','"
                + String.Format("{0:yyyy-MM-d }", dpkBirthday.Value) + "','"
                + cbbAdd.SelectedItem.ToString() + "','"
                + rdMale.Checked + "')";
            SqlCommand cmd = new SqlCommand(query1, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            //dataGrid.DataSource = 
            //MessageBox.Show(cnn.State.ToString());
            show();
            cnn.Close();
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string mssv_ = dataGrid.SelectedRows[0].Cells["MSSV"].Value.ToString();
            string con = @"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            string query1 = "select * from SinhVien where mssv=" + mssv_;
            SqlCommand cmd1 = new SqlCommand(query1, cnn);
            SqlDataReader r;
            cnn.Open();
            r = cmd1.ExecuteReader();
            while (r.Read())
            {
                txtMSSV.Text = r["MSSV"].ToString();
                txtName.Text = r["Name"].ToString();
                dpkBirthday.Value =Convert.ToDateTime( r["Birthday"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            string ten;
            ten = txtSearch.Text;
            string con = @"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            string query;
            query = "Select * from SinhVien where Name like '%" + txtSearch.Text + "%';";
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            cnn.Open();
            adapter.Fill(ds);
            dataGrid.DataSource = ds.Tables[0];
            cnn.Close();
        }
        private void show()
        {
            string con = @"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            string query;
            query = "SELECT * FROM SinhVien ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            cnn.Open();
            adapter.Fill(ds);
            dataGrid.DataSource = ds.Tables[0];
            cnn.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach(DataGridViewRow item in dataGrid.SelectedRows)
            {
                list.Add(item.Cells["MSSV"].Value.ToString());
            }
            
            SqlConnection cnn = DbUtil.openConnection();
            cnn.Open();
            string query;
            try
            {
                foreach (string s in list)
                {
                    query = "Delete from SinhVien where "
            + "MSSV = '" + s + "' ;";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
                }
                show();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally {
                cnn.Close();
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            string query;
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            query = "update SinhVien "
                + "set Name = @nameVar , Birthday = @birVar,Address = @addVar,Gender = @genVar  " +
                "where MSSV = @mssvVar ";
            cmd.CommandText = query;


            cmd.Parameters.AddWithValue("@nameVar", txtName.Text);
            cmd.Parameters.AddWithValue("@birVar", String.Format("{0:yyyy-MM-dd}", dpkBirthday.Value));
            cmd.Parameters.AddWithValue("@addVar", cbbAdd.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@genVar", rdMale.Checked);
            cmd.Parameters.AddWithValue("@mssvVar", txtMSSV.Text);
            cmd.ExecuteNonQuery();
            show();
            cnn.Close();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            //SqlConnection cnn = DbUtil.openConnection();
            //cnn.Open();
            //string querySearch = "select * from SinhVien where Name Like '%" + txtSearch.Text+ "%'";
            //DataTable dtb;
            //try
            //{
            //    SqlDataAdapter adapter = new SqlDataAdapter(querySearch, cnn);
            //    dtb = new DataTable();
            //    adapter.Fill(dtb);
            //    dataGrid.DataSource = dtb;
            //}catch(Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    cnn.Close();
            //}
            
        }

        public delegate void DD();
        public DD d;

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            if (txtMSSV.Text.Length>10) MessageBox.Show("Khong Nhap Qua 10 Kí tự");
        }
    }                           
}
