namespace ComicConverter
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.findFolder = new System.Windows.Forms.Button();
            this.outputAddressBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.isRTL = new System.Windows.Forms.RadioButton();
            this.isLTR = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resizeHeight = new System.Windows.Forms.NumericUpDown();
            this.resizeWidth = new System.Windows.Forms.NumericUpDown();
            this.resizeType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.doSplitCover = new System.Windows.Forms.CheckBox();
            this.doSplitLandscape = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quality = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.toGIF = new System.Windows.Forms.RadioButton();
            this.toPNG = new System.Windows.Forms.RadioButton();
            this.toJPG = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.forceResizing = new System.Windows.Forms.CheckBox();
            this.forGoogle = new System.Windows.Forms.RadioButton();
            this.forApple = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeWidth)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quality)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 247);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기본 설정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.findFolder);
            this.groupBox3.Controls.Add(this.outputAddressBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(346, 53);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EPUB 저장 경로";
            // 
            // findFolder
            // 
            this.findFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.findFolder.Location = new System.Drawing.Point(296, 19);
            this.findFolder.Name = "findFolder";
            this.findFolder.Size = new System.Drawing.Size(42, 23);
            this.findFolder.TabIndex = 6;
            this.findFolder.Text = "찾기";
            this.findFolder.UseVisualStyleBackColor = true;
            this.findFolder.Click += new System.EventHandler(this.findFolder_Click);
            // 
            // outputAddressBox
            // 
            this.outputAddressBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputAddressBox.Location = new System.Drawing.Point(8, 21);
            this.outputAddressBox.Name = "outputAddressBox";
            this.outputAddressBox.ReadOnly = true;
            this.outputAddressBox.Size = new System.Drawing.Size(282, 21);
            this.outputAddressBox.TabIndex = 6;
            this.outputAddressBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.isRTL);
            this.groupBox2.Controls.Add(this.isLTR);
            this.groupBox2.Location = new System.Drawing.Point(6, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(346, 53);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "읽기 방향 설정";
            // 
            // isRTL
            // 
            this.isRTL.AutoSize = true;
            this.isRTL.Location = new System.Drawing.Point(194, 22);
            this.isRTL.Name = "isRTL";
            this.isRTL.Size = new System.Drawing.Size(103, 16);
            this.isRTL.TabIndex = 5;
            this.isRTL.TabStop = true;
            this.isRTL.Text = "왼쪽 ← 오른쪽";
            this.isRTL.UseVisualStyleBackColor = true;
            this.isRTL.CheckedChanged += new System.EventHandler(this.isRTL_CheckedChanged);
            // 
            // isLTR
            // 
            this.isLTR.AutoSize = true;
            this.isLTR.Checked = true;
            this.isLTR.Location = new System.Drawing.Point(58, 22);
            this.isLTR.Name = "isLTR";
            this.isLTR.Size = new System.Drawing.Size(103, 16);
            this.isLTR.TabIndex = 5;
            this.isLTR.TabStop = true;
            this.isLTR.Text = "왼쪽 → 오른쪽";
            this.isLTR.UseVisualStyleBackColor = true;
            this.isLTR.CheckedChanged += new System.EventHandler(this.isLTR_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(359, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "이미지 설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.resizeHeight);
            this.groupBox6.Controls.Add(this.resizeWidth);
            this.groupBox6.Controls.Add(this.resizeType);
            this.groupBox6.Location = new System.Drawing.Point(8, 152);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(345, 59);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "이미지 크기 (W × H)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "×";
            // 
            // resizeHeight
            // 
            this.resizeHeight.Location = new System.Drawing.Point(108, 23);
            this.resizeHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.resizeHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resizeHeight.Name = "resizeHeight";
            this.resizeHeight.Size = new System.Drawing.Size(74, 21);
            this.resizeHeight.TabIndex = 27;
            this.resizeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resizeHeight.Value = new decimal(new int[] {
            1015,
            0,
            0,
            0});
            this.resizeHeight.ValueChanged += new System.EventHandler(this.resizeHeight_ValueChanged);
            // 
            // resizeWidth
            // 
            this.resizeWidth.Location = new System.Drawing.Point(11, 23);
            this.resizeWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.resizeWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resizeWidth.Name = "resizeWidth";
            this.resizeWidth.Size = new System.Drawing.Size(74, 21);
            this.resizeWidth.TabIndex = 26;
            this.resizeWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resizeWidth.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.resizeWidth.ValueChanged += new System.EventHandler(this.resizeWidth_ValueChanged);
            // 
            // resizeType
            // 
            this.resizeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeType.FormattingEnabled = true;
            this.resizeType.Location = new System.Drawing.Point(202, 23);
            this.resizeType.Name = "resizeType";
            this.resizeType.Size = new System.Drawing.Size(129, 20);
            this.resizeType.TabIndex = 28;
            this.resizeType.SelectedIndexChanged += new System.EventHandler(this.resizeType_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.doSplitCover);
            this.groupBox4.Controls.Add(this.doSplitLandscape);
            this.groupBox4.Location = new System.Drawing.Point(8, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 55);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "이미지 분할 옵션";
            // 
            // doSplitCover
            // 
            this.doSplitCover.AutoSize = true;
            this.doSplitCover.Location = new System.Drawing.Point(195, 24);
            this.doSplitCover.Name = "doSplitCover";
            this.doSplitCover.Size = new System.Drawing.Size(104, 16);
            this.doSplitCover.TabIndex = 24;
            this.doSplitCover.Text = "표지 따로 분할";
            this.doSplitCover.UseVisualStyleBackColor = true;
            this.doSplitCover.CheckedChanged += new System.EventHandler(this.doSplitCover_CheckedChanged);
            // 
            // doSplitLandscape
            // 
            this.doSplitLandscape.AutoSize = true;
            this.doSplitLandscape.Location = new System.Drawing.Point(59, 24);
            this.doSplitLandscape.Name = "doSplitLandscape";
            this.doSplitLandscape.Size = new System.Drawing.Size(110, 16);
            this.doSplitLandscape.TabIndex = 23;
            this.doSplitLandscape.Text = "2쪽 이미지 분할";
            this.doSplitLandscape.UseVisualStyleBackColor = true;
            this.doSplitLandscape.CheckedChanged += new System.EventHandler(this.doSplitLandscape_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quality);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.toGIF);
            this.groupBox1.Controls.Add(this.toPNG);
            this.groupBox1.Controls.Add(this.toJPG);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 48);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "출력 이미지 형식";
            // 
            // quality
            // 
            this.quality.Cursor = System.Windows.Forms.Cursors.Default;
            this.quality.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quality.Location = new System.Drawing.Point(295, 18);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(44, 21);
            this.quality.TabIndex = 20;
            this.quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quality.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "이미지 품질";
            // 
            // toGIF
            // 
            this.toGIF.AutoSize = true;
            this.toGIF.Location = new System.Drawing.Point(128, 20);
            this.toGIF.Name = "toGIF";
            this.toGIF.Size = new System.Drawing.Size(42, 16);
            this.toGIF.TabIndex = 16;
            this.toGIF.TabStop = true;
            this.toGIF.Text = "GIF";
            this.toGIF.UseVisualStyleBackColor = true;
            this.toGIF.CheckedChanged += new System.EventHandler(this.toGIF_CheckedChanged);
            // 
            // toPNG
            // 
            this.toPNG.AutoSize = true;
            this.toPNG.Location = new System.Drawing.Point(73, 20);
            this.toPNG.Name = "toPNG";
            this.toPNG.Size = new System.Drawing.Size(49, 16);
            this.toPNG.TabIndex = 16;
            this.toPNG.TabStop = true;
            this.toPNG.Text = "PNG";
            this.toPNG.UseVisualStyleBackColor = true;
            this.toPNG.CheckedChanged += new System.EventHandler(this.toPNG_CheckedChanged);
            // 
            // toJPG
            // 
            this.toJPG.AutoSize = true;
            this.toJPG.Location = new System.Drawing.Point(13, 20);
            this.toJPG.Name = "toJPG";
            this.toJPG.Size = new System.Drawing.Size(54, 16);
            this.toJPG.TabIndex = 17;
            this.toJPG.TabStop = true;
            this.toJPG.Text = "JPEG";
            this.toJPG.UseVisualStyleBackColor = true;
            this.toJPG.CheckedChanged += new System.EventHandler(this.toJPG_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.forceResizing);
            this.tabPage3.Controls.Add(this.forGoogle);
            this.tabPage3.Controls.Add(this.forApple);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(359, 221);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "디바이스 설정";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(40, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 44);
            this.label3.TabIndex = 12;
            this.label3.Text = "iBooks는 각 페이지의 이미지 크기가 다를경우에 제대로 처리하지 못하므로, 모든 페이지의 이미지 크기를 강제로 동일하게 바꾸는 옵션입니다.";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apple의 iPhone, iPad, iPod에서 구동되는 어플리케이션인 iBooks를 위한 설정입니다.";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 57);
            this.label2.TabIndex = 12;
            this.label2.Text = "Android에서 구동되는 Google Play Books에 업로드하기 위한 설정입니다. 이 설정을 사용하셔서 Play Books전용 EPUB 파" +
    "일을 작성하실 때는 반드시 용량이 50MB 이하가 되도록 이미지의 화질 조절을 해주시기 바랍니다.";
            // 
            // forceResizing
            // 
            this.forceResizing.AutoSize = true;
            this.forceResizing.Location = new System.Drawing.Point(42, 62);
            this.forceResizing.Name = "forceResizing";
            this.forceResizing.Size = new System.Drawing.Size(116, 16);
            this.forceResizing.TabIndex = 11;
            this.forceResizing.Text = "이미지 크기 강제";
            this.forceResizing.UseVisualStyleBackColor = true;
            // 
            // forGoogle
            // 
            this.forGoogle.AutoSize = true;
            this.forGoogle.Location = new System.Drawing.Point(6, 131);
            this.forGoogle.Name = "forGoogle";
            this.forGoogle.Size = new System.Drawing.Size(131, 16);
            this.forGoogle.TabIndex = 9;
            this.forGoogle.TabStop = true;
            this.forGoogle.Text = "Google Play Books";
            this.forGoogle.UseVisualStyleBackColor = true;
            this.forGoogle.CheckedChanged += new System.EventHandler(this.forGoogle_CheckedChanged);
            // 
            // forApple
            // 
            this.forApple.AutoSize = true;
            this.forApple.Location = new System.Drawing.Point(6, 12);
            this.forApple.Name = "forApple";
            this.forApple.Size = new System.Drawing.Size(61, 16);
            this.forApple.TabIndex = 10;
            this.forApple.TabStop = true;
            this.forApple.Text = "iBooks";
            this.forApple.UseVisualStyleBackColor = true;
            this.forApple.CheckedChanged += new System.EventHandler(this.forApple_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(305, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "닫기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(12, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "기본값 복구";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 300);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Setting";
            this.Text = "환경설정";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeWidth)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quality)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton isRTL;
        public System.Windows.Forms.RadioButton isLTR;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button findFolder;
        public System.Windows.Forms.TextBox outputAddressBox;
        public System.Windows.Forms.CheckBox forceResizing;
        public System.Windows.Forms.RadioButton forGoogle;
        public System.Windows.Forms.RadioButton forApple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton toPNG;
        public System.Windows.Forms.RadioButton toJPG;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton toGIF;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.CheckBox doSplitCover;
        public System.Windows.Forms.CheckBox doSplitLandscape;
        public System.Windows.Forms.NumericUpDown quality;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown resizeHeight;
        public System.Windows.Forms.NumericUpDown resizeWidth;
        public System.Windows.Forms.ComboBox resizeType;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}