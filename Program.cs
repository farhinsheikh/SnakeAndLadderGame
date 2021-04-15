using System;
using System.Collections.Generic;
using System.Text;


namespace SnakeAndLadderGame
{
    class Program
    {
        const int StartPosition = 0;
        const int NO_PLAY = 0;
        const int LADDER = 1;
        const int SNAKE = 2;
        int positionOfPlayer = 0;

        static void Main(string[] args)
        {
            Program play = new Program();
            play.getDieRoll();
        }
        public void getDieRoll()
        {

            Random random = new Random();
            int option = random.Next(0, 3);
            int die = random.Next(1, 7);
            Console.WriteLine(" Player's start position is = " + StartPosition);
            Console.WriteLine(" Die number is = " + die);

            switch (option)
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;
                case LADDER:
                    positionOfPlayer += die;
                    Console.WriteLine("You got Ladder = " + positionOfPlayer);
                    break;
                case SNAKE:
                    positionOfPlayer -= die;
                    Console.WriteLine("You got Snake = " + positionOfPlayer);
                    break;
            }
         
        }
    }
}

