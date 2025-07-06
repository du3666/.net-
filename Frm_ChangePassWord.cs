using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 饮品店点餐收银系统
{
    public partial class Frm_ChangePassWord : Form
    {
        public Frm_ChangePassWord()
        {
            InitializeComponent();
        }

        private void btn_queren_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("请输入用户名！");
            }
            else if(txt_Password.Text=="")
            {
                MessageBox.Show("请输入密码！");
            }
            else if(txt_Password.Text!=txt_RePassword.Text)
            {
                MessageBox.Show("两次输入的密码不一致!");
            }
            else
            {
                string sqlstr = string.Format("update User_Info set Password='{0}' where UserName='{1}'",txt_Password.Text,txt_Name.Text);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    MessageBox.Show("密码修改成功！");
                }
                else
                {
                    MessageBox.Show("密码修改失败！");
                }
            }
        }
    }
}
