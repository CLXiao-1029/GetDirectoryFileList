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

namespace GetDirectoryFileList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void OnButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btn_browse":
                    BrowseDirectory();
                    break;
                case "btn_copyAll":
                    CopyAllPath();
                    break;
                case "btn_create":
                    CreateFile();
                    break;
                default:
                    break;
            }
        }

        void BrowseDirectory()
        {
            LXCustomTools.LXFolderBrowserDialog dialog = new LXCustomTools.LXFolderBrowserDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.DirectoryPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                listBox1.Items.Clear();
                textBox_content.Text = dialog.DirectoryPath;
                string[] files = Directory.GetFiles(textBox_content.Text, "*", SearchOption.AllDirectories);
                listBox1.Items.AddRange(files);
            }
        }

        void CopyAllPath()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string item in listBox1.Items)
            {
                stringBuilder.AppendLine(item);
            }
            Clipboard.SetDataObject(stringBuilder.ToString(),true);
        }

        void CreateFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult dr = saveFileDialog.ShowDialog();
            string filename = saveFileDialog.FileName;
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string item in listBox1.Items)
                {
                    stringBuilder.AppendLine(item);
                }
                StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8);
                sw.Write(stringBuilder);
                sw.Close();
                sw.Dispose();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                List<string> files = new List<string>();
                foreach (string item in listBox1.Items)
                {
                    files.Add(item.Replace(textBox_content.Text, ""));
                }
                listBox1.Items.Clear();
                listBox1.Items.AddRange(files.ToArray());
                listBox1.Refresh();
            }
        }
    }
}
