using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CshapeWinforBasic
{
    public partial class ListViewDemo : Form
    {
        public ListViewDemo()
        {
            InitializeComponent();
            loadListView();
        }
        void loadListView()
        {
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Ten colums 1");
            listView1.Columns.Add("Ten colums 2");
            listView1.Columns.Add("Ten colums 3");

            ListViewItem item1 = new ListViewItem();
            item1.Text = "Item1";
            item1.SubItems.Add(new ListViewItem.ListViewSubItem(){ Text = "Sub Item1" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub Item2" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub Item3" });
            ListViewItem item2 = new ListViewItem();
            item2.Text = "Item2";
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub Item A" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub Item B" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub Item C" });
            ListViewItem item3 = new ListViewItem();
            item3.Text = "Item3";
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub Item F" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub Item G" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub Item K" });
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }
    }
}
