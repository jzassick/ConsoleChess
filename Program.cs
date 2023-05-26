using ConsoleChess;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Let's play chess");
        GameManager gameManager = new();
        gameManager.printBoard();
    }
}