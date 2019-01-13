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
    public partial class CheckboxDemo : Form
    {
        public CheckboxDemo()
        {
            InitializeComponent();
        }

        void showCheckText(Label lb,Panel pnl)
        {
            CheckBox ckbS = null;
            string s = null ;
            foreach(CheckBox i in pnl.Controls)
                if(i!=null)
                    if (i.Checked)
                    {
                        s += i.Text;
                    }
            lb.Text = s;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            showCheckText(lb1, pnl1);
        }
    }
}
