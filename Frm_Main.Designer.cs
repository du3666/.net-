namespace 饮品店点餐收银系统
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理toolmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TeaInfoManag = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TeaPriceManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MemberInfoManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_UserInfoManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ChangePassWord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.点餐服务FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_PlayMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.查询中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TeaInfoQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MemberInfoQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OrderInfoQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_BusinessChart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_TeaInfoManage = new System.Windows.Forms.ToolStripButton();
            this.btn_MemberInfo = new System.Windows.Forms.ToolStripButton();
            this.btn_Orderonly = new System.Windows.Forms.ToolStripButton();
            this.btn_Order = new System.Windows.Forms.ToolStripButton();
            this.btn_PlayMusic = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理toolmenu,
            this.点餐服务FToolStripMenuItem,
            this.查询中心ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 系统管理toolmenu
            // 
            this.系统管理toolmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_TeaInfoManag,
            this.menu_TeaPriceManage,
            this.menu_MemberInfoManage,
            this.menu_UserInfoManage,
            this.menu_ChangePassWord,
            this.toolStripMenuItem2,
            this.menu_Exit});
            this.系统管理toolmenu.Name = "系统管理toolmenu";
            this.系统管理toolmenu.Size = new System.Drawing.Size(120, 28);
            this.系统管理toolmenu.Text = "系统管理(&S)";
            // 
            // menu_TeaInfoManag
            // 
            this.menu_TeaInfoManag.Name = "menu_TeaInfoManag";
            this.menu_TeaInfoManag.Size = new System.Drawing.Size(300, 34);
            this.menu_TeaInfoManag.Text = "饮品信息管理";
            this.menu_TeaInfoManag.Click += new System.EventHandler(this.menu_TeaInfoManag_Click);
            // 
            // menu_TeaPriceManage
            // 
            this.menu_TeaPriceManage.Name = "menu_TeaPriceManage";
            this.menu_TeaPriceManage.Size = new System.Drawing.Size(300, 34);
            this.menu_TeaPriceManage.Text = "饮品价格管理";
            this.menu_TeaPriceManage.Click += new System.EventHandler(this.menu_TeaPriceManage_Click);
            // 
            // menu_MemberInfoManage
            // 
            this.menu_MemberInfoManage.Name = "menu_MemberInfoManage";
            this.menu_MemberInfoManage.Size = new System.Drawing.Size(300, 34);
            this.menu_MemberInfoManage.Text = "会员信息管理";
            this.menu_MemberInfoManage.Click += new System.EventHandler(this.menu_MemberInfoManage_Click);
            // 
            // menu_UserInfoManage
            // 
            this.menu_UserInfoManage.Name = "menu_UserInfoManage";
            this.menu_UserInfoManage.Size = new System.Drawing.Size(300, 34);
            this.menu_UserInfoManage.Text = "员工信息i管理";
            this.menu_UserInfoManage.Click += new System.EventHandler(this.menu_UserInfoManage_Click);
            // 
            // menu_ChangePassWord
            // 
            this.menu_ChangePassWord.Name = "menu_ChangePassWord";
            this.menu_ChangePassWord.Size = new System.Drawing.Size(300, 34);
            this.menu_ChangePassWord.Text = "修改密码";
            this.menu_ChangePassWord.Click += new System.EventHandler(this.menu_ChangePassWord_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(300, 34);
            this.toolStripMenuItem2.Text = "——————————";
            // 
            // menu_Exit
            // 
            this.menu_Exit.Name = "menu_Exit";
            this.menu_Exit.Size = new System.Drawing.Size(300, 34);
            this.menu_Exit.Text = "退出系统";
            this.menu_Exit.Click += new System.EventHandler(this.menu_Exit_Click);
            // 
            // 点餐服务FToolStripMenuItem
            // 
            this.点餐服务FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Order,
            this.menu_PlayMusic});
            this.点餐服务FToolStripMenuItem.Name = "点餐服务FToolStripMenuItem";
            this.点餐服务FToolStripMenuItem.Size = new System.Drawing.Size(120, 28);
            this.点餐服务FToolStripMenuItem.Text = "点餐服务(&F)";
            // 
            // menu_Order
            // 
            this.menu_Order.Name = "menu_Order";
            this.menu_Order.Size = new System.Drawing.Size(182, 34);
            this.menu_Order.Text = "点餐收银";
            this.menu_Order.Click += new System.EventHandler(this.menu_Order_Click);
            // 
            // menu_PlayMusic
            // 
            this.menu_PlayMusic.Name = "menu_PlayMusic";
            this.menu_PlayMusic.Size = new System.Drawing.Size(182, 34);
            this.menu_PlayMusic.Text = "播放音乐";
            this.menu_PlayMusic.Click += new System.EventHandler(this.menu_PlayMusic_Click);
            // 
            // 查询中心ToolStripMenuItem
            // 
            this.查询中心ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_TeaInfoQuery,
            this.menu_MemberInfoQuery,
            this.menu_OrderInfoQuery,
            this.menu_BusinessChart});
            this.查询中心ToolStripMenuItem.Name = "查询中心ToolStripMenuItem";
            this.查询中心ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.查询中心ToolStripMenuItem.Text = "查询中心";
            // 
            // menu_TeaInfoQuery
            // 
            this.menu_TeaInfoQuery.Name = "menu_TeaInfoQuery";
            this.menu_TeaInfoQuery.Size = new System.Drawing.Size(218, 34);
            this.menu_TeaInfoQuery.Text = "饮品信息查询";
            this.menu_TeaInfoQuery.Click += new System.EventHandler(this.menu_TeaInfoQuery_Click);
            // 
            // menu_MemberInfoQuery
            // 
            this.menu_MemberInfoQuery.Name = "menu_MemberInfoQuery";
            this.menu_MemberInfoQuery.Size = new System.Drawing.Size(218, 34);
            this.menu_MemberInfoQuery.Text = "会员信息查询";
            this.menu_MemberInfoQuery.Click += new System.EventHandler(this.menu_MemberInfoQuery_Click);
            // 
            // menu_OrderInfoQuery
            // 
            this.menu_OrderInfoQuery.Name = "menu_OrderInfoQuery";
            this.menu_OrderInfoQuery.Size = new System.Drawing.Size(218, 34);
            this.menu_OrderInfoQuery.Text = "营业信息查询";
            this.menu_OrderInfoQuery.Click += new System.EventHandler(this.menu_OrderInfoQuery_Click);
            // 
            // menu_BusinessChart
            // 
            this.menu_BusinessChart.Name = "menu_BusinessChart";
            this.menu_BusinessChart.Size = new System.Drawing.Size(218, 34);
            this.menu_BusinessChart.Text = "业绩统计分析";
            this.menu_BusinessChart.Click += new System.EventHandler(this.menu_BusinessChart_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_TeaInfoManage,
            this.btn_MemberInfo,
            this.btn_Orderonly,
            this.btn_Order,
            this.btn_PlayMusic});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1027, 83);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_TeaInfoManage
            // 
            this.btn_TeaInfoManage.Image = ((System.Drawing.Image)(resources.GetObject("btn_TeaInfoManage.Image")));
            this.btn_TeaInfoManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_TeaInfoManage.Name = "btn_TeaInfoManage";
            this.btn_TeaInfoManage.Size = new System.Drawing.Size(122, 78);
            this.btn_TeaInfoManage.Text = "饮品信息管理";
            this.btn_TeaInfoManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TeaInfoManage.Click += new System.EventHandler(this.btn_TeaInfoManage_Click);
            // 
            // btn_MemberInfo
            // 
            this.btn_MemberInfo.Image = ((System.Drawing.Image)(resources.GetObject("btn_MemberInfo.Image")));
            this.btn_MemberInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_MemberInfo.Name = "btn_MemberInfo";
            this.btn_MemberInfo.Size = new System.Drawing.Size(122, 78);
            this.btn_MemberInfo.Text = "会员信息管理";
            this.btn_MemberInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_MemberInfo.Click += new System.EventHandler(this.btn_MemberInfo_Click);
            // 
            // btn_Orderonly
            // 
            this.btn_Orderonly.Image = ((System.Drawing.Image)(resources.GetObject("btn_Orderonly.Image")));
            this.btn_Orderonly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Orderonly.Name = "btn_Orderonly";
            this.btn_Orderonly.Size = new System.Drawing.Size(86, 78);
            this.btn_Orderonly.Text = "自助点餐";
            this.btn_Orderonly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Orderonly.Click += new System.EventHandler(this.btn_Orderonly_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Image = ((System.Drawing.Image)(resources.GetObject("btn_Order.Image")));
            this.btn_Order.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(86, 78);
            this.btn_Order.Text = "点餐收银";
            this.btn_Order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_PlayMusic
            // 
            this.btn_PlayMusic.Image = ((System.Drawing.Image)(resources.GetObject("btn_PlayMusic.Image")));
            this.btn_PlayMusic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PlayMusic.Name = "btn_PlayMusic";
            this.btn_PlayMusic.Size = new System.Drawing.Size(86, 78);
            this.btn_PlayMusic.Text = "播放音乐";
            this.btn_PlayMusic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_PlayMusic.Click += new System.EventHandler(this.btn_PlayMusic_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label1,
            this.Label2,
            this.Label3,
            this.Label5,
            this.Label4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1027, 31);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // Label1
            // 
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(118, 24);
            this.Label1.Text = "当前操作员：";
            // 
            // Label2
            // 
            this.Label2.AutoSize = false;
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 24);
            // 
            // Label3
            // 
            this.Label3.AutoSize = false;
            this.Label3.AutoToolTip = true;
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(244, 24);
            this.Label3.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Label5
            // 
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(0, 24);
            // 
            // Label4
            // 
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 24);
            this.Label4.Text = "当前时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 432);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 7;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 615);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.Text = "饮品店点餐收银系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理toolmenu;
        private System.Windows.Forms.ToolStripMenuItem menu_TeaInfoManag;
        private System.Windows.Forms.ToolStripMenuItem menu_TeaPriceManage;
        private System.Windows.Forms.ToolStripMenuItem menu_MemberInfoManage;
        private System.Windows.Forms.ToolStripMenuItem menu_UserInfoManage;
        private System.Windows.Forms.ToolStripMenuItem menu_ChangePassWord;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem 点餐服务FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Order;
        private System.Windows.Forms.ToolStripMenuItem menu_PlayMusic;
        private System.Windows.Forms.ToolStripMenuItem 查询中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_TeaInfoQuery;
        private System.Windows.Forms.ToolStripMenuItem menu_MemberInfoQuery;
        private System.Windows.Forms.ToolStripMenuItem menu_OrderInfoQuery;
        private System.Windows.Forms.ToolStripMenuItem menu_BusinessChart;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_TeaInfoManage;
        private System.Windows.Forms.ToolStripButton btn_MemberInfo;
        private System.Windows.Forms.ToolStripButton btn_Orderonly;
        private System.Windows.Forms.ToolStripButton btn_Order;
        private System.Windows.Forms.ToolStripButton btn_PlayMusic;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Label1;
        private System.Windows.Forms.ToolStripStatusLabel Label2;
        private System.Windows.Forms.ToolStripStatusLabel Label3;
        private System.Windows.Forms.ToolStripStatusLabel Label4;
        private System.Windows.Forms.ToolStripStatusLabel Label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}