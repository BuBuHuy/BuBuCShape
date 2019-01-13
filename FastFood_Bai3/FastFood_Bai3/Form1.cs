using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastFood_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initItemCb();
            initDataTable();
            button1.Click += Add;
            button2.Click += Add;
            button3.Click += Add;
            button4.Click += Add;
            button5.Click += Add;
            button6.Click += Add;
            button7.Click += Add;
            button8.Click += Add;
            button9.Click += Add;
            button10.Click += Add;
            button11.Click += Add;
            button12.Click += Add;
            List<Button> list = new List<Button>();
        }
        public void initItemCb()
        {
            for (int i = 1; i <= 12; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }
        public void initDataTable()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnCount = 2;
            dataGridView1.ColumnHeadersVisible = true;
                //    dataGridView1.Columns.Add("food","Món ăn");
                //    dataGridView1.Columns.Add("Quantity","Số lượng");
            dataGridView1.Columns[0].Name = "Món ăn";
            dataGridView1.Columns[1].Name = "Số lượng";

        }
    public void Add(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = btn.Text;
            row.Cells[1].Value = 1.ToString();
            //this.dataGridView1.Rows.Add(btn.Text, 1.ToString());
            dataGridView1.Rows.Add(row);
        }
    }
}
