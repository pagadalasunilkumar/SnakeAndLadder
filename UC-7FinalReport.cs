using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    internal class UC_7FinalReport
    {static void Main(string[] args)
    {
        // Assuming both players are initially at position 0
        int player1Position = 0;
        int player2Position = 0;

        // Creating an instance of the random number generator
        Random random = new Random();

        int diceRollCount = 0;  // To keep track of the number of times the dice was rolled

        bool player1Turn = true;  // To keep track of whose turn it is

        while (player1Position != 100 && player2Position != 100)
        {
            // Determine the player position and name based on the current turn
            int currentPlayerPosition = player1Turn ? player1Position : player2Position;
            string currentPlayerName = player1Turn ? "Player 1" : "Player 2";

            // Rolling the die
            int dieRoll = random.Next(1, 7);  // Assuming a standard six-sided die

            // Checking for options
            int option = random.Next(1, 4);  // Generating a random number between 1 and 3

            diceRollCount++;  // Incrementing the dice roll count

            switch (option)
            {
                case 1:
                    // No Play option
                    Console.WriteLine($"{currentPlayerName} rolls {dieRoll}. No Play. {currentPlayerName} stays at position {currentPlayerPosition}.");
                    break;
                case 2:
                    // Ladder option
                    currentPlayerPosition += dieRoll;
                    Console.WriteLine($"{currentPlayerName} rolls {dieRoll}. Ladder! {currentPlayerName} moves ahead by {dieRoll} positions. New position: {currentPlayerPosition}");

                    // Check if the player gets another turn due to ladder
                    if (currentPlayerPosition == 100)
                        break;
                    else if (currentPlayerPosition > 100)
                    {
                        currentPlayerPosition -= dieRoll;
                        Console.WriteLine($"{currentPlayerName} needs to reach exactly 100. They stay at the previous position: {currentPlayerPosition}");
                    }
                    else
                        player1Turn = !player1Turn;  // Switch to the other player's turn
                    break;
                case 3:
                    // Snake option
                    currentPlayerPosition -= dieRoll;
                    if (currentPlayerPosition < 0)
                        currentPlayerPosition = 0;
                    Console.WriteLine($"{currentPlayerName} rolls {dieRoll}. Snake! {currentPlayerName} moves behind by {dieRoll} positions. New position: {currentPlayerPosition}");
                    player1Turn = !player1Turn;  // Switch to the other player's turn
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            // Update the respective player's position based on the turn
            if (player1Turn)
                player1Position = currentPlayerPosition;
            else
                player2Position = currentPlayerPosition;
        }

        // Determine and report the winner
        string winner = player1Position == 100 ? "Player 1" : "Player 2";
        Console.WriteLine($"{winner} wins the game!");

        Console.WriteLine($"Total dice rolls: {diceRollCount}");
    }
}
    }
}
