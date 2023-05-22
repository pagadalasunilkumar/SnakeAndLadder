using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    internal class UC_1startingposition
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder game!");

            int position = 0;
            int diceValue;
            int count = 0;

            while (position < 100)
            {
                count++;
                Console.WriteLine("Press any key to roll the dice...");
                Console.ReadKey();

                Random random = new Random();
                diceValue = random.Next(1, 7);
                Console.WriteLine("You rolled a " + diceValue);

                position += diceValue;

                if (position > 100)
                {
                    position -= diceValue;
                    Console.WriteLine("Oops! You need " + (100 - position) + " to win. Try again.");
                }
                else
                {
                    Console.WriteLine("You are now at position " + position);

                    switch (position)
                    {
                        case 3:
                            position = 22;
                            Console.WriteLine("You climbed a ladder and jumped to position 22!");
                            break;
                        case 8:
                            position = 30;
                            Console.WriteLine("You climbed a ladder and jumped to position 30!");
                            break;
                        case 18:
                            position = 52;
                            Console.WriteLine("You climbed a ladder and jumped to position 52!");
                            break;
                        case 26:
                            position = 10;
                            Console.WriteLine("Oops! You got bitten by a snake and moved back to position 10!");
                            break;
                        case 39:
                            position = 61;
                            Console.WriteLine("You climbed a ladder and jumped to position 61!");
                            break;
                        case 51:
                            position = 67;
                            Console.WriteLine("You climbed a ladder and jumped to position 67!");
                            break;
                        case 56:
                            position = 53;
                            Console.WriteLine("Oops! You got bitten by a snake and moved back to position 53!");
                            break;
                        case 60:
                            position = 85;
                            Console.WriteLine("You climbed a ladder and jumped to position 85!");
                            break;
                        case 75:
                            position = 28;
                            Console.WriteLine("Oops! You got bitten by a snake and moved back to position 28!");
                            break;
                        case 80:
                            position = 100;
                            Console.WriteLine("Congratulations! You climbed the ladder and reached position 100! You win!");
                            break;
                    }
                }
            }

            Console.WriteLine("Game over! Total rolls: " + count);
            Console.ReadKey();
        }
    }

}

