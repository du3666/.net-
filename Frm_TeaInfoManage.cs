using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 饮品店点餐收银系统
{
    public partial class Frm_TeaInfoManage : Form
    {
        string teaid;
        public Frm_TeaInfoManage()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        protected void DataBind_TeaInfo()
        {
            string sqlstr = "select* from Tea_Info";
            DataTable dt = DataWork.DataQuery(sqlstr);
            Lv_TeaInfo.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["TeaID"].ToString());
                myitem.SubItems.Add(dr["TeaName"].ToString());
                myitem.SubItems.Add(dr["Price_Small"].ToString());
                myitem.SubItems.Add(dr["Price_Medium"].ToString());
                myitem.SubItems.Add(dr["Price_Large"].ToString());
                switch (dr["Status"].ToString())
                {
                    case "1":myitem.SubItems.Add("在售");
                        break;
                    case "2":
                        myitem.SubItems.Add("售完");
                        break;
                    case "3":
                        myitem.SubItems.Add("停售");
                        break;
                    default:  break;
                }
                myitem.SubItems.Add(dr["TeaImage"].ToString());
                Lv_TeaInfo.Items.Add(myitem);
            }
        }
        private void Frm_TeaInfoManage_Load(object sender, EventArgs e)
        {
            DataBind_TeaInfo();
            lbl_Operation.Text = "添加";
        }

        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        protected void ClearTextBox()
        {
            txt_TeaName.Text = "";
            txt_Price_Large .Text= "";
            txt_Price_Small .Text= "";
            txt_Price_Mediun.Text = "";
            ccb_Status.SelectedIndex = 0;
            lbl_Note.Text = "";
            lbl_Operation.Text = "添加";
            pictureBox1.ImageLocation = "";
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string teaName = txt_TeaName.Text.Trim();
            string teaImage = pictureBox1.ImageLocation;
            string priceSmall = txt_Price_Small.Text.Trim();
            string priceMedium = txt_Price_Mediun.Text.Trim();
            string priceLarge = txt_Price_Large.Text.Trim();
            int status = ccb_Status.SelectedIndex + 1;
            if (teaName == "")
            {
                lbl_Note.Text = "饮品名称不能为空";
                lbl_Note.ForeColor = Color.Red;
                txt_TeaName.Focus();
            }
            else if (lbl_Operation.Text == "添加")
            {
                string sqlstr = string.Format("insert into Tea_Info values('{0}','{1}',{2},{3},{4},{5})", teaName, teaImage, priceSmall, priceMedium, priceLarge, status);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "饮品信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_TeaInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，饮品信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else{
                string sqlstr = string.Format("update Tea_Info set TeaName='{0}',TeaImage='{1}',Price_Small={2},Price_Medium={3},Price_Large={4},Status={5} where TeaID={6}", teaName, teaImage, priceSmall, priceMedium, priceLarge, status,teaid);
                int i = DataWork.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "饮品信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_TeaInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，饮品信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }

        private void Lv_TeaInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lv_TeaInfo.SelectedItems.Count > 0)
            {
                ListViewItem myitem = Lv_TeaInfo.SelectedItems[0];
                teaid = myitem.SubItems[0].Text;
                txt_TeaName.Text = myitem.SubItems[1].Text;
                txt_Price_Small.Text= myitem.SubItems[2].Text;
                txt_Price_Mediun.Text= myitem.SubItems[3].Text;
                txt_Price_Large.Text= myitem.SubItems[4].Text;
                switch (myitem.SubItems[5].Text)
                {
                    case "在售":ccb_Status.SelectedIndex = 0;break;
                    case "售完": ccb_Status.SelectedIndex = 1; break;
                    case "停售": ccb_Status.SelectedIndex = 2; break;
                    default: ccb_Status.SelectedIndex = 0; break;
                }
                pictureBox1.ImageLocation = myitem.SubItems[6].Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                lbl_Operation.Text = "修改";
            }
        }

        private void btn_OnSale_Click(object sender, EventArgs e)
        {
            if (teaid == "")
            {
                MessageBox.Show("请先选择要设置的饮品信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认要设置选中的饮品状态为“在售”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Tea_Info set Status=1 where TeaID='{0}'", teaid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "饮品状态成功修改为在售！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_TeaInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            lbl_Operation.Text = "添加";
            lbl_Note.Text = "";
            teaid = "";
        }

        private void txt_Price_Small_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void txt_Price_Mediun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void txt_Price_Large_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void btn_Soldout_Click(object sender, EventArgs e)
        {
            if (teaid == "")
            {
                MessageBox.Show("请先选择要设置的饮品信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认要设置选中的饮品状态为“售完”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Tea_Info set Status=2 where TeaID='{0}'", teaid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "饮品状态成功修改为售完！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_TeaInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Discontinued_Click(object sender, EventArgs e)
        {
            if (teaid == "")
            {
                MessageBox.Show("请先选择要设置的饮品信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认要设置选中的饮品状态为“停售”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Tea_Info set Status=3 where TeaID='{0}'", teaid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "饮品状态成功修改为售完！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_TeaInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (teaid == "")
            {
                MessageBox.Show("请先选择要删除的饮品信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认要删除选中的饮品？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from Tea_Info  where TeaID='{0}'", teaid);
                    int i = DataWork.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "饮品信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_TeaInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
