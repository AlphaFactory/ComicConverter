using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ComicConverter
{
    public partial class Main : Form
    {
        public Boolean canAccess = true;

        public Main()
        {
            InitializeComponent();
            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            String[] filenames = openFileDialog.FileNames;
            foreach (String filename in filenames)
            {
                int added = filelistview.Rows.Add();
                String title;
                filelistview.Rows[added].Cells[0].Value = false;
                filelistview.Rows[added].Cells[1].Value = title = filename.Substring(filename.LastIndexOf("\\") + 1);
                filelistview.Rows[added].Cells[2].Value = title.Substring(0, title.LastIndexOf("."));
                filelistview.Rows[added].Cells[3].Value = System.IO.Directory.GetParent(filename).Name;
                filelistview.Rows[added].Cells[4].Value = filename;
            }
        }

        private void openFiles_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "ZIP Files|*.zip;*.ZIP;";
            openFileDialog.ShowDialog();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            int count = filelistview.RowCount;
            for (int i = 0; i < count; i++)
            {
                filelistview.Rows[i].Cells[0].Value = true;
            }
        }

        private void unselect_Click(object sender, EventArgs e)
        {
            int count = filelistview.RowCount;
            for (int i = 0; i < count; i++)
            {
                filelistview.Rows[i].Cells[0].Value = false;
            }
        }

        private void deleteSelectedFiles_Click(object sender, EventArgs e)
        {
            int count = filelistview.RowCount;
            for (int i = 0; i < count; i++)
            {
                if ((bool)filelistview.Rows[i].Cells[0].Value)
                {
                    filelistview.Rows.Remove(filelistview.Rows[i]);
                    i--;
                    count--;
                }
            }
        }

        private void startConvert_Click(object sender, EventArgs e)
        {
            Thread ProcessEpubThread = new Thread(new ThreadStart(processEpubFunction));
            ProcessEpubThread.Start();
        }


        public void processEpubFunction()
        {
            Properties.Settings setting = new Properties.Settings();

            Process process = new Process(this, setting.convDirectory);
            Process.setProgressBar1_Delegate spba = new Process.setProgressBar1_Delegate(Process.setProgressBar1);
            Process.setProgressBar2_Delegate spba2 = new Process.setProgressBar2_Delegate(Process.setProgressBar2);
            Process.setProgressBar3_Delegate spba3 = new Process.setProgressBar3_Delegate(Process.setProgressBar3);
            Process.setProgressBar4_Delegate spba4 = new Process.setProgressBar4_Delegate(Process.setProgressBar4);
            Process.setProgressBar5_Delegate spba5 = new Process.setProgressBar5_Delegate(Process.setProgressBar5);
            this.Invoke(spba, 0, 0);
            this.Invoke(spba2, 0, 0);
            this.Invoke(spba3, 0, 0);
            this.Invoke(spba4, 0, 0);
            this.Invoke(spba5, 0, 0);

            UIDisable_Delegate uidd = new UIDisable_Delegate(UIDisable);
            UIEnable_Delegate uied = new UIEnable_Delegate(UIEnable);

            this.Invoke(uidd);
            int count = filelistview.RowCount;
            canAccess = true;
            for (int i = 0; i < count; i++)
            {
                if (!canAccess)
                {
                    this.Invoke(spba, 0, 0);
                    this.Invoke(spba2, 0, 0);
                    this.Invoke(spba3, 0, 0);
                    this.Invoke(spba4, 0, 0);
                    this.Invoke(spba5, 0, 0);
                    break;
                }
                this.Invoke(spba, i, count);
                String cbzAddress = (String)filelistview.Rows[i].Cells[4].Value;
                process.DoProcessEpub(cbzAddress, (String)filelistview.Rows[i].Cells[2].Value, (String)filelistview.Rows[i].Cells[3].Value);
            }
            this.Invoke(uied);
        }

        public delegate void UIDisable_Delegate();
        public delegate void UIEnable_Delegate();

        public void UIDisable()
        {
            filelistview.Enabled =
            openFiles.Enabled =
            buttonSelectAll.Enabled =
            unselect.Enabled =
            deleteSelectedFiles.Enabled =
            startConvert.Enabled =
            false;


            startConvert.Text = "변환 중";
        }

        public void UIEnable()
        {
            filelistview.Enabled =
            openFiles.Enabled =
            buttonSelectAll.Enabled =
            unselect.Enabled =
            deleteSelectedFiles.Enabled =
            startConvert.Enabled =
            true;

            startConvert.Text = "변환 시작";
        }
        private void comicConverterByAlphaFactory정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.ProgramInfo, "Comic Converter 정보");
        }

        private void 업데이트로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.UpdateLog, "업데이트 로그");
        }


        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string filename in filePaths)
                {
                    if (File.Exists(filename) && filename.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
                    {
                        int added = filelistview.Rows.Add();
                        String title;
                        filelistview.Rows[added].Cells[0].Value = false;
                        filelistview.Rows[added].Cells[1].Value = title = filename.Substring(filename.LastIndexOf("\\") + 1);
                        filelistview.Rows[added].Cells[2].Value = title.Substring(0, title.LastIndexOf("."));
                        filelistview.Rows[added].Cells[3].Value = System.IO.Directory.GetParent(filename).Name;
                        filelistview.Rows[added].Cells[4].Value = filename;
                    }
                }
            }
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            System.Diagnostics.Process.Start("explorer.exe", setting.convDirectory);
        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }
    }
}
