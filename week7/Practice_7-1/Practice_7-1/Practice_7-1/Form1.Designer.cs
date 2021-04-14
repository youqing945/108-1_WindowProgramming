namespace Practice_7_1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.equalizer = new System.Windows.Forms.TabPage();
            this.setting = new System.Windows.Forms.TabPage();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.SBB = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.SBG = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.SBR = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelFilepath = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.equalizer);
            this.tabControl.Controls.Add(this.setting);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1161, 939);
            this.tabControl.TabIndex = 0;
            // 
            // equalizer
            // 
            this.equalizer.Location = new System.Drawing.Point(8, 39);
            this.equalizer.Name = "equalizer";
            this.equalizer.Padding = new System.Windows.Forms.Padding(3);
            this.equalizer.Size = new System.Drawing.Size(1145, 892);
            this.equalizer.TabIndex = 0;
            this.equalizer.Text = "等化器";
            this.equalizer.UseVisualStyleBackColor = true;
            // 
            // setting
            // 
            this.setting.Controls.Add(this.btn_openfile);
            this.setting.Controls.Add(this.labelFilepath);
            this.setting.Controls.Add(this.label2);
            this.setting.Controls.Add(this.picColor);
            this.setting.Controls.Add(this.SBB);
            this.setting.Controls.Add(this.label5);
            this.setting.Controls.Add(this.SBG);
            this.setting.Controls.Add(this.label4);
            this.setting.Controls.Add(this.SBR);
            this.setting.Controls.Add(this.label3);
            this.setting.Controls.Add(this.label1);
            this.setting.Location = new System.Drawing.Point(8, 39);
            this.setting.Name = "setting";
            this.setting.Padding = new System.Windows.Forms.Padding(3);
            this.setting.Size = new System.Drawing.Size(1145, 892);
            this.setting.TabIndex = 1;
            this.setting.Text = "等化器設定";
            this.setting.UseVisualStyleBackColor = true;
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picColor.Location = new System.Drawing.Point(159, 29);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(113, 51);
            this.picColor.TabIndex = 10;
            this.picColor.TabStop = false;
            // 
            // SBB
            // 
            this.SBB.Location = new System.Drawing.Point(106, 245);
            this.SBB.Maximum = 255;
            this.SBB.Name = "SBB";
            this.SBB.Size = new System.Drawing.Size(485, 37);
            this.SBB.TabIndex = 9;
            this.SBB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SBScroll);
            this.SBB.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(43, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "藍色";
            // 
            // SBG
            // 
            this.SBG.Location = new System.Drawing.Point(106, 186);
            this.SBG.Maximum = 255;
            this.SBG.Name = "SBG";
            this.SBG.Size = new System.Drawing.Size(485, 37);
            this.SBG.TabIndex = 7;
            this.SBG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SBScroll);
            this.SBG.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(43, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "綠色";
            // 
            // SBR
            // 
            this.SBR.Location = new System.Drawing.Point(106, 125);
            this.SBR.Maximum = 255;
            this.SBR.Name = "SBR";
            this.SBR.Size = new System.Drawing.Size(485, 37);
            this.SBR.TabIndex = 5;
            this.SBR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SBScroll);
            this.SBR.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(43, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "紅色";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "顏色設定";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "檔案: ";
            // 
            // labelFilepath
            // 
            this.labelFilepath.Location = new System.Drawing.Point(124, 345);
            this.labelFilepath.Name = "labelFilepath";
            this.labelFilepath.Size = new System.Drawing.Size(385, 87);
            this.labelFilepath.TabIndex = 12;
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(515, 340);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(75, 35);
            this.btn_openfile.TabIndex = 13;
            this.btn_openfile.Text = "瀏覽...";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1185, 963);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.setting.ResumeLayout(false);
            this.setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage equalizer;
        private System.Windows.Forms.TabPage setting;
        private System.Windows.Forms.HScrollBar SBB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar SBG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar SBR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.Label labelFilepath;
        private System.Windows.Forms.Label label2;
    }
}

