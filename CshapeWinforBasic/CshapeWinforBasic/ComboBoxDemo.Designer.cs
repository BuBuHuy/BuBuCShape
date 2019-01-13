namespace CshapeWinforBasic
{
    partial class ComboBoxDemo
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
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Bu Bu Huy",
            "Luu Van Huy",
            "AHIHI"});
            this.cb1.Location = new System.Drawing.Point(12, 30);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(198, 21);
            this.cb1.TabIndex = 0;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(259, 30);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(183, 21);
            this.cb2.TabIndex = 2;
            // 
            // ComboBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 335);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb1);
            this.Name = "ComboBoxDemo";
            this.Text = "ComboBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb2;
    }
}