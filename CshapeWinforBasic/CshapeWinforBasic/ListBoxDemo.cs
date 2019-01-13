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
    public partial class ListBoxDemo : Form
    {
        public ListBoxDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.IndexOf(textBox1.Text) >= 0)
            {
                MessageBox.Show("Trung");
            }
            else
            {
                if (textBox1.Text.Length > 0)
                    listBox1.Items.Add(textBox1.Text);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
