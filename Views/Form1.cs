


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Børne_Spil
{
    public partial class Form1 : Form
    {
        private Game game;
        private AnswerChecker answerChecker;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            answerChecker = new AnswerChecker();
            Restart();
        }

        private void Restart()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            ResetTextBoxColors();
            game.GenerateRandomNumber();
            stxNumber.Text = game.RandomNumber.ToString();
        }

        private void ResetTextBoxColors()
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AreAllTextBoxesFilled())
            {
                int[] userInputs = new int[]
                {
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text),
                    Convert.ToInt32(textBox4.Text)
                };

                answerChecker.CheckAnswers(userInputs, game, new TextBox[] { textBox1, textBox2, textBox3, textBox4 });
            }
            else
            {
                MessageBox.Show("Not all textboxes have been filled");
            }
        }

        private bool AreAllTextBoxesFilled()
        {
            return !string.IsNullOrEmpty(textBox1.Text) &&
                   !string.IsNullOrEmpty(textBox2.Text) &&
                   !string.IsNullOrEmpty(textBox3.Text) &&
                   !string.IsNullOrEmpty(textBox4.Text);
        }

        private void RETRY_BTN_Click(object sender, EventArgs e)
        {
            Restart();
        }

        // Handle key press events for numeric input
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress(sender, e);
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress(sender, e);
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress(sender, e);
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress(sender, e);
    }
}

