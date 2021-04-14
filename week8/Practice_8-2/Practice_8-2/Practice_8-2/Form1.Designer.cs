namespace Practice_8_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msState = new System.Windows.Forms.ToolStripMenuItem();
            this.msiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.msiPause = new System.Windows.Forms.ToolStripMenuItem();
            this.msiRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.lbScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msState});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msState
            // 
            this.msState.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiStart,
            this.msiPause,
            this.msiRestart});
            this.msState.Name = "msState";
            this.msState.Size = new System.Drawing.Size(73, 38);
            this.msState.Text = "狀態";
            // 
            // msiStart
            // 
            this.msiStart.Name = "msiStart";
            this.msiStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.msiStart.Size = new System.Drawing.Size(293, 38);
            this.msiStart.Text = "開始";
            this.msiStart.Click += new System.EventHandler(this.msi_Click);
            // 
            // msiPause
            // 
            this.msiPause.Name = "msiPause";
            this.msiPause.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.msiPause.Size = new System.Drawing.Size(293, 38);
            this.msiPause.Text = "暫停";
            this.msiPause.Click += new System.EventHandler(this.msi_Click);
            // 
            // msiRestart
            // 
            this.msiRestart.Name = "msiRestart";
            this.msiRestart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.msiRestart.Size = new System.Drawing.Size(293, 38);
            this.msiRestart.Text = "重新開始";
            this.msiRestart.Click += new System.EventHandler(this.msi_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(182, 204);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(81, 24);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "分數: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(474, 429);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "視力檢測?";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msState;
        private System.Windows.Forms.ToolStripMenuItem msiStart;
        private System.Windows.Forms.ToolStripMenuItem msiPause;
        private System.Windows.Forms.ToolStripMenuItem msiRestart;
        private System.Windows.Forms.Label lbScore;
        public System.Windows.Forms.Timer timer1;
    }
}

