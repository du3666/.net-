namespace 饮品店点餐收银系统
{
    partial class Frm_TeaInfoManage
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Operation = new System.Windows.Forms.Label();
            this.ccb_Status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Price_Large = new System.Windows.Forms.TextBox();
            this.txt_Price_Mediun = new System.Windows.Forms.TextBox();
            this.txt_Price_Small = new System.Windows.Forms.TextBox();
            this.txt_TeaName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SelectImage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lv_TeaInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Discontinued = new System.Windows.Forms.Button();
            this.btn_Soldout = new System.Windows.Forms.Button();
            this.btn_OnSale = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.lbl_Operation);
            this.groupBox1.Controls.Add(this.ccb_Status);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Price_Large);
            this.groupBox1.Controls.Add(this.txt_Price_Mediun);
            this.groupBox1.Controls.Add(this.txt_Price_Small);
            this.groupBox1.Controls.Add(this.txt_TeaName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑饮品信息    当前操作：";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(215, 290);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(96, 44);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "重制";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(55, 290);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(96, 44);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Operation
            // 
            this.lbl_Operation.AutoSize = true;
            this.lbl_Operation.Location = new System.Drawing.Point(261, 0);
            this.lbl_Operation.Name = "lbl_Operation";
            this.lbl_Operation.Size = new System.Drawing.Size(44, 18);
            this.lbl_Operation.TabIndex = 13;
            this.lbl_Operation.Text = "添加\r\n";
            // 
            // ccb_Status
            // 
            this.ccb_Status.FormattingEnabled = true;
            this.ccb_Status.Items.AddRange(new object[] {
            "在售",
            "售完",
            "停售"});
            this.ccb_Status.Location = new System.Drawing.Point(116, 243);
            this.ccb_Status.Name = "ccb_Status";
            this.ccb_Status.Size = new System.Drawing.Size(218, 26);
            this.ccb_Status.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "（大份）";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "（中份）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "（正常/小份）";
            // 
            // txt_Price_Large
            // 
            this.txt_Price_Large.Location = new System.Drawing.Point(116, 189);
            this.txt_Price_Large.Name = "txt_Price_Large";
            this.txt_Price_Large.Size = new System.Drawing.Size(109, 28);
            this.txt_Price_Large.TabIndex = 7;
            this.txt_Price_Large.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_Large_KeyPress);
            // 
            // txt_Price_Mediun
            // 
            this.txt_Price_Mediun.Location = new System.Drawing.Point(116, 144);
            this.txt_Price_Mediun.Name = "txt_Price_Mediun";
            this.txt_Price_Mediun.Size = new System.Drawing.Size(109, 28);
            this.txt_Price_Mediun.TabIndex = 6;
            this.txt_Price_Mediun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_Mediun_KeyPress);
            // 
            // txt_Price_Small
            // 
            this.txt_Price_Small.Location = new System.Drawing.Point(116, 89);
            this.txt_Price_Small.Name = "txt_Price_Small";
            this.txt_Price_Small.Size = new System.Drawing.Size(109, 28);
            this.txt_Price_Small.TabIndex = 5;
            this.txt_Price_Small.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_Small_KeyPress);
            // 
            // txt_TeaName
            // 
            this.txt_TeaName.Location = new System.Drawing.Point(116, 44);
            this.txt_TeaName.Name = "txt_TeaName";
            this.txt_TeaName.Size = new System.Drawing.Size(218, 28);
            this.txt_TeaName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "饮品价格：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "饮品名称：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.btn_SelectImage);
            this.groupBox3.Location = new System.Drawing.Point(414, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 290);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "饮品图片";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 167);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SelectImage
            // 
            this.btn_SelectImage.Location = new System.Drawing.Point(15, 32);
            this.btn_SelectImage.Name = "btn_SelectImage";
            this.btn_SelectImage.Size = new System.Drawing.Size(96, 44);
            this.btn_SelectImage.TabIndex = 16;
            this.btn_SelectImage.Text = "选择图片";
            this.btn_SelectImage.UseVisualStyleBackColor = true;
            this.btn_SelectImage.Click += new System.EventHandler(this.btn_SelectImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Lv_TeaInfo);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Discontinued);
            this.groupBox2.Controls.Add(this.btn_Soldout);
            this.groupBox2.Controls.Add(this.btn_OnSale);
            this.groupBox2.Location = new System.Drawing.Point(27, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "饮品信息列表";
            // 
            // Lv_TeaInfo
            // 
            this.Lv_TeaInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9});
            this.Lv_TeaInfo.FullRowSelect = true;
            this.Lv_TeaInfo.GridLines = true;
            this.Lv_TeaInfo.HideSelection = false;
            this.Lv_TeaInfo.Location = new System.Drawing.Point(6, 50);
            this.Lv_TeaInfo.MultiSelect = false;
            this.Lv_TeaInfo.Name = "Lv_TeaInfo";
            this.Lv_TeaInfo.Size = new System.Drawing.Size(781, 336);
            this.Lv_TeaInfo.TabIndex = 20;
            this.Lv_TeaInfo.UseCompatibleStateImageBehavior = false;
            this.Lv_TeaInfo.View = System.Windows.Forms.View.Details;
            this.Lv_TeaInfo.SelectedIndexChanged += new System.EventHandler(this.Lv_TeaInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "饮品名称";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "价格（小）";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "价格（中）";
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "价格（大）";
            this.columnHeader5.Width = 102;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "状态";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "图片地址";
            this.columnHeader9.Width = 208;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(530, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(96, 44);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Discontinued
            // 
            this.btn_Discontinued.Location = new System.Drawing.Point(399, 0);
            this.btn_Discontinued.Name = "btn_Discontinued";
            this.btn_Discontinued.Size = new System.Drawing.Size(96, 44);
            this.btn_Discontinued.TabIndex = 18;
            this.btn_Discontinued.Text = "停售";
            this.btn_Discontinued.UseVisualStyleBackColor = true;
            this.btn_Discontinued.Click += new System.EventHandler(this.btn_Discontinued_Click);
            // 
            // btn_Soldout
            // 
            this.btn_Soldout.Location = new System.Drawing.Point(263, 0);
            this.btn_Soldout.Name = "btn_Soldout";
            this.btn_Soldout.Size = new System.Drawing.Size(96, 44);
            this.btn_Soldout.TabIndex = 17;
            this.btn_Soldout.Text = "售完";
            this.btn_Soldout.UseVisualStyleBackColor = true;
            this.btn_Soldout.Click += new System.EventHandler(this.btn_Soldout_Click);
            // 
            // btn_OnSale
            // 
            this.btn_OnSale.Location = new System.Drawing.Point(129, 0);
            this.btn_OnSale.Name = "btn_OnSale";
            this.btn_OnSale.Size = new System.Drawing.Size(96, 44);
            this.btn_OnSale.TabIndex = 16;
            this.btn_OnSale.Text = "在售";
            this.btn_OnSale.UseVisualStyleBackColor = true;
            this.btn_OnSale.Click += new System.EventHandler(this.btn_OnSale_Click);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(64, 377);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 18);
            this.lbl_Note.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_TeaInfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 803);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_TeaInfoManage";
            this.Text = "饮品信息管理";
            this.Load += new System.EventHandler(this.Frm_TeaInfoManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Price_Large;
        private System.Windows.Forms.TextBox txt_Price_Mediun;
        private System.Windows.Forms.TextBox txt_Price_Small;
        private System.Windows.Forms.TextBox txt_TeaName;
        private System.Windows.Forms.Label lbl_Operation;
        private System.Windows.Forms.ComboBox ccb_Status;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_SelectImage;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Discontinued;
        private System.Windows.Forms.Button btn_Soldout;
        private System.Windows.Forms.Button btn_OnSale;
        private System.Windows.Forms.ListView Lv_TeaInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}