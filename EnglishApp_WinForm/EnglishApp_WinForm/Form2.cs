using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCTesting.DataModels;
using EFCTesting.Migrations;
using EFCTesting.UOW;

namespace EnglishApp_WinForm
{
    public partial class Form2 : Form
    {
        private int testid, userid;
        private static EnglishContext englishContext = new EnglishContext();
        private UnitOfWork unitOfWork = new UnitOfWork(englishContext);
        private User user;

        public Form2(int userid)
        {
            this.userid = userid;
            InitializeComponent();
            initDB();
            btn_submit.Hide();
            pnl_click.Hide();
            pnl_progress.Hide();
            pnl_progressbar.Hide();
            lbl_progress.Hide();
        }

        private async void initDB()
        {
            englishContext = new EnglishContext();
            unitOfWork = new UnitOfWork(englishContext);
            user = (await unitOfWork.UserRepository.GetAllWithDetails()).FirstOrDefault(x => x.UserID == userid);
        }
        private void btn_submit_MouseOFF(object sender, EventArgs e)
        {
            btn_submit.BackColor = Color.FromArgb(83, 70, 131);
            btn_submit.ForeColor = Color.White;
        }
        private void buttonON(object sender, EventArgs e)
        {
            var button = new Button();
            button = (Button)sender;
            button.BackColor = SystemColors.Control;
            button.ForeColor = Color.Black;

            lbl_progress.Show();
            pnl_progressbar.Show();
            float cur_progress = 0;
            switch (button.Name)
            {
                case "button1":
                    cur_progress = (float)user.Tests.ElementAt(0).Progress;
                    break;
                case "button2":
                    cur_progress = (float)user.Tests.ElementAt(1).Progress;
                    break;
                case "button3":
                    cur_progress = (float)user.Tests.ElementAt(2).Progress;
                    break;
                case "button4":
                    cur_progress = (float)user.Tests.ElementAt(3).Progress;
                    break;
                case "button5":
                    cur_progress = (float)user.Tests.ElementAt(4).Progress;
                    break;
                default:
                    break;
            }
            float max_mark = 15;
            float percentage = cur_progress / max_mark * 100;
            if (cur_progress == max_mark)
                pnl_progress.Width = pnl_progressbar.Width;
            else
            {
                int pnlWidth = (int)pnl_progressbar.Width / 100 * (int)percentage;
                pnl_progress.Width = pnlWidth;
            }
            pnl_progress.BringToFront();
            pnl_progress.Show();
        }

        private void buttonOFF(object sender, EventArgs e)
        {
            var button = new Button();
            button = (Button)sender;
            button.BackColor = Color.FromArgb(83, 70, 131);
            button.ForeColor = Color.White;
        }
        private void btn_submit_MouseOn(object sender, EventArgs e)
        {
            btn_submit.BackColor = SystemColors.Control;
            btn_submit.ForeColor = Color.Black;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3(testid, userid);
            this.Hide();
            form3.Show();
        }

        private void btn_leaderboard_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6(userid);
            this.Hide();
            form6.Show();
        }

        private void ldrbuttonON(object sender, EventArgs e)
        {
            var button = new Button();
            button = (Button)sender;
            button.BackColor = SystemColors.Control;
            button.ForeColor = Color.Black;
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            Test form1 = new Test();
            this.Close();
            form1.Show();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (testid == 0)
            {
                btn_submit.Show();
                pnl_click.Show();
            }
            var button = new Button();
            button = (Button)sender;
            switch (button.Name)
            {
                case "button1":
                    testid = 1;
                    break;
                case "button2":
                    testid = 2;
                    break;
                case "button3":
                    testid = 3;
                    break;
                case "button4":
                    testid = 4;
                    break;
                case "button5":
                    testid = 5;
                    break;
                default:
                    break;
            }
            pnl_click.Height = button.Height - 3;
            pnl_click.Top = button.Top + 10;
        }
    }
}
