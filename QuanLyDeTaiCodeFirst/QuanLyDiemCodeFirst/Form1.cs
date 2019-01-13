using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyDiemCodeFirst.BLL;
using QuanLyDiemCodeFirst.Entity;
namespace QuanLyDiemCodeFirst
{
    
    public partial class Form1 : Form
    {
        BLL.DeTaiBLL deTai;
        public Form1()
        {
            InitializeComponent();
            deTai= new BLL.DeTaiBLL();
            dataGrid.Columns.Clear();
            dataGrid.Columns.Add("STT", "STT");
            dataGrid.Columns["STT"].Width = 50;
            LoadCBB();
        }
        public void LoadCBB()
        {
            List<string> lCDT = deTai.loadTenCDT_bll();
            for (int i = 0; i < lCDT.Count; i++)
            {
                cbbCapDeTai.Items.Add(lCDT[i].Trim());
            }
            List<string> lCN = deTai.loadTenCN_bll();
            for (int i = 0; i < lCN.Count; i++)
            {
                cbbChuNhiem.Items.Add(lCN[i].Trim());
            }
        }

        private void dataGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGrid.Rows.Count)
                this.dataGrid.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            //Context m = new Context();
            //dataGrid.DataSource = m.DeTais.Select(p => p).ToList();
            dataGrid.DataSource = deTai.getListDT_bll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMa.Text=="")
            {
                MessageBox.Show("Điền mã!!");
            }
            else if (deTai.checkExist_bll(txtMa.Text))
            {
                MessageBox.Show("Đề tài đã tồn tại!!");
            }
            else
            {
                try
                {
                    deTai.addDeTai_bll(new DeTai()
                    {
                        MaDeTai = txtMa.Text.Trim(),
                        TenDeTai = txtTen.Text.Trim(),
                        TinhTrang = ((rdHThanh.Checked) ? true : false),
                        NgayNhanDeTai = dpkNgayNhan.Value,
                        MaCapDeTai = deTai.getMaCDTFormTenCDT_bll(cbbCapDeTai.SelectedItem.ToString()),
                        ChuNhiem = cbbChuNhiem.SelectedItem.ToString()
                    });
                    MessageBox.Show("Add Success!!");
                }
                catch
                {
                    MessageBox.Show("Add UnSuccess!!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                deTai.updateDeTai_bll(new DeTai()
                {
                    MaDeTai = dataGrid.CurrentRow.Cells["Mã đề tài"].Value.ToString(),
                    TenDeTai = txtTen.Text.Trim(),
                    TinhTrang = ((rdHThanh.Checked) ? true : false),
                    NgayNhanDeTai = dpkNgayNhan.Value,
                    MaCapDeTai = deTai.getMaCDTFormTenCDT_bll(cbbCapDeTai.SelectedItem.ToString()),
                    ChuNhiem = cbbChuNhiem.SelectedItem.ToString()
                });
                MessageBox.Show("Update Success!!");
                dataGrid.DataSource = deTai.getListDT_bll();
            }
            catch
            {
                MessageBox.Show("Update UnSuccess!!");
            }
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r;
            r = dataGrid.SelectedRows[0];
            txtMa.Text = r.Cells["Mã đề tài"].Value.ToString();
            txtTen.Text = r.Cells["Tên đề tài"].Value.ToString().Trim();
            dpkNgayNhan.Value = Convert.ToDateTime(r.Cells["Ngày nhận"].Value.ToString());
            cbbCapDeTai.SelectedIndex = cbbCapDeTai.FindStringExact(deTai.getTenCDTFormMa_bll(r.Cells["Mã cấp đề tài"].Value.ToString()));
            cbbChuNhiem.SelectedIndex = cbbChuNhiem.FindStringExact(r.Cells["Chủ nhiệm"].Value.ToString());
            if (r.Cells["Tình trạng"].Value.ToString() == "True")
            {
                rdHThanh.Checked = true;
            }
            else
            {
                rdChuaHThanh.Checked = true;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                deTai.deleteDeTai_bll(dataGrid.CurrentRow.Cells["Mã đề tài"].Value.ToString());
                MessageBox.Show("Delete Success!!");
                dataGrid.DataSource = deTai.getListDT_bll();
            }
            catch
            {
                MessageBox.Show("Delete UnSuccess!!");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if(cbbSort.SelectedIndex>-1)
            {
                dataGrid.DataSource=deTai.Sort_bll(cbbSort.SelectedIndex);
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (txtS.Text != "")
            {
                dataGrid.DataSource = deTai.searchDT_bll(txtS.Text.Trim());
            }
            else
            {
                dataGrid.DataSource = deTai.getListDT_bll();
            }      
        }
    }
}
