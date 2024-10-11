# 🎮 Børne Spil - Tal Udfordringsspil

## Oversigt
**Børne Spil** er en Windows Forms-applikation, der opfordrer børn til at øve matematik ved at løse simple taludfordringer. Spillet præsenterer et tilfældigt tal og kræver, at spillerne beregner og indtaster fire svar relateret til dette tal. Det giver realtidsfeedback om brugernes inputnøjagtighed.

## Funktioner
- 🎲 Genererer et tilfældigt tal mellem 11 og 89.
- 🧮 Beder brugerne om at løse grundlæggende matematiske problemer relateret til det genererede tal.
- ✅ Giver øjeblikkelig feedback med farvekodede svar (grøn for korrekt, rød for forkert).
- 🛡️ Brugervenlig grænseflade med inputvalidering, der sikrer, at kun numeriske indtastninger er tilladt.
- 🔄 Mulighed for at genstarte spillet for kontinuerlig træning.

```csharp


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
        static int RandomNumValue;
        int Correct_answerbox1;
        int Correct_answerbox2;
        int Correct_answerbox3;
        int Correct_answerbox4;
        int Random_Number;

        

        public Form1()
        {
            InitializeComponent();

            RND();

            Correct_answerbox1 = Random_Number + 10;
             Correct_answerbox2 = Random_Number + 1;
             Correct_answerbox3 = Random_Number - 10;
             Correct_answerbox4 = Random_Number - 1;

            // if alle text != nulll calcuate / valid answers


         
            
        }
        private void RND()
        {
            Random rand1 = new Random();
             Random_Number = rand1.Next(11, 89);


            string LabelStartValue = Random_Number.ToString();
            stxNumber.Text = Convert.ToString(Random_Number);

        }

        private void stxNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
       
        }

      

        private void CheckAnswer()
        {
            int UserInput_TextBox1 = Convert.ToInt16(textBox1.Text);
            int UserInput_TextBox2 = Convert.ToInt16(textBox2.Text);
            int UserInput_TextBox3 = Convert.ToInt16(textBox3.Text);
            int UserInput_TextBox4 = Convert.ToInt16(textBox4.Text);
           
            if(UserInput_TextBox1 == Correct_answerbox1) { textBox1.BackColor = Color.LightGreen; }
            else { textBox1.BackColor = Color.Red; }
       

            if (UserInput_TextBox2 == Correct_answerbox2) { textBox2.BackColor = Color.LightGreen; }
            else textBox2.BackColor = Color.Red;

            if (UserInput_TextBox3 == Correct_answerbox3) { textBox3.BackColor = Color.LightGreen; }
            else textBox3.BackColor = Color.Red;

            if (UserInput_TextBox4 == Correct_answerbox4) { textBox4.BackColor = Color.LightGreen; }
            else textBox4.BackColor = Color.Red;

            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null)
            {
                CheckAnswer();
            }
            else
            {
            //   MessageBox("Not all textboxes have been filled");
            }
        }
        private void Restart()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
;
            RND();
                
       
        }

        private void RETRY_BTN_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }













```
