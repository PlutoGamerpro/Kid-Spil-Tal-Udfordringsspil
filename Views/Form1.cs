


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;


namespace Børne_Spil
{
    public partial class Form1 : Form
    {
        private int countdownTime;
        private Game game;
        private AnswerChecker answerChecker;
        private CancellationTokenSource _cts;
        private int RandomNumHighligt;

        public Form1()
        {
                 

            // Set up the tooltip text for a button



            InitializeComponent();
         
            
            StartContinuousUpdate();
            game = new Game();
            answerChecker = new AnswerChecker();
            Restart();

            timer5.Interval = 1000; // Set timer interval to 1 second
            timer5.Tick += timer5_Tick;

            StartCountdown();
         
            // Add mouse event handlers for button1
            button1.MouseDown += Button_MouseDown;
            button1.MouseUp += Button_MouseUp;

            RETRY_BTN.MouseDown += Button_MouseDown;
            RETRY_BTN.MouseUp += Button_MouseUp;

            button4.MouseDown += Button_MouseDown;
            button4.MouseUp += Button_MouseUp;

            button2.MouseDown += Button_MouseDown;
            button2.MouseUp += Button_MouseUp;


            if (!AreAllTextBoxesFilled())
            {
                button1.Enabled = false;
                button1.BackColor = Color.Gray;
                button1.Text = "Finish all b4 ✔️";
            }
            PopulateTaloversigt();

/*
            string filePath = @"C:\Users\GH\source\repos\Børne Spil\Børne Spil\STARSBACKGROUND1.jfif"; // Change this to your actual file path
            this.BackgroundImage = Image.FromFile(filePath);
            this.BackgroundImageLayout = ImageLayout.Stretch; // or any other layout you prefer
*/
            


            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(LOCKEDBTN, "Achieve 2 streaks to unlock the next level!");

          

        }

      


    

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                button.Size = new Size(button.Width - 5, button.Height - 5); // Make the button smaller

            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                button.Size = new Size(button.Width + 5, button.Height + 5); // Restore original size


                // Optionally call the click event handler
                button.PerformClick();
            }
        }

        private void StartCountdown()
        {

            countdownTime = 20; // Example: 10 seconds
            LABEL_COUNTDOWN.Text = countdownTime.ToString() + "⏳";

        }

        private async void StartContinuousUpdate()
        {
            _cts = new CancellationTokenSource();
            await Task.Run(() =>
            {
                while (!_cts.Token.IsCancellationRequested)
                {
                    CHECKSUBMIT();
                    Thread.Sleep(16); // ~60 FPS
                }
            });
        }
        private void CHECKSUBMIT()
        {


            if (AreAllTextBoxesFilled())
            {
                // Ensure this code runs on the UI thread
                Invoke((MethodInvoker)(() =>
            {
                button1.Enabled = true;
                button1.BackColor = Color.LimeGreen;
                button1.Text = "Check answers ✔️";
            }));
            }
            
        }


        private void RestartCountdown()
        {
            //timer5.Stop(); // Stop the timer
            timer8.Start(); // Start the timer again
            countdownTime = 20; // Reset countdown time (or any value you want)
            LABEL_COUNTDOWN.Text = countdownTime.ToString() + "⏳"; // Update the UI
        }

        private void Restart()
        {
            panel1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            ResetTextBoxColors();

            game.GenerateRandomNumber();

            RandomNumHighligt = game.RandomNumber;

            RestartCountdown();

          


            stxNumber.Text = game.RandomNumber.ToString();
           

            PopulateTaloversigt();

            if (!AreAllTextBoxesFilled())
            {
                button1.Enabled = false;
                button1.BackColor = Color.Gray;
                button1.Text = "Finish all b4 ✔️";
            }

        }

        private void ResetTextBoxColors()
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;

            LABEL_COUNTDOWN.ForeColor = Color.LimeGreen;




        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] userInputs = new int[]
            {
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text),
                    Convert.ToInt32(textBox4.Text)
            };

            answerChecker.CheckAnswers(userInputs, game, new TextBox[] { textBox1, textBox2, textBox3, textBox4 });

            if (AnswerChecker.AllAnswersCorrect)
            {
                timer8.Stop();
                IncrementSteakText_Display();


                label9.Text = "Congrats! You beat the clock and won!";

                button2.Visible = true;
                button4.Visible = true;


                //  MessageBox.Show("All answers are correct!✔️");
                // Restart();
                panel1.Visible = true;
                
            }

        }
        private void IncrementSteakText_Display()
        {
            AnswerChecker.StreakScore++;
            STEAKTEXT.Text = AnswerChecker.StreakScore.ToString();
         

        }
        private void ResetSteakTest_Display()
        {
            AnswerChecker.StreakScore = 0;
            STEAKTEXT.Text = AnswerChecker.StreakScore.ToString();
         
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

        private void Helping_Tool_mat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PopulateTaloversigt()
        {


            int totalColumns = 10;
            int totalRows = 10;
            int number = 1;

            // Clear previous rows and columns
            Helping_Tool_mat.Rows.Clear();
            Helping_Tool_mat.Columns.Clear();

            // Desired total width for all columns
            int maxTotalWidth = 800; // Maximum width in pixels
            int columnWidth = maxTotalWidth / totalColumns; // Calculate width per column

            // Add columns with calculated width
            for (int col = 0; col < totalColumns; col++)
            {
                Helping_Tool_mat.Columns.Add("col" + col, (col + 1).ToString());
                Helping_Tool_mat.Columns[col].Width = columnWidth; // Set the calculated width for each column
            }

            // Set fixed row height
            Helping_Tool_mat.RowTemplate.Height = 30; // Adjust this value as needed

            // Populate rows
            for (int row = 0; row < totalRows; row++)
            {
                Helping_Tool_mat.Rows.Add(); // Add a new row
                for (int col = 0; col < totalColumns; col++)
                {
                    // Fill cell value
                    Helping_Tool_mat.Rows[row].Cells[col].Value = number;

                    // Check if the number is the generated random number
                    if (number == RandomNumHighligt)
                    {
                        Helping_Tool_mat.Rows[row].Cells[col].Style.Font = new Font("MV Boli", 8.25F, FontStyle.Bold);
                        Helping_Tool_mat.Rows[row].Cells[col].Style.BackColor = Color.Navy; // Highlight the cell
                        Helping_Tool_mat.Rows[row].Cells[col].Style.ForeColor = Color.LimeGreen; // Highlight the cell
                    }

                    number++;
                }
            }

          

        }

        private void Enable_Disable_HELP_TOOL_Click(object sender, EventArgs e)
        {
                             

         

            Helping_Tool_mat.Visible = !Helping_Tool_mat.Visible;
            Enable_Disable_HELP_TOOL.Text = Helping_Tool_mat.Visible ? "Disable Tool 🛠" : "Enable Tool 🛠️";

         
         

        }

        private void timer5_Tick(object sender, EventArgs e)
        {

        }

        private void timer8_Tick(object sender, EventArgs e)
        {


            if (countdownTime > 0)
            {
                LABEL_COUNTDOWN.Text = countdownTime.ToString() + "⏳";// Update the TextBox with the new value

                // Set colors based on countdownTime
                LABEL_COUNTDOWN.ForeColor = countdownTime <= 9 ? Color.Red : Color.LimeGreen;
                // Countdown_TIMER.BackColor = Color.White; // Keep the background white

                countdownTime--; // Decrement the countdown time
            }
            else
            {
                timer8.Stop(); // Stop the timer
                
                label9.Text = "Time's up! Unfortunately, you couldn't finish in time." +
                    " But don't worry—every challenge is a chance to improve." +
                    " Get ready for your next attempt!";
                LABEL_COUNTDOWN.Text = "0⏳";

                button2.Visible = true;
                button4.Visible = true;
                panel1.Visible = true;
               

                // Action when countdown reaches zero
                AnswerChecker.StreakScore = 0;
                ResetSteakTest_Display();
              //  Restart();

               

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}

