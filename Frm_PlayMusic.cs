using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 饮品店点餐收银系统
{
    public partial class Frm_PlayMusic : Form
    {
        int itemid = -1;
        public Frm_PlayMusic()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btn_selectFolder_Click(object sender, EventArgs e)
        {
            string[] strArr = {".mp3", ".mp4", ".wma", ".avi", ".rm", ".rmvb", ".flv", ".mpg", ".mov", ".mkv","FLAC" };
            folderBrowserDialog1.Description = "选择所有文件存放目录";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string sPath = folderBrowserDialog1.SelectedPath;
                DirectoryInfo dir = new DirectoryInfo(sPath);
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo info in files)
                {
                    string str = info.Extension;
                    if (((System.Collections.IList)strArr).Contains(str))
                    {
                        string[] musicdata = new string[2];
                        musicdata[0] = info.Name;
                        musicdata[1] = info.FullName;
                        listView1.Items.Add(new ListViewItem(musicdata));
                    }

               }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                itemid = listView1.SelectedItems[0].Index;
                string path = listView1.SelectedItems[0].SubItems[1].Text;
                axWindowsMediaPlayer1.URL = path;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (itemid == -1)
            {
                MessageBox.Show("请先选择要删除的音视频文件！");

            }
            else
            {
                listView1.Items[itemid].Remove();
                itemid = -1;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(mp3,FLAC,mp4,wav,wmv,mov)|* .mp3; * .mp4; * .FLAC; *.wva; * .mmv; * .wov|all files|* . *";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }
    }
}
