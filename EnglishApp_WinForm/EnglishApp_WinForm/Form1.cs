using EFCTesting.Configuration;
using EFCTesting.DataModels;
using EFCTesting.Repository;
using EFCTesting.UOW;
using Microsoft.Data.SqlClient;

namespace EnglishApp_WinForm
{
    public partial class Test : Form
    {
        public string username;
        private static EnglishContext englishContext = new EnglishContext();
        private UnitOfWork unitOfWork = new UnitOfWork(englishContext);
        private IEnumerable<User> res;

        public Test()
        {
            InitializeComponent();
            initUserDB();
            this.Size = new Size(1042, 600);
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

        private async void initUserDB()
        {
            res = await unitOfWork.UserRepository.GetAllWithDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            var iter = res.GetEnumerator();
            iter.Reset();
            while (iter.MoveNext())
            {
                if (username == iter.Current.NickName)
                {
                    Form2 form = new Form2(iter.Current.UserID);
                    this.Hide();
                    form.Show();
                    return;
                }
            }

            MessageBox.Show("Such username doesn't exist!");
        }

        private async void btn_create_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            if (username == "")
            {
                MessageBox.Show("You can't create user without a name!");
                return;
            }

            var iter = res.GetEnumerator();
            iter.Reset();
            while (iter.MoveNext())
            {
                if (username == iter.Current.NickName)
                {
                    MessageBox.Show("Such username alread exists! Please sign in with it.");
                    return;
                }
            }

            var t = await unitOfWork.TestRepository.GetAll();
            var tests = englishContext.Tests;
            var u = new User();
            u.NickName = username;

            await unitOfWork.UserRepository.Add(u);
            await unitOfWork.Update();
            res = await unitOfWork.UserRepository.GetAllWithDetails();

            Form2 formi = new Form2(res.Last().UserID);
            this.Hide();
            formi.Show();
        }
    }
}