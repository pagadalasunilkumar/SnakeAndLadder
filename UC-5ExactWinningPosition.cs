using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    internal class UC_5ExactWinningPosition
    {static void Main(string[] args)
    {
        // Assuming the player is initially at position 0
        int playerPosition = 0;

        // Creating an instance of the random number generator
        Random random = new Random();

        while (playerPosition != 100)
        {
            // Rolling the die
            int dieRoll = random.Next(1, 7);  // Assuming a standard six-sided die

            // Checking for options
            int option = random.Next(1, 4);  // Generating a random number between 1 and 3

            switch (option)
            {
                case 1:
                    // No Play option
                    Console.WriteLine("No Play. The player stays in the same position.");
                    break;
                case 2:
                    // Ladder option
                    if (playerPosition + dieRoll <= 100)
                    {
                        playerPosition += dieRoll;
                        Console.WriteLine($"Ladder! The player moves ahead by {dieRoll} positions. New position: {playerPosition}");
                    }
                    else
                    {
                        Console.WriteLine("Ladder! But the player cannot move beyond the winning position of 100. The player stays in the same position.");
                    }
                    break;
                case 3:
                    // Snake option
                    playerPosition -= dieRoll;
                    if (playerPosition < 0)
                        playerPosition = 0;
                    Console.WriteLine($"Snake! The player moves behind by {dieRoll} positions. New position: {playerPosition}");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        Console.WriteLine("Congratulations! The player has reached the winning position of 100.");
    }
}
    }

    }
}
