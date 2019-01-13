using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CshapeWinforBasic
{
    public partial class LoadImage : Form
    {
        SuaAnh_DAL dal;
        public LoadImage()
        {
            InitializeComponent();
            dal = new SuaAnh_DAL();
            loadPic();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            string file = openFile.FileName;
            if (string.IsNullOrEmpty(file)) return;
            byte[] data = File.ReadAllBytes(file);
            /* MemoryStream là một đối tượng nó quản lý một bộ đệm (buffer) là một mảng các byte,
            khi các byte được ghi vào luồng này nó sẽ tự động được gán vào các vị trí tiếp theo
            tính từ vị trí hiện tại của con trỏ trên mảng. Khi bộ đệm đầy một mảng mới có
            kích thước lớn hơn được tạo ra, và copy các dữ liệu từ mảng cũ sang.*/
            MemoryStream mem = new MemoryStream(data);
            pictureBox1.Image = Image.FromStream(mem);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //MemoryStream stream = new MemoryStream();
            //pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            //MyDBPictureDataContext dBPictureDataContext = new MyDBPictureDataContext();
            //imgtable im = new imgtable();
            //im.img = 16; 
            //pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            //im.image = stream.ToArray();
            //dBPictureDataContext.imgtables.InsertOnSubmit(im);
            //dBPictureDataContext.SubmitChanges();

            
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            dal.luuAnh_DAL("GV001", stream.ToArray());
            MessageBox.Show("Success");
        }
        public void loadPic()
        {
            byte[] data = dal.loadAnh("GV001");
            if (data == null)
            {
                pictureBox2.Image = null;
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream(data);
                pictureBox2.Image = Image.FromStream(memoryStream);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //MyDBPictureDataContext myDb = new MyDBPictureDataContext();
            //imgtable ig = myDb.imgtables.Where(p => p.img == 12).FirstOrDefault();
            //if (ig == null)
            //{
            //    return;
            //}
            //byte[] data = (byte[])ig.image.ToArray();
            //if (data == null) pictureBox2.Image = null;
            //else
            //{
            //    MemoryStream memoryStream = new MemoryStream(data);
            //    pictureBox2.Image = Image.FromStream(memoryStream);

            //}

            

        }
    }
}
