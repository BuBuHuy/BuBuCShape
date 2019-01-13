namespace CshapeWinforBasic
{
    partial class ListViewDemo1
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
            this.lw1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lw1
            // 
            this.lw1.FullRowSelect = true;
            this.lw1.Location = new System.Drawing.Point(49, 38);
            this.lw1.Name = "lw1";
            this.lw1.Size = new System.Drawing.Size(508, 268);
            this.lw1.TabIndex = 0;
            this.lw1.UseCompatibleStateImageBehavior = false;
            this.lw1.SelectedIndexChanged += new System.EventHandler(this.lw1_SelectedIndexChanged);
            // 
            // ListViewDemo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 331);
            this.Controls.Add(this.lw1);
            this.Name = "ListViewDemo1";
            this.Text = "0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lw1;
    }
}