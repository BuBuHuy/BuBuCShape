namespace CshapeWinforBasic
{
    partial class TextBoxDemo
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
            this.lab1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(35, 91);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(35, 13);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "label1";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(241, 33);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(120, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(38, 33);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(172, 20);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 341);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lab1);
            this.Name = "Form1";
            this.Text = "TextBoxDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt1;
    }
}

