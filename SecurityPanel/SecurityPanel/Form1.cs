using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecurityPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Add;
            button2.Click += Add;
            button3.Click += Add;
            button4.Click += Add;
            button5.Click += Add;
            button6.Click += Add;
            button7.Click += Add;
            button8.Click += Add;
            button9.Click += Add;
            button12.Click += Add;
        }
        
        
        private void Add(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text+=  btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="1234")
            {
                listBox1.Items.Add(DateTime.Now.ToString() + "       " + "Access Deny!!");
            }
            else
            {
                listBox1.Items.Add(DateTime.Now.ToString() + "       " + "Access !!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 4)
            {
                MessageBox.Show("4 Character"); 
            }
        }
    }
    

}
