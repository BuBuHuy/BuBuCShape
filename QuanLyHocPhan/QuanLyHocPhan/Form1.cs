using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHocPhan
{
    public partial class Form1 : Form
    {
        HocPhanBLL bll;
        public Form1()
        {
            bll = new HocPhanBLL();
            InitializeComponent();
            dataGrid.Columns.Clear();
            dataGrid.Columns.Add("STT", "STT");
            dataGrid.Columns["STT"].Width = 50;
            loadCbb();
        }

        private void dataGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGrid.Rows.Count)
                this.dataGrid.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        void loadData()
        {
            dataGrid.DataSource = bll.getListHP_bll();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadCbb()
        {
            cbbKhoa.Items.AddRange(bll.loadCbb_bll(1).ToArray());
            cbbHP.Items.AddRange(bll.loadCbb_bll(2).ToArray());
        }
        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r;
            r = dataGrid.SelectedRows[0];
            txtName.Text = r.Cells["TenGV"].Value.ToString();
            cbbKhoa.SelectedIndex = cbbKhoa.FindStringExact(r.Cells["Khoa"].Value.ToString());
            dateTimePicker1.Value = Convert.ToDateTime(r.Cells["NgaySinh"].Value.ToString());
            cbbHH.SelectedIndex = cbbHH.FindStringExact(r.Cells["HocHam"].Value.ToString());
            cbbHV.SelectedIndex = cbbHV.FindStringExact(r.Cells["HocVi"].Value.ToString());
            cbbHP.SelectedIndex = cbbHP.FindStringExact(r.Cells["TenHP"].Value.ToString());
            if (r.Cells["GioiTinh"].Value.ToString() == "True")
            {
                rdMale.Checked = true;
            }
            else rdFemale.Checked = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddGV_HP f = new AddGV_HP();
            f.addSuc += new AddGV_HP.AddSuccess(loadData);
            f.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            List<string> msList = new List<string>();
            List<string> HPList = new List<string>();
            DataGridViewSelectedRowCollection tap;
            tap = dataGrid.SelectedRows;
            foreach (DataGridViewRow hang in tap)
            {
                msList.Add(hang.Cells["MSGV"].Value.ToString());
                HPList.Add(hang.Cells["TenHP"].Value.ToString());
            }
            int i = 0;
            foreach (string tengv in msList)
            {

                bll.delGV_HP_bll(new Entity.GV_HP
                {
                    MSGV = msList[i],
                    MSHP = bll.getMSHPFormTenHp_bll(HPList[i])
                });
                i++;
            }
            MessageBox.Show("Xóa Thành công");
            dataGrid.DataSource = bll.getListHP_bll();
        }
    }
}
