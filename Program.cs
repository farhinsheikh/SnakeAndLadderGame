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
        const int WinPosition = 100;


        static void Main(string[] args)
        {
            Program play = new Program();
            play.getDieRoll();
        }
        public void getDieRoll()
        {
            Console.WriteLine(" Player's start position is = " + StartPosition);
            while (positionOfPlayer < WinPosition)
            {
                Random random = new Random();
                int option = random.Next(0, 3);
                int die = random.Next(1, 7);
                Console.WriteLine(" Die number is = " + die);

                switch (option)
                {
                    case NO_PLAY:
                        Console.WriteLine("No Play");
                        break;
                    case LADDER:
                        positionOfPlayer += die;
                        if (positionOfPlayer > WinPosition)
                        {
                            Console.WriteLine("Invalid position");
                            positionOfPlayer -= die;
                        }
                            Console.WriteLine("You got Ladder = " + positionOfPlayer);
                        break;
                    case SNAKE:
                        positionOfPlayer -= die;
                       if (positionOfPlayer < StartPosition)
                       {
                           positionOfPlayer = StartPosition;
                       }
                        Console.WriteLine("You got Snake = " + positionOfPlayer);
                        break;
                }
            }
         
        }
    }
}

