namespace Practice_5_1
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
            this.PINEAPPLE = new System.Windows.Forms.CheckBox();
            this.HAM = new System.Windows.Forms.CheckBox();
            this.PINEAPPLETEXT = new System.Windows.Forms.TextBox();
            this.HAMTEXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.make = new System.Windows.Forms.Button();
            this.BLUE = new System.Windows.Forms.RadioButton();
            this.GREEN = new System.Windows.Forms.RadioButton();
            this.RED = new System.Windows.Forms.RadioButton();
            this.NONE = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxSauce = new System.Windows.Forms.PictureBox();
            this.pictureBoxBread = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSauce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBread)).BeginInit();
            this.SuspendLayout();
            // 
            // PINEAPPLE
            // 
            this.PINEAPPLE.AutoSize = true;
            this.PINEAPPLE.Checked = true;
            this.PINEAPPLE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PINEAPPLE.Font = new System.Drawing.Font("新細明體", 10F);
            this.PINEAPPLE.Location = new System.Drawing.Point(19, 57);
            this.PINEAPPLE.Name = "PINEAPPLE";
            this.PINEAPPLE.Size = new System.Drawing.Size(98, 31);
            this.PINEAPPLE.TabIndex = 1;
            this.PINEAPPLE.Text = "鳳梨";
            this.PINEAPPLE.UseVisualStyleBackColor = true;
            this.PINEAPPLE.CheckedChanged += new System.EventHandler(this.PINEAPPLE_CheckedChanged);
            // 
            // HAM
            // 
            this.HAM.AutoSize = true;
            this.HAM.Checked = true;
            this.HAM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HAM.Font = new System.Drawing.Font("新細明體", 10F);
            this.HAM.Location = new System.Drawing.Point(19, 120);
            this.HAM.Name = "HAM";
            this.HAM.Size = new System.Drawing.Size(98, 31);
            this.HAM.TabIndex = 3;
            this.HAM.Text = "火腿";
            this.HAM.UseVisualStyleBackColor = true;
            this.HAM.CheckedChanged += new System.EventHandler(this.HAM_CheckedChanged);
            // 
            // PINEAPPLETEXT
            // 
            this.PINEAPPLETEXT.Font = new System.Drawing.Font("新細明體", 10F);
            this.PINEAPPLETEXT.Location = new System.Drawing.Point(143, 53);
            this.PINEAPPLETEXT.Name = "PINEAPPLETEXT";
            this.PINEAPPLETEXT.Size = new System.Drawing.Size(100, 39);
            this.PINEAPPLETEXT.TabIndex = 9;
            this.PINEAPPLETEXT.Text = "0";
            // 
            // HAMTEXT
            // 
            this.HAMTEXT.Font = new System.Drawing.Font("新細明體", 10F);
            this.HAMTEXT.Location = new System.Drawing.Point(144, 116);
            this.HAMTEXT.Name = "HAMTEXT";
            this.HAMTEXT.Size = new System.Drawing.Size(100, 39);
            this.HAMTEXT.TabIndex = 10;
            this.HAMTEXT.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F);
            this.label3.Location = new System.Drawing.Point(249, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "片";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10F);
            this.label4.Location = new System.Drawing.Point(250, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "片";
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(987, 750);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(175, 77);
            this.make.TabIndex = 13;
            this.make.Text = "生成";
            this.make.UseVisualStyleBackColor = true;
            this.make.Click += new System.EventHandler(this.make_Click);
            // 
            // BLUE
            // 
            this.BLUE.AutoSize = true;
            this.BLUE.Font = new System.Drawing.Font("新細明體", 10F);
            this.BLUE.Location = new System.Drawing.Point(19, 58);
            this.BLUE.Name = "BLUE";
            this.BLUE.Size = new System.Drawing.Size(97, 31);
            this.BLUE.TabIndex = 14;
            this.BLUE.Text = "藍莓";
            this.BLUE.UseVisualStyleBackColor = true;
            // 
            // GREEN
            // 
            this.GREEN.AutoSize = true;
            this.GREEN.Font = new System.Drawing.Font("新細明體", 10F);
            this.GREEN.Location = new System.Drawing.Point(19, 140);
            this.GREEN.Name = "GREEN";
            this.GREEN.Size = new System.Drawing.Size(97, 31);
            this.GREEN.TabIndex = 15;
            this.GREEN.Text = "抹茶";
            this.GREEN.UseVisualStyleBackColor = true;
            // 
            // RED
            // 
            this.RED.AutoSize = true;
            this.RED.Font = new System.Drawing.Font("新細明體", 10F);
            this.RED.Location = new System.Drawing.Point(19, 222);
            this.RED.Name = "RED";
            this.RED.Size = new System.Drawing.Size(124, 31);
            this.RED.TabIndex = 16;
            this.RED.Text = "番茄醬";
            this.RED.UseVisualStyleBackColor = true;
            // 
            // NONE
            // 
            this.NONE.AutoSize = true;
            this.NONE.Checked = true;
            this.NONE.Font = new System.Drawing.Font("新細明體", 10F);
            this.NONE.Location = new System.Drawing.Point(19, 304);
            this.NONE.Name = "NONE";
            this.NONE.Size = new System.Drawing.Size(124, 31);
            this.NONE.TabIndex = 17;
            this.NONE.TabStop = true;
            this.NONE.Text = "不加醬";
            this.NONE.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GREEN);
            this.groupBox1.Controls.Add(this.BLUE);
            this.groupBox1.Controls.Add(this.RED);
            this.groupBox1.Controls.Add(this.NONE);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox1.Location = new System.Drawing.Point(912, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 356);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "醬料";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PINEAPPLE);
            this.groupBox2.Controls.Add(this.HAM);
            this.groupBox2.Controls.Add(this.PINEAPPLETEXT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.HAMTEXT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox2.Location = new System.Drawing.Point(912, 500);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 186);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配料";
            // 
            // pictureBoxSauce
            // 
            this.pictureBoxSauce.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSauce.Location = new System.Drawing.Point(72, 76);
            this.pictureBoxSauce.Name = "pictureBoxSauce";
            this.pictureBoxSauce.Size = new System.Drawing.Size(625, 625);
            this.pictureBoxSauce.TabIndex = 22;
            this.pictureBoxSauce.TabStop = false;
            // 
            // pictureBoxBread
            // 
            this.pictureBoxBread.Location = new System.Drawing.Point(66, 74);
            this.pictureBoxBread.Name = "pictureBoxBread";
            this.pictureBoxBread.Size = new System.Drawing.Size(768, 768);
            this.pictureBoxBread.TabIndex = 0;
            this.pictureBoxBread.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 922);
            this.Controls.Add(this.pictureBoxSauce);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.make);
            this.Controls.Add(this.pictureBoxBread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSauce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBread)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBread;
        private System.Windows.Forms.CheckBox PINEAPPLE;
        private System.Windows.Forms.CheckBox HAM;
        private System.Windows.Forms.TextBox PINEAPPLETEXT;
        private System.Windows.Forms.TextBox HAMTEXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button make;
        private System.Windows.Forms.RadioButton BLUE;
        private System.Windows.Forms.RadioButton GREEN;
        private System.Windows.Forms.RadioButton RED;
        private System.Windows.Forms.RadioButton NONE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxSauce;
    }
}

