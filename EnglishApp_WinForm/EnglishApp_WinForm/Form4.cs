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
    public partial class Form4 : Form
    {
        private int userid;
        private static EnglishContext englishContext = new EnglishContext();
        private UnitOfWork unitOfWork = new UnitOfWork(englishContext);
        private User user;
        public Form4(int counter, int testid, int userid)
        {
            InitializeComponent();
            this.userid = userid;
            lbl_result.Text = counter.ToString() + "/15 correct";
            switch (testid)
            {
                case 1:
                    lbl_test.Text = "Test1.Name";
                    break;
                case 2:
                    lbl_test.Text = "Test2.Name";
                    break;
                case 3:
                    lbl_test.Text = "Test3.Name";
                    break;
                default:
                    break;
            }
            updDB(testid, counter);
        }
        private async void updDB(int testid, int counter)
        {
            user = (await unitOfWork.UserRepository.GetAllWithDetails()).FirstOrDefault(x => x.UserID == userid);

            var test = user.Tests.Where(x => x.UserId == user.UserID).Select(x => x.Test).ElementAt(testid - 1);
            if(test.Progress < counter) test.Progress = counter;
            test.Done = true;

            unitOfWork.TestRepository.Update(test);
            await unitOfWork.Update();
            unitOfWork.UserRepository.Update(user);
            await unitOfWork.Update();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(userid);
            form2.Show();
            this.Hide();
        }
    }
}
