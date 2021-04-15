using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        const int StartPosition = 0;
        public void getDieRoll()
        {
            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine(" Player's start position is = " + StartPosition);
            Console.WriteLine(" Your number is = " + die);
        }
        static void Main(string[] args)
        {
            Program play = new Program();
            play.getDieRoll();
        }
    }
}

