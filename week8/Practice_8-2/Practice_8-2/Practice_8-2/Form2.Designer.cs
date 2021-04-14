namespace Practice_8_2
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msState = new System.Windows.Forms.ToolStripMenuItem();
            this.msiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.msiPause = new System.Windows.Forms.ToolStripMenuItem();
            this.msiRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msState
            // 
            this.msState.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiStart,
            this.msiPause,
            this.msiRestart});
            this.msState.Name = "msState";
            this.msState.Size = new System.Drawing.Size(73, 34);
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
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(51, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(370, 370);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(474, 429);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "圖片";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msState;
        private System.Windows.Forms.ToolStripMenuItem msiStart;
        private System.Windows.Forms.ToolStripMenuItem msiPause;
        private System.Windows.Forms.ToolStripMenuItem msiRestart;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}