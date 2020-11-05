using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eight_Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "" && button4.Text == "")
            {
                button4.Text = button1.Text;
                button1.Text = "";
            }
            else if (button1.Text != "" && button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "" && button5.Text == "")
            {
                button5.Text = button2.Text;
                button2.Text = "";
            }
            else if (button2.Text != "" && button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }
            else if (button2.Text != "" && button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "" && button6.Text == "")
            {
                button6.Text = button3.Text;
                button3.Text = "";
            }
            else if (button3.Text != "" && button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "" && button5.Text == "")
            {
                button5.Text = button4.Text;
                button4.Text = "";
            }
            else if (button4.Text != "" && button1.Text == "")
            {
                button1.Text = button4.Text;
                button4.Text = "";
            }
            else if (button4.Text != "" && button7.Text == "")
            {
                button7.Text = button4.Text;
                button4.Text = "";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "" && button8.Text == "")
            {
                button8.Text = button5.Text;
                button5.Text = "";
            }
            else if (button5.Text != "" && button4.Text == "")
            {
                button4.Text = button5.Text;
                button5.Text = "";
            }
            else if (button5.Text != "" && button2.Text == "")
            {
                button2.Text = button5.Text;
                button5.Text = "";
            }
            else if (button5.Text != "" && button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "" && button9.Text == "")
            {
                button9.Text = button6.Text;
                button6.Text = "";
                button8.Text = button8.Text;
            }
            else if (button6.Text != "" && button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }
            else if (button6.Text != "" && button3.Text == "")
            {
                button3.Text = button6.Text;
                button6.Text = "";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "" && button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }
            else if (button7.Text != "" && button4.Text == "")
            {
                button4.Text = button7.Text;
                button7.Text = "";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "" && button9.Text == "")
            {
                button9.Text = button8.Text;
                button8.Text = "";
                button6.Text = button6.Text;
            }
            else if (button8.Text != "" && button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
            }
            else if (button8.Text != "" && button5.Text == "")
            {
                button5.Text = button8.Text;
                button8.Text = "";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "" && button8.Text == "")
            {
                button8.Text = button9.Text;
                button9.Text = "";
            }
            else if (button9.Text != "" && button6.Text == "")
            {
                button6.Text = button9.Text;
                button9.Text = "";
            }
        }
        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int randomNumber1 = random.Next(1,9);
            int randomNumber2 = random.Next(1,9);
            int randomNumber3 = random.Next(1,9);
            textBox1.Text = randomNumber1.ToString();
            textBox2.Text = randomNumber2.ToString();
            textBox3.Text = randomNumber3.ToString();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == button1.Text && textBox2.Text == button5.Text && textBox3.Text == button9.Text)
                {
                    MessageBox.Show("You Win !", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You Lost !", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                    MessageBox.Show("No random number is generated for you.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generate random numbers first and match to the numbers generated in the insets.Skip random numbers if atleast two of the generated numbers are equal and generate again.Check when done.Once matched, you'll win.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
