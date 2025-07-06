namespace 饮品店点餐收银系统
{
    partial class Frm_MenberInfoManage
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
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.radio_delete = new System.Windows.Forms.RadioButton();
            this.radio_Normal = new System.Windows.Forms.RadioButton();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.txt_Tele = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_MemberInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Normal = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.radio_delete);
            this.groupBox1.Controls.Add(this.radio_Normal);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_Remark);
            this.groupBox1.Controls.Add(this.txt_Tele);
            this.groupBox1.Controls.Add(this.txt_num);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑会员信息  状态：";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(219, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 18);
            this.lbl_Status.TabIndex = 16;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(412, 245);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(119, 52);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(213, 245);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(119, 52);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Location = new System.Drawing.Point(118, 18);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(51, 22);
            this.radio_female.TabIndex = 13;
            this.radio_female.Text = "女";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Location = new System.Drawing.Point(33, 20);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(51, 22);
            this.radio_male.TabIndex = 12;
            this.radio_male.Text = "男";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // radio_delete
            // 
            this.radio_delete.AutoSize = true;
            this.radio_delete.Location = new System.Drawing.Point(247, 188);
            this.radio_delete.Name = "radio_delete";
            this.radio_delete.Size = new System.Drawing.Size(69, 22);
            this.radio_delete.TabIndex = 11;
            this.radio_delete.Text = "删除";
            this.radio_delete.UseVisualStyleBackColor = true;
            // 
            // radio_Normal
            // 
            this.radio_Normal.AutoSize = true;
            this.radio_Normal.Location = new System.Drawing.Point(159, 186);
            this.radio_Normal.Name = "radio_Normal";
            this.radio_Normal.Size = new System.Drawing.Size(69, 22);
            this.radio_Normal.TabIndex = 10;
            this.radio_Normal.Text = "正常";
            this.radio_Normal.UseVisualStyleBackColor = true;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(471, 67);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(213, 28);
            this.txt_Name.TabIndex = 9;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(471, 186);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(213, 28);
            this.txt_Remark.TabIndex = 8;
            // 
            // txt_Tele
            // 
            this.txt_Tele.Location = new System.Drawing.Point(147, 121);
            this.txt_Tele.Name = "txt_Tele";
            this.txt_Tele.Size = new System.Drawing.Size(213, 28);
            this.txt_Tele.TabIndex = 7;
            this.txt_Tele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tele_KeyPress);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(147, 64);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(213, 28);
            this.txt_num.TabIndex = 6;
            this.txt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "电话：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员卡号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_MemberInfo);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_Normal);
            this.groupBox2.Location = new System.Drawing.Point(22, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会员信息列表：";
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
            this.lv_MemberInfo.Location = new System.Drawing.Point(-10, 62);
            this.lv_MemberInfo.MultiSelect = false;
            this.lv_MemberInfo.Name = "lv_MemberInfo";
            this.lv_MemberInfo.Size = new System.Drawing.Size(744, 300);
            this.lv_MemberInfo.TabIndex = 18;
            this.lv_MemberInfo.UseCompatibleStateImageBehavior = false;
            this.lv_MemberInfo.View = System.Windows.Forms.View.Details;
            this.lv_MemberInfo.SelectedIndexChanged += new System.EventHandler(this.lv_MemberInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "会员姓名";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "会员卡号";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "性别";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "电话";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "备注";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(402, -12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 52);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Normal
            // 
            this.btn_Normal.Location = new System.Drawing.Point(203, -12);
            this.btn_Normal.Name = "btn_Normal";
            this.btn_Normal.Size = new System.Drawing.Size(119, 52);
            this.btn_Normal.TabIndex = 16;
            this.btn_Normal.Text = "设为正常";
            this.btn_Normal.UseVisualStyleBackColor = true;
            this.btn_Normal.Click += new System.EventHandler(this.btn_Normal_Click);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(295, 345);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 18);
            this.lbl_Note.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_male);
            this.panel1.Controls.Add(this.radio_female);
            this.panel1.Location = new System.Drawing.Point(471, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 53);
            this.panel1.TabIndex = 17;
            // 
            // Frm_MenberInfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 793);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_MenberInfoManage";
            this.Text = "会员信息管理";
            this.Load += new System.EventHandler(this.Frm_MenberInfoManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.RadioButton radio_delete;
        private System.Windows.Forms.RadioButton radio_Normal;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.TextBox txt_Tele;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.ListView lv_MemberInfo;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Normal;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel1;
    }
}