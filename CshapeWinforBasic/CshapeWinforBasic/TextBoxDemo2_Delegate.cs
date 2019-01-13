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
    public partial class Form2 : Form
    {
        public delegate void DD(string s);
        public DD d;
        public Form2()
        {
            InitializeComponent();
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            d(txt2.Text);
        }

        private void f2_Load(object sender, EventArgs e)
        {

        }

    }
}
