using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalPayMentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();  
        }
        public int TinhTien()
        {
            //int a, b, c;
            int total = 0;
            int so =0;
            CheckBox ck = new CheckBox();
            if (cb1.Checked == true) total += Int32.Parse(cv.Text);
            if (cb2.Checked == true) total += Int32.Parse(yt.Text);
            if (cb3.Checked == true) total += Int32.Parse(cr.Text);
            try
            {
                so = Convert.ToInt32(cbb.Items[cbb.SelectedIndex].ToString());
            }
            catch
            {
                MessageBox.Show("Dien so Rang");
            }
            return total * so;
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(txt1.Text == null)
            {
                MessageBox.Show("Dien ten Khach Hang");

                return;
            }
            txt2.Text = string.Concat(TinhTien()) ;
            MessageBox.Show("Tien cua quy khach la :" + txt2.Text);
        }

        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
