namespace Practice_6_3
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
            this.labelKeyboard = new System.Windows.Forms.Label();
            this.labelPress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKeyboard
            // 
            this.labelKeyboard.AutoSize = true;
            this.labelKeyboard.Location = new System.Drawing.Point(287, 354);
            this.labelKeyboard.Name = "labelKeyboard";
            this.labelKeyboard.Size = new System.Drawing.Size(141, 24);
            this.labelKeyboard.TabIndex = 0;
            this.labelKeyboard.Text = "labelKeyboard";
            // 
            // labelPress
            // 
            this.labelPress.AutoSize = true;
            this.labelPress.Location = new System.Drawing.Point(12, 735);
            this.labelPress.Name = "labelPress";
            this.labelPress.Size = new System.Drawing.Size(59, 24);
            this.labelPress.TabIndex = 1;
            this.labelPress.Text = "Press";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 768);
            this.Controls.Add(this.labelPress);
            this.Controls.Add(this.labelKeyboard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeyboard;
        private System.Windows.Forms.Label labelPress;
    }
}

