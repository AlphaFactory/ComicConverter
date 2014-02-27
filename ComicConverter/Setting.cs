using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicConverter
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();

            if (Properties.Settings.Default.convDirectory.Length == 0)
            {
                Properties.Settings temp = new Properties.Settings();
                temp.convDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                temp.Save();
            }

            Properties.Settings settings = new Properties.Settings();
            outputAddressBox.Text = settings.convDirectory;
            if (settings.direction.Equals("ltr"))
                isLTR.Checked = true;
            else
                isRTL.Checked = true;

            if (settings.forApple)
            {
                forceResizing.Enabled = true;
                forApple.Checked = true;
            }
            else
            {
                forceResizing.Enabled = false;
                forGoogle.Checked = true;
            }

            forceResizing.Checked = settings.forceResizing;

            if (settings.imagetype.Equals("jpeg"))
                toJPG.Checked = true;
            else if (settings.imagetype.Equals("png"))
                toPNG.Checked = true;
            else
                toGIF.Checked = true;

            quality.Value = settings.quality;
            doSplitLandscape.Checked = settings.dosplitLandscape;
            doSplitCover.Checked = settings.dosplitCover;
            resizeWidth.Value = settings.userWidth;
            resizeHeight.Value = settings.userHeight;

            string[] resizeTypeData = { "가운데 맞춤(기본)", "가로 고정", "세로 고정", "종횡비 무시", "리사이징 하지 않음" };
            resizeType.Items.AddRange(resizeTypeData);
            resizeType.SelectedIndex = settings.resizeType;
            switch (resizeType.SelectedIndex)
            {
                case 0:
                case 3:
                    resizeWidth.Enabled = true;
                    resizeHeight.Enabled = true;
                    break;
                case 1:
                    resizeWidth.Enabled = true;
                    resizeHeight.Enabled = false;
                    break;
                case 2:
                    resizeWidth.Enabled = false;
                    resizeHeight.Enabled = true;
                    break;
                case 4:
                    resizeWidth.Enabled = false;
                    resizeHeight.Enabled = false;
                    break;
            }
        }

        private void forApple_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            forceResizing.Enabled = setting.forApple = true;
            setting.Save();
        }

        private void forGoogle_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            forceResizing.Enabled = setting.forApple = false;
            setting.Save();
        }

        private void findFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = outputAddressBox.Text;
            DialogResult dr = folderBrowserDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                outputAddressBox.Text = folderBrowserDialog.SelectedPath;
                Properties.Settings setting = new Properties.Settings();
                setting.convDirectory = folderBrowserDialog.SelectedPath;
                setting.Save();
            }

        }
        
        private void isLTR_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            setting.direction = "ltr";
            setting.Save();
        }

        private void isRTL_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            setting.direction = "rtl";
            setting.Save();
        }

        private void toJPG_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            setting.imagetype = "jpg";
            quality.Enabled = true;
            setting.Save();
        }


        private void toPNG_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            setting.imagetype = "png";
            quality.Enabled = false;
            setting.Save();
        }

        private void toGIF_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            setting.imagetype = "gif";
            quality.Enabled = false;
            setting.Save();
        }

        private void doSplitLandscape_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            setting.dosplitLandscape = doSplitLandscape.Checked;
            setting.Save();
        }

        private void doSplitCover_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            setting.dosplitCover = doSplitCover.Checked;
            setting.Save();
        }

        private void resizeWidth_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            setting.userWidth = (int)resizeWidth.Value;
            setting.Save();
        }

        private void resizeHeight_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            setting.userHeight = (int)resizeHeight.Value;
            setting.Save();
        }


        private void resizeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = new Properties.Settings();
            setting.resizeType = resizeType.SelectedIndex;
            setting.Save();

            switch (resizeType.SelectedIndex)
            {
                case 0:
                case 3:
                    resizeWidth.Enabled = true;
                    resizeHeight.Enabled = true;
                    break;
                case 1:
                    resizeWidth.Enabled = true;
                    resizeHeight.Enabled = false;
                    break;
                case 2:
                    resizeWidth.Enabled = false;
                    resizeHeight.Enabled = true;
                    break;
                case 4:
                    resizeWidth.Enabled = false;
                    resizeHeight.Enabled = false;
                    break;
            }
        }

        
    }
}
