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
    public partial class RadioButtonDemo : Form
    {
        public RadioButtonDemo()
        {
            InitializeComponent();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void showResult(Label lb, Panel pnl)
        {
            RadioButton ckb = null;
            foreach(RadioButton item in pnl.Controls)
            {
                if (item != null)
                if (item.Checked)
                {
                    ckb = item;
                    break;
                }
            }
            if (ckb != null)
            {
                lb.Text = ckb.Text;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            showResult(lb1, pnl1);
            showResult(lb2, pnl2);
            showResult(lb3, pnl3);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Change the check box position to be opposite its current position.
            if (rb.CheckAlign == ContentAlignment.MiddleLeft)
            {
                rb.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                rb.CheckAlign = ContentAlignment.MiddleLeft;
            }
        }
    }
}
