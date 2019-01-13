namespace QuanLyDeTai
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCapDeTai = new System.Windows.Forms.ComboBox();
            this.dpkNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbChuNhiem = new System.Windows.Forms.ComboBox();
            this.rdHThanh = new System.Windows.Forms.RadioButton();
            this.rdChuaHThanh = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.txtS = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cbbCapDeTai
            // 
            this.cbbCapDeTai.FormattingEnabled = true;
            this.cbbCapDeTai.Location = new System.Drawing.Point(448, 35);
            this.cbbCapDeTai.Name = "cbbCapDeTai";
            this.cbbCapDeTai.Size = new System.Drawing.Size(212, 21);
            this.cbbCapDeTai.TabIndex = 4;
            // 
            // dpkNgayNhan
            // 
            this.dpkNgayNhan.Location = new System.Drawing.Point(117, 98);
            this.dpkNgayNhan.Name = "dpkNgayNhan";
            this.dpkNgayNhan.Size = new System.Drawing.Size(200, 20);
            this.dpkNgayNhan.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(117, 62);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cấp Đề Tài";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(117, 28);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(200, 20);
            this.txtMa.TabIndex = 1;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày Nhận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên Đề Tài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Đề Tài";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Chủ Nhiệm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tình Trạng";
            // 
            // cbbChuNhiem
            // 
            this.cbbChuNhiem.FormattingEnabled = true;
            this.cbbChuNhiem.Location = new System.Drawing.Point(448, 69);
            this.cbbChuNhiem.Name = "cbbChuNhiem";
            this.cbbChuNhiem.Size = new System.Drawing.Size(212, 21);
            this.cbbChuNhiem.TabIndex = 5;
            // 
            // rdHThanh
            // 
            this.rdHThanh.AutoSize = true;
            this.rdHThanh.Location = new System.Drawing.Point(448, 105);
            this.rdHThanh.Name = "rdHThanh";
            this.rdHThanh.Size = new System.Drawing.Size(81, 17);
            this.rdHThanh.TabIndex = 6;
            this.rdHThanh.TabStop = true;
            this.rdHThanh.Text = "Hoàn thành";
            this.rdHThanh.UseVisualStyleBackColor = true;
            // 
            // rdChuaHThanh
            // 
            this.rdChuaHThanh.AutoSize = true;
            this.rdChuaHThanh.Location = new System.Drawing.Point(550, 105);
            this.rdChuaHThanh.Name = "rdChuaHThanh";
            this.rdChuaHThanh.Size = new System.Drawing.Size(110, 17);
            this.rdChuaHThanh.TabIndex = 7;
            this.rdChuaHThanh.TabStop = true;
            this.rdChuaHThanh.Text = "Chưa hoàn thành ";
            this.rdChuaHThanh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(479, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(339, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(81, 310);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 154);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(674, 150);
            this.dataGrid.TabIndex = 35;
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(395, 194);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(395, 353);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(61, 22);
            this.btnS.TabIndex = 14;
            this.btnS.Text = "Search";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(479, 355);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(181, 20);
            this.txtS.TabIndex = 13;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(48, 353);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(156, 353);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(161, 21);
            this.cbbSort.TabIndex = 43;
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 412);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdChuaHThanh);
            this.Controls.Add(this.rdHThanh);
            this.Controls.Add(this.cbbChuNhiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbCapDeTai);
            this.Controls.Add(this.dpkNgayNhan);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbCapDeTai;
        private System.Windows.Forms.DateTimePicker dpkNgayNhan;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbChuNhiem;
        private System.Windows.Forms.RadioButton rdHThanh;
        private System.Windows.Forms.RadioButton rdChuaHThanh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbbSort;
    }
}

