using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_4_2
{
    public partial class Form1 : Form
    {
        int B = 10000;
        public Form1()
        {
            InitializeComponent();
            menu_hide();
            withdraw_hide();
            result_hide();
            deposit_hide();
            history_hide();
            login_show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string pass = password.Text;
            if(pass == "000000")
            {
                login_hide();
                menu_show();
            }
            else
            {
                password.Clear();
            }
        }

        //====================================================

        private void withdraw_Click(object sender, EventArgs e)
        {
            menu_hide();
            withdraw_show();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            menu_hide();
            deposit_show();
        }

        private void balance_Click(object sender, EventArgs e)
        {
            menu_hide();
            result_show(0, 0);
        }

        private void history_Click(object sender, EventArgs e)
        {
            menu_hide();
            history_show();
        }
        //====================================================
        //withdraw
        private void NT1000_Click(object sender, EventArgs e)
        {
            withdraw_hide();
            result_show(-1, 1000);
        }
        private void NT3000_Click(object sender, EventArgs e)
        {
            withdraw_hide();
            result_show(-1, 3000);
        }
        private void NT5000_Click(object sender, EventArgs e)
        {
            withdraw_hide();
            result_show(-1, 5000);
        }
        private void NT10000_Click(object sender, EventArgs e)
        {
            withdraw_hide();
            result_show(-1, 10000);
        }
        private void NT20000_Click(object sender, EventArgs e)
        {
            withdraw_hide();
            result_show(-1, 20000);
        }
        private void NT30000_Click(object sender, EventArgs e)
        {
            withdraw_hide();
            result_show(-1, 30000);
        }
        //====================================================
        //deposit
        private void depositbutton_Click(object sender, EventArgs e)
        {
            deposit_hide();
            result_show(1, int.Parse(depositmoney.Text));
        }
        //====================================================
        private void logout_Click(object sender, EventArgs e)
        {
            menu_hide();
            withdraw_hide();
            result_hide();
            deposit_hide();
            history_hide();
            login_show();
        }
        //====================================================
        private void login_hide()
        {
            this.label1.Hide();
            this.password.Hide();
            this.login.Hide();
        }
        private void login_show()
        {
            this.password.Clear();
            this.label1.Show();
            this.password.Show();
            this.login.Show();
        }

        private void menu_hide()
        {
            this.menu_label.Hide();
            this.withdraw.Hide();
            this.deposit.Hide();
            this.balance.Hide();
            this.history.Hide();
            this.logout.Hide();
        }
        private void menu_show()
        {
            menu_label.Text = "請選擇服務項目";
            this.menu_label.Show();
            this.withdraw.Show();
            this.deposit.Show();
            this.balance.Show();
            this.history.Show();
            this.logout.Show();
        }

        private void withdraw_hide()
                {
                    this.menu_label.Hide();
                    this.NT1000.Hide();
                    this.NT3000.Hide();
                    this.NT5000.Hide();
                    this.NT10000.Hide();
                    this.NT20000.Hide();
                    this.NT30000.Hide();
                    this.logout.Hide();
                }
        private void withdraw_show()
        {
            menu_label.Text = "請選擇提款金額";
            this.menu_label.Show();
            this.NT1000.Show();
            this.NT3000.Show();
            this.NT5000.Show();
            this.NT10000.Show();
            this.NT20000.Show();
            this.NT30000.Show();
            this.logout.Show();
        }

        private void result_hide()
        {
            result_label.Hide();
            logout.Hide();
        }
        private void result_show(int flag, int money)
        {
            result_label.Show();
            logout.Show();
            if (flag == 0)
            {
                result_label.Text = "餘額剩下: " + B + "NTD";
            }
            else if (flag == 1)
            {
                B = B + money;
                history_label.Text += "\n[存款] " + money + " NTD";
                history_label.Text += "\n[餘額] " + B + " NTD";
                result_label.Text = "餘額剩下: " + B + "NTD";
            }
            else if (flag == -1)
            {
                if (B >= money)
                {
                    B = B - money;
                    history_label.Text += "\n[提款] " + money + " NTD";
                    history_label.Text += "\n[餘額] " + B + " NTD";
                    result_label.Text = "餘額剩下: " + B + "NTD";
                }
                else result_label.Text = "餘額不足。";
            }
        }

        private void deposit_hide()
        {
            deposit_label.Hide();
            depositmoney.Hide();
            depositbutton.Hide();
            logout.Hide();
        }
        private void deposit_show()
        {
            depositmoney.Clear();
            deposit_label.Show();
            depositmoney.Show();
            depositbutton.Show();
            logout.Show();
        }

        private void history_hide()
        {
            history_label.Hide();
            logout.Hide();
        }
        private void history_show()
        {
            history_label.Show();
            logout.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
