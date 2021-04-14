namespace Practice_5_2
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.colorToValue = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.resistanceValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._4silver = new System.Windows.Forms.RadioButton();
            this._4gold = new System.Windows.Forms.RadioButton();
            this._4gray = new System.Windows.Forms.RadioButton();
            this._4purple = new System.Windows.Forms.RadioButton();
            this._4blue = new System.Windows.Forms.RadioButton();
            this._4green = new System.Windows.Forms.RadioButton();
            this._4red = new System.Windows.Forms.RadioButton();
            this._4brown = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._3silver = new System.Windows.Forms.RadioButton();
            this._3gold = new System.Windows.Forms.RadioButton();
            this._3white = new System.Windows.Forms.RadioButton();
            this._3gray = new System.Windows.Forms.RadioButton();
            this._3purple = new System.Windows.Forms.RadioButton();
            this._3blue = new System.Windows.Forms.RadioButton();
            this._3green = new System.Windows.Forms.RadioButton();
            this._3yellow = new System.Windows.Forms.RadioButton();
            this._3orange = new System.Windows.Forms.RadioButton();
            this._3red = new System.Windows.Forms.RadioButton();
            this._3brown = new System.Windows.Forms.RadioButton();
            this._3black = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._2white = new System.Windows.Forms.RadioButton();
            this._2gray = new System.Windows.Forms.RadioButton();
            this._2purple = new System.Windows.Forms.RadioButton();
            this._2blue = new System.Windows.Forms.RadioButton();
            this._2green = new System.Windows.Forms.RadioButton();
            this._2yellow = new System.Windows.Forms.RadioButton();
            this._2orange = new System.Windows.Forms.RadioButton();
            this._2red = new System.Windows.Forms.RadioButton();
            this._2brown = new System.Windows.Forms.RadioButton();
            this._2black = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._1white = new System.Windows.Forms.RadioButton();
            this._1gray = new System.Windows.Forms.RadioButton();
            this._1purple = new System.Windows.Forms.RadioButton();
            this._1blue = new System.Windows.Forms.RadioButton();
            this._1green = new System.Windows.Forms.RadioButton();
            this._1yellow = new System.Windows.Forms.RadioButton();
            this._1orange = new System.Windows.Forms.RadioButton();
            this._1red = new System.Windows.Forms.RadioButton();
            this._1brown = new System.Windows.Forms.RadioButton();
            this._1black = new System.Windows.Forms.RadioButton();
            this.calculateValue = new System.Windows.Forms.TabPage();
            this.txbParallel = new System.Windows.Forms.TextBox();
            this.txbSerial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.colorToValue.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.calculateValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.colorToValue);
            this.tabControl.Controls.Add(this.calculateValue);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(703, 970);
            this.tabControl.TabIndex = 0;
            // 
            // colorToValue
            // 
            this.colorToValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorToValue.Controls.Add(this.label2);
            this.colorToValue.Controls.Add(this.resistanceValue);
            this.colorToValue.Controls.Add(this.label1);
            this.colorToValue.Controls.Add(this.groupBox4);
            this.colorToValue.Controls.Add(this.groupBox3);
            this.colorToValue.Controls.Add(this.groupBox2);
            this.colorToValue.Controls.Add(this.groupBox1);
            this.colorToValue.Location = new System.Drawing.Point(8, 39);
            this.colorToValue.Name = "colorToValue";
            this.colorToValue.Padding = new System.Windows.Forms.Padding(3);
            this.colorToValue.Size = new System.Drawing.Size(687, 923);
            this.colorToValue.TabIndex = 0;
            this.colorToValue.Text = "顏色->阻值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(531, 845);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ω";
            // 
            // resistanceValue
            // 
            this.resistanceValue.Location = new System.Drawing.Point(212, 842);
            this.resistanceValue.Name = "resistanceValue";
            this.resistanceValue.ReadOnly = true;
            this.resistanceValue.Size = new System.Drawing.Size(315, 36);
            this.resistanceValue.TabIndex = 14;
            this.resistanceValue.Text = "0 ± 1%";
            this.resistanceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 845);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "阻值：";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this._4silver);
            this.groupBox4.Controls.Add(this._4gold);
            this.groupBox4.Controls.Add(this._4gray);
            this.groupBox4.Controls.Add(this._4purple);
            this.groupBox4.Controls.Add(this._4blue);
            this.groupBox4.Controls.Add(this._4green);
            this.groupBox4.Controls.Add(this._4red);
            this.groupBox4.Controls.Add(this._4brown);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(518, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(135, 756);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "第四色";
            // 
            // _4silver
            // 
            this._4silver.AutoSize = true;
            this._4silver.ForeColor = System.Drawing.Color.Silver;
            this._4silver.Location = new System.Drawing.Point(36, 688);
            this._4silver.Name = "_4silver";
            this._4silver.Size = new System.Drawing.Size(66, 28);
            this._4silver.TabIndex = 11;
            this._4silver.Text = "■";
            this._4silver.UseVisualStyleBackColor = true;
            this._4silver.CheckedChanged += new System.EventHandler(this._4_CheckedChanged);
            // 
            // _4gold
            // 
            this._4gold.AutoSize = true;
            this._4gold.ForeColor = System.Drawing.Color.Gold;
            this._4gold.Location = new System.Drawing.Point(36, 630);
            this._4gold.Name = "_4gold";
            this._4gold.Size = new System.Drawing.Size(66, 28);
            this._4gold.TabIndex = 10;
            this._4gold.Text = "■";
            this._4gold.UseVisualStyleBackColor = true;
            this._4gold.CheckedChanged += new System.EventHandler(this._4_CheckedChanged);
            // 
            // _4gray
            // 
            this._4gray.AutoSize = true;
            this._4gray.ForeColor = System.Drawing.Color.Gray;
            this._4gray.Location = new System.Drawing.Point(36, 514);
            this._4gray.Name = "_4gray";
            this._4gray.Size = new System.Drawing.Size(66, 28);
            this._4gray.TabIndex = 8;
            this._4gray.Text = "■";
            this._4gray.UseVisualStyleBackColor = true;
            this._4gray.CheckedChanged += new System.EventHandler(this._4_CheckedChanged);
            // 
            // _4purple
            // 
            this._4purple.AutoSize = true;
            this._4purple.ForeColor = System.Drawing.Color.Purple;
            this._4purple.Location = new System.Drawing.Point(36, 456);
            this._4purple.Name = "_4purple";
            this._4purple.Size = new System.Drawing.Size(66, 28);
            this._4purple.TabIndex = 7;
            this._4purple.Text = "■";
            this._4purple.UseVisualStyleBackColor = true;
            this._4purple.CheckedChanged += new System.EventHandler(this._4_CheckedChanged);
            // 
            // _4blue
            // 
            this._4blue.AutoSize = true;
            this._4blue.ForeColor = System.Drawing.Color.Blue;
            this._4blue.Location = new System.Drawing.Point(36, 398);
            this._4blue.Name = "_4blue";
            this._4blue.Size = new System.Drawing.Size(66, 28);
            this._4blue.TabIndex = 6;
            this._4blue.Text = "■";
            this._4blue.UseVisualStyleBackColor = true;
            this._4blue.CheckedChanged += new System.EventHandler(this._4_CheckedChanged);
            // 
            // _4green
            // 
            this._4green.AutoSize = true;
            this._4green.ForeColor = System.Drawing.Color.Green;
            this._4green.Location = new System.Drawing.Point(36, 340);
            this._4green.Name = "_4green";
            this._4green.Size = new System.Drawing.Size(66, 28);
            this._4green.TabIndex = 5;
            this._4green.Text = "■";
            this._4green.UseVisualStyleBackColor = true;
            this._4green.CheckedChanged += new System.EventHandler(this._4_CheckedChanged);
            // 
            // _4red
            // 
            this._4red.AutoSize = true;
            this._4red.ForeColor = System.Drawing.Color.Red;
            this._4red.Location = new System.Drawing.Point(36, 166);
            this._4red.Name = "_4red";
            this._4red.Size = new System.Drawing.Size(66, 28);
            this._4red.TabIndex = 2;
            this._4red.Text = "■";
            this._4red.UseVisualStyleBackColor = true;
            this._4red.CheckedChanged += new System.EventHandler(this._4_CheckedChanged);
            // 
            // _4brown
            // 
            this._4brown.AutoSize = true;
            this._4brown.Checked = true;
            this._4brown.ForeColor = System.Drawing.Color.Brown;
            this._4brown.Location = new System.Drawing.Point(36, 108);
            this._4brown.Name = "_4brown";
            this._4brown.Size = new System.Drawing.Size(66, 28);
            this._4brown.TabIndex = 1;
            this._4brown.TabStop = true;
            this._4brown.Text = "■";
            this._4brown.UseVisualStyleBackColor = true;
            this._4brown.CheckedChanged += new System.EventHandler(this._4_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this._3silver);
            this.groupBox3.Controls.Add(this._3gold);
            this.groupBox3.Controls.Add(this._3white);
            this.groupBox3.Controls.Add(this._3gray);
            this.groupBox3.Controls.Add(this._3purple);
            this.groupBox3.Controls.Add(this._3blue);
            this.groupBox3.Controls.Add(this._3green);
            this.groupBox3.Controls.Add(this._3yellow);
            this.groupBox3.Controls.Add(this._3orange);
            this.groupBox3.Controls.Add(this._3red);
            this.groupBox3.Controls.Add(this._3brown);
            this.groupBox3.Controls.Add(this._3black);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(356, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 756);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "第三色";
            // 
            // _3silver
            // 
            this._3silver.AutoSize = true;
            this._3silver.ForeColor = System.Drawing.Color.Silver;
            this._3silver.Location = new System.Drawing.Point(36, 688);
            this._3silver.Name = "_3silver";
            this._3silver.Size = new System.Drawing.Size(66, 28);
            this._3silver.TabIndex = 11;
            this._3silver.Text = "■";
            this._3silver.UseVisualStyleBackColor = true;
            this._3silver.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3gold
            // 
            this._3gold.AutoSize = true;
            this._3gold.ForeColor = System.Drawing.Color.Gold;
            this._3gold.Location = new System.Drawing.Point(36, 630);
            this._3gold.Name = "_3gold";
            this._3gold.Size = new System.Drawing.Size(66, 28);
            this._3gold.TabIndex = 10;
            this._3gold.Text = "■";
            this._3gold.UseVisualStyleBackColor = true;
            this._3gold.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3white
            // 
            this._3white.AutoSize = true;
            this._3white.Location = new System.Drawing.Point(36, 572);
            this._3white.Name = "_3white";
            this._3white.Size = new System.Drawing.Size(66, 28);
            this._3white.TabIndex = 9;
            this._3white.Text = "■";
            this._3white.UseVisualStyleBackColor = true;
            this._3white.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3gray
            // 
            this._3gray.AutoSize = true;
            this._3gray.ForeColor = System.Drawing.Color.Gray;
            this._3gray.Location = new System.Drawing.Point(36, 514);
            this._3gray.Name = "_3gray";
            this._3gray.Size = new System.Drawing.Size(66, 28);
            this._3gray.TabIndex = 8;
            this._3gray.Text = "■";
            this._3gray.UseVisualStyleBackColor = true;
            this._3gray.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3purple
            // 
            this._3purple.AutoSize = true;
            this._3purple.ForeColor = System.Drawing.Color.Purple;
            this._3purple.Location = new System.Drawing.Point(36, 456);
            this._3purple.Name = "_3purple";
            this._3purple.Size = new System.Drawing.Size(66, 28);
            this._3purple.TabIndex = 7;
            this._3purple.Text = "■";
            this._3purple.UseVisualStyleBackColor = true;
            this._3purple.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3blue
            // 
            this._3blue.AutoSize = true;
            this._3blue.ForeColor = System.Drawing.Color.Blue;
            this._3blue.Location = new System.Drawing.Point(36, 398);
            this._3blue.Name = "_3blue";
            this._3blue.Size = new System.Drawing.Size(66, 28);
            this._3blue.TabIndex = 6;
            this._3blue.Text = "■";
            this._3blue.UseVisualStyleBackColor = true;
            this._3blue.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3green
            // 
            this._3green.AutoSize = true;
            this._3green.ForeColor = System.Drawing.Color.Green;
            this._3green.Location = new System.Drawing.Point(36, 340);
            this._3green.Name = "_3green";
            this._3green.Size = new System.Drawing.Size(66, 28);
            this._3green.TabIndex = 5;
            this._3green.Text = "■";
            this._3green.UseVisualStyleBackColor = true;
            this._3green.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3yellow
            // 
            this._3yellow.AutoSize = true;
            this._3yellow.ForeColor = System.Drawing.Color.Yellow;
            this._3yellow.Location = new System.Drawing.Point(36, 282);
            this._3yellow.Name = "_3yellow";
            this._3yellow.Size = new System.Drawing.Size(66, 28);
            this._3yellow.TabIndex = 4;
            this._3yellow.Text = "■";
            this._3yellow.UseVisualStyleBackColor = true;
            this._3yellow.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3orange
            // 
            this._3orange.AutoSize = true;
            this._3orange.ForeColor = System.Drawing.Color.Orange;
            this._3orange.Location = new System.Drawing.Point(36, 224);
            this._3orange.Name = "_3orange";
            this._3orange.Size = new System.Drawing.Size(66, 28);
            this._3orange.TabIndex = 3;
            this._3orange.Text = "■";
            this._3orange.UseVisualStyleBackColor = true;
            this._3orange.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3red
            // 
            this._3red.AutoSize = true;
            this._3red.ForeColor = System.Drawing.Color.Red;
            this._3red.Location = new System.Drawing.Point(36, 166);
            this._3red.Name = "_3red";
            this._3red.Size = new System.Drawing.Size(66, 28);
            this._3red.TabIndex = 2;
            this._3red.Text = "■";
            this._3red.UseVisualStyleBackColor = true;
            this._3red.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3brown
            // 
            this._3brown.AutoSize = true;
            this._3brown.ForeColor = System.Drawing.Color.Brown;
            this._3brown.Location = new System.Drawing.Point(36, 108);
            this._3brown.Name = "_3brown";
            this._3brown.Size = new System.Drawing.Size(66, 28);
            this._3brown.TabIndex = 1;
            this._3brown.Text = "■";
            this._3brown.UseVisualStyleBackColor = true;
            this._3brown.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // _3black
            // 
            this._3black.AutoSize = true;
            this._3black.Checked = true;
            this._3black.ForeColor = System.Drawing.Color.Black;
            this._3black.Location = new System.Drawing.Point(36, 50);
            this._3black.Name = "_3black";
            this._3black.Size = new System.Drawing.Size(66, 28);
            this._3black.TabIndex = 0;
            this._3black.TabStop = true;
            this._3black.Text = "■";
            this._3black.UseVisualStyleBackColor = true;
            this._3black.CheckedChanged += new System.EventHandler(this._3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this._2white);
            this.groupBox2.Controls.Add(this._2gray);
            this.groupBox2.Controls.Add(this._2purple);
            this.groupBox2.Controls.Add(this._2blue);
            this.groupBox2.Controls.Add(this._2green);
            this.groupBox2.Controls.Add(this._2yellow);
            this.groupBox2.Controls.Add(this._2orange);
            this.groupBox2.Controls.Add(this._2red);
            this.groupBox2.Controls.Add(this._2brown);
            this.groupBox2.Controls.Add(this._2black);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(194, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 756);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第二色";
            // 
            // _2white
            // 
            this._2white.AutoSize = true;
            this._2white.Location = new System.Drawing.Point(36, 572);
            this._2white.Name = "_2white";
            this._2white.Size = new System.Drawing.Size(66, 28);
            this._2white.TabIndex = 9;
            this._2white.Text = "■";
            this._2white.UseVisualStyleBackColor = true;
            this._2white.CheckedChanged += new System.EventHandler(this._2_CheckedChanged);
            // 
            // _2gray
            // 
            this._2gray.AutoSize = true;
            this._2gray.ForeColor = System.Drawing.Color.Gray;
            this._2gray.Location = new System.Drawing.Point(36, 514);
            this._2gray.Name = "_2gray";
            this._2gray.Size = new System.Drawing.Size(66, 28);
            this._2gray.TabIndex = 8;
            this._2gray.Text = "■";
            this._2gray.UseVisualStyleBackColor = true;
            this._2gray.CheckedChanged += new System.EventHandler(this._2_CheckedChanged);
            // 
            // _2purple
            // 
            this._2purple.AutoSize = true;
            this._2purple.ForeColor = System.Drawing.Color.Purple;
            this._2purple.Location = new System.Drawing.Point(36, 456);
            this._2purple.Name = "_2purple";
            this._2purple.Size = new System.Drawing.Size(66, 28);
            this._2purple.TabIndex = 7;
            this._2purple.Text = "■";
            this._2purple.UseVisualStyleBackColor = true;
            this._2purple.CheckedChanged += new System.EventHandler(this._2_CheckedChanged);
            // 
            // _2blue
            // 
            this._2blue.AutoSize = true;
            this._2blue.ForeColor = System.Drawing.Color.Blue;
            this._2blue.Location = new System.Drawing.Point(36, 398);
            this._2blue.Name = "_2blue";
            this._2blue.Size = new System.Drawing.Size(66, 28);
            this._2blue.TabIndex = 6;
            this._2blue.Text = "■";
            this._2blue.UseVisualStyleBackColor = true;
            this._2blue.CheckedChanged += new System.EventHandler(this._2_CheckedChanged);
            // 
            // _2green
            // 
            this._2green.AutoSize = true;
            this._2green.ForeColor = System.Drawing.Color.Green;
            this._2green.Location = new System.Drawing.Point(36, 340);
            this._2green.Name = "_2green";
            this._2green.Size = new System.Drawing.Size(66, 28);
            this._2green.TabIndex = 5;
            this._2green.Text = "■";
            this._2green.UseVisualStyleBackColor = true;
            this._2green.CheckedChanged += new System.EventHandler(this._2_CheckedChanged);
            // 
            // _2yellow
            // 
            this._2yellow.AutoSize = true;
            this._2yellow.ForeColor = System.Drawing.Color.Yellow;
            this._2yellow.Location = new System.Drawing.Point(36, 282);
            this._2yellow.Name = "_2yellow";
            this._2yellow.Size = new System.Drawing.Size(66, 28);
            this._2yellow.TabIndex = 4;
            this._2yellow.Text = "■";
            this._2yellow.UseVisualStyleBackColor = true;
            this._2yellow.CheckedChanged += new System.EventHandler(this._2_CheckedChanged);
            // 
            // _2orange
            // 
            this._2orange.AutoSize = true;
            this._2orange.ForeColor = System.Drawing.Color.Orange;
            this._2orange.Location = new System.Drawing.Point(36, 224);
            this._2orange.Name = "_2orange";
            this._2orange.Size = new System.Drawing.Size(66, 28);
            this._2orange.TabIndex = 3;
            this._2orange.Text = "■";
            this._2orange.UseVisualStyleBackColor = true;
            this._2orange.CheckedChanged += new System.EventHandler(this._2_CheckedChanged);
            // 
            // _2red
            // 
            this._2red.AutoSize = true;
            this._2red.ForeColor = System.Drawing.Color.Red;
            this._2red.Location = new System.Drawing.Point(36, 166);
            this._2red.Name = "_2red";
            this._2red.Size = new System.Drawing.Size(66, 28);
            this._2red.TabIndex = 2;
            this._2red.Text = "■";
            this._2red.UseVisualStyleBackColor = true;
            this._2red.CheckedChanged += new System.EventHandler(this._2_CheckedChanged);
            // 
            // _2brown
            // 
            this._2brown.AutoSize = true;
            this._2brown.ForeColor = System.Drawing.Color.Brown;
            this._2brown.Location = new System.Drawing.Point(36, 108);
            this._2brown.Name = "_2brown";
            this._2brown.Size = new System.Drawing.Size(66, 28);
            this._2brown.TabIndex = 1;
            this._2brown.Text = "■";
            this._2brown.UseVisualStyleBackColor = true;
            this._2brown.CheckedChanged += new System.EventHandler(this._2_CheckedChanged);
            // 
            // _2black
            // 
            this._2black.AutoSize = true;
            this._2black.Checked = true;
            this._2black.ForeColor = System.Drawing.Color.Black;
            this._2black.Location = new System.Drawing.Point(36, 50);
            this._2black.Name = "_2black";
            this._2black.Size = new System.Drawing.Size(66, 28);
            this._2black.TabIndex = 0;
            this._2black.TabStop = true;
            this._2black.Text = "■";
            this._2black.UseVisualStyleBackColor = true;
            this._2black.CheckedChanged += new System.EventHandler(this._2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this._1white);
            this.groupBox1.Controls.Add(this._1gray);
            this.groupBox1.Controls.Add(this._1purple);
            this.groupBox1.Controls.Add(this._1blue);
            this.groupBox1.Controls.Add(this._1green);
            this.groupBox1.Controls.Add(this._1yellow);
            this.groupBox1.Controls.Add(this._1orange);
            this.groupBox1.Controls.Add(this._1red);
            this.groupBox1.Controls.Add(this._1brown);
            this.groupBox1.Controls.Add(this._1black);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(32, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 756);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第一色";
            // 
            // _1white
            // 
            this._1white.AutoSize = true;
            this._1white.Location = new System.Drawing.Point(36, 572);
            this._1white.Name = "_1white";
            this._1white.Size = new System.Drawing.Size(66, 28);
            this._1white.TabIndex = 9;
            this._1white.Text = "■";
            this._1white.UseVisualStyleBackColor = true;
            this._1white.CheckedChanged += new System.EventHandler(this._1_CheckedChanged);
            // 
            // _1gray
            // 
            this._1gray.AutoSize = true;
            this._1gray.ForeColor = System.Drawing.Color.Gray;
            this._1gray.Location = new System.Drawing.Point(36, 514);
            this._1gray.Name = "_1gray";
            this._1gray.Size = new System.Drawing.Size(66, 28);
            this._1gray.TabIndex = 8;
            this._1gray.Text = "■";
            this._1gray.UseVisualStyleBackColor = true;
            this._1gray.CheckedChanged += new System.EventHandler(this._1_CheckedChanged);
            // 
            // _1purple
            // 
            this._1purple.AutoSize = true;
            this._1purple.ForeColor = System.Drawing.Color.Purple;
            this._1purple.Location = new System.Drawing.Point(36, 456);
            this._1purple.Name = "_1purple";
            this._1purple.Size = new System.Drawing.Size(66, 28);
            this._1purple.TabIndex = 7;
            this._1purple.Text = "■";
            this._1purple.UseVisualStyleBackColor = true;
            this._1purple.CheckedChanged += new System.EventHandler(this._1_CheckedChanged);
            // 
            // _1blue
            // 
            this._1blue.AutoSize = true;
            this._1blue.ForeColor = System.Drawing.Color.Blue;
            this._1blue.Location = new System.Drawing.Point(36, 398);
            this._1blue.Name = "_1blue";
            this._1blue.Size = new System.Drawing.Size(66, 28);
            this._1blue.TabIndex = 6;
            this._1blue.Text = "■";
            this._1blue.UseVisualStyleBackColor = true;
            this._1blue.CheckedChanged += new System.EventHandler(this._1_CheckedChanged);
            // 
            // _1green
            // 
            this._1green.AutoSize = true;
            this._1green.ForeColor = System.Drawing.Color.Green;
            this._1green.Location = new System.Drawing.Point(36, 340);
            this._1green.Name = "_1green";
            this._1green.Size = new System.Drawing.Size(66, 28);
            this._1green.TabIndex = 5;
            this._1green.Text = "■";
            this._1green.UseVisualStyleBackColor = true;
            this._1green.CheckedChanged += new System.EventHandler(this._1_CheckedChanged);
            // 
            // _1yellow
            // 
            this._1yellow.AutoSize = true;
            this._1yellow.ForeColor = System.Drawing.Color.Yellow;
            this._1yellow.Location = new System.Drawing.Point(36, 282);
            this._1yellow.Name = "_1yellow";
            this._1yellow.Size = new System.Drawing.Size(66, 28);
            this._1yellow.TabIndex = 4;
            this._1yellow.Text = "■";
            this._1yellow.UseVisualStyleBackColor = true;
            this._1yellow.CheckedChanged += new System.EventHandler(this._1_CheckedChanged);
            // 
            // _1orange
            // 
            this._1orange.AutoSize = true;
            this._1orange.ForeColor = System.Drawing.Color.Orange;
            this._1orange.Location = new System.Drawing.Point(36, 224);
            this._1orange.Name = "_1orange";
            this._1orange.Size = new System.Drawing.Size(66, 28);
            this._1orange.TabIndex = 3;
            this._1orange.Text = "■";
            this._1orange.UseVisualStyleBackColor = true;
            this._1orange.CheckedChanged += new System.EventHandler(this._1_CheckedChanged);
            // 
            // _1red
            // 
            this._1red.AutoSize = true;
            this._1red.ForeColor = System.Drawing.Color.Red;
            this._1red.Location = new System.Drawing.Point(36, 166);
            this._1red.Name = "_1red";
            this._1red.Size = new System.Drawing.Size(66, 28);
            this._1red.TabIndex = 2;
            this._1red.Text = "■";
            this._1red.UseVisualStyleBackColor = true;
            this._1red.CheckedChanged += new System.EventHandler(this._1_CheckedChanged);
            // 
            // _1brown
            // 
            this._1brown.AutoSize = true;
            this._1brown.ForeColor = System.Drawing.Color.Brown;
            this._1brown.Location = new System.Drawing.Point(36, 108);
            this._1brown.Name = "_1brown";
            this._1brown.Size = new System.Drawing.Size(66, 28);
            this._1brown.TabIndex = 1;
            this._1brown.Text = "■";
            this._1brown.UseVisualStyleBackColor = true;
            this._1brown.CheckedChanged += new System.EventHandler(this._1_CheckedChanged);
            // 
            // _1black
            // 
            this._1black.AutoSize = true;
            this._1black.Checked = true;
            this._1black.ForeColor = System.Drawing.Color.Black;
            this._1black.Location = new System.Drawing.Point(36, 50);
            this._1black.Name = "_1black";
            this._1black.Size = new System.Drawing.Size(66, 28);
            this._1black.TabIndex = 0;
            this._1black.TabStop = true;
            this._1black.Text = "■";
            this._1black.UseVisualStyleBackColor = true;
            this._1black.CheckedChanged += new System.EventHandler(this._1_CheckedChanged);
            // 
            // calculateValue
            // 
            this.calculateValue.Controls.Add(this.label6);
            this.calculateValue.Controls.Add(this.label5);
            this.calculateValue.Controls.Add(this.txbParallel);
            this.calculateValue.Controls.Add(this.txbSerial);
            this.calculateValue.Controls.Add(this.label4);
            this.calculateValue.Controls.Add(this.label3);
            this.calculateValue.Controls.Add(this.btnDelete);
            this.calculateValue.Controls.Add(this.btnAdd);
            this.calculateValue.Controls.Add(this.btnCal);
            this.calculateValue.Location = new System.Drawing.Point(8, 39);
            this.calculateValue.Name = "calculateValue";
            this.calculateValue.Padding = new System.Windows.Forms.Padding(3);
            this.calculateValue.Size = new System.Drawing.Size(687, 923);
            this.calculateValue.TabIndex = 1;
            this.calculateValue.Text = "串聯/並聯計算";
            this.calculateValue.UseVisualStyleBackColor = true;
            // 
            // txbParallel
            // 
            this.txbParallel.Location = new System.Drawing.Point(348, 285);
            this.txbParallel.Name = "txbParallel";
            this.txbParallel.ReadOnly = true;
            this.txbParallel.Size = new System.Drawing.Size(223, 36);
            this.txbParallel.TabIndex = 6;
            // 
            // txbSerial
            // 
            this.txbSerial.Location = new System.Drawing.Point(348, 192);
            this.txbSerial.Name = "txbSerial";
            this.txbSerial.ReadOnly = true;
            this.txbSerial.Size = new System.Drawing.Size(223, 36);
            this.txbSerial.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "並聯：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "串聯：";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDelete.Location = new System.Drawing.Point(86, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnAdd.Location = new System.Drawing.Point(18, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(371, 69);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(210, 42);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "計算";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(577, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ω";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(577, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ω";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(723, 995);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "工具人QQ";
            this.tabControl.ResumeLayout(false);
            this.colorToValue.ResumeLayout(false);
            this.colorToValue.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.calculateValue.ResumeLayout(false);
            this.calculateValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage colorToValue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton _4silver;
        private System.Windows.Forms.RadioButton _4gold;
        private System.Windows.Forms.RadioButton _4gray;
        private System.Windows.Forms.RadioButton _4purple;
        private System.Windows.Forms.RadioButton _4blue;
        private System.Windows.Forms.RadioButton _4green;
        private System.Windows.Forms.RadioButton _4red;
        private System.Windows.Forms.RadioButton _4brown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton _3silver;
        private System.Windows.Forms.RadioButton _3gold;
        private System.Windows.Forms.RadioButton _3white;
        private System.Windows.Forms.RadioButton _3gray;
        private System.Windows.Forms.RadioButton _3purple;
        private System.Windows.Forms.RadioButton _3blue;
        private System.Windows.Forms.RadioButton _3green;
        private System.Windows.Forms.RadioButton _3yellow;
        private System.Windows.Forms.RadioButton _3orange;
        private System.Windows.Forms.RadioButton _3red;
        private System.Windows.Forms.RadioButton _3brown;
        private System.Windows.Forms.RadioButton _3black;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton _2white;
        private System.Windows.Forms.RadioButton _2gray;
        private System.Windows.Forms.RadioButton _2purple;
        private System.Windows.Forms.RadioButton _2blue;
        private System.Windows.Forms.RadioButton _2green;
        private System.Windows.Forms.RadioButton _2yellow;
        private System.Windows.Forms.RadioButton _2orange;
        private System.Windows.Forms.RadioButton _2red;
        private System.Windows.Forms.RadioButton _2brown;
        private System.Windows.Forms.RadioButton _2black;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _1white;
        private System.Windows.Forms.RadioButton _1gray;
        private System.Windows.Forms.RadioButton _1purple;
        private System.Windows.Forms.RadioButton _1blue;
        private System.Windows.Forms.RadioButton _1green;
        private System.Windows.Forms.RadioButton _1yellow;
        private System.Windows.Forms.RadioButton _1orange;
        private System.Windows.Forms.RadioButton _1red;
        private System.Windows.Forms.RadioButton _1brown;
        private System.Windows.Forms.RadioButton _1black;
        private System.Windows.Forms.TabPage calculateValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resistanceValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbParallel;
        private System.Windows.Forms.TextBox txbSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

