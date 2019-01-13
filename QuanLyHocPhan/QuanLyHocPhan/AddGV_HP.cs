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
    public partial class AddGV_HP : Form
    {
        HocPhanBLL bll;
        public delegate void AddSuccess();
        public AddSuccess addSuc;
        public AddGV_HP()
        {
            InitializeComponent();
            bll = new HocPhanBLL();
            loadCbb();
        }
        public void loadCbb()
        {
            cbbKhoa.Items.AddRange(bll.loadCbb_bll(1).ToArray());
            cbbHP.Items.AddRange(bll.loadCbb_bll(2).ToArray());
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (bll.ExistedMSGV_bll(txtMaso.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Giáo viên đã tồn tại, bạn có muốn thêm HP này vào giáo viên không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (bll.ExistedPairGV_HP_bll(txtMaso.Text, cbbHP.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Giáo viên đã dạy học phần này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {
                        bll.addGV_HP_bll(new Entity.GV_HP
                        {
                            MSGV = txtMaso.Text,
                            MSHP = bll.getMSHPFormTenHp_bll(cbbHP.SelectedItem.ToString())
                        });
                        addSuc();
                        MessageBox.Show("Đã thêm GV_HP thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                        this.Dispose();
                    }
                } else if (dialogResult == DialogResult.No)
                {
                    this.Dispose();
                    return;
                }
                else
                {
                    this.Dispose();
                    return;
                }
            }
            else
            {
                bll.addGV_bll(new Entity.GiangVien
                {
                    MSGV = txtMaso.Text,
                    TenGV = txtName.Text,
                    NgaySinh = dateTimePicker1.Value,
                    GioiTinh = (rdMale.Checked) ? true : false,
                    HocHam = cbbHH.SelectedItem.ToString(),
                    HocVi = cbbHV.SelectedItem.ToString(),
                    Khoa = cbbKhoa.SelectedItem.ToString(),
                });

                bll.addGV_HP_bll(new Entity.GV_HP
                {
                    MSGV = txtMaso.Text,
                    MSHP = bll.getMSHPFormTenHp_bll(cbbHP.SelectedItem.ToString())
                });
                addSuc();
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
