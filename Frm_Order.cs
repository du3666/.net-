using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 饮品店点餐收银系统
{
    public partial class Frm_Order : Form
    {
        string teaid = "";
        int selectitemindex = -1;
        public Frm_Order()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        protected void DataBind_OrderInfo()
        {
            String sqlstr = "select* from Tea_Info where Status=1";
            DataTable dt = DataWork.DataQuery(sqlstr);
            imageList1.Images.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                imageList1.Images.Add(Image.FromFile(dr["TeaImage"].ToString()));
            }
            lv_TeaInfo.Items.Clear();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string title = dt.Rows[i]["TeaName"].ToString() + "\n";
                title += "小份" + double.Parse(dt.Rows[i]["Price_Small"].ToString()).ToString("C") + "\n";
                title += "中份" + double.Parse(dt.Rows[i]["Price_Medium"].ToString()).ToString("C") + "\n";
                title += "大份" + double.Parse(dt.Rows[i]["Price_Large"].ToString()).ToString("C") + "\n";
                ListViewItem myitem = new ListViewItem(title);
                myitem.SubItems.Add(dt.Rows[i]["TeaID"].ToString());
                myitem.ImageIndex = i;
                lv_TeaInfo.Items.Add(myitem);
            }
        }
        private void Frm_Order_Load(object sender, EventArgs e)
        {
            DataBind_OrderInfo();
            txt_Quantity.Text = "1";
        }

        private void lv_TeaInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_TeaInfo.SelectedIndices.Count > 0)
            {
                teaid = lv_TeaInfo.SelectedItems[0].SubItems[1].Text;
                string sqlstr = string.Format("select* from Tea_Info where Status=1 and teaid={0}",teaid);
                DataTable dt = DataWork.DataQuery(sqlstr);
                if (dt.Rows.Count > 0)
                {
                    lbl_TeaName.Text = dt.Rows[0]["TeaName"].ToString();
                    pictureBox1.ImageLocation = dt.Rows[0]["TeaImage"].ToString();
                    lbl_Price_Small.Text = double.Parse(dt.Rows[0]["Price_Small"].ToString()).ToString("f2");
                    lbl_Price_Medium.Text = double.Parse(dt.Rows[0]["Price_Medium"].ToString()).ToString("f2");
                    lbl_Price_Large.Text = double.Parse(dt.Rows[0]["Price_Large"].ToString()).ToString("f2");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectitemindex == -1)
            {
                MessageBox.Show("请先选择要增加份数的订单!");
            }
            else
            {
                int quality = int.Parse(lv_OrderInfo.Items[selectitemindex].SubItems[4].Text);
                lv_OrderInfo.Items[selectitemindex].SubItems[4].Text = (quality + 1).ToString();
                updaOrderInfoAcount();
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txt_Quantity.Text);
            txt_Quantity.Text = (quantity + 1).ToString();

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txt_Quantity.Text);
            if (quantity > 1)
            {
                txt_Quantity.Text = (quantity - 1).ToString();
            }
            else
            {
                txt_Quantity.Text = "1";
            }
        }
        protected void updaOrderInfoAcount()
        {
            double duemoney = 0;
            foreach(ListViewItem item in lv_OrderInfo.Items)
            {
                int quantity = int.Parse(item.SubItems[4].Text);
                double unitprice = double.Parse(item.SubItems[3].Text);
                duemoney += quantity * unitprice;
            }
            txt_DueMoney.Text = duemoney.ToString();
            txt_DiscountRate_Leave(null, null);
        }
        protected void txt_DiscountRate_Leave(object sender,EventArgs e)
        {
            double duemoney = double.Parse(txt_DueMoney.Text);
            double discountrate = double.Parse(txt_DiscountRate.Value.ToString());
            double discountmoney = duemoney * (discountrate / 100.00);
            double pickupmoney = duemoney - discountmoney;
            txt_DiscountMoney.Text = discountmoney.ToString();
            txt_PaidUpMoney.Text = pickupmoney.ToString();
        }
        private void btn_AppendtoOrder_Click(object sender, EventArgs e)
        {
            if (teaid == "")
            {
                MessageBox.Show("请先选择要下单的饮品！");
            }
            else
            {
                string[] data = new string[6];
                data[0] = teaid;
                data[1] = lbl_TeaName.Text;
                string size = "";
                double unitprice = 0;
                if (rb_Small.Checked == true)
                {
                    size = "小份";
                    unitprice = double.Parse(lbl_Price_Small.Text);
                }
                else if (rb_Medium.Checked == true)
                    {
                    size = "中份";
                    unitprice = double.Parse(lbl_Price_Medium.Text);
                }
                else if (rb_Large.Checked == true)
                {
                    size = "大份";
                    unitprice = double.Parse(lbl_Price_Large.Text);
                }
                data[2] = size.ToString();
                data[3] = unitprice.ToString();
                data[4] = txt_Quantity.Text;
                data[5] = txt_Remark1.Text;
                ListViewItem orderitem = new ListViewItem(data);
                lv_OrderInfo.Items.Add(orderitem);
                updaOrderInfoAcount();
                txt_Remark1.Text = "";
                txt_Quantity.Text = "1";
            }
        }

        private void lv_OrderInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_OrderInfo.SelectedIndices.Count > 0)
            {
                selectitemindex = lv_OrderInfo.SelectedItems[0].Index;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectitemindex == -1)
            {
                MessageBox.Show("请先选择要减少份数的订单项！");

            }
            else
            {
                int quality = int.Parse(lv_OrderInfo.Items[selectitemindex].SubItems[4].Text);
                if (quality > 1)
                {
                    lv_OrderInfo.Items[selectitemindex].SubItems[4].Text = (quality - 1).ToString();
                    updaOrderInfoAcount();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectitemindex == -1)
            {
                MessageBox.Show("请先选择要移除的订单项！");

            }
            else
            {
                lv_OrderInfo.Items[selectitemindex].Remove();
                selectitemindex = -1;
                updaOrderInfoAcount();
            }
        }
        protected void ClearTextBox()
        {
            pictureBox1.ImageLocation = "";
            lbl_TeaName.Text = "";
            teaid = "";
            rb_Small.Checked = true;
            lbl_Price_Large.Text = "0";
            lbl_Price_Medium.Text = "0";
            lbl_Price_Small.Text = "0";
            txt_Quantity.Text = "1";
            txt_MemberNumber.Text = "1";
            lv_OrderInfo.Items.Clear();
            txt_DueMoney.Text = "0";
            txt_DiscountRate.Text = "0";
            txt_DiscountMoney.Text = "0";
            txt_PaidUpMoney.Text = "0";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int payway = 0;
            if (rb_Payway.Checked)
            {
                payway = 1;
            }
            else if (rb_Payway2.Checked) { payway = 2; }
            else if (rb_Payway3.Checked) { payway = 3; }
            else if (rb_Payway4.Checked) { payway = 4; }
            string username = ConfigurationManager.AppSettings["UserName"];
            int status = 1;
            string teanames = "";
            int teaacount = 0;
            foreach(ListViewItem item in lv_OrderInfo.Items)
            {
                teanames += item.SubItems[1].Text + ",";
                teaacount += int.Parse(item.SubItems[4].Text);
            }
            String sqlstr1 = "insert into Order_Info(TeaNames,TeaAccount,MemberNumber,DueMoney,DiscountRate,DiscountMoney,PaidUpMoney,Payway,OrderDate,UserName,Status,Remark)";
            sqlstr1 += string.Format(" values('{0}',{1},'{2}',{3},{4},{5},{6},{7},'{8}','{9}',{10},'{11}');",teanames,teaacount,txt_MemberNumber.Text,txt_DueMoney.Text,txt_DiscountRate.Value.ToString(),txt_DiscountMoney.Text,txt_PaidUpMoney.Text,payway,DateTime.Now.ToString(),username,status,txt_Remark2.Text);
            sqlstr1 += "SELECT @@IDENTITY";
            int orderid = DataWork.ExecuteScalar(sqlstr1);
            int i = 0;
            foreach (ListViewItem item in lv_OrderInfo.Items)
            {
                int size = 0;
                switch (item.SubItems[2].Text)
                {
                    case "小份": size = 1; break;
                    case "中份": size = 2; break;
                    case "大份": size = 3; break;
                }
                string sqlstr2 = "insert into Order_Items(OrderID,TeaID,Size,UnitPrice,Account,Remark)";
                sqlstr2 += string.Format(" values({0},{1},{2},{3},{4},'{5}')", orderid, item.SubItems[0].Text, size, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text);
                i += DataWork.DataExcute(sqlstr2);
            }
                if (orderid != 0 && i == lv_OrderInfo.Items.Count)
                {
                    MessageBox.Show("付款成功，谢谢惠顾! ");
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("订单保存失败，请联系店家！");
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lv_OrderInfo.Items.Clear();
            txt_DueMoney.Text = "0";
            txt_MemberNumber.Text = "";
            txt_DiscountRate.Text = "0";
            txt_PaidUpMoney.Text = "0";
        }

        private void txt_DiscountRate_Leave_1(object sender, EventArgs e)
        {
            double rate = int.Parse (txt_DiscountRate.Value.ToString())/100.0;
            int money = int.Parse(txt_DueMoney.Text);
            txt_DiscountMoney.Text = (money * rate).ToString();
            txt_PaidUpMoney.Text = (money - money * rate).ToString();

        }
    }
}
