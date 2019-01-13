namespace CshapeWinforBasic
{
    partial class CheckboxDemo
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
            this.ckb1 = new System.Windows.Forms.CheckBox();
            this.ckb2 = new System.Windows.Forms.CheckBox();
            this.ckb3 = new System.Windows.Forms.CheckBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckb1
            // 
            this.ckb1.AutoSize = true;
            this.ckb1.Location = new System.Drawing.Point(3, 3);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(80, 17);
            this.ckb1.TabIndex = 0;
            this.ckb1.Text = "checkBox1";
            this.ckb1.UseVisualStyleBackColor = true;
            // 
            // ckb2
            // 
            this.ckb2.AutoSize = true;
            this.ckb2.Location = new System.Drawing.Point(3, 45);
            this.ckb2.Name = "ckb2";
            this.ckb2.Size = new System.Drawing.Size(80, 17);
            this.ckb2.TabIndex = 1;
            this.ckb2.Text = "checkBox2";
            this.ckb2.UseVisualStyleBackColor = true;
            // 
            // ckb3
            // 
            this.ckb3.AutoSize = true;
            this.ckb3.Location = new System.Drawing.Point(3, 89);
            this.ckb3.Name = "ckb3";
            this.ckb3.Size = new System.Drawing.Size(80, 17);
            this.ckb3.TabIndex = 2;
            this.ckb3.Text = "checkBox3";
            this.ckb3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(140, 160);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(8, 8);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "button1";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(196, 13);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(35, 13);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "label1";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.ckb1);
            this.pnl1.Controls.Add(this.ckb2);
            this.pnl1.Controls.Add(this.ckb3);
            this.pnl1.Location = new System.Drawing.Point(32, 13);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(88, 119);
            this.pnl1.TabIndex = 6;
            // 
            // CheckboxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 310);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn2);
            this.Name = "CheckboxDemo";
            this.Text = "CheckboxDemo";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb1;
        private System.Windows.Forms.CheckBox ckb2;
        private System.Windows.Forms.CheckBox ckb3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel pnl1;
    }
}