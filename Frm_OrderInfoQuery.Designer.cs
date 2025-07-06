namespace 饮品店点餐收银系统
{
    partial class Frm_OrderInfoQuery
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_BeginDate = new System.Windows.Forms.DateTimePicker();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbb_Payway = new System.Windows.Forms.ComboBox();
            this.cbb_Drink_Name = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chb_Member_Number = new System.Windows.Forms.CheckBox();
            this.chb_Payway = new System.Windows.Forms.CheckBox();
            this.chb_Name = new System.Windows.Forms.CheckBox();
            this.chb_Date = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_OrderQuery = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_EndDate);
            this.groupBox1.Controls.Add(this.dtp_BeginDate);
            this.groupBox1.Controls.Add(this.txt_Number);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.cbb_Payway);
            this.groupBox1.Controls.Add(this.cbb_Drink_Name);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.chb_Member_Number);
            this.groupBox1.Controls.Add(this.chb_Payway);
            this.groupBox1.Controls.Add(this.chb_Name);
            this.groupBox1.Controls.Add(this.chb_Date);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "至";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(315, 44);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(159, 28);
            this.dtp_EndDate.TabIndex = 14;
            // 
            // dtp_BeginDate
            // 
            this.dtp_BeginDate.Location = new System.Drawing.Point(119, 42);
            this.dtp_BeginDate.Name = "dtp_BeginDate";
            this.dtp_BeginDate.Size = new System.Drawing.Size(158, 28);
            this.dtp_BeginDate.TabIndex = 13;
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(618, 98);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(161, 28);
            this.txt_Number.TabIndex = 12;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(959, 46);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(114, 67);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "请空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(800, 46);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 67);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbb_Payway
            // 
            this.cbb_Payway.FormattingEnabled = true;
            this.cbb_Payway.Items.AddRange(new object[] {
            "全部",
            "现金",
            "银行卡",
            "支付宝",
            "微信"});
            this.cbb_Payway.Location = new System.Drawing.Point(609, 41);
            this.cbb_Payway.Name = "cbb_Payway";
            this.cbb_Payway.Size = new System.Drawing.Size(161, 26);
            this.cbb_Payway.TabIndex = 8;
            // 
            // cbb_Drink_Name
            // 
            this.cbb_Drink_Name.FormattingEnabled = true;
            this.cbb_Drink_Name.Items.AddRange(new object[] {
            "杨枝甘露",
            "冰美式",
            "西瓜汁",
            "拿铁"});
            this.cbb_Drink_Name.Location = new System.Drawing.Point(130, 108);
            this.cbb_Drink_Name.Name = "cbb_Drink_Name";
            this.cbb_Drink_Name.Size = new System.Drawing.Size(344, 26);
            this.cbb_Drink_Name.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chb_Member_Number
            // 
            this.chb_Member_Number.AutoSize = true;
            this.chb_Member_Number.Location = new System.Drawing.Point(497, 100);
            this.chb_Member_Number.Name = "chb_Member_Number";
            this.chb_Member_Number.Size = new System.Drawing.Size(106, 22);
            this.chb_Member_Number.TabIndex = 3;
            this.chb_Member_Number.Text = "会员卡号";
            this.chb_Member_Number.UseVisualStyleBackColor = true;
            // 
            // chb_Payway
            // 
            this.chb_Payway.AutoSize = true;
            this.chb_Payway.Location = new System.Drawing.Point(497, 48);
            this.chb_Payway.Name = "chb_Payway";
            this.chb_Payway.Size = new System.Drawing.Size(106, 22);
            this.chb_Payway.TabIndex = 2;
            this.chb_Payway.Text = "付款方式";
            this.chb_Payway.UseVisualStyleBackColor = true;
            // 
            // chb_Name
            // 
            this.chb_Name.AutoSize = true;
            this.chb_Name.Location = new System.Drawing.Point(7, 108);
            this.chb_Name.Name = "chb_Name";
            this.chb_Name.Size = new System.Drawing.Size(106, 22);
            this.chb_Name.TabIndex = 1;
            this.chb_Name.Text = "饮品名称";
            this.chb_Name.UseVisualStyleBackColor = true;
            // 
            // chb_Date
            // 
            this.chb_Date.AutoSize = true;
            this.chb_Date.Location = new System.Drawing.Point(7, 43);
            this.chb_Date.Name = "chb_Date";
            this.chb_Date.Size = new System.Drawing.Size(106, 22);
            this.chb_Date.TabIndex = 0;
            this.chb_Date.Text = "销售日期";
            this.chb_Date.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_OrderQuery);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "营业信息列表";
            // 
            // lv_OrderQuery
            // 
            this.lv_OrderQuery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lv_OrderQuery.FullRowSelect = true;
            this.lv_OrderQuery.GridLines = true;
            this.lv_OrderQuery.HideSelection = false;
            this.lv_OrderQuery.Location = new System.Drawing.Point(7, 32);
            this.lv_OrderQuery.MultiSelect = false;
            this.lv_OrderQuery.Name = "lv_OrderQuery";
            this.lv_OrderQuery.Size = new System.Drawing.Size(1096, 307);
            this.lv_OrderQuery.TabIndex = 0;
            this.lv_OrderQuery.UseCompatibleStateImageBehavior = false;
            this.lv_OrderQuery.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "订单编号";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "会员卡号";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "订单内容";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "饮品数量";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "订单金额";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "折扣比例";
            this.columnHeader6.Width = 92;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "折扣金额";
            this.columnHeader7.Width = 97;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "实收金额";
            this.columnHeader8.Width = 92;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "支付方式";
            this.columnHeader9.Width = 95;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "销售日期";
            this.columnHeader10.Width = 118;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "操作员";
            this.columnHeader11.Width = 90;
            // 
            // Frm_OrderInfoQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_OrderInfoQuery";
            this.Text = "营业信息查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chb_Member_Number;
        private System.Windows.Forms.CheckBox chb_Payway;
        private System.Windows.Forms.CheckBox chb_Name;
        private System.Windows.Forms.CheckBox chb_Date;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbb_Payway;
        private System.Windows.Forms.ComboBox cbb_Drink_Name;
        private System.Windows.Forms.ListView lv_OrderQuery;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.DateTimePicker dtp_BeginDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
    }
}