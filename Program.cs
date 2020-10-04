using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Snake and Ladder game for single player\n");
            int startPosition = 0;
            int currentPosition = 0;
            const int noPlay = 1;
            const int ladder = 2;
            const int snake = 3;
            int jump = 0;
            Console.WriteLine("Start Position= " + startPosition);

            //Rolling of die to get a random number
            Random random = new Random();
            


            //Options for the player (No play, Ladder, Snake)
            
            while (currentPosition != 100)
               
            {
                int diceValue = random.Next(1, 7);
                Console.WriteLine("Dice value= " + diceValue);
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
                        break;
                    case snake:
                        jump = -diceValue;
                        Console.WriteLine("Snake: Jump= " + jump);
                        break;
                }
                        currentPosition += jump;
                        Console.WriteLine("Position after this die roll: " + currentPosition);
                        if (currentPosition < 0)
                        {
                            currentPosition = startPosition;
                            Console.WriteLine("Position reset to: " + currentPosition);
                        }
                }
            Console.WriteLine("Congratuation!! You Won the game");
            Console.ReadKey();
            }
       
        }
    }



