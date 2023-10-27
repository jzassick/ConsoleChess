using ConsoleChess;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        bool gameOver = false;
        Console.WriteLine("Let's play chess");
        GameManager gameManager = new();
        gameManager.printBoard();

        // query the user for a move until the game is over
        while (!gameOver) {
            Console.WriteLine("Your turn. Enter a move in the form of letter number letter number (example: a1 b1).");
            string move = Console.ReadLine();
            if (move == null || move == "") { continue; }
            else if (!Regex.IsMatch(move, "^[a-h][1-8] [a-h][1-8]$")) 
            {
                Console.WriteLine("Invalid move");
                continue;
            }
            else if (gameManager.processMove(move))
            {
                gameManager.printBoard();
            }
            else { Console.WriteLine("That is not a valid move. Pick a different move."); }
        }
    }
}