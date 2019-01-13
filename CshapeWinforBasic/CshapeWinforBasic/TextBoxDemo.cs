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
    public partial class TextBoxDemo : Form
    {
        public TextBoxDemo()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.d = new Form2.DD(show);
            f2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txt1.Text = "Bu Bu Huy";
        }
        public void show(string s) {
            txt1.Text = s;
        }
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(txt1.Text, out num))
            {
                lab1.Text = (num * num).ToString();

            }
            else
            {
                lab1.Text = "Vui long nhap so";
            }
        }
    }
}
