using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTest_Forms
{
    public partial class Form4 : Form
    {
        public Form4(int counter, int testid)
        {
            InitializeComponent();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
