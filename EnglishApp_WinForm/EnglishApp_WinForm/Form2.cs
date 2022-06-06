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
using EFCTesting.UOW;

namespace EnglishApp_WinForm
{
    public partial class Form2 : Form
    {
        private int testid, userid;
        private static EnglishContext englishContext = new EnglishContext();
        private UnitOfWork unitOfWork = new UnitOfWork(englishContext);
        private User user;

        public Form2(int userid, User user)
        {
            this.userid = userid;
            InitializeComponent();
            initDB(user);
            btn_submit.Hide();
            pnl_click.Hide();
        }

        private async void initDB(User user)
        { 
            user = (await unitOfWork.UserRepository.GetAllWithDetails()).FirstOrDefault(x => x.UserID == userid);
            if (user.Tests.ElementAt(0).Done) percentT1.Text = (user.Tests.ElementAt(0).Progress / 15).ToString("#0.00") + "%";
            if (user.Tests.ElementAt(1).Done) percentT2.Text = (user.Tests.ElementAt(1).Progress / 15).ToString("#0.00") + "%";
            if (user.Tests.ElementAt(2).Done) percentT3.Text = (user.Tests.ElementAt(2).Progress / 15).ToString("#0.00") + "%";

            // ADD MORE TESTS //

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
            Form form3 = new Form3(testid, userid, user);
            this.Hide();
            form3.Show();
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
