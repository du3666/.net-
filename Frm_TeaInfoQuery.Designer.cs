namespace 饮品店点餐收银系统
{
    partial class Frm_TeaInfoQuery
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cbb_Price_Medium = new System.Windows.Forms.ComboBox();
            this.txt_Price_Medium = new System.Windows.Forms.TextBox();
            this.txt_Price_Large = new System.Windows.Forms.TextBox();
            this.txt_Price_Small = new System.Windows.Forms.TextBox();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.cbb_Price_Large = new System.Windows.Forms.ComboBox();
            this.cbb_Price_Small = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.chb_Price_Medium = new System.Windows.Forms.CheckBox();
            this.chb_Status = new System.Windows.Forms.CheckBox();
            this.chb_Price_Large = new System.Windows.Forms.CheckBox();
            this.chb_Price_Small = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_TeaInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.cbb_Price_Medium);
            this.groupBox1.Controls.Add(this.txt_Price_Medium);
            this.groupBox1.Controls.Add(this.txt_Price_Large);
            this.groupBox1.Controls.Add(this.txt_Price_Small);
            this.groupBox1.Controls.Add(this.cbb_Status);
            this.groupBox1.Controls.Add(this.cbb_Price_Large);
            this.groupBox1.Controls.Add(this.cbb_Price_Small);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.chb_Price_Medium);
            this.groupBox1.Controls.Add(this.chb_Status);
            this.groupBox1.Controls.Add(this.chb_Price_Large);
            this.groupBox1.Controls.Add(this.chb_Price_Small);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(756, 61);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 48);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "清空";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cbb_Price_Medium
            // 
            this.cbb_Price_Medium.FormattingEnabled = true;
            this.cbb_Price_Medium.Items.AddRange(new object[] {
            "=",
            "<",
            ">"});
            this.cbb_Price_Medium.Location = new System.Drawing.Point(396, 28);
            this.cbb_Price_Medium.Name = "cbb_Price_Medium";
            this.cbb_Price_Medium.Size = new System.Drawing.Size(46, 26);
            this.cbb_Price_Medium.TabIndex = 13;
            // 
            // txt_Price_Medium
            // 
            this.txt_Price_Medium.Location = new System.Drawing.Point(448, 27);
            this.txt_Price_Medium.Name = "txt_Price_Medium";
            this.txt_Price_Medium.Size = new System.Drawing.Size(100, 28);
            this.txt_Price_Medium.TabIndex = 12;
            // 
            // txt_Price_Large
            // 
            this.txt_Price_Large.Location = new System.Drawing.Point(174, 77);
            this.txt_Price_Large.Name = "txt_Price_Large";
            this.txt_Price_Large.Size = new System.Drawing.Size(100, 28);
            this.txt_Price_Large.TabIndex = 11;
            // 
            // txt_Price_Small
            // 
            this.txt_Price_Small.Location = new System.Drawing.Point(174, 34);
            this.txt_Price_Small.Name = "txt_Price_Small";
            this.txt_Price_Small.Size = new System.Drawing.Size(100, 28);
            this.txt_Price_Small.TabIndex = 10;
            // 
            // cbb_Status
            // 
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Items.AddRange(new object[] {
            "全部",
            "在售",
            "售完",
            "停售"});
            this.cbb_Status.Location = new System.Drawing.Point(371, 85);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(136, 26);
            this.cbb_Status.TabIndex = 9;
            // 
            // cbb_Price_Large
            // 
            this.cbb_Price_Large.FormattingEnabled = true;
            this.cbb_Price_Large.Items.AddRange(new object[] {
            "=",
            "<",
            ">"});
            this.cbb_Price_Large.Location = new System.Drawing.Point(117, 81);
            this.cbb_Price_Large.Name = "cbb_Price_Large";
            this.cbb_Price_Large.Size = new System.Drawing.Size(51, 26);
            this.cbb_Price_Large.TabIndex = 7;
            // 
            // cbb_Price_Small
            // 
            this.cbb_Price_Small.FormattingEnabled = true;
            this.cbb_Price_Small.Items.AddRange(new object[] {
            "=",
            "<",
            ">"});
            this.cbb_Price_Small.Location = new System.Drawing.Point(117, 32);
            this.cbb_Price_Small.Name = "cbb_Price_Small";
            this.cbb_Price_Small.Size = new System.Drawing.Size(46, 26);
            this.cbb_Price_Small.TabIndex = 6;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(623, 61);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(111, 50);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // chb_Price_Medium
            // 
            this.chb_Price_Medium.AutoSize = true;
            this.chb_Price_Medium.Location = new System.Drawing.Point(295, 32);
            this.chb_Price_Medium.Name = "chb_Price_Medium";
            this.chb_Price_Medium.Size = new System.Drawing.Size(106, 22);
            this.chb_Price_Medium.TabIndex = 3;
            this.chb_Price_Medium.Text = "价格(中)";
            this.chb_Price_Medium.UseVisualStyleBackColor = true;
            // 
            // chb_Status
            // 
            this.chb_Status.AutoSize = true;
            this.chb_Status.Location = new System.Drawing.Point(295, 87);
            this.chb_Status.Name = "chb_Status";
            this.chb_Status.Size = new System.Drawing.Size(70, 22);
            this.chb_Status.TabIndex = 2;
            this.chb_Status.Text = "状态";
            this.chb_Status.UseVisualStyleBackColor = true;
            // 
            // chb_Price_Large
            // 
            this.chb_Price_Large.AutoSize = true;
            this.chb_Price_Large.Location = new System.Drawing.Point(16, 83);
            this.chb_Price_Large.Name = "chb_Price_Large";
            this.chb_Price_Large.Size = new System.Drawing.Size(106, 22);
            this.chb_Price_Large.TabIndex = 1;
            this.chb_Price_Large.Text = "价格(大)";
            this.chb_Price_Large.UseVisualStyleBackColor = true;
            // 
            // chb_Price_Small
            // 
            this.chb_Price_Small.AutoSize = true;
            this.chb_Price_Small.Location = new System.Drawing.Point(16, 34);
            this.chb_Price_Small.Name = "chb_Price_Small";
            this.chb_Price_Small.Size = new System.Drawing.Size(106, 22);
            this.chb_Price_Small.TabIndex = 0;
            this.chb_Price_Small.Text = "价格(小)";
            this.chb_Price_Small.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_TeaInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "饮品信息列表";
            // 
            // lv_TeaInfo
            // 
            this.lv_TeaInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_TeaInfo.FullRowSelect = true;
            this.lv_TeaInfo.GridLines = true;
            this.lv_TeaInfo.HideSelection = false;
            this.lv_TeaInfo.Location = new System.Drawing.Point(6, 27);
            this.lv_TeaInfo.MultiSelect = false;
            this.lv_TeaInfo.Name = "lv_TeaInfo";
            this.lv_TeaInfo.Size = new System.Drawing.Size(874, 320);
            this.lv_TeaInfo.TabIndex = 0;
            this.lv_TeaInfo.UseCompatibleStateImageBehavior = false;
            this.lv_TeaInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "饮品名称";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "价格(小)";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "价格(中)";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "价格(大)";
            this.columnHeader5.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "图片";
            this.columnHeader7.Width = 270;
            // 
            // Frm_TeaInfoQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_TeaInfoQuery";
            this.Text = "饮品信息查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chb_Price_Medium;
        private System.Windows.Forms.CheckBox chb_Status;
        private System.Windows.Forms.CheckBox chb_Price_Large;
        private System.Windows.Forms.CheckBox chb_Price_Small;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_Price_Medium;
        private System.Windows.Forms.TextBox txt_Price_Medium;
        private System.Windows.Forms.TextBox txt_Price_Large;
        private System.Windows.Forms.TextBox txt_Price_Small;
        private System.Windows.Forms.ComboBox cbb_Status;
        private System.Windows.Forms.ComboBox cbb_Price_Large;
        private System.Windows.Forms.ComboBox cbb_Price_Small;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ListView lv_TeaInfo;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}