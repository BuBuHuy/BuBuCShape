using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDeTai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCbbCapDeTai();
            LoadCbbChuNhiem();
            LoadCbbSort();
            txtMa.ReadOnly = true;
        }
        
        //Load du lieu Cap De Tai
        public void LoadCbbCapDeTai()
        {
            string queryCapDT = "select TenCapDeTai from CapDeTai";
            SqlConnection cnn = DBConnect.openConnection();
            DataTable dtbCDT = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(queryCapDT, cnn);
            foreach (DataRow r in dtbCDT.Rows)
            {
                string tenCapDeTai = r["TenCapDeTai"].ToString();
                if (cbbCapDeTai.FindStringExact(tenCapDeTai) < 0)
                    cbbCapDeTai.Items.Add(tenCapDeTai);
            }
            cnn.Close();
        }
        //Load du lieu Chu Nhiem
        public void LoadCbbChuNhiem()
        {
            string queryCn = "select ChuNhiem from DeTai";
            SqlConnection cnn = DBConnect.openConnection();
            cnn.Open();
            DataTable dtbCN = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(queryCn, cnn);
            adapter.Fill(dtbCN);
            foreach (DataRow r in dtbCN.Rows)
            {
                string tenCn = r["ChuNhiem"].ToString();
                if (cbbChuNhiem.FindStringExact(tenCn) < 0)
                    cbbChuNhiem.Items.Add(tenCn);
            }
            cnn.Close();
        }
        public void LoadCbbSort()
        {
            cbbSort.Items.Add("Tên Cấp Đề Tài - Chủ Nhiệm");
        }
        //ham show data --> BtnShow
        DataTable getTable(string queryChoose)
        {
            SqlConnection cnn = DBConnect.openConnection();
            DataTable dtb = new DataTable();
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(queryChoose, cnn);
            adapter.Fill(dtb);
            cnn.Close();
            return dtb;
        }
        void showDataTableOnGrid()
        {
            if (dataGrid.ColumnCount > 0)
            {
                dataGrid.Columns.RemoveAt(0);
            }
            string queryShow = "SELECT MaDeTai,TenDeTai,CapDeTai.TenCapDeTai,ChuNhiem,TinhTrang,DeTai.NgayNhanDeTai" +
                " FROM DeTai INNER JOIN CapDeTai " +
                "ON DeTai.MaCapDeTai = CapDeTai.MaCapDeTai";
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "STT";
            dataGrid.Columns.Insert(0, col);
            dataGrid.DataSource = getTable(queryShow);
            int i = dataGrid.RowCount;
            for (int j = 0; j < i - 1; j++)
            {
                dataGrid.Rows[j].Cells[0].Value = Convert.ToString(j + 1);
            }
        }
        /*--------------------------------------------Show Button-------------------------------------------------------------------*/
        private void btnShow_Click(object sender, EventArgs e)
        {
            showDataTableOnGrid();
        }
        /*--------------------------------------------Delete Button-------------------------------------------------------------------*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.DataSource == null)
            {
                MessageBox.Show("Chon Dong Muon Xoa !!");
                return;
            }
            SqlConnection cnn = DBConnect.openConnection();
            cnn.Open();
            string queryDelete;

            List<string> list = new List<string>();
            foreach (DataGridViewRow item in dataGrid.SelectedRows)
            {
                list.Add(item.Cells["MaDeTai"].Value.ToString());
            }
            foreach (string s in list)
            {
                queryDelete = "DELETE FROM DeTai where "+ "MaDeTai = N'" + s + "' ;";
                SqlCommand cmd = new SqlCommand(queryDelete, cnn);
                cmd.ExecuteNonQuery();
            }
            cnn.Close();
            showDataTableOnGrid();
        }
        /*--------------------------------------------Row Header Mouse Click------------------------------------------------------*/
        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string queryRow = "SELECT MaDeTai,TenDeTai,CapDeTai.TenCapDeTai,ChuNhiem,TinhTrang,DeTai.NgayNhanDeTai" +
                " FROM DeTai INNER JOIN CapDeTai " +"ON DeTai.MaCapDeTai = CapDeTai.MaCapDeTai where "
                + "MaDeTai ='" + dataGrid.SelectedRows[0].Cells["MaDeTai"].Value.ToString() + "';";

            DataTable dtb = getTable(queryRow);
            foreach (DataRow r in dtb.Rows)
            {
                txtMa.Text = r["MaDeTai"].ToString().Trim();
                txtTen.Text = r["TenDeTai"].ToString().Trim();
                dpkNgayNhan.Value = Convert.ToDateTime(r["NgayNhanDeTai"].ToString());
                cbbCapDeTai.SelectedIndex = cbbCapDeTai.FindStringExact(r["TenCapDeTai"].ToString());
                cbbChuNhiem.SelectedIndex = cbbChuNhiem.FindStringExact(r["ChuNhiem"].ToString());
                if (Convert.ToBoolean(r["TinhTrang"]) == true)
                {
                    rdHThanh.Checked = true;
                }
                else
                {
                    rdChuaHThanh.Checked = true;
                }
            }
        }
        /*--------------------------------------------Update Button-------------------------------------------------------------------*/
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGrid.DataSource == null||txtMa.Text=="")
            {
                MessageBox.Show("Chon Dong Muon Cap Nhat !!");
                return;
            }
            
            SqlConnection cnn = DBConnect.openConnection();
            cnn.Open();
            string query = "update DeTai set TenDeTai = N'"
            + txtTen.Text + "', NgayNhanDeTai ='" + String.Format("{0:yyyy-MM-dd}", dpkNgayNhan.Value)
            + "',TinhTrang =  '" + rdHThanh.Checked + "',ChuNhiem = N'" + cbbChuNhiem.SelectedItem.ToString() + "' where MaDeTai= '" + txtMa.Text + "'";
            string query2 = "UPDATE DeTai SET MaCapDeTai = (SELECT MaCapDeTai FROM CapDeTai WHERE TenCapDeTai = N'" +
                cbbCapDeTai.SelectedItem.ToString() + "') WHERE MaDeTai = '" + txtMa.Text + "'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            showDataTableOnGrid();
            cnn.Close();
        }
        /*--------------------------------------------Add Button-------------------------------------------------------------------*/
        //lay Data trong combobox
        List<string> getListItemsCbb(ComboBox cb)
        {
            List<string> ls = new List<string>();
            foreach (string i in cb.Items)
            {
                ls.Add(i);
            }
            return ls;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(getListItemsCbb(cbbCapDeTai),getListItemsCbb(cbbChuNhiem));
            f2.sd = new Form2.DeleData(getAddInfo);
            f2.Show();
        }
        //sau khi lay duoc du lieu tu formAdd -- > Add De Tai
        public void getAddInfo(DeTai dt)
        {
            SqlConnection cnn = DBConnect.openConnection();
            cnn.Open();
            //Test De Tai Trung Nhau
            string quTrung = "select count(*) from DeTai " + "where MaDeTai =N'" + dt.MaDeTai +"' ";
            SqlCommand cmdTrung = new SqlCommand(quTrung, cnn);
            if ((int)cmdTrung.ExecuteScalar() > 0)
            {
                MessageBox.Show("De Tai da ton tai");
                cnn.Close();
            }
            else
            {
                string quInsert = "DECLARE @MaCDT nchar(10)" +
                    " Select @MaCDT = MaCapDeTai From CapDeTai where TenCapDeTai = N'" +dt.TenCapDeTai +"'" +
                    " INSERT INTO DeTai(MaDeTai, TenDeTai, TinhTrang, MaCapDeTai, NgayNhanDeTai, ChuNhiem) VALUES(N'" + dt.MaDeTai + "', N'" +
                dt.TenDeTai + "','" + dt.TinhTrang + "'," + "@MaCDT" + ",'" + String.Format("{0:yyyy-MM-d }", dt.NgayNhanDeTai) + "', N'" + dt.ChuNhiem + "')";
                SqlCommand cmd = new SqlCommand(quInsert, cnn);// chu y gap loi string dai qua 10 ki tu
                cmd.ExecuteNonQuery();
                showDataTableOnGrid();
                cnn.Close();
            }
        }
        /*--------------------------------------------------Search Button------------------------------------------------------*/
        private void btnS_Click(object sender, EventArgs e)
        {
            string querySearch;
            if (txtS.Text.Trim() == "")
            {
                //tim nhung de tai ma chua co TenDeTai
                querySearch = "select * from DeTai where TenDeTai =''";
            }
            else
            {
                querySearch = "select * from DeTai where TenDeTai Like N'%" + txtS.Text.Trim() + "%'";
            }
            
            if (dataGrid.ColumnCount > 0)
            {
                dataGrid.Columns.RemoveAt(0);
            }
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "STT";
            dataGrid.Columns.Insert(0, col);
            dataGrid.DataSource = getTable(querySearch);
            int i = dataGrid.RowCount;
            for (int j = 0; j < i - 1; j++)
            {
                dataGrid.Rows[j].Cells[0].Value = Convert.ToString(j + 1);
            }
        }
        /*-----------------------------------------------Sort Button-------------------------------------------------------------*/
        private void btnSort_Click(object sender, EventArgs e)
        {
           
            string querySort  = "SELECT MaDeTai,TenDeTai,CapDeTai.TenCapDeTai,ChuNhiem,TinhTrang,DeTai.NgayNhanDeTai " +
                "FROM DeTai INNER JOIN CapDeTai ON DeTai.MaCapDeTai = CapDeTai.MaCapDeTai " +
                "Order By  CapDeTai.TenCapDeTai, DeTai.ChuNhiem";
            if (dataGrid.ColumnCount > 0)
            {
                dataGrid.Columns.RemoveAt(0);
            }
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "STT";
            dataGrid.Columns.Insert(0, col);
            dataGrid.DataSource = getTable(querySort);
            int i = dataGrid.RowCount;
            for (int j = 0; j < i - 1; j++)
            {
                dataGrid.Rows[j].Cells[0].Value = Convert.ToString(j + 1);
            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (txtTen.Text.IndexOf('\'') != -1) MessageBox.Show("Không nhập kí tự '");
        }

       
    }
}
