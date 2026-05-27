namespace TSVFile
{
    partial class frmTSVFile
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
            this.ssrWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvwWord = new System.Windows.Forms.ListView();
            this.chWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhonogram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoundPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExplain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnsWord = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ssrWord.SuspendLayout();
            this.mnsWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssrWord
            // 
            this.ssrWord.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ssrWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.ssrWord.Location = new System.Drawing.Point(0, 365);
            this.ssrWord.Name = "ssrWord";
            this.ssrWord.Size = new System.Drawing.Size(553, 25);
            this.ssrWord.TabIndex = 1;
            this.ssrWord.Text = "statusStrip1";
            // 
            // tsslMessage
            // 
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(75, 20);
            this.tsslMessage.Text = "Message";
            // 
            // lvwWord
            // 
            this.lvwWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWord,
            this.chPhonogram,
            this.chSoundPath,
            this.chExplain});
            this.lvwWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwWord.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwWord.HideSelection = false;
            this.lvwWord.Location = new System.Drawing.Point(0, 28);
            this.lvwWord.Name = "lvwWord";
            this.lvwWord.Size = new System.Drawing.Size(553, 337);
            this.lvwWord.TabIndex = 2;
            this.lvwWord.UseCompatibleStateImageBehavior = false;
            this.lvwWord.View = System.Windows.Forms.View.Details;
            // 
            // chWord
            // 
            this.chWord.Text = "單字";
            this.chWord.Width = 61;
            // 
            // chPhonogram
            // 
            this.chPhonogram.Text = "音標";
            this.chPhonogram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chSoundPath
            // 
            this.chSoundPath.Text = "音檔路徑";
            this.chSoundPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSoundPath.Width = 150;
            // 
            // chExplain
            // 
            this.chExplain.Text = "解釋";
            this.chExplain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mnsWord
            // 
            this.mnsWord.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mnsWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.mnsWord.Location = new System.Drawing.Point(0, 0);
            this.mnsWord.Name = "mnsWord";
            this.mnsWord.Size = new System.Drawing.Size(553, 28);
            this.mnsWord.TabIndex = 3;
            this.mnsWord.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(71, 24);
            this.tsmiFile.Text = "檔案(&F)";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(180, 24);
            this.tsmiOpen.Text = "開啟(&O)";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 24);
            this.tsmiExit.Text = "離開(&E)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(75, 24);
            this.tsmiHelp.Text = "幫助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(180, 24);
            this.tsmiAbout.Text = "關於(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // frmTSVFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 390);
            this.Controls.Add(this.lvwWord);
            this.Controls.Add(this.ssrWord);
            this.Controls.Add(this.mnsWord);
            this.Name = "frmTSVFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSV資料檔讀取";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTSVFile_FormClosing);
            this.Load += new System.EventHandler(this.frmTSVFile_Load);
            this.ssrWord.ResumeLayout(false);
            this.ssrWord.PerformLayout();
            this.mnsWord.ResumeLayout(false);
            this.mnsWord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssrWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.ListView lvwWord;
        private System.Windows.Forms.ColumnHeader chWord;
        private System.Windows.Forms.ColumnHeader chPhonogram;
        private System.Windows.Forms.ColumnHeader chSoundPath;
        private System.Windows.Forms.ColumnHeader chExplain;
        private System.Windows.Forms.MenuStrip mnsWord;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

