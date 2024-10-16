using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // For Color
using System.Windows.Forms; // For TextBox

namespace Børne_Spil
{
    public class AnswerChecker
    {
        public void CheckAnswers(int[] userInputs, Game game, TextBox[] textBoxes)
        {
            for (int i = 0; i < userInputs.Length; i++)
            {
                if (userInputs[i] == GetCorrectAnswer(i, game))
                {
                    textBoxes[i].BackColor = Color.LightGreen;
                }
                else
                {
                    textBoxes[i].BackColor = Color.Red;
                }
            }
        }

        private int GetCorrectAnswer(int index, Game game)
        {
            switch (index)
            {
                case 0:
                    return game.CorrectAnswerBox1;
                case 1:
                    return game.CorrectAnswerBox2;
                case 2:
                    return game.CorrectAnswerBox3;
                case 3:
                    return game.CorrectAnswerBox4;
                default:
                    throw new ArgumentOutOfRangeException(nameof(index));

            }
        }
    }
}
