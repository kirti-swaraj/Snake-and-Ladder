using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game for single player\n");
            int startPosition = 0;
            const int noPlay = 1;
            const int ladder = 2;
            const int snake = 3;
            int jump = 0;
            Console.WriteLine("Start Position= " + startPosition);

            //Rolling of die to get a random number
            Random random = new Random();
            int diceValue = random.Next(1, 7);
            Console.WriteLine("Dice value= " + diceValue);

            //Options for the player (No play, Ladder, Snake)
            int options = random.Next(1, 4);
            switch (options)
            {
                case noPlay:
                    jump = 0;
                    Console.WriteLine("No play: Jump= " + jump);
                    break;
                case ladder:
                    jump = diceValue;
                    Console.WriteLine("Ladder: Jump= " + jump);
                    Console.WriteLine("New position="+jump);
                    break;
                case snake:
                    jump = -diceValue;
                    Console.WriteLine("Snake: Jump= " + jump);
                    if (jump < 0)
                        jump = 0;
                    Console.WriteLine("New position=" + jump);
                    break;
            }

            Console.ReadKey();
        }

    }
}