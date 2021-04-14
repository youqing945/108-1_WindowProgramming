namespace Practice_4_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.menu_label = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.NT1000 = new System.Windows.Forms.Button();
            this.NT3000 = new System.Windows.Forms.Button();
            this.NT5000 = new System.Windows.Forms.Button();
            this.NT10000 = new System.Windows.Forms.Button();
            this.NT20000 = new System.Windows.Forms.Button();
            this.NT30000 = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.deposit_label = new System.Windows.Forms.Label();
            this.depositmoney = new System.Windows.Forms.TextBox();
            this.depositbutton = new System.Windows.Forms.Button();
            this.history_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(162, 271);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(329, 36);
            this.password.TabIndex = 2;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(497, 271);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(101, 42);
            this.login.TabIndex = 3;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Location = new System.Drawing.Point(242, 71);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(178, 24);
            this.menu_label.TabIndex = 4;
            this.menu_label.Text = "請選擇服務項目";
            // 
            // withdraw
            // 
            this.withdraw.Location = new System.Drawing.Point(180, 131);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(301, 65);
            this.withdraw.TabIndex = 5;
            this.withdraw.Text = "存簿提款";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(180, 221);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(301, 65);
            this.deposit.TabIndex = 6;
            this.deposit.Text = "存簿存款";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(180, 313);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(301, 65);
            this.balance.TabIndex = 7;
            this.balance.Text = "查詢餘額";
            this.balance.UseVisualStyleBackColor = true;
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(180, 401);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(301, 65);
            this.history.TabIndex = 8;
            this.history.Text = "查詢歷史紀錄";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(241, 516);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(179, 50);
            this.logout.TabIndex = 9;
            this.logout.Text = "登出";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // NT1000
            // 
            this.NT1000.Location = new System.Drawing.Point(248, 135);
            this.NT1000.Name = "NT1000";
            this.NT1000.Size = new System.Drawing.Size(162, 43);
            this.NT1000.TabIndex = 10;
            this.NT1000.Text = "1000 NTD";
            this.NT1000.UseVisualStyleBackColor = true;
            this.NT1000.Click += new System.EventHandler(this.NT1000_Click);
            // 
            // NT3000
            // 
            this.NT3000.Location = new System.Drawing.Point(248, 194);
            this.NT3000.Name = "NT3000";
            this.NT3000.Size = new System.Drawing.Size(162, 43);
            this.NT3000.TabIndex = 11;
            this.NT3000.Text = "3000 NTD";
            this.NT3000.UseVisualStyleBackColor = true;
            this.NT3000.Click += new System.EventHandler(this.NT3000_Click);
            // 
            // NT5000
            // 
            this.NT5000.Location = new System.Drawing.Point(248, 253);
            this.NT5000.Name = "NT5000";
            this.NT5000.Size = new System.Drawing.Size(162, 43);
            this.NT5000.TabIndex = 12;
            this.NT5000.Text = "5000 NTD";
            this.NT5000.UseVisualStyleBackColor = true;
            this.NT5000.Click += new System.EventHandler(this.NT5000_Click);
            // 
            // NT10000
            // 
            this.NT10000.Location = new System.Drawing.Point(248, 312);
            this.NT10000.Name = "NT10000";
            this.NT10000.Size = new System.Drawing.Size(162, 43);
            this.NT10000.TabIndex = 13;
            this.NT10000.Text = "10000 NTD";
            this.NT10000.UseVisualStyleBackColor = true;
            this.NT10000.Click += new System.EventHandler(this.NT10000_Click);
            // 
            // NT20000
            // 
            this.NT20000.Location = new System.Drawing.Point(248, 371);
            this.NT20000.Name = "NT20000";
            this.NT20000.Size = new System.Drawing.Size(162, 43);
            this.NT20000.TabIndex = 14;
            this.NT20000.Text = "20000 NTD";
            this.NT20000.UseVisualStyleBackColor = true;
            this.NT20000.Click += new System.EventHandler(this.NT20000_Click);
            // 
            // NT30000
            // 
            this.NT30000.Location = new System.Drawing.Point(248, 430);
            this.NT30000.Name = "NT30000";
            this.NT30000.Size = new System.Drawing.Size(162, 43);
            this.NT30000.TabIndex = 15;
            this.NT30000.Text = "30000 NTD";
            this.NT30000.UseVisualStyleBackColor = true;
            this.NT30000.Click += new System.EventHandler(this.NT30000_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(146, 194);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(116, 24);
            this.result_label.TabIndex = 16;
            this.result_label.Text = "Result label";
            // 
            // deposit_label
            // 
            this.deposit_label.AutoSize = true;
            this.deposit_label.Location = new System.Drawing.Point(123, 250);
            this.deposit_label.Name = "deposit_label";
            this.deposit_label.Size = new System.Drawing.Size(184, 24);
            this.deposit_label.TabIndex = 17;
            this.deposit_label.Text = "請輸入存款金額:";
            // 
            // depositmoney
            // 
            this.depositmoney.Location = new System.Drawing.Point(127, 281);
            this.depositmoney.Name = "depositmoney";
            this.depositmoney.Size = new System.Drawing.Size(294, 36);
            this.depositmoney.TabIndex = 18;
            // 
            // depositbutton
            // 
            this.depositbutton.Location = new System.Drawing.Point(427, 281);
            this.depositbutton.Name = "depositbutton";
            this.depositbutton.Size = new System.Drawing.Size(159, 41);
            this.depositbutton.TabIndex = 19;
            this.depositbutton.Text = "存入款項";
            this.depositbutton.UseVisualStyleBackColor = true;
            this.depositbutton.Click += new System.EventHandler(this.depositbutton_Click);
            // 
            // history_label
            // 
            this.history_label.AutoSize = true;
            this.history_label.Location = new System.Drawing.Point(150, 101);
            this.history_label.Name = "history_label";
            this.history_label.Size = new System.Drawing.Size(187, 24);
            this.history_label.TabIndex = 20;
            this.history_label.Text = "[初始] 10000 NTD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 614);
            this.Controls.Add(this.history_label);
            this.Controls.Add(this.depositbutton);
            this.Controls.Add(this.depositmoney);
            this.Controls.Add(this.deposit_label);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.NT30000);
            this.Controls.Add(this.NT20000);
            this.Controls.Add(this.NT10000);
            this.Controls.Add(this.NT5000);
            this.Controls.Add(this.NT3000);
            this.Controls.Add(this.NT1000);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.history);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.menu_label);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button balance;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button NT1000;
        private System.Windows.Forms.Button NT3000;
        private System.Windows.Forms.Button NT5000;
        private System.Windows.Forms.Button NT10000;
        private System.Windows.Forms.Button NT20000;
        private System.Windows.Forms.Button NT30000;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Label deposit_label;
        private System.Windows.Forms.TextBox depositmoney;
        private System.Windows.Forms.Button depositbutton;
        private System.Windows.Forms.Label history_label;
    }
}

