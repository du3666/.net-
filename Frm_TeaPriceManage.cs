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
     public partial class Frm_TeaPriceManage : Form
    {
        private List<TeaPrice> teaPrices = new List<TeaPrice>();

        public Frm_TeaPriceManage()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string teaNum = txt_TeaNum.Text.Trim();
            decimal priceSmall;
            decimal priceMedium;
            decimal priceLarge;
            DateTime beginDate = data_Begin.Value;
            DateTime endDate = data_End.Value;

            // 检查输入有效性
            if (string.IsNullOrEmpty(teaNum) || 
                !decimal.TryParse(txt_price_Small.Text.Trim(), out priceSmall) || priceSmall <= 0 ||
                !decimal.TryParse(txt_Price_Medium.Text.Trim(), out priceMedium) || priceMedium <= 0 ||
                !decimal.TryParse(txt_Price_Large.Text.Trim(), out priceLarge) || priceLarge <= 0 ||
                beginDate >= endDate)
            {
                MessageBox.Show("请确保所有字段已填写且日期有效", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 查找是否已存在该茶品的价格
            TeaPrice existingPrice = teaPrices.Find(t => t.TeaNum == teaNum && t.BeginDate == beginDate);
            if (existingPrice != null)
            {
                // 如果存在，更新已有记录
                existingPrice.PriceSmall = priceSmall;
                existingPrice.PriceMedium = priceMedium;
                existingPrice.PriceLarge = priceLarge;
                existingPrice.EndDate = endDate;

                // 更新数据库记录
                string updateSql = $"UPDATE Tea_Price SET PriceSmall = {priceSmall}, PriceMedium = {priceMedium}, PriceLarge = {priceLarge}, EndDate = '{endDate}' WHERE TeaNum = '{teaNum}' AND BeginDate = '{beginDate}'";
                DataWork.DataExcute(updateSql);
            }
            else
            {
                // 如果不存在，添加新的记录
                teaPrices.Add(new TeaPrice
                {
                    TeaNum = teaNum,
                    PriceSmall = priceSmall,
                    PriceMedium = priceMedium,
                    PriceLarge = priceLarge,
                    BeginDate = beginDate,
                    EndDate = endDate
                });

                // 插入新记录到数据库
                string insertSql = $"INSERT INTO Tea_Price (TeaNum, PriceSmall, PriceMedium, PriceLarge, BeginDate, EndDate) VALUES ('{teaNum}', {priceSmall}, {priceMedium}, {priceLarge}, '{beginDate}', '{endDate}')";
                DataWork.DataExcute(insertSql);
            }

            // 更新 ListView 显示
            LoadTeaPriceList();
            ClearInputFields();
            MessageBox.Show("保存成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的记录", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 获取选中的记录
            ListViewItem selectedItem = listView1.SelectedItems[0];
            string teaNum = selectedItem.SubItems[1].Text;
            DateTime beginDate = DateTime.Parse(selectedItem.SubItems[5].Text);

            // 从数据中删除
            TeaPrice teaPriceToDelete = teaPrices.Find(t => t.TeaNum == teaNum && t.BeginDate == beginDate);
            if (teaPriceToDelete != null)
            {
                teaPrices.Remove(teaPriceToDelete);

                // 从数据库中删除记录
                string deleteSql = $"DELETE FROM Tea_Price WHERE TeaNum = '{teaNum}' AND BeginDate = '{beginDate}'";
                DataWork.DataExcute(deleteSql);

                LoadTeaPriceList();
                MessageBox.Show("删除成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txt_TeaNum.Text = selectedItem.SubItems[1].Text;
                txt_price_Small.Text = selectedItem.SubItems[2].Text;
                txt_Price_Medium.Text = selectedItem.SubItems[3].Text;
                txt_Price_Large.Text = selectedItem.SubItems[4].Text;
                data_Begin.Value = DateTime.Parse(selectedItem.SubItems[5].Text);
                data_End.Value = DateTime.Parse(selectedItem.SubItems[6].Text);
            }
        }

        private void Frm_TeaPriceManage_Load(object sender, EventArgs e)
        {
            LoadTeaPriceList();
        }

        private void LoadTeaPriceList()
        {
            // 清空现有的 ListView 项
            listView1.Items.Clear();

            // 从数据库加载数据
            string selectSql = "SELECT * FROM Tea_Price";
            DataTable dt = DataWork.DataQuery(selectSql);
            teaPrices.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                TeaPrice teaPrice = new TeaPrice
                {
                    TeaNum = dr["TeaNum"].ToString(),
                    PriceSmall = decimal.Parse(dr["PriceSmall"].ToString()),
                    PriceMedium = decimal.Parse(dr["PriceMedium"].ToString()),
                    PriceLarge = decimal.Parse(dr["PriceLarge"].ToString()),
                    BeginDate = DateTime.Parse(dr["BeginDate"].ToString()),
                    EndDate = DateTime.Parse(dr["EndDate"].ToString())
                };
                teaPrices.Add(teaPrice);

                ListViewItem item = new ListViewItem(teaPrice.TeaNum);
                item.SubItems.Add(teaPrice.PriceSmall.ToString("C"));
                item.SubItems.Add(teaPrice.PriceMedium.ToString("C"));
                item.SubItems.Add(teaPrice.PriceLarge.ToString("C"));
                item.SubItems.Add(teaPrice.BeginDate.ToShortDateString());
                item.SubItems.Add(teaPrice.EndDate.ToShortDateString());

                listView1.Items.Add(item);
            }
        }

        private void ClearInputFields()
        {
            // 清空文本框和日期选择器
            txt_TeaNum.Clear();
            txt_price_Small.Clear();
            txt_Price_Medium.Clear();
            txt_Price_Large.Clear();
            data_Begin.Value = DateTime.Now;
            data_End.Value = DateTime.Now;
        }
    }
    public partial class Frm_TeaPriceManage : Form
    {
        public Frm_TeaPriceManage()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //string teaNum = txt_TeaNum.Text.Trim();
            //decimal priceSmall = decimal.TryParse(txt_price_Small.Text.Trim(), out priceSmall) ? priceSmall : 0;
            //decimal priceMedium = decimal.TryParse(txt_Price_Medium.Text.Trim(), out priceMedium) ? priceMedium : 0;
            //decimal priceLarge = decimal.TryParse(txt_Price_Large.Text.Trim(), out priceLarge) ? priceLarge : 0;
            //DateTime beginDate = data_Begin.Value;
            //DateTime endDate = data_End.Value;

            //// 检查输入有效性
            //if (string.IsNullOrEmpty(teaNum) || priceSmall <= 0 || priceMedium <= 0 || priceLarge <= 0 || beginDate >= endDate)
            //{
            //    MessageBox.Show("请确保所有字段已填写且日期有效", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// 查找是否已存在该茶品的价格
            //TeaPrice existingPrice = teaPrices.Find(t => t.TeaNum == teaNum && t.BeginDate == beginDate);
            //if (existingPrice != null)
            //{
            //    // 如果存在，更新已有记录
            //    existingPrice.PriceSmall = priceSmall;
            //    existingPrice.PriceMedium = priceMedium;
            //    existingPrice.PriceLarge = priceLarge;
            //    existingPrice.EndDate = endDate;
            //}
            //else
            //{
            //    // 如果不存在，添加新的记录
            //    teaPrices.Add(new TeaPrice
            //    {
            //        TeaNum = teaNum,
            //        PriceSmall = priceSmall,
            //        PriceMedium = priceMedium,
            //        PriceLarge = priceLarge,
            //        BeginDate = beginDate,
            //        EndDate = endDate
            //    });
            //}

            //// 更新 ListView 显示
            //LoadTeaPriceList();
            //ClearInputFields();
            //MessageBox.Show("保存成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("请选择要删除的记录", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// 获取选中的记录
            //ListViewItem selectedItem = listView1.SelectedItems[0];
            //string teaNum = selectedItem.SubItems[1].Text;
            //DateTime beginDate = DateTime.Parse(selectedItem.SubItems[5].Text);

            //// 从数据中删除
            //TeaPrice teaPriceToDelete = teaPrices.Find(t => t.TeaNum == teaNum && t.BeginDate == beginDate);
            //if (teaPriceToDelete != null)
            //{
            //    teaPrices.Remove(teaPriceToDelete);
            //    LoadTeaPriceList();
            //    MessageBox.Show("删除成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count > 0)
            //{
            //    ListViewItem selectedItem = listView1.SelectedItems[0];
            //    txt_TeaNum.Text = selectedItem.SubItems[1].Text;
            //    txt_price_Small.Text = selectedItem.SubItems[2].Text;
            //    txt_Price_Medium.Text = selectedItem.SubItems[3].Text;
            //    txt_Price_Large.Text = selectedItem.SubItems[4].Text;
            //    data_Begin.Value = DateTime.Parse(selectedItem.SubItems[5].Text);
            //    data_End.Value = DateTime.Parse(selectedItem.SubItems[6].Text);
            //}
        }

        private void Frm_TeaPriceManage_Load(object sender, EventArgs e)
        {
            //LoadTeaPriceList();
        }
        private void LoadTeaPriceList()
        {
            // 清空现有的 ListView 项
            listView1.Items.Clear();

            // 将 teaPrices 数据填充到 ListView
            //foreach (var teaPrice in teaPrices)
            //{
            //    ListViewItem item = new ListViewItem(teaPrice.TeaNum);
            //    item.SubItems.Add(teaPrice.PriceSmall.ToString("C"));
            //    item.SubItems.Add(teaPrice.PriceMedium.ToString("C"));
            //    item.SubItems.Add(teaPrice.PriceLarge.ToString("C"));
            //    item.SubItems.Add(teaPrice.BeginDate.ToShortDateString());
            //    item.SubItems.Add(teaPrice.EndDate.ToShortDateString());

            //    listView1.Items.Add(item);
            //}
        }

        private void ClearInputFields()
        {
            // 清空文本框和日期选择器
            txt_TeaNum.Clear();
            txt_price_Small.Clear();
            txt_Price_Medium.Clear();
            txt_Price_Large.Clear();
            data_Begin.Value = DateTime.Now;
            data_End.Value = DateTime.Now;
        }
    }
}
