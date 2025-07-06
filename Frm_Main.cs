using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace 饮品店点餐收银系统
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Label2.Text = ConfigurationManager.AppSettings["RealName"];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }

        private void btn_TeaInfoManage_Click(object sender, EventArgs e)
        {
            Frm_TeaInfoManage frm = new Frm_TeaInfoManage();
            frm.Show();
        }

        private void btn_MemberInfo_Click(object sender, EventArgs e)
        {
            Frm_MenberInfoManage frm = new Frm_MenberInfoManage();
            frm.Show();
        }

        private void btn_Orderonly_Click(object sender, EventArgs e)
        {
            Frm_Order frm = new Frm_Order();
            frm.Show();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Frm_Order frm = new Frm_Order();
            frm.Show();
        }

        private void btn_PlayMusic_Click(object sender, EventArgs e)
        {
            Frm_PlayMusic frm = new Frm_PlayMusic();
            frm.Show();
        }

        private void menu_TeaInfoManag_Click(object sender, EventArgs e)
        {
            Frm_TeaInfoManage frm = new Frm_TeaInfoManage();
            frm.Show();
        }

        private void menu_TeaPriceManage_Click(object sender, EventArgs e)
        {
            Frm_TeaPriceManage frm = new Frm_TeaPriceManage();
            frm.Show();
        }

        private void menu_MemberInfoManage_Click(object sender, EventArgs e)
        {
            Frm_MenberInfoManage frm = new Frm_MenberInfoManage();
            frm.Show();
        }

        private void menu_UserInfoManage_Click(object sender, EventArgs e)
        {
            Frm_UserInfoManage frm = new Frm_UserInfoManage();
            frm.Show();
        }

        private void menu_ChangePassWord_Click(object sender, EventArgs e)
        {
            Frm_ChangePassWord frm = new Frm_ChangePassWord();
            frm.Show();
        }

        private void menu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Order_Click(object sender, EventArgs e)
        {
            Frm_Order frm = new Frm_Order();
            frm.Show();
        }

        private void menu_PlayMusic_Click(object sender, EventArgs e)
        {
            Frm_PlayMusic frm = new Frm_PlayMusic();
            frm.Show();
        }

        private void menu_TeaInfoQuery_Click(object sender, EventArgs e)
        {
            Frm_TeaInfoQuery frm = new Frm_TeaInfoQuery();
            frm.Show();
        }

        private void menu_MemberInfoQuery_Click(object sender, EventArgs e)
        {
            Frm_MemberInfoQuery frm = new Frm_MemberInfoQuery();
            frm.Show();
        }

        private void menu_OrderInfoQuery_Click(object sender, EventArgs e)
        {
            Frm_OrderInfoQuery frm = new Frm_OrderInfoQuery();
            frm.Show();
        }

        private void menu_BusinessChart_Click(object sender, EventArgs e)
        {
            Frm_BusinessChart frm = new Frm_BusinessChart();
            frm.Show();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认要退出吗", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
