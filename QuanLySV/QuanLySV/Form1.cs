using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySV
{
    
    public partial class Form1 : Form
    {

        QLSV db;
        public Form1()
        {
            InitializeComponent();
            this.db = new QLSV();
            LoadCBB();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = db.getListSV();
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            textBox1.Text = dataGrid.SelectedRows[0].Cells["MSSV"].Value.ToString();
            textBox2.Text = dataGrid.SelectedRows[0].Cells["Name"].Value.ToString();
            bool gender = Convert.ToBoolean(dataGrid.SelectedRows[0].Cells["Gender"].Value);
            if (gender == true)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            DateTime d = Convert.ToDateTime(dataGrid.SelectedRows[0].Cells["Birthday"].Value);
            dateTimePicker1.Value = d;
            string address = dataGrid.SelectedRows[0].Cells["Address"].Value.ToString();
            int index = comboBox2.FindStringExact(address);
            comboBox2.SelectedIndex = index;
        }
        public void LoadCBB()
        {
            foreach(SV i in this.db.getListSV())
            {
                if (comboBox2.FindStringExact(i.address.ToString()) < 0)
                {
                    comboBox2.Items.Add(i.address.ToString());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
                string delMS = dataGrid.SelectedRows[0].Cells["MSSV"].Value.ToString();
            dataGrid.DataSource = this.db.delSV(delMS);
        }
     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Ad = comboBox2.SelectedItem.ToString();
            SV addS = new SV(textBox1.Text, textBox2.Text, dateTimePicker1.Value, Ad, radioButton1.Checked);
            dataGrid.DataSource = this.db.AddSV(addS);
            dataGrid.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Ad = comboBox2.SelectedItem.ToString();
            SV newS= new SV(textBox1.Text, textBox2.Text, dateTimePicker1.Value, Ad, radioButton1.Checked);
            dataGrid.DataSource = this.db.Update(newS);
            dataGrid.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = this.db.ListSearch(textBox3.Text);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
