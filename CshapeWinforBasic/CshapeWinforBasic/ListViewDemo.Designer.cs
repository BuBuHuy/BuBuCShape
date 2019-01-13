namespace CshapeWinforBasic
{
    partial class ListViewDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewDemo));
            this.SmallIM = new System.Windows.Forms.ImageList(this.components);
            this.BigIM = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SmallIM
            // 
            this.SmallIM.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallIM.ImageStream")));
            this.SmallIM.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallIM.Images.SetKeyName(0, "28795532_2098196483795455_421441902858992388_n.jpg");
            this.SmallIM.Images.SetKeyName(1, "12224541_1638097373122203_2066457398_n.jpg");
            this.SmallIM.Images.SetKeyName(2, "36689279_2107464399541751_5752352018538692608_n.jpg");
            this.SmallIM.Images.SetKeyName(3, "23915704_1755763781165782_3337334240808919447_n.jpg");
            // 
            // BigIM
            // 
            this.BigIM.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BigIM.ImageStream")));
            this.BigIM.TransparentColor = System.Drawing.Color.Transparent;
            this.BigIM.Images.SetKeyName(0, "24232290_1762904637087017_6028505715555251955_n.jpg");
            this.BigIM.Images.SetKeyName(1, "39939180_1934229029973197_5661154396667379712_n.jpg");
            this.BigIM.Images.SetKeyName(2, "41294795_1892074151100428_2577511415946412032_n.jpg");
            this.BigIM.Images.SetKeyName(3, "41442051_10156575392908232_5421628378421657600_n.jpg");
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.BigIM;
            this.listView1.Location = new System.Drawing.Point(9, 8);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(618, 342);
            this.listView1.SmallImageList = this.SmallIM;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "BigIM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "SmallIM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(737, 380);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "ListViewDemo";
            this.Text = "ListView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList BigIM;
        private System.Windows.Forms.ImageList SmallIM;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}