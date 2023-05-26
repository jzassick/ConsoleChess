using ConsoleChess.chess_pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    internal class GameManager
    {
        private Tile[,] gameBoard { get; }
        public GameManager()
        {
            this.gameBoard = new Tile[8, 8];
            bool isWhite = true;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j is 0 or 7) { gameBoard[i, j] = new Tile(isWhite, new Pawn()); }
                    else { gameBoard[i, j] = new Tile(isWhite, new Empty()); }
                    if (j < 7) { isWhite = !isWhite; }
                }
            }
        }
        public void printBoard()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" abcdefgh");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(Console.BackgroundColor = ConsoleColor.Black);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1", Console.BackgroundColor = ConsoleColor.Red);
            for (int i = 0;i < 8;i++)
            {
                for (int j = 0;j < 8; j++)
                {
                    gameBoard[i,j].printTile();
                    if (j == 7 && i < 7) {
                        Console.WriteLine(Console.BackgroundColor = ConsoleColor.Black);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(i+2);
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(Console.BackgroundColor = ConsoleColor.Black);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
