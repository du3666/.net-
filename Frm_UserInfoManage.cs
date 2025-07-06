using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 饮品店点餐收银系统
{
    
    public partial class Frm_UserInfoManage : Form
    {
        string userid = "";
        public Frm_UserInfoManage()
        {
            InitializeComponent();
        }
        protected void DataBind_UserInfo()
        {
            string sqlstr = "select* from User_Info";
            DataTable dt = DataWork.DataQuery(sqlstr);
            lv_UserInfo.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["UserID"].ToString());
                myitem.SubItems.Add(dr["UserName"].ToString());
                myitem.SubItems.Add(dr["Password"].ToString());
                //if (dr["Sex"].ToString() == "1")
                //{
                //    myitem.SubItems.Add("男");
                //}
                //else
                //{
                //    myitem.SubItems.Add("女");
                //}
                myitem.SubItems.Add(dr["RealName"].ToString());
                switch (dr["UserType"].ToString())
                {
                    case "1":
                        myitem.SubItems.Add("职员");
                        break;
                    case "2":
                        myitem.SubItems.Add("店长");
                        break;
                    default: break;
                }
                switch (dr["Status"].ToString())
                {
                    case "1":
                        myitem.SubItems.Add("启用");
                        break;
                    case "2":
                        myitem.SubItems.Add("禁用");
                        break;
                    default: break;
                }
                lv_UserInfo.Items.Add(myitem);
            }
        }
        protected void ClearTextBox()
        {
            txt_UserName.Text = "";
            txt_Password.Text = "";
            txt_RealName.Text = "";
            cbb_Type.SelectedIndex = 0;
            radio_Use.Checked = false;
            radio_forbidden.Checked = false;
            lbl_Note.Text = "";
            lbl_Status.Text = "添加";
            userid = "";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Frm_UserInfoManage_Load(object sender, EventArgs e)
        {
            DataBind_UserInfo();
            lbl_Status.Text = "添加";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text.Trim();
            string password = txt_Password.Text.Trim();
            string realname = txt_RealName.Text.Trim();
            int status = radio_Use.Checked ? 1 : 2;
            int usertype = cbb_Type.SelectedIndex + 1;
            if (username == "")
            {
                lbl_Note.Text = "会员信息不能为空";
                lbl_Note.ForeColor = Color.Red;
                txt_UserName.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                string sqlstr = string.Format("insert into User_Info values('{0}','{1}','{2}','{3}','{4}')", username,password,realname,usertype,status);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "员工信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_UserInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                string sqlstr = string.Format("update User_Info set UserName='{0}',Password='{1}',RealName='{2}',UserType='{3}',Status='{4}' where UserID='{5}'",username,password,realname,usertype,status,userid);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "员工信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_UserInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }

        private void lv_UserInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_UserInfo.SelectedItems.Count > 0)
            {
                lbl_Status.Text = "修改";
                ListViewItem myitem = lv_UserInfo.SelectedItems[0];
                userid = myitem.SubItems[0].Text;
                txt_UserName.Text = myitem.SubItems[1].Text;
                txt_Password.Text = myitem.SubItems[2].Text;
                txt_RealName.Text = myitem.SubItems[3].Text;
                if (myitem.SubItems[4].Text == "职员")
                {
                    cbb_Type.SelectedIndex = 0;
                }
                else
                {
                    cbb_Type.SelectedIndex = 1;
                }
                
                if (myitem.SubItems[5].Text == "启用")
                {
                    radio_Use.Checked = true;
                    radio_forbidden.Checked = false;
                }
                else
                {
                    radio_Use.Checked = false;
                    radio_forbidden.Checked = true;
                }
               
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            lbl_Status.Text = "添加";
            lbl_Note.Text = "";
            userid = "";
        }

        private void btn_Use_Click(object sender, EventArgs e)
        {
            if (userid == "")
            {
                MessageBox.Show("请先选择要启用的员工信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认要设置选中的员工状态为“启用”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update User_Info set Status=1 where UserID='{0}'", userid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "员工状态成功修改为启用！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_UserInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Forbidden_Click(object sender, EventArgs e)
        {
            if (userid == "")
            {
                MessageBox.Show("请先选择要禁用的员工信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认要设置选中的员工状态为“禁用”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update User_Info set Status=2 where UserID='{0}'", userid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "员工状态成功修改为禁用！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_UserInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (userid == "")
            {
                MessageBox.Show("请先选择要删除的员工信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认要删除选中的员工？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from User_Info  where UserID='{0}'", userid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "员工信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_UserInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            if (userid == "")
            {
                MessageBox.Show("请先选择要重置密码的员工信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认要重制选中员工的密码？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update User_Info set Password='123456' where UserID='{0}'", userid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "员工密码重制成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_UserInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工密码重制失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
