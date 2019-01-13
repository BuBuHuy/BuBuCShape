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
    public partial class ListViewDemo1 : Form
    {
        public ListViewDemo1()
        {
            InitializeComponent();
            ColumnHeader c1 = new ColumnHeader();
            ColumnHeader c2 = new ColumnHeader();
            ColumnHeader c3 = new ColumnHeader();
            c1.Text = "MSSV";   
            c2.Text = "Name";
            c3.Text = "Class";

            lw1.Columns.Add(c1);
            lw1.Columns.Add(c2);
            lw1.Columns.Add(c3);

            ListViewItem item1 = new ListViewItem();
            ListViewItem item2 = new ListViewItem();
            item1.Text = "1";
            item2.Text = "2";
            ListViewItem.ListViewSubItem subItem11 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem subItem12 = new ListViewItem.ListViewSubItem();
            subItem11.Text = "Bu Bu HUy";
            subItem12.Text = "16TCLC3";
                
        }

        private void lw1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection list;
            list = lw1.SelectedItems;

            //list = lw1.Selected
        }
    }
}
