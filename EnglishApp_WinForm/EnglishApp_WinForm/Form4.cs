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
        private int userid, testid;
        private static EnglishContext englishContext = new EnglishContext();
        private UnitOfWork unitOfWork = new UnitOfWork(englishContext);
        private User user;
        private List<int> incorrect_sequence;
        public Form4(int counter, int testid, int userid, List<int> incorrect_sequence, int maxnumber)
        {
            InitializeComponent();
            this.incorrect_sequence = incorrect_sequence;
            this.userid = userid;
            this.testid = testid;
            lbl_result.Text = counter.ToString() + "/" + maxnumber.ToString() + " correct";
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
            if (counter == maxnumber) lbl_passed_or_not.Text = "Perfect score! Well done!";
            if (counter < maxnumber) lbl_passed_or_not.Text = "Nice";
            if (counter < maxnumber*0.8) lbl_passed_or_not.Text = "Good";
            if (counter < maxnumber*0.5) lbl_passed_or_not.Text = "Could be better";
            if (counter < 0.25) lbl_passed_or_not.Text = "Are you even trying";
            if (counter == 0) lbl_passed_or_not.Text = "Try harder next time";

            if (incorrect_sequence.Count > 0) button2.Visible = true;
            updDB(counter);
        }
        private async void updDB(int counter)
        {
            user = (await unitOfWork.UserRepository.GetAllWithDetails()).FirstOrDefault(x => x.UserID == userid);

            var test = user.Tests.Where(x => x.UserId == user.UserID).Select(x => x.Test).ElementAt(testid - 1);
            if (test.Progress < counter) test.Progress = counter;
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
        private void button2_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5(testid, userid, incorrect_sequence);
            form5.Show();
            this.Hide();
        }
    }
}
