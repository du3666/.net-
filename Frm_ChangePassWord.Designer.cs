namespace 饮品店点餐收银系统
{
    partial class Frm_ChangePassWord
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_RePassword = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_queren = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Name.Location = new System.Drawing.Point(272, 81);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(295, 28);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_RePassword
            // 
            this.txt_RePassword.Location = new System.Drawing.Point(272, 232);
            this.txt_RePassword.Name = "txt_RePassword";
            this.txt_RePassword.PasswordChar = '*';
            this.txt_RePassword.Size = new System.Drawing.Size(295, 28);
            this.txt_RePassword.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(272, 159);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(295, 28);
            this.txt_Password.TabIndex = 2;
            // 
            // btn_queren
            // 
            this.btn_queren.Location = new System.Drawing.Point(206, 320);
            this.btn_queren.Name = "btn_queren";
            this.btn_queren.Size = new System.Drawing.Size(117, 52);
            this.btn_queren.TabIndex = 3;
            this.btn_queren.Text = "确认重制";
            this.btn_queren.UseVisualStyleBackColor = true;
            this.btn_queren.Click += new System.EventHandler(this.btn_queren_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(428, 320);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 52);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "清空";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "请输入用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "请输入密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "请再次输入密码：";
            // 
            // Frm_ChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_queren);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_RePassword);
            this.Controls.Add(this.txt_Name);
            this.Name = "Frm_ChangePassWord";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_RePassword;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_queren;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}