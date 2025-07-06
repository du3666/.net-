namespace 饮品店点餐收银系统
{
    partial class Frm_UserInfoManage
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
            this.cbb_Type = new System.Windows.Forms.ComboBox();
            this.radio_forbidden = new System.Windows.Forms.RadioButton();
            this.radio_Use = new System.Windows.Forms.RadioButton();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_RealName = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_UserInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.btn_Forbidden = new System.Windows.Forms.Button();
            this.btn_Use = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_Type);
            this.groupBox1.Controls.Add(this.radio_forbidden);
            this.groupBox1.Controls.Add(this.radio_Use);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.txt_RealName);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑员工信息  状态：";
            // 
            // cbb_Type
            // 
            this.cbb_Type.FormattingEnabled = true;
            this.cbb_Type.Items.AddRange(new object[] {
            "职员",
            "店长"});
            this.cbb_Type.Location = new System.Drawing.Point(499, 98);
            this.cbb_Type.Name = "cbb_Type";
            this.cbb_Type.Size = new System.Drawing.Size(207, 26);
            this.cbb_Type.TabIndex = 13;
            // 
            // radio_forbidden
            // 
            this.radio_forbidden.AutoSize = true;
            this.radio_forbidden.Location = new System.Drawing.Point(293, 157);
            this.radio_forbidden.Name = "radio_forbidden";
            this.radio_forbidden.Size = new System.Drawing.Size(69, 22);
            this.radio_forbidden.TabIndex = 12;
            this.radio_forbidden.TabStop = true;
            this.radio_forbidden.Text = "禁用";
            this.radio_forbidden.UseVisualStyleBackColor = true;
            this.radio_forbidden.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radio_Use
            // 
            this.radio_Use.AutoSize = true;
            this.radio_Use.Location = new System.Drawing.Point(169, 157);
            this.radio_Use.Name = "radio_Use";
            this.radio_Use.Size = new System.Drawing.Size(69, 22);
            this.radio_Use.TabIndex = 11;
            this.radio_Use.TabStop = true;
            this.radio_Use.Text = "启用";
            this.radio_Use.UseVisualStyleBackColor = true;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(499, 51);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(207, 28);
            this.txt_Password.TabIndex = 10;
            // 
            // txt_RealName
            // 
            this.txt_RealName.Location = new System.Drawing.Point(155, 97);
            this.txt_RealName.Name = "txt_RealName";
            this.txt_RealName.Size = new System.Drawing.Size(207, 28);
            this.txt_RealName.TabIndex = 9;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(155, 51);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(207, 28);
            this.txt_UserName.TabIndex = 8;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(443, 219);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(119, 50);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(183, 219);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(114, 50);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(205, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 18);
            this.lbl_Status.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "用户类别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_UserInfo);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_changePassword);
            this.groupBox2.Controls.Add(this.btn_Forbidden);
            this.groupBox2.Controls.Add(this.btn_Use);
            this.groupBox2.Location = new System.Drawing.Point(12, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "员工信息列表";
            // 
            // lv_UserInfo
            // 
            this.lv_UserInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_UserInfo.FullRowSelect = true;
            this.lv_UserInfo.GridLines = true;
            this.lv_UserInfo.HideSelection = false;
            this.lv_UserInfo.Location = new System.Drawing.Point(6, 40);
            this.lv_UserInfo.MultiSelect = false;
            this.lv_UserInfo.Name = "lv_UserInfo";
            this.lv_UserInfo.Size = new System.Drawing.Size(764, 267);
            this.lv_UserInfo.TabIndex = 12;
            this.lv_UserInfo.UseCompatibleStateImageBehavior = false;
            this.lv_UserInfo.View = System.Windows.Forms.View.Details;
            this.lv_UserInfo.SelectedIndexChanged += new System.EventHandler(this.lv_UserInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "用户名";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "密码";
            this.columnHeader3.Width = 153;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "姓名";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "类别";
            this.columnHeader5.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态";
            this.columnHeader6.Width = 106;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(651, -13);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 50);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Location = new System.Drawing.Point(499, -13);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(119, 50);
            this.btn_changePassword.TabIndex = 10;
            this.btn_changePassword.Text = "重制密码";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // btn_Forbidden
            // 
            this.btn_Forbidden.Location = new System.Drawing.Point(342, -13);
            this.btn_Forbidden.Name = "btn_Forbidden";
            this.btn_Forbidden.Size = new System.Drawing.Size(119, 50);
            this.btn_Forbidden.TabIndex = 9;
            this.btn_Forbidden.Text = "禁用";
            this.btn_Forbidden.UseVisualStyleBackColor = true;
            this.btn_Forbidden.Click += new System.EventHandler(this.btn_Forbidden_Click);
            // 
            // btn_Use
            // 
            this.btn_Use.Location = new System.Drawing.Point(183, -13);
            this.btn_Use.Name = "btn_Use";
            this.btn_Use.Size = new System.Drawing.Size(119, 50);
            this.btn_Use.TabIndex = 8;
            this.btn_Use.Text = "启用";
            this.btn_Use.UseVisualStyleBackColor = true;
            this.btn_Use.Click += new System.EventHandler(this.btn_Use_Click);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(300, 341);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 18);
            this.lbl_Note.TabIndex = 2;
            this.lbl_Note.Click += new System.EventHandler(this.label7_Click);
            // 
            // Frm_UserInfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 718);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_UserInfoManage";
            this.Text = "员工信息管理";
            this.Load += new System.EventHandler(this.Frm_UserInfoManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.Button btn_Forbidden;
        private System.Windows.Forms.Button btn_Use;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.ComboBox cbb_Type;
        private System.Windows.Forms.RadioButton radio_forbidden;
        private System.Windows.Forms.RadioButton radio_Use;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_RealName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.ListView lv_UserInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}