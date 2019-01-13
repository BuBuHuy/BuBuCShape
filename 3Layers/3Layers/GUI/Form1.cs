using _3Layers.BLL;
using _3Layers.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3Layers
{
    public partial class Form1 : Form
    {
        public SV_BLL sv_bll { set; get; }
        public Form1()
        {
            InitializeComponent();
            sv_bll = new SV_BLL();
            LoadCbb();
        }
        public void LoadCbb()
        {
            cbbAdd.Items.AddRange(sv_bll.GetListAddress().ToArray());
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = sv_bll.GetListSV_BLL();
        }
        private SV getSVForm()
        {
            SV s = new SV() { };
            s.mssv = txtMSSV.Text;
            s.name = txtName.Text;
            s.birthday = Convert.ToDateTime(dpkBirthday.Value.ToString());
            s.gender = Convert.ToBoolean(rdMale.Checked);
            s.address = cbbAdd.SelectedItem.ToString();
            return s;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            sv_bll.AddSV_BLL(getSVForm());
            dataGrid.DataSource = sv_bll.GetListSV_BLL();
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SV sv = sv_bll.getSVByMssv_BLL(dataGrid.SelectedRows[0].Cells["MSSV"].Value.ToString());
            txtMSSV.Text = sv.mssv;
            txtName.Text = sv.name;
            dpkBirthday.Value = Convert.ToDateTime(sv.birthday);
            cbbAdd.SelectedIndex = cbbAdd.FindStringExact(sv.address);
            if (Convert.ToBoolean(sv.gender) == true)
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sv_bll.UpdateSv_BLL(getSVForm());
            dataGrid.DataSource = sv_bll.GetListSV_BLL();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (DataGridViewRow item in dataGrid.SelectedRows)
            {
                list.Add(item.Cells["MSSV"].Value.ToString());
            }
            sv_bll.DeleteSv_BLL(list);
            dataGrid.DataSource = sv_bll.GetListSV_BLL();
        }

        private void btnSearchDB_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = sv_bll.SearchSV_BLL(txtSearch.Text);
        }
    }
}
