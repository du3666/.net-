namespace 饮品店点餐收银系统
{
    partial class Frm_TeaPriceManage
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TeaNum = new System.Windows.Forms.TextBox();
            this.txt_price_Small = new System.Windows.Forms.TextBox();
            this.txt_Price_Medium = new System.Windows.Forms.TextBox();
            this.txt_Price_Large = new System.Windows.Forms.TextBox();
            this.data_Begin = new System.Windows.Forms.DateTimePicker();
            this.data_End = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 233);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(779, 205);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "价格编号";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "饮品编号";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "价格(小)";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "价格(中)";
            this.columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "价格(大)";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "生效日期";
            this.columnHeader6.Width = 122;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "失效日期";
            this.columnHeader7.Width = 395;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "饮品编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "价格(小)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "价格(中)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "价格(大)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "生效日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "失效日期";
            // 
            // txt_TeaNum
            // 
            this.txt_TeaNum.Location = new System.Drawing.Point(186, 34);
            this.txt_TeaNum.Name = "txt_TeaNum";
            this.txt_TeaNum.Size = new System.Drawing.Size(100, 28);
            this.txt_TeaNum.TabIndex = 7;
            // 
            // txt_price_Small
            // 
            this.txt_price_Small.Location = new System.Drawing.Point(186, 89);
            this.txt_price_Small.Name = "txt_price_Small";
            this.txt_price_Small.Size = new System.Drawing.Size(100, 28);
            this.txt_price_Small.TabIndex = 8;
            // 
            // txt_Price_Medium
            // 
            this.txt_Price_Medium.Location = new System.Drawing.Point(517, 34);
            this.txt_Price_Medium.Name = "txt_Price_Medium";
            this.txt_Price_Medium.Size = new System.Drawing.Size(100, 28);
            this.txt_Price_Medium.TabIndex = 10;
            // 
            // txt_Price_Large
            // 
            this.txt_Price_Large.Location = new System.Drawing.Point(517, 78);
            this.txt_Price_Large.Name = "txt_Price_Large";
            this.txt_Price_Large.Size = new System.Drawing.Size(100, 28);
            this.txt_Price_Large.TabIndex = 11;
            // 
            // data_Begin
            // 
            this.data_Begin.Location = new System.Drawing.Point(170, 129);
            this.data_Begin.Name = "data_Begin";
            this.data_Begin.Size = new System.Drawing.Size(170, 28);
            this.data_Begin.TabIndex = 12;
            // 
            // data_End
            // 
            this.data_End.Location = new System.Drawing.Point(517, 118);
            this.data_End.Name = "data_End";
            this.data_End.Size = new System.Drawing.Size(152, 28);
            this.data_End.TabIndex = 13;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(144, 182);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 45);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(478, 182);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(102, 46);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Frm_TeaPriceManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.data_End);
            this.Controls.Add(this.data_Begin);
            this.Controls.Add(this.txt_Price_Large);
            this.Controls.Add(this.txt_Price_Medium);
            this.Controls.Add(this.txt_price_Small);
            this.Controls.Add(this.txt_TeaNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Frm_TeaPriceManage";
            this.Text = "饮品价格管理";
            this.Load += new System.EventHandler(this.Frm_TeaPriceManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TeaNum;
        private System.Windows.Forms.TextBox txt_price_Small;
        private System.Windows.Forms.TextBox txt_Price_Medium;
        private System.Windows.Forms.TextBox txt_Price_Large;
        private System.Windows.Forms.DateTimePicker data_Begin;
        private System.Windows.Forms.DateTimePicker data_End;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
    }
}