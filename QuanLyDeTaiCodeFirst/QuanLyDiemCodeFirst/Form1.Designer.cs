namespace QuanLyDiemCodeFirst
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.rdChuaHThanh = new System.Windows.Forms.RadioButton();
            this.rdHThanh = new System.Windows.Forms.RadioButton();
            this.cbbChuNhiem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCapDeTai = new System.Windows.Forms.ComboBox();
            this.dpkNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnS = new System.Windows.Forms.Button();
            this.txtS = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(535, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 81;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(395, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 80;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 79;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(137, 321);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 78;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rdChuaHThanh
            // 
            this.rdChuaHThanh.AutoSize = true;
            this.rdChuaHThanh.Location = new System.Drawing.Point(606, 116);
            this.rdChuaHThanh.Name = "rdChuaHThanh";
            this.rdChuaHThanh.Size = new System.Drawing.Size(110, 17);
            this.rdChuaHThanh.TabIndex = 77;
            this.rdChuaHThanh.TabStop = true;
            this.rdChuaHThanh.Text = "Chưa hoàn thành ";
            this.rdChuaHThanh.UseVisualStyleBackColor = true;
            // 
            // rdHThanh
            // 
            this.rdHThanh.AutoSize = true;
            this.rdHThanh.Location = new System.Drawing.Point(504, 116);
            this.rdHThanh.Name = "rdHThanh";
            this.rdHThanh.Size = new System.Drawing.Size(81, 17);
            this.rdHThanh.TabIndex = 76;
            this.rdHThanh.TabStop = true;
            this.rdHThanh.Text = "Hoàn thành";
            this.rdHThanh.UseVisualStyleBackColor = true;
            // 
            // cbbChuNhiem
            // 
            this.cbbChuNhiem.FormattingEnabled = true;
            this.cbbChuNhiem.Location = new System.Drawing.Point(504, 80);
            this.cbbChuNhiem.Name = "cbbChuNhiem";
            this.cbbChuNhiem.Size = new System.Drawing.Size(212, 21);
            this.cbbChuNhiem.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Chủ Nhiệm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Tình Trạng";
            // 
            // cbbCapDeTai
            // 
            this.cbbCapDeTai.FormattingEnabled = true;
            this.cbbCapDeTai.Location = new System.Drawing.Point(504, 46);
            this.cbbCapDeTai.Name = "cbbCapDeTai";
            this.cbbCapDeTai.Size = new System.Drawing.Size(212, 21);
            this.cbbCapDeTai.TabIndex = 74;
            // 
            // dpkNgayNhan
            // 
            this.dpkNgayNhan.Location = new System.Drawing.Point(173, 109);
            this.dpkNgayNhan.Name = "dpkNgayNhan";
            this.dpkNgayNhan.Size = new System.Drawing.Size(200, 20);
            this.dpkNgayNhan.TabIndex = 73;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(173, 73);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Cấp Đề Tài";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(173, 39);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(200, 20);
            this.txtMa.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Ngày Nhận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Tên Đề Tài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Mã Đề Tài";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(68, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 136);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(68, 165);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(674, 150);
            this.dataGrid.TabIndex = 92;
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            this.dataGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGrid_RowPostPaint);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(451, 364);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(61, 22);
            this.btnS.TabIndex = 84;
            this.btnS.Text = "Search";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(535, 366);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(181, 20);
            this.txtS.TabIndex = 83;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(104, 364);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 82;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Items.AddRange(new object[] {
            "Đề tài",
            "Cấp đề tài"});
            this.cbbSort.Location = new System.Drawing.Point(212, 364);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(161, 21);
            this.cbbSort.TabIndex = 93;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 409);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShow);
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
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rdChuaHThanh;
        private System.Windows.Forms.RadioButton rdHThanh;
        private System.Windows.Forms.ComboBox cbbChuNhiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbCapDeTai;
        private System.Windows.Forms.DateTimePicker dpkNgayNhan;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbbSort;
    }
}

