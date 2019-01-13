namespace CshapeWinforBasic
{
    partial class TreeViewDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeViewDemo));
            this.tw1 = new System.Windows.Forms.TreeView();
            this.im1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tw1
            // 
            this.tw1.ImageIndex = 0;
            this.tw1.ImageList = this.im1;
            this.tw1.Location = new System.Drawing.Point(0, 0);
            this.tw1.Name = "tw1";
            this.tw1.SelectedImageIndex = 0;
            this.tw1.Size = new System.Drawing.Size(658, 288);
            this.tw1.TabIndex = 0;
            // 
            // im1
            // 
            this.im1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("im1.ImageStream")));
            this.im1.TransparentColor = System.Drawing.Color.Transparent;
            this.im1.Images.SetKeyName(0, "28685733_2043692362540273_3161428042497130496_n.jpg");
            this.im1.Images.SetKeyName(1, "24899714_1808948836072153_6247337013257307860_n.jpg");
            this.im1.Images.SetKeyName(2, "36748646_1987716637957309_8218413169207410688_n.jpg");
            // 
            // TreeViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 378);
            this.Controls.Add(this.tw1);
            this.Name = "TreeViewDemo";
            this.Text = "TreeViewDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tw1;
        private System.Windows.Forms.ImageList im1;
    }
}