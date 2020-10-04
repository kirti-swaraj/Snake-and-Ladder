using System;

namespace SnakeAndLadder
{
    class Program
    {
       static void Main(string[] args)
            {
                Console.WriteLine("Snake and Ladder game for single player\n");
                int startPosition = 0;
                Console.WriteLine("Start Position= " + startPosition);

                //Rolling of die to get a random number
                Random random = new Random();
                int diceValue = random.Next(1, 7);
                Console.WriteLine("Dice value= " + diceValue);
            Console.ReadKey();
            }

        }
    }