using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CshapeWinforBasic
{
    public partial class DataGridViewDemo : Form
    {
        public DataGridViewDemo()
        {
            InitializeComponent();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllNV().Tables[0];
        }
        DataSet GetAllNV()
        {
            DataSet data = new DataSet();
            //SQlConnection
            int id = 2;
            //string query = "Select * from NhanVien where Id =" + id.ToString();
            string query = "Select * from NhanVien where Id = @id" ;
            string query1 = "Select count(*) from NhanVien";
            using (SqlConnection connection =    new SqlConnection(ConnectionString.connectingString))
            {
                
                connection.Open();
                //SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                //adapter.Fill(data);
                SqlCommand command = new SqlCommand(query, connection);
                SqlCommand command1 = new SqlCommand(query1, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.AddWithValue("@id", id);
                adapter.Fill(data);
                int count = (int)command1.ExecuteScalar();
                MessageBox.Show(count.ToString());
                connection.Close();

            }
            return data;
            //SQL Command
            //SQL DataAdapter
        }

    }
}
