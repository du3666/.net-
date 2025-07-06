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
    public partial class Frm_BusinessChart : Form
    {
        public Frm_BusinessChart()
        {
            InitializeComponent();
        }
        protected void DataBind_OrderInfo(string sqlstr)
        {
            DataTable dt = DataWork.DataQuery(sqlstr);
            double[] business = new double[dt.Rows.Count];
            string[] date = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            { business[i] = double.Parse(dt.Rows[i]["business"].ToString()); 
              date[i] = dt.Rows[i]["date"].ToString(); }
            
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false; 
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            
            chart1.ChartAreas[0].AxisX.Title = "日期";
            chart1.ChartAreas[0].AxisY.Title = "营业额";
            
            chart1.Series[0].Points.DataBindXY(date, business);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlstr = "select sum(PaidupMoney) as business,convert(varchar, OrderDate, 111) as date from Order_Info where 1 = 1 ";
if (chb_OrderDate.Checked)  
                sqlstr += string.Format(" and OrderDate between '{0}' and '{1}' ", dtp_BeginDate.Value, dtp_EndDate.Value);
            if (chb_Payway.Checked && cbb_PayWay.SelectedIndex != 0) 
                sqlstr += string.Format(" and Payway = {0} ", cbb_PayWay.SelectedIndex);
            if (chb_User.Checked && cbb_User.SelectedIndex != 0 && cbb_User.Text != "全部")    
                sqlstr += string.Format(" and UserName like '%{0}%' ", cbb_User.Text);
                if (chb_Tea.Checked && cbb_Tea.SelectedIndex != 0 && cbb_Tea.Text != "全部")
                sqlstr += string.Format(" and TeaNames like '%{0}%' ", cbb_Tea.Text);
                    sqlstr += " Group by convert(varchar,OrderDate,111) order by convert(varchar,OrderDate,111)"; 
            DataBind_OrderInfo(sqlstr);

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            chb_OrderDate.Checked = false;
            chb_Payway.Checked = false;
            chb_Tea.Checked = false;
            chb_User.Checked = false;
            cbb_PayWay.SelectedIndex = 0;
            cbb_Tea.SelectedIndex = 0;
            cbb_User.SelectedIndex = 0;
            chart1.Series.Clear();
        }
    }
}
