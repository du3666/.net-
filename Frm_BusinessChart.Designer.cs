namespace 饮品店点餐收银系统
{
    partial class Frm_BusinessChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_User = new System.Windows.Forms.ComboBox();
            this.cbb_Tea = new System.Windows.Forms.ComboBox();
            this.cbb_PayWay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_BeginDate = new System.Windows.Forms.DateTimePicker();
            this.chb_User = new System.Windows.Forms.CheckBox();
            this.chb_Tea = new System.Windows.Forms.CheckBox();
            this.chb_Payway = new System.Windows.Forms.CheckBox();
            this.chb_OrderDate = new System.Windows.Forms.CheckBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_User);
            this.groupBox1.Controls.Add(this.cbb_Tea);
            this.groupBox1.Controls.Add(this.cbb_PayWay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_EndDate);
            this.groupBox1.Controls.Add(this.dtp_BeginDate);
            this.groupBox1.Controls.Add(this.chb_User);
            this.groupBox1.Controls.Add(this.chb_Tea);
            this.groupBox1.Controls.Add(this.chb_Payway);
            this.groupBox1.Controls.Add(this.chb_OrderDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // cbb_User
            // 
            this.cbb_User.FormattingEnabled = true;
            this.cbb_User.Items.AddRange(new object[] {
            "111",
            "nannan"});
            this.cbb_User.Location = new System.Drawing.Point(533, 95);
            this.cbb_User.Name = "cbb_User";
            this.cbb_User.Size = new System.Drawing.Size(121, 26);
            this.cbb_User.TabIndex = 9;
            // 
            // cbb_Tea
            // 
            this.cbb_Tea.FormattingEnabled = true;
            this.cbb_Tea.Items.AddRange(new object[] {
            "拿铁",
            "冰美式",
            "西瓜汁",
            "杨枝甘露"});
            this.cbb_Tea.Location = new System.Drawing.Point(353, 93);
            this.cbb_Tea.Name = "cbb_Tea";
            this.cbb_Tea.Size = new System.Drawing.Size(78, 26);
            this.cbb_Tea.TabIndex = 8;
            // 
            // cbb_PayWay
            // 
            this.cbb_PayWay.FormattingEnabled = true;
            this.cbb_PayWay.Items.AddRange(new object[] {
            "全部",
            "现金",
            "银行卡",
            "支付宝",
            "微信"});
            this.cbb_PayWay.Location = new System.Drawing.Point(143, 94);
            this.cbb_PayWay.Name = "cbb_PayWay";
            this.cbb_PayWay.Size = new System.Drawing.Size(92, 26);
            this.cbb_PayWay.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "至";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(395, 39);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(165, 28);
            this.dtp_EndDate.TabIndex = 5;
            // 
            // dtp_BeginDate
            // 
            this.dtp_BeginDate.Location = new System.Drawing.Point(171, 39);
            this.dtp_BeginDate.Name = "dtp_BeginDate";
            this.dtp_BeginDate.Size = new System.Drawing.Size(156, 28);
            this.dtp_BeginDate.TabIndex = 4;
            // 
            // chb_User
            // 
            this.chb_User.AutoSize = true;
            this.chb_User.Location = new System.Drawing.Point(439, 96);
            this.chb_User.Name = "chb_User";
            this.chb_User.Size = new System.Drawing.Size(88, 22);
            this.chb_User.TabIndex = 3;
            this.chb_User.Text = "销售员";
            this.chb_User.UseVisualStyleBackColor = true;
            // 
            // chb_Tea
            // 
            this.chb_Tea.AutoSize = true;
            this.chb_Tea.Location = new System.Drawing.Point(241, 95);
            this.chb_Tea.Name = "chb_Tea";
            this.chb_Tea.Size = new System.Drawing.Size(106, 22);
            this.chb_Tea.TabIndex = 2;
            this.chb_Tea.Text = "饮品名称";
            this.chb_Tea.UseVisualStyleBackColor = true;
            // 
            // chb_Payway
            // 
            this.chb_Payway.AutoSize = true;
            this.chb_Payway.Location = new System.Drawing.Point(27, 97);
            this.chb_Payway.Name = "chb_Payway";
            this.chb_Payway.Size = new System.Drawing.Size(106, 22);
            this.chb_Payway.TabIndex = 1;
            this.chb_Payway.Text = "付款方式";
            this.chb_Payway.UseVisualStyleBackColor = true;
            // 
            // chb_OrderDate
            // 
            this.chb_OrderDate.AutoSize = true;
            this.chb_OrderDate.Location = new System.Drawing.Point(27, 39);
            this.chb_OrderDate.Name = "chb_OrderDate";
            this.chb_OrderDate.Size = new System.Drawing.Size(106, 22);
            this.chb_OrderDate.TabIndex = 0;
            this.chb_OrderDate.Text = "销售日期";
            this.chb_OrderDate.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(804, 77);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(105, 48);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(681, 77);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(98, 53);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "生成报表";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 169);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(884, 355);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Frm_BusinessChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 548);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_BusinessChart";
            this.Text = "业绩统计分析";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_User;
        private System.Windows.Forms.ComboBox cbb_Tea;
        private System.Windows.Forms.ComboBox cbb_PayWay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_BeginDate;
        private System.Windows.Forms.CheckBox chb_User;
        private System.Windows.Forms.CheckBox chb_Tea;
        private System.Windows.Forms.CheckBox chb_Payway;
        private System.Windows.Forms.CheckBox chb_OrderDate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}