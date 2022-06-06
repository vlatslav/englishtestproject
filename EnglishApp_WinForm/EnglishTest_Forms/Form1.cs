using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnglishTest_Forms
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            this.Size = new Size(1042,600);
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            username = textBox1.Text;
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_MouseOFF(object sender, EventArgs e)
        {
            btn_submit.BackgroundImage = BackgroundImage;
            btn_submit.ForeColor = Color.FromArgb(83, 70, 131);
            
        }

        private void btn_submit_MouseOn(object sender, EventArgs e)
        {
            btn_submit.BackColor = SystemColors.Control;
            btn_submit.BackgroundImage = null;
            btn_submit.ForeColor = Color.Black;
        }


    }
}