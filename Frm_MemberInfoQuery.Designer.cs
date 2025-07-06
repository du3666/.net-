namespace 饮品店点餐收银系统
{
    partial class Frm_MemberInfoQuery
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
            this.cbb_Sex = new System.Windows.Forms.ComboBox();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.chb_Sex = new System.Windows.Forms.CheckBox();
            this.chb_Number = new System.Windows.Forms.CheckBox();
            this.chb_Telephone = new System.Windows.Forms.CheckBox();
            this.chb_Name = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_MemberInfo = new System.Windows.Forms.ListView();
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
            this.groupBox1.Controls.Add(this.cbb_Sex);
            this.groupBox1.Controls.Add(this.txt_Number);
            this.groupBox1.Controls.Add(this.txt_Telephone);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.chb_Sex);
            this.groupBox1.Controls.Add(this.chb_Number);
            this.groupBox1.Controls.Add(this.chb_Telephone);
            this.groupBox1.Controls.Add(this.chb_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // cbb_Sex
            // 
            this.cbb_Sex.FormattingEnabled = true;
            this.cbb_Sex.Items.AddRange(new object[] {
            "全部",
            "男",
            "女"});
            this.cbb_Sex.Location = new System.Drawing.Point(388, 89);
            this.cbb_Sex.Name = "cbb_Sex";
            this.cbb_Sex.Size = new System.Drawing.Size(139, 26);
            this.cbb_Sex.TabIndex = 9;
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(424, 40);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(149, 28);
            this.txt_Number.TabIndex = 8;
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(128, 85);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(160, 28);
            this.txt_Telephone.TabIndex = 7;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(128, 36);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(160, 28);
            this.txt_Name.TabIndex = 6;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(722, 62);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 51);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "清空";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(579, 62);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(115, 51);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // chb_Sex
            // 
            this.chb_Sex.AutoSize = true;
            this.chb_Sex.Location = new System.Drawing.Point(312, 91);
            this.chb_Sex.Name = "chb_Sex";
            this.chb_Sex.Size = new System.Drawing.Size(70, 22);
            this.chb_Sex.TabIndex = 3;
            this.chb_Sex.Text = "性别";
            this.chb_Sex.UseVisualStyleBackColor = true;
            // 
            // chb_Number
            // 
            this.chb_Number.AutoSize = true;
            this.chb_Number.Location = new System.Drawing.Point(312, 42);
            this.chb_Number.Name = "chb_Number";
            this.chb_Number.Size = new System.Drawing.Size(106, 22);
            this.chb_Number.TabIndex = 2;
            this.chb_Number.Text = "会员卡号";
            this.chb_Number.UseVisualStyleBackColor = true;
            // 
            // chb_Telephone
            // 
            this.chb_Telephone.AutoSize = true;
            this.chb_Telephone.Location = new System.Drawing.Point(21, 92);
            this.chb_Telephone.Name = "chb_Telephone";
            this.chb_Telephone.Size = new System.Drawing.Size(106, 22);
            this.chb_Telephone.TabIndex = 1;
            this.chb_Telephone.Text = "电话号码";
            this.chb_Telephone.UseVisualStyleBackColor = true;
            // 
            // chb_Name
            // 
            this.chb_Name.AutoSize = true;
            this.chb_Name.Location = new System.Drawing.Point(21, 36);
            this.chb_Name.Name = "chb_Name";
            this.chb_Name.Size = new System.Drawing.Size(106, 22);
            this.chb_Name.TabIndex = 0;
            this.chb_Name.Text = "会员姓名";
            this.chb_Name.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_MemberInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会员信息列表";
            // 
            // lv_MemberInfo
            // 
            this.lv_MemberInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_MemberInfo.FullRowSelect = true;
            this.lv_MemberInfo.GridLines = true;
            this.lv_MemberInfo.HideSelection = false;
            this.lv_MemberInfo.Location = new System.Drawing.Point(15, 27);
            this.lv_MemberInfo.MultiSelect = false;
            this.lv_MemberInfo.Name = "lv_MemberInfo";
            this.lv_MemberInfo.Size = new System.Drawing.Size(867, 348);
            this.lv_MemberInfo.TabIndex = 0;
            this.lv_MemberInfo.UseCompatibleStateImageBehavior = false;
            this.lv_MemberInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "会员姓名";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "会员卡号";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "性别";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "电话";
            this.columnHeader5.Width = 156;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态";
            this.columnHeader6.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "备注";
            this.columnHeader7.Width = 241;
            // 
            // Frm_MemberInfoQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_MemberInfoQuery";
            this.Text = "会员信息查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_Sex;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.CheckBox chb_Sex;
        private System.Windows.Forms.CheckBox chb_Number;
        private System.Windows.Forms.CheckBox chb_Telephone;
        private System.Windows.Forms.CheckBox chb_Name;
        private System.Windows.Forms.ListView lv_MemberInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}