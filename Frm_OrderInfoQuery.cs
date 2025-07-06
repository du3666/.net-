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
    public partial class Frm_OrderInfoQuery : Form
    {
        public Frm_OrderInfoQuery()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lv_OrderQuery.Items.Clear();
            chb_Date.Checked = false;
            chb_Member_Number.Checked = false;
            chb_Name.Checked = false;
            chb_Payway.Checked = false;
            cbb_Drink_Name.SelectedIndex = 0;
            cbb_Payway.SelectedIndex = 0;
        }
        protected void DataBind_OrderInfo(string sqlstr)
        {
            DataTable dt = DataWork.DataQuery(sqlstr);
            lv_OrderQuery.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["OrderID"].ToString());
                myitem.SubItems.Add(dr["MemberNumber"].ToString());
                myitem.SubItems.Add(dr["TeaNames"].ToString());
                myitem.SubItems.Add(dr["TeaAccount"].ToString());
               
                myitem.SubItems.Add(dr["DueMoney"].ToString());
                myitem.SubItems.Add(dr["DiscountRate"].ToString());
                myitem.SubItems.Add(dr["DiscountMoney"].ToString());
                myitem.SubItems.Add(dr["PaidUpMoney"].ToString());
                
                switch (dr["Payway"].ToString())
                {
                    case "1": myitem.SubItems.Add("现金"); break;
                    case "2": myitem.SubItems.Add("银行卡"); break;
                    case "3": myitem.SubItems.Add("支付宝"); break;
                    case "4": myitem.SubItems.Add("微信"); break;
                    default: break;
                }
                myitem.SubItems.Add(dr["OrderDate"].ToString());
                myitem.SubItems.Add(dr["UserName"].ToString());
                lv_OrderQuery.Items.Add(myitem);

            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlstr = "select * from Order_Info where 1=1 ";
            if (chb_Date.Checked) 
                sqlstr += string.Format(" and OrderDate between '{0}' and '{1}' ", dtp_BeginDate.Value, dtp_EndDate.Value);

            if (chb_Payway.Checked && cbb_Payway.SelectedIndex != 0) 
                sqlstr += string.Format(" and Payway = {0} ", cbb_Payway.SelectedIndex);
                if (chb_Member_Number.Checked && txt_Number.Text.Trim() != "")
                sqlstr += string.Format(" and MemberNumber like '%{0}%' ", txt_Number.Text);
            if (chb_Name.Checked && cbb_Drink_Name.SelectedIndex != 0 && chb_Name.Text != "全部") 
                sqlstr += string.Format(" and TeaNames like '%{0}%' ", cbb_Drink_Name.Text);
                DataBind_OrderInfo(sqlstr);

        }
    }
}
