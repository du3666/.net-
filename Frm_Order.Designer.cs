namespace 饮品店点餐收银系统
{
    partial class Frm_Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Price_Small = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AppendtoOrder = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.lbl_Price_Large = new System.Windows.Forms.Label();
            this.lbl_Price_Medium = new System.Windows.Forms.Label();
            this.lb_Price_Small = new System.Windows.Forms.Label();
            this.txt_Remark1 = new System.Windows.Forms.TextBox();
            this.rb_Large = new System.Windows.Forms.RadioButton();
            this.rb_Medium = new System.Windows.Forms.RadioButton();
            this.rb_Small = new System.Windows.Forms.RadioButton();
            this.lbl_TeaName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lv_TeaInfo = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rb_Payway4 = new System.Windows.Forms.RadioButton();
            this.rb_Payway3 = new System.Windows.Forms.RadioButton();
            this.rb_Payway2 = new System.Windows.Forms.RadioButton();
            this.rb_Payway = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DiscountRate = new System.Windows.Forms.NumericUpDown();
            this.txt_PaidUpMoney = new System.Windows.Forms.TextBox();
            this.txt_DiscountMoney = new System.Windows.Forms.TextBox();
            this.txt_DueMoney = new System.Windows.Forms.TextBox();
            this.txt_MemberNumber = new System.Windows.Forms.TextBox();
            this.txt_Remark2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_plus2 = new System.Windows.Forms.Button();
            this.lv_OrderInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiscountRate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "我的饮品我做主！";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Price_Small);
            this.groupBox1.Controls.Add(this.txt_Quantity);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_AppendtoOrder);
            this.groupBox1.Controls.Add(this.btn_minus);
            this.groupBox1.Controls.Add(this.btn_plus);
            this.groupBox1.Controls.Add(this.lbl_Price_Large);
            this.groupBox1.Controls.Add(this.lbl_Price_Medium);
            this.groupBox1.Controls.Add(this.lb_Price_Small);
            this.groupBox1.Controls.Add(this.txt_Remark1);
            this.groupBox1.Controls.Add(this.rb_Large);
            this.groupBox1.Controls.Add(this.rb_Medium);
            this.groupBox1.Controls.Add(this.rb_Small);
            this.groupBox1.Controls.Add(this.lbl_TeaName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lv_TeaInfo);
            this.groupBox1.Location = new System.Drawing.Point(16, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 582);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择饮品信息";
            // 
            // lbl_Price_Small
            // 
            this.lbl_Price_Small.AutoSize = true;
            this.lbl_Price_Small.Location = new System.Drawing.Point(304, 474);
            this.lbl_Price_Small.Name = "lbl_Price_Small";
            this.lbl_Price_Small.Size = new System.Drawing.Size(0, 18);
            this.lbl_Price_Small.TabIndex = 40;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(351, 508);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.ReadOnly = true;
            this.txt_Quantity.Size = new System.Drawing.Size(64, 28);
            this.txt_Quantity.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 187);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btn_AppendtoOrder
            // 
            this.btn_AppendtoOrder.Location = new System.Drawing.Point(558, 461);
            this.btn_AppendtoOrder.Name = "btn_AppendtoOrder";
            this.btn_AppendtoOrder.Size = new System.Drawing.Size(103, 44);
            this.btn_AppendtoOrder.TabIndex = 37;
            this.btn_AppendtoOrder.Text = "加入订单";
            this.btn_AppendtoOrder.UseVisualStyleBackColor = true;
            this.btn_AppendtoOrder.Click += new System.EventHandler(this.btn_AppendtoOrder_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(420, 508);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(41, 28);
            this.btn_minus.TabIndex = 36;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(307, 508);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(38, 29);
            this.btn_plus.TabIndex = 35;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // lbl_Price_Large
            // 
            this.lbl_Price_Large.AutoSize = true;
            this.lbl_Price_Large.Location = new System.Drawing.Point(476, 474);
            this.lbl_Price_Large.Name = "lbl_Price_Large";
            this.lbl_Price_Large.Size = new System.Drawing.Size(0, 18);
            this.lbl_Price_Large.TabIndex = 33;
            // 
            // lbl_Price_Medium
            // 
            this.lbl_Price_Medium.AutoSize = true;
            this.lbl_Price_Medium.Location = new System.Drawing.Point(390, 474);
            this.lbl_Price_Medium.Name = "lbl_Price_Medium";
            this.lbl_Price_Medium.Size = new System.Drawing.Size(0, 18);
            this.lbl_Price_Medium.TabIndex = 32;
            // 
            // lb_Price_Small
            // 
            this.lb_Price_Small.AutoSize = true;
            this.lb_Price_Small.Location = new System.Drawing.Point(304, 474);
            this.lb_Price_Small.Name = "lb_Price_Small";
            this.lb_Price_Small.Size = new System.Drawing.Size(0, 18);
            this.lb_Price_Small.TabIndex = 31;
            // 
            // txt_Remark1
            // 
            this.txt_Remark1.Location = new System.Drawing.Point(296, 547);
            this.txt_Remark1.Name = "txt_Remark1";
            this.txt_Remark1.Size = new System.Drawing.Size(272, 28);
            this.txt_Remark1.TabIndex = 23;
            // 
            // rb_Large
            // 
            this.rb_Large.AutoSize = true;
            this.rb_Large.Location = new System.Drawing.Point(479, 425);
            this.rb_Large.Name = "rb_Large";
            this.rb_Large.Size = new System.Drawing.Size(69, 22);
            this.rb_Large.TabIndex = 30;
            this.rb_Large.TabStop = true;
            this.rb_Large.Text = "大份";
            this.rb_Large.UseVisualStyleBackColor = true;
            // 
            // rb_Medium
            // 
            this.rb_Medium.AutoSize = true;
            this.rb_Medium.Location = new System.Drawing.Point(393, 425);
            this.rb_Medium.Name = "rb_Medium";
            this.rb_Medium.Size = new System.Drawing.Size(69, 22);
            this.rb_Medium.TabIndex = 29;
            this.rb_Medium.TabStop = true;
            this.rb_Medium.Text = "中份";
            this.rb_Medium.UseVisualStyleBackColor = true;
            // 
            // rb_Small
            // 
            this.rb_Small.AutoSize = true;
            this.rb_Small.Location = new System.Drawing.Point(307, 425);
            this.rb_Small.Name = "rb_Small";
            this.rb_Small.Size = new System.Drawing.Size(69, 22);
            this.rb_Small.TabIndex = 28;
            this.rb_Small.TabStop = true;
            this.rb_Small.Text = "小份";
            this.rb_Small.UseVisualStyleBackColor = true;
            // 
            // lbl_TeaName
            // 
            this.lbl_TeaName.AutoSize = true;
            this.lbl_TeaName.Location = new System.Drawing.Point(293, 391);
            this.lbl_TeaName.Name = "lbl_TeaName";
            this.lbl_TeaName.Size = new System.Drawing.Size(0, 18);
            this.lbl_TeaName.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "备注：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 514);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "数量：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "价格：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "饮品名称：";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lv_TeaInfo
            // 
            this.lv_TeaInfo.HideSelection = false;
            this.lv_TeaInfo.LargeImageList = this.imageList1;
            this.lv_TeaInfo.Location = new System.Drawing.Point(6, 27);
            this.lv_TeaInfo.MultiSelect = false;
            this.lv_TeaInfo.Name = "lv_TeaInfo";
            this.lv_TeaInfo.Size = new System.Drawing.Size(655, 348);
            this.lv_TeaInfo.TabIndex = 0;
            this.lv_TeaInfo.UseCompatibleStateImageBehavior = false;
            this.lv_TeaInfo.SelectedIndexChanged += new System.EventHandler(this.lv_TeaInfo_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.rb_Payway4);
            this.groupBox2.Controls.Add(this.rb_Payway3);
            this.groupBox2.Controls.Add(this.rb_Payway2);
            this.groupBox2.Controls.Add(this.rb_Payway);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_DiscountRate);
            this.groupBox2.Controls.Add(this.txt_PaidUpMoney);
            this.groupBox2.Controls.Add(this.txt_DiscountMoney);
            this.groupBox2.Controls.Add(this.txt_DueMoney);
            this.groupBox2.Controls.Add(this.txt_MemberNumber);
            this.groupBox2.Controls.Add(this.txt_Remark2);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btn_plus2);
            this.groupBox2.Controls.Add(this.lv_OrderInfo);
            this.groupBox2.Location = new System.Drawing.Point(716, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 567);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单信息";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(312, 376);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 18);
            this.label17.TabIndex = 3;
            this.label17.Text = "%";
            // 
            // rb_Payway4
            // 
            this.rb_Payway4.AutoSize = true;
            this.rb_Payway4.Location = new System.Drawing.Point(205, 500);
            this.rb_Payway4.Name = "rb_Payway4";
            this.rb_Payway4.Size = new System.Drawing.Size(69, 22);
            this.rb_Payway4.TabIndex = 22;
            this.rb_Payway4.TabStop = true;
            this.rb_Payway4.Text = "微信";
            this.rb_Payway4.UseVisualStyleBackColor = true;
            // 
            // rb_Payway3
            // 
            this.rb_Payway3.AutoSize = true;
            this.rb_Payway3.Location = new System.Drawing.Point(119, 500);
            this.rb_Payway3.Name = "rb_Payway3";
            this.rb_Payway3.Size = new System.Drawing.Size(87, 22);
            this.rb_Payway3.TabIndex = 21;
            this.rb_Payway3.TabStop = true;
            this.rb_Payway3.Text = "支付宝";
            this.rb_Payway3.UseVisualStyleBackColor = true;
            // 
            // rb_Payway2
            // 
            this.rb_Payway2.AutoSize = true;
            this.rb_Payway2.Location = new System.Drawing.Point(205, 474);
            this.rb_Payway2.Name = "rb_Payway2";
            this.rb_Payway2.Size = new System.Drawing.Size(87, 22);
            this.rb_Payway2.TabIndex = 20;
            this.rb_Payway2.TabStop = true;
            this.rb_Payway2.Text = "银行卡";
            this.rb_Payway2.UseVisualStyleBackColor = true;
            // 
            // rb_Payway
            // 
            this.rb_Payway.AutoSize = true;
            this.rb_Payway.Location = new System.Drawing.Point(119, 471);
            this.rb_Payway.Name = "rb_Payway";
            this.rb_Payway.Size = new System.Drawing.Size(69, 22);
            this.rb_Payway.TabIndex = 19;
            this.rb_Payway.TabStop = true;
            this.rb_Payway.Text = "现金";
            this.rb_Payway.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "实收金额";
            // 
            // txt_DiscountRate
            // 
            this.txt_DiscountRate.Location = new System.Drawing.Point(104, 366);
            this.txt_DiscountRate.Name = "txt_DiscountRate";
            this.txt_DiscountRate.Size = new System.Drawing.Size(202, 28);
            this.txt_DiscountRate.TabIndex = 17;
            this.txt_DiscountRate.Leave += new System.EventHandler(this.txt_DiscountRate_Leave_1);
            // 
            // txt_PaidUpMoney
            // 
            this.txt_PaidUpMoney.Location = new System.Drawing.Point(104, 434);
            this.txt_PaidUpMoney.Name = "txt_PaidUpMoney";
            this.txt_PaidUpMoney.Size = new System.Drawing.Size(202, 28);
            this.txt_PaidUpMoney.TabIndex = 16;
            this.txt_PaidUpMoney.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_DiscountMoney
            // 
            this.txt_DiscountMoney.Location = new System.Drawing.Point(104, 400);
            this.txt_DiscountMoney.Name = "txt_DiscountMoney";
            this.txt_DiscountMoney.Size = new System.Drawing.Size(202, 28);
            this.txt_DiscountMoney.TabIndex = 15;
            // 
            // txt_DueMoney
            // 
            this.txt_DueMoney.Location = new System.Drawing.Point(104, 332);
            this.txt_DueMoney.Name = "txt_DueMoney";
            this.txt_DueMoney.Size = new System.Drawing.Size(202, 28);
            this.txt_DueMoney.TabIndex = 14;
            // 
            // txt_MemberNumber
            // 
            this.txt_MemberNumber.Location = new System.Drawing.Point(104, 298);
            this.txt_MemberNumber.Name = "txt_MemberNumber";
            this.txt_MemberNumber.Size = new System.Drawing.Size(202, 28);
            this.txt_MemberNumber.TabIndex = 13;
            // 
            // txt_Remark2
            // 
            this.txt_Remark2.Location = new System.Drawing.Point(104, 264);
            this.txt_Remark2.Name = "txt_Remark2";
            this.txt_Remark2.Size = new System.Drawing.Size(202, 28);
            this.txt_Remark2.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(205, 527);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 34);
            this.button5.TabIndex = 11;
            this.button5.Text = "取消订单";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "确认支付";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "折扣金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "付款方式：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "折扣比例：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "订单金额：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "会员卡号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "订单备注：";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "移除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "减1份";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_plus2
            // 
            this.btn_plus2.Location = new System.Drawing.Point(29, 230);
            this.btn_plus2.Name = "btn_plus2";
            this.btn_plus2.Size = new System.Drawing.Size(85, 34);
            this.btn_plus2.TabIndex = 1;
            this.btn_plus2.Text = "加1份";
            this.btn_plus2.UseVisualStyleBackColor = true;
            this.btn_plus2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lv_OrderInfo
            // 
            this.lv_OrderInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_OrderInfo.FullRowSelect = true;
            this.lv_OrderInfo.GridLines = true;
            this.lv_OrderInfo.HideSelection = false;
            this.lv_OrderInfo.Location = new System.Drawing.Point(6, 27);
            this.lv_OrderInfo.MultiSelect = false;
            this.lv_OrderInfo.Name = "lv_OrderInfo";
            this.lv_OrderInfo.Size = new System.Drawing.Size(387, 197);
            this.lv_OrderInfo.TabIndex = 0;
            this.lv_OrderInfo.UseCompatibleStateImageBehavior = false;
            this.lv_OrderInfo.View = System.Windows.Forms.View.Details;
            this.lv_OrderInfo.SelectedIndexChanged += new System.EventHandler(this.lv_OrderInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "饮品名称";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "规模";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "价格";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "数量";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            // 
            // Frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Order";
            this.Text = "点餐收银";
            this.Load += new System.EventHandler(this.Frm_Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiscountRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_TeaInfo;
        private System.Windows.Forms.Button btn_plus2;
        private System.Windows.Forms.ListView lv_OrderInfo;
        private System.Windows.Forms.TextBox txt_DueMoney;
        private System.Windows.Forms.TextBox txt_MemberNumber;
        private System.Windows.Forms.TextBox txt_Remark2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txt_DiscountRate;
        private System.Windows.Forms.TextBox txt_PaidUpMoney;
        private System.Windows.Forms.TextBox txt_DiscountMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rb_Payway4;
        private System.Windows.Forms.RadioButton rb_Payway3;
        private System.Windows.Forms.RadioButton rb_Payway2;
        private System.Windows.Forms.RadioButton rb_Payway;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RadioButton rb_Large;
        private System.Windows.Forms.RadioButton rb_Medium;
        private System.Windows.Forms.RadioButton rb_Small;
        private System.Windows.Forms.Label lbl_TeaName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AppendtoOrder;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Label lbl_Price_Large;
        private System.Windows.Forms.Label lbl_Price_Medium;
        private System.Windows.Forms.Label lb_Price_Small;
        private System.Windows.Forms.TextBox txt_Remark1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_Price_Small;
    }
}