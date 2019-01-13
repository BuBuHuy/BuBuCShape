using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QuanLyDeTai
{
    

    public partial class Form2 : Form
    {
        //Khoi tao delegate truyen du lieu 
        public delegate void DeleData(DeTai deTai);
        public DeleData sd;
        public Form2()
        {
            
        }
        public Form2(List<string> lCDT,List<string> lCN)
        {
            InitializeComponent();
            //AddRange: chuyen list vao Items Combobox
            cbbCapDeTai2.Items.AddRange(lCDT.ToArray());
            cbbChuNhiem2.Items.AddRange(lCN.ToArray());
        }
        private void btnOK2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMa2.Text)||cbbCapDeTai2.SelectedItem== null|| cbbChuNhiem2.SelectedItem == null)
            {
                MessageBox.Show("Ma De Tai , Cap De Tai , Chu Nhiem la bat buoc" );
                return;
            }
            else
            {
                DeTai deTai = new DeTai();
                deTai.MaDeTai = txtMa2.Text.Trim();//bo khoang trang truoc ,sau MaDeTai
                deTai.TenDeTai = txtTen2.Text.Trim();
                if (rdHThanh2.Checked) deTai.TinhTrang = true;
                else deTai.TinhTrang = false;
                deTai.TenCapDeTai = cbbCapDeTai2.SelectedItem.ToString();
                deTai.NgayNhanDeTai = Convert.ToDateTime(dpkNgayNhan2.Value);
                deTai.ChuNhiem = cbbChuNhiem2.SelectedItem.ToString();
                sd(deTai);
            }
        }
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
        private void txtMa2_TextChanged(object sender, EventArgs e)
        {
            if (txtMa2.Text.Length > 10) MessageBox.Show("MÃ ĐỀ TÀI không nhập quá 10 Kí tự");
            if(txtMa2.Text.IndexOf('\'')!=-1) MessageBox.Show("Không nhập kí tự '");
        }

        private void txtTen2_TextChanged(object sender, EventArgs e)
        {
            if (txtTen2.Text.IndexOf('\'') != -1) MessageBox.Show("Không nhập kí tự '");
        }
    }
}
