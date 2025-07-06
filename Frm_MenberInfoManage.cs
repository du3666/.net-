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
    public partial class Frm_MenberInfoManage : Form
    {
        string memberid = "";
        public Frm_MenberInfoManage()
        {
            InitializeComponent();
        }
        private void DataBind_MemberInfo()
        {
            string sqlstr = "select* from Member_Info";
            DataTable dt = DataWork.DataQuery(sqlstr);
            lv_MemberInfo.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["MemberID"].ToString());
                myitem.SubItems.Add(dr["MemberName"].ToString());
                myitem.SubItems.Add(dr["MemberNumber"].ToString());
                if (dr["Sex"].ToString()=="1")
                {
                    myitem.SubItems.Add("男");
                }
                else
                {
                    myitem.SubItems.Add("女");
                }
                myitem.SubItems.Add(dr["Telephone"].ToString());
                switch (dr["Status"].ToString())
                {
                    case "1":
                        myitem.SubItems.Add("正常");
                        break;
                    case "2":
                        myitem.SubItems.Add("删除");
                        break;
                    default: break;
                }
                myitem.SubItems.Add(dr["Remark"].ToString());
                lv_MemberInfo.Items.Add(myitem);
            }
        }
        private void Frm_MenberInfoManage_Load(object sender, EventArgs e)
        {
            DataBind_MemberInfo();
            lbl_Status.Text = "添加";
        }
        protected void ClearTextBox()
        {
            txt_Name.Text="";
            txt_num.Text ="";
            radio_male.Checked = false;
            radio_female.Checked = false;
            radio_delete.Checked = false;
            radio_Normal.Checked = false;
            txt_Tele.Text = "";
            txt_Remark.Text = "";
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string membername = txt_Name.Text.Trim();
            string membernumber = txt_num.Text.Trim();
            string telephone = txt_Tele.Text.Trim();
            int status = radio_Normal.Checked ? 1 : 2;
            string remark = txt_Remark.Text.Trim();
            int sex = radio_male.Checked ? 1 : 2;
            if (membername== "")
            {
                lbl_Note.Text = "会员信息不能为空";
                lbl_Note.ForeColor = Color.Red;
                txt_Name.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                string sqlstr = string.Format("insert into Member_Info values('{0}','{1}',{2},'{3}',{4},'{5}')", membername,membernumber,sex,telephone,status,remark);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "会员信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_MemberInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，会员信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                string sqlstr = string.Format("update Member_Info set MemberName='{0}',MemberNumber='{1}',Sex={2},Telephone='{3}',Status={4},Remark='{5}' where MemberID={6}", membername, membernumber, sex, telephone, status, remark,memberid);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "会员信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_MemberInfo();
                    lbl_Status.Text = "添加";
                }
                else
                {
                    lbl_Note.Text = "对不起，会员信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }

        private void lv_MemberInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Status.Text = "修改";
            if (lv_MemberInfo.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_MemberInfo.SelectedItems[0];
                memberid = myitem.SubItems[0].Text;
                txt_Name.Text = myitem.SubItems[1].Text;
                txt_num.Text = myitem.SubItems[2].Text;
                if (myitem.SubItems[3].Text == "男")
                {
                    radio_male.Checked = true;
                    radio_female.Checked = false;
                }
                else
                {
                    radio_male.Checked = false;
                    radio_female.Checked = true;
                }
                txt_Tele.Text= myitem.SubItems[4].Text;
                if (myitem.SubItems[5].Text == "正常")
                {
                    radio_Normal.Checked = true;
                    radio_delete.Checked = false;
                }
                else
                {
                    radio_Normal.Checked = false;
                    radio_delete.Checked = true;
                }
                txt_Remark.Text= myitem.SubItems[6].Text;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (memberid == "")
            {
                MessageBox.Show("请先选择要删除的会员信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认要删除选中的会员？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from Member_Info  where MemberID='{0}'", memberid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "会员信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_MemberInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，会员信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void txt_Tele_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            lbl_Note.Text = "";
            lbl_Status.Text = "添加";
            memberid = "";
        }

        private void btn_Normal_Click(object sender, EventArgs e)
        {
            if (memberid == "")
            {
                MessageBox.Show("请先选择要设置的饮品信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认要修改选中的会员状态为“正常”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Member_Info set Status=1 where MemberID='{0}'", memberid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "会员状态成功修改为正常！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_MemberInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
