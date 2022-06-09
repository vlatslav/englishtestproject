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
    public partial class Form6 : Form
    {
        private int userid;
        private static EnglishContext englishContext = new EnglishContext();
        private UnitOfWork unitOfWork = new UnitOfWork(englishContext);
        private Dictionary<int, int> users = new Dictionary<int, int>();

        public Form6(int userid)
        {
            InitializeComponent();
            initDB();
            this.userid = userid;
        }

        private async void initDB()
        {
            englishContext = new EnglishContext();
            unitOfWork = new UnitOfWork(englishContext);
            var user = await unitOfWork.UserRepository.GetAllWithDetails();
            var count = user.Select(x => new
                { UserId = x.UserID, Count = x.Tests.Where(x => x.Done).Count() });
            List<int> usersid = new List<int>();
            List<int> userscount = new List<int>();
            foreach (var i in count)
            {
                if (i.Count > 0)
                {
                    usersid.Add(i.UserId);
                    userscount.Add(i.Count);
                }
            }

            int temp;
            for (int i = 0; i < userscount.Count(); i++)
            {
                for (int j = 0; j < userscount.Count(); j++)
                {
                    if (userscount[i] > userscount[j])
                    {
                        temp = userscount[i];
                        userscount[i] = userscount[j];
                        userscount[j] = temp;
                        temp = usersid[i];
                        usersid[i] = usersid[j];
                        usersid[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                var text = "---";
                if (i < usersid.Count())
                {
                    text = user.Where(u => u.UserID == usersid[i]).Select(x => x.NickName).First();
                    for (int j = 25 - text.Count(); j > 0; j--) text += " ";
                    text += userscount[i];
                }
                switch (i)
                {
                    case 0:
                        label2.Text += text;
                        break;
                    case 1:
                        label3.Text += text;
                        break;
                    case 2:
                        label4.Text += text;
                        break;
                    case 3:
                        label5.Text += text;
                        break;
                    case 4:
                        label6.Text += text;
                        break;
                    default:
                        break;
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(userid);
            form2.Show();
            this.Hide();
        }

        private void buttonOFF(object sender, EventArgs e)
        {
            var button = new Button();
            button = (Button)sender;
            button.BackColor = Color.FromArgb(83, 70, 131);
            button.ForeColor = Color.White;
        }

        private void buttonON(object sender, EventArgs e)
        {
            var button = new Button();
            button = (Button)sender;
            button.BackColor = SystemColors.Control;
            button.ForeColor = Color.Black;
        }
    }
}
