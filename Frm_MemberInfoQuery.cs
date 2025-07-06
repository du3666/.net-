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
    public partial class Frm_MemberInfoQuery : Form
    {
        public Frm_MemberInfoQuery()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            chb_Name.Checked = false;
            chb_Sex.Checked = false;
            chb_Number.Checked = false;
            chb_Telephone.Checked = false;
            lv_MemberInfo.Items.Clear();
            txt_Name.Text = "";
            txt_Number.Text = "";
            txt_Telephone.Text = "";
            cbb_Sex.SelectedIndex = 0;
        }
        protected void DataBind_MemberInfo(string sqlstr)
        {
            DataTable dt = DataWork.DataQuery(sqlstr);
            lv_MemberInfo.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["MemberID"].ToString());
                myitem.SubItems.Add(dr["MemberName"].ToString());
                myitem.SubItems.Add(dr["MemberNumber"].ToString());
                switch (dr["Sex"].ToString())
                {
                    case "1": myitem.SubItems.Add("男"); break;
                    case "2": myitem.SubItems.Add("女"); break;
                    
                    default: break;
                }
                myitem.SubItems.Add(dr["Telephone"].ToString());
                switch (dr["Status"].ToString())
                {
                    case "1": myitem.SubItems.Add("正常"); break;
                    case "2": myitem.SubItems.Add("注销"); break;
                    
                    default: break;
                }



                myitem.SubItems.Add(dr["Remark"].ToString());
                lv_MemberInfo.Items.Add(myitem);

            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlstr = "select * from Member_Info where 1=1 ";
            
            if (chb_Name.Checked && txt_Name.Text.Trim() != "")
            sqlstr += string.Format(" and MemberName like '%{0}%' ", txt_Name.Text);
           
            if (chb_Number.Checked && txt_Number.Text.Trim() != "")
            sqlstr += string.Format(" and MemberNumber like '%{0}%' ", txt_Number.Text);
            
            if (chb_Telephone.Checked && txt_Telephone.Text.Trim() != "")
            sqlstr += string.Format(" and Telephone like '%{0}%' ", txt_Telephone.Text);
           
            if (chb_Sex.Checked && cbb_Sex.SelectedIndex != 0)
                sqlstr += string.Format(" and Sex = {0} ", cbb_Sex.SelectedIndex);

                DataBind_MemberInfo(sqlstr);
            
        }
    }
}
