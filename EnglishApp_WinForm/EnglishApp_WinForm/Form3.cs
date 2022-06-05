using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EFCTesting.DataModels;
using EFCTesting.Repository;
using EFCTesting.UOW;

namespace EnglishApp_WinForm
{
    public partial class Form3 : Form
    {
        private static EnglishContext englishContext = new EnglishContext();
        private UnitOfWork unitOfWork = new UnitOfWork(englishContext);
        private List<int> button_sequence = new List<int>();
        private List<int> index_sequence = new List<int>();
        private List<int> correct_sequence = new List<int>();
        private int correct_counter = 0, _tick, current_index = 0, testid;
        private bool dbLoaded = false;
        private List<Answer> answ;
        private IEnumerable<Question> res;

        public Form3(int testid)
        {
            this.testid = testid;
            InitializeComponent();
            randomIndex(15);
            randomButtons(4);
            showTest();
        }
        private void btn_returntomainClick(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();
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
        private async void showTest()
        {
            if (current_index == 0) buttonBack.Visible = false;
            else buttonBack.Visible = true;
            if (!dbLoaded)
            {
                res = await unitOfWork.QuestionRepository.GetAllWithDetails();
                res = res.OrderBy(x => x.TestID);
                dbLoaded = true;
            }
            answ = res.ElementAt((testid - 1) * 15 + index_sequence[current_index]).Answer.ToList();
            label1.Text = res.ElementAt((testid - 1) * 15 + index_sequence[current_index]).Quest;
            buttonA.Text = answ[button_sequence[0]].Answ;
            buttonB.Text = answ[button_sequence[1]].Answ;
            buttonC.Text = answ[button_sequence[2]].Answ;
            buttonD.Text = answ[button_sequence[3]].Answ;
        }
        private void randomButtons(int num)
        {
            int t;
            for (int i = 0; i < num; i++)
            {
                t = new Random().Next(0, num);
                for (int j = 0; j < button_sequence.Count(); j++)
                {
                    if (button_sequence[j] != t)
                    {
                        continue;
                    }
                    j = -1;
                    t = new Random().Next(0, num);
                }
                button_sequence.Add(t);
            }
        }
        private void randomIndex(int num)
        {
            int i, index;
            index = new Random().Next(0, num);
            for (i = 0; i < num; i++)
            {
                for (int j = 0; j < index_sequence.Count(); j++)
                {
                    if (index_sequence[j] != index)
                    {
                        continue;
                    }
                    j = -1;
                    index = new Random().Next(0, num);
                }
                correct_sequence.Add(0);
                index_sequence.Add(index);
            }
        }

        private void correctAnswerCheck(Button b1, Button b2, Button b3, Button b4, int a, int b, int c, int d)
        {
            if (answ[d].Correct)
            {
                b1.BackColor = Color.Chartreuse;
                buttonNxt.Enabled = true;
                correct_counter++;
            }
            else
            {
                b1.BackColor = Color.Firebrick;
                if (answ[a].Correct) b2.BackColor = Color.Chartreuse;
                if (answ[b].Correct) b3.BackColor = Color.Chartreuse;
                if (answ[c].Correct) b4.BackColor = Color.Chartreuse;
                buttonBack.Enabled = false;
                timerNext.Start();
                buttonNxt.Text = "3";
            }
        }
        private void showAnsweredButtons()
        {
            if (correct_sequence[current_index] != 0)
            {
                switch (correct_sequence[current_index])
                {
                    case 1:
                        buttonA.BackColor = Color.Firebrick;
                        break;
                    case 2:
                        buttonB.BackColor = Color.Firebrick;
                        break;
                    case 3:
                        buttonC.BackColor = Color.Firebrick;
                        break;
                    case 4:
                        buttonD.BackColor = Color.Firebrick;
                        break;
                    default:
                        break;
                }
                for (int i = 0; i < 4; i++)
                {
                    if (answ[button_sequence[i]].Correct)
                    {
                        switch (i)
                        {
                            case 0:
                                buttonA.BackColor = Color.Chartreuse;
                                break;
                            case 1:
                                buttonB.BackColor = Color.Chartreuse;
                                break;
                            case 2:
                                buttonC.BackColor = Color.Chartreuse;
                                break;
                            case 3:
                                buttonD.BackColor = Color.Chartreuse;
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                }
                buttonNxt.Enabled = true;
            }
        }
        private void buttonA_Click(object sender, EventArgs e)
        {
            if (correct_sequence[current_index] != 0) return;
            correctAnswerCheck(buttonA, buttonB, buttonC, buttonD, button_sequence[1], button_sequence[2], button_sequence[3], button_sequence[0]);
            correct_sequence[current_index] = 1;
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            if (correct_sequence[current_index] != 0) return;
            correctAnswerCheck(buttonB, buttonA, buttonC, buttonD, button_sequence[0], button_sequence[2], button_sequence[3], button_sequence[1]);
            correct_sequence[current_index] = 2;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (correct_sequence[current_index] != 0) return;
            correctAnswerCheck(buttonC, buttonB, buttonA, buttonD, button_sequence[1], button_sequence[0], button_sequence[3], button_sequence[2]);
            correct_sequence[current_index] = 3;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (correct_sequence[current_index] != 0) return;
            correctAnswerCheck(buttonD, buttonB, buttonC, buttonA, button_sequence[1], button_sequence[2], button_sequence[0], button_sequence[3]);
            correct_sequence[current_index] = 4;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
            current_index--;
            showTest();
            showAnsweredButtons();
        }
        private void buttonNxt_Click(object sender, EventArgs e)
        {
            if (current_index == 14)
            {
                buttonNxt.Visible = false;
                Form form4 = new Form4(correct_counter, testid);
                this.Close();
                form4.Show();
                return;
            }
            current_index++;
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
            showTest();
            buttonNxt.Enabled = false;
            showAnsweredButtons();
        }
        private void timerNext_Tick(object sender, EventArgs e)
        {
            _tick++;
            buttonNxt.Text = (3 - _tick).ToString();
            if (_tick == 3)
            {
                timerNext.Stop();
                buttonNxt.Text = ">>";
                buttonBack.Enabled = true;
                buttonNxt.Enabled = true;
                _tick = 0;
            }
        }
    }
}
