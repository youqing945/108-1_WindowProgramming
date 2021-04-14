namespace Practice_8_1
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
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.lbPics = new System.Windows.Forms.ListBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnResetColor = new System.Windows.Forms.Button();
            this.btnChangePicColor = new System.Windows.Forms.Button();
            this.btnResetPicColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(12, 12);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(207, 32);
            this.cbDirection.TabIndex = 0;
            this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
            // 
            // lbPics
            // 
            this.lbPics.FormattingEnabled = true;
            this.lbPics.ItemHeight = 24;
            this.lbPics.Location = new System.Drawing.Point(12, 50);
            this.lbPics.Name = "lbPics";
            this.lbPics.Size = new System.Drawing.Size(207, 268);
            this.lbPics.TabIndex = 1;
            this.lbPics.SelectedValueChanged += new System.EventHandler(this.lbPics_SelectedValueChanged);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(12, 324);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(90, 22);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "更換背景顏色";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Silver;
            this.pictureBox.Location = new System.Drawing.Point(239, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(382, 306);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // btnResetColor
            // 
            this.btnResetColor.Location = new System.Drawing.Point(108, 324);
            this.btnResetColor.Name = "btnResetColor";
            this.btnResetColor.Size = new System.Drawing.Size(90, 22);
            this.btnResetColor.TabIndex = 4;
            this.btnResetColor.Text = "重設背景顏色";
            this.btnResetColor.UseVisualStyleBackColor = true;
            this.btnResetColor.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnChangePicColor
            // 
            this.btnChangePicColor.Location = new System.Drawing.Point(239, 324);
            this.btnChangePicColor.Name = "btnChangePicColor";
            this.btnChangePicColor.Size = new System.Drawing.Size(110, 22);
            this.btnChangePicColor.TabIndex = 5;
            this.btnChangePicColor.Text = "更換圖片背景顏色";
            this.btnChangePicColor.UseVisualStyleBackColor = true;
            this.btnChangePicColor.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnResetPicColor
            // 
            this.btnResetPicColor.Location = new System.Drawing.Point(355, 324);
            this.btnResetPicColor.Name = "btnResetPicColor";
            this.btnResetPicColor.Size = new System.Drawing.Size(110, 22);
            this.btnResetPicColor.TabIndex = 6;
            this.btnResetPicColor.Text = "重設圖片背景顏色";
            this.btnResetPicColor.UseVisualStyleBackColor = true;
            this.btnResetPicColor.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(633, 358);
            this.Controls.Add(this.btnResetPicColor);
            this.Controls.Add(this.btnChangePicColor);
            this.Controls.Add(this.btnResetColor);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lbPics);
            this.Controls.Add(this.cbDirection);
            this.Name = "Form1";
            this.Text = "圖片檢視器";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbPics;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.Button btnResetColor;
        private System.Windows.Forms.Button btnChangePicColor;
        private System.Windows.Forms.Button btnResetPicColor;
    }
}

