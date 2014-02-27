namespace ComicConverter
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteSelectedFiles = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.openFiles = new System.Windows.Forms.Button();
            this.filelistview = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unselect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업데이트로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.comicConverterByAlphaFactory정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startConvert = new System.Windows.Forms.Button();
            this.progressLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressLabel2 = new System.Windows.Forms.Label();
            this.progressLabel3 = new System.Windows.Forms.Label();
            this.progressLabel4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressLabel5 = new System.Windows.Forms.Label();
            this.openFolder = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.filelistview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteSelectedFiles
            // 
            this.deleteSelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSelectedFiles.Location = new System.Drawing.Point(583, 396);
            this.deleteSelectedFiles.Name = "deleteSelectedFiles";
            this.deleteSelectedFiles.Size = new System.Drawing.Size(123, 23);
            this.deleteSelectedFiles.TabIndex = 4;
            this.deleteSelectedFiles.Text = "목록에서 선택 제거";
            this.deleteSelectedFiles.UseVisualStyleBackColor = true;
            this.deleteSelectedFiles.Click += new System.EventHandler(this.deleteSelectedFiles_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectAll.Location = new System.Drawing.Point(421, 396);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 2;
            this.buttonSelectAll.Text = "모두 선택";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // openFiles
            // 
            this.openFiles.Location = new System.Drawing.Point(6, 396);
            this.openFiles.Name = "openFiles";
            this.openFiles.Size = new System.Drawing.Size(75, 23);
            this.openFiles.TabIndex = 1;
            this.openFiles.Text = "파일 추가";
            this.openFiles.UseVisualStyleBackColor = true;
            this.openFiles.Click += new System.EventHandler(this.openFiles_Click);
            // 
            // filelistview
            // 
            this.filelistview.AllowUserToAddRows = false;
            this.filelistview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filelistview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.filelistview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filelistview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.filename,
            this.title,
            this.editor,
            this.fileaddress,
            this.empty});
            this.filelistview.Location = new System.Drawing.Point(8, 22);
            this.filelistview.Name = "filelistview";
            this.filelistview.RowHeadersVisible = false;
            this.filelistview.RowTemplate.Height = 23;
            this.filelistview.Size = new System.Drawing.Size(696, 368);
            this.filelistview.TabIndex = 0;
            this.filelistview.TabStop = false;
            // 
            // check
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.NullValue = false;
            this.check.DefaultCellStyle = dataGridViewCellStyle5;
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.check.Width = 20;
            // 
            // filename
            // 
            this.filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.filename.HeaderText = "파일명";
            this.filename.Name = "filename";
            this.filename.ReadOnly = true;
            this.filename.Width = 66;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title.HeaderText = "제목";
            this.title.Name = "title";
            this.title.Width = 54;
            // 
            // editor
            // 
            this.editor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.editor.HeaderText = "작가";
            this.editor.Name = "editor";
            this.editor.Width = 54;
            // 
            // fileaddress
            // 
            this.fileaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.fileaddress.DefaultCellStyle = dataGridViewCellStyle6;
            this.fileaddress.HeaderText = "파일 경로";
            this.fileaddress.MinimumWidth = 300;
            this.fileaddress.Name = "fileaddress";
            this.fileaddress.ReadOnly = true;
            this.fileaddress.Width = 300;
            // 
            // empty
            // 
            this.empty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empty.HeaderText = "";
            this.empty.Name = "empty";
            this.empty.ReadOnly = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filelistview);
            this.groupBox1.Controls.Add(this.unselect);
            this.groupBox1.Controls.Add(this.buttonSelectAll);
            this.groupBox1.Controls.Add(this.deleteSelectedFiles);
            this.groupBox1.Controls.Add(this.openFiles);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(712, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일 불러오기";
            // 
            // unselect
            // 
            this.unselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unselect.Location = new System.Drawing.Point(502, 396);
            this.unselect.Name = "unselect";
            this.unselect.Size = new System.Drawing.Size(75, 23);
            this.unselect.TabIndex = 3;
            this.unselect.Text = "선택 해제";
            this.unselect.UseVisualStyleBackColor = true;
            this.unselect.Click += new System.EventHandler(this.unselect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.편집ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.환경설정ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            this.환경설정ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.환경설정ToolStripMenuItem.Text = "환경설정";
            this.환경설정ToolStripMenuItem.Click += new System.EventHandler(this.환경설정ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.업데이트로그ToolStripMenuItem,
            this.toolStripSeparator1,
            this.comicConverterByAlphaFactory정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 업데이트로그ToolStripMenuItem
            // 
            this.업데이트로그ToolStripMenuItem.Name = "업데이트로그ToolStripMenuItem";
            this.업데이트로그ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.업데이트로그ToolStripMenuItem.Text = "업데이트 로그";
            this.업데이트로그ToolStripMenuItem.Click += new System.EventHandler(this.업데이트로그ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // comicConverterByAlphaFactory정보ToolStripMenuItem
            // 
            this.comicConverterByAlphaFactory정보ToolStripMenuItem.Name = "comicConverterByAlphaFactory정보ToolStripMenuItem";
            this.comicConverterByAlphaFactory정보ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.comicConverterByAlphaFactory정보ToolStripMenuItem.Text = "Comic Converter 정보";
            this.comicConverterByAlphaFactory정보ToolStripMenuItem.Click += new System.EventHandler(this.comicConverterByAlphaFactory정보ToolStripMenuItem_Click);
            // 
            // startConvert
            // 
            this.startConvert.Location = new System.Drawing.Point(536, 24);
            this.startConvert.Name = "startConvert";
            this.startConvert.Size = new System.Drawing.Size(80, 52);
            this.startConvert.TabIndex = 16;
            this.startConvert.Text = "변환 시작";
            this.startConvert.UseVisualStyleBackColor = true;
            this.startConvert.Click += new System.EventHandler(this.startConvert_Click);
            // 
            // progressLabel1
            // 
            this.progressLabel1.AutoSize = true;
            this.progressLabel1.Location = new System.Drawing.Point(337, 26);
            this.progressLabel1.Name = "progressLabel1";
            this.progressLabel1.Size = new System.Drawing.Size(129, 12);
            this.progressLabel1.TabIndex = 9;
            this.progressLabel1.Text = "전체 진행도 : 0/0 (0%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 10;
            // 
            // progressLabel2
            // 
            this.progressLabel2.AutoSize = true;
            this.progressLabel2.Location = new System.Drawing.Point(8, 50);
            this.progressLabel2.Name = "progressLabel2";
            this.progressLabel2.Size = new System.Drawing.Size(151, 12);
            this.progressLabel2.TabIndex = 9;
            this.progressLabel2.Text = "1. 압축 해제 중... 0/0 (0%)";
            // 
            // progressLabel3
            // 
            this.progressLabel3.AutoSize = true;
            this.progressLabel3.Location = new System.Drawing.Point(8, 70);
            this.progressLabel3.Name = "progressLabel3";
            this.progressLabel3.Size = new System.Drawing.Size(163, 12);
            this.progressLabel3.TabIndex = 9;
            this.progressLabel3.Text = "2. 이미지 처리 중... 0/0 (0%)";
            // 
            // progressLabel4
            // 
            this.progressLabel4.AutoSize = true;
            this.progressLabel4.Location = new System.Drawing.Point(226, 50);
            this.progressLabel4.Name = "progressLabel4";
            this.progressLabel4.Size = new System.Drawing.Size(179, 12);
            this.progressLabel4.TabIndex = 9;
            this.progressLabel4.Text = "3. 필요 파일 작성 중... 0/0 (0%)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressLabel5);
            this.groupBox4.Controls.Add(this.openFolder);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.startConvert);
            this.groupBox4.Controls.Add(this.progressLabel4);
            this.groupBox4.Controls.Add(this.progressLabel3);
            this.groupBox4.Controls.Add(this.progressLabel2);
            this.groupBox4.Controls.Add(this.progressLabel1);
            this.groupBox4.Location = new System.Drawing.Point(12, 458);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(712, 93);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "변환 작업";
            // 
            // progressLabel5
            // 
            this.progressLabel5.AutoSize = true;
            this.progressLabel5.Location = new System.Drawing.Point(226, 70);
            this.progressLabel5.Name = "progressLabel5";
            this.progressLabel5.Size = new System.Drawing.Size(187, 12);
            this.progressLabel5.TabIndex = 11;
            this.progressLabel5.Text = "4. EPUB 파일 생성 중... 0/0 (0%)";
            // 
            // openFolder
            // 
            this.openFolder.Location = new System.Drawing.Point(624, 24);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(80, 52);
            this.openFolder.TabIndex = 17;
            this.openFolder.Text = "폴더 열기";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(323, 15);
            this.progressBar1.TabIndex = 7;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 562);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Comic Converter Ver 1.0.1.0";
            ((System.ComponentModel.ISupportInitialize)(this.filelistview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView filelistview;
        public System.Windows.Forms.Button openFiles;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.Button deleteSelectedFiles;
        public System.Windows.Forms.Button buttonSelectAll;
        public System.Windows.Forms.DataGridViewCheckBoxColumn check;
        public System.Windows.Forms.DataGridViewTextBoxColumn filename;
        public System.Windows.Forms.DataGridViewTextBoxColumn title;
        public System.Windows.Forms.DataGridViewTextBoxColumn editor;
        public System.Windows.Forms.DataGridViewTextBoxColumn fileaddress;
        public System.Windows.Forms.DataGridViewTextBoxColumn empty;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem comicConverterByAlphaFactory정보ToolStripMenuItem;
        public System.Windows.Forms.Button startConvert;
        public System.Windows.Forms.Button unselect;
        public System.Windows.Forms.Label progressLabel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label progressLabel2;
        public System.Windows.Forms.Label progressLabel3;
        public System.Windows.Forms.Label progressLabel4;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.ToolStripMenuItem 업데이트로그ToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button openFolder;
        public System.Windows.Forms.Label progressLabel5;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;


    }
}

