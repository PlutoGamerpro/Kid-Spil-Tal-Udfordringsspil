using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Børne_Spil
{
    public class Game
    {
        public int RandomNumber { get; private set; }
        public int CorrectAnswerBox1 => RandomNumber + 10;
        public int CorrectAnswerBox2 => RandomNumber + 1;
        public int CorrectAnswerBox3 => RandomNumber - 10;
        public int CorrectAnswerBox4 => RandomNumber - 1;

        private Random rand = new Random();

        public void GenerateRandomNumber()
        {
            RandomNumber = rand.Next(11, 89);
        }
    }
}
