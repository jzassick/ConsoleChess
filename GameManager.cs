using ConsoleChess.chess_pieces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleChess
{
    internal class GameManager
    {
        private Tile[,] gameBoard { get; }
        private Hashtable letters = new Hashtable();

        // initialize the gameboard for a new game of chess
        public GameManager()
        {
            this.gameBoard = new Tile[8, 8];
            bool isWhite = true;
            letters.Add("a", 0);
            letters.Add("b", 1);
            letters.Add("c", 2);
            letters.Add("d", 3);
            letters.Add("e", 4);
            letters.Add("f", 5);
            letters.Add("g", 6);
            letters.Add("h", 7);
            // generate the empty tiles and pawns
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j is 1) { gameBoard[i, j] = new Tile(isWhite, new Pawn(true)); }
                    else if (j is 6) { gameBoard[i, j] = new Tile(isWhite, new Pawn(false)); }
                    else { gameBoard[i, j] = new Tile(isWhite, new Empty()); }
                    if (j < 7) { isWhite = !isWhite; }
                }
            }
            // generate the rooks, knights, bishops, king, and queen
            gameBoard[0, 0].changePiece(new Rook(true));
            gameBoard[7, 0].changePiece(new Rook(true));
            gameBoard[0, 7].changePiece(new Rook(false));
            gameBoard[7, 7].changePiece(new Rook(false));
            gameBoard[1, 0].changePiece(new Knight(true));
            gameBoard[6, 0].changePiece(new Knight(true));
            gameBoard[1, 7].changePiece(new Knight(false));
            gameBoard[6, 7].changePiece(new Knight(false));
            gameBoard[2, 0].changePiece(new Bishop(true));
            gameBoard[5, 0].changePiece(new Bishop(true));
            gameBoard[2, 7].changePiece(new Bishop(false));
            gameBoard[5, 7].changePiece(new Bishop(false));
            gameBoard[3, 0].changePiece(new Queen(true));
            gameBoard[3, 7].changePiece(new Queen(false));
            gameBoard[4, 0].changePiece(new King(true));
            gameBoard[4, 7].changePiece(new King(false));
        }

        // prints the current state of the gameboard
        public void printBoard()
        {
            // prints the border and column letters
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
                    // prints the border and row numbers
                    if (j == 7 && i < 7) {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(Console.BackgroundColor = ConsoleColor.Black);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(i+2);
                    }
                }
            }
            // fixes border coloring
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(Console.BackgroundColor = ConsoleColor.Black);
            Console.ForegroundColor = ConsoleColor.White;
        }
        // this function processes a move
        public bool processMove(string move)
        {
            int firstLet = (int)letters[key: move[..1]];
            int secondLet = (int)letters[key: move.Substring(3, 1)];
            int firstNum = Int32.Parse(move.Substring(1, 1))-1;
            int secondNum = Int32.Parse(move.Substring(4, 1))-1;
            Piece origin = gameBoard[firstNum, firstLet].getPiece();
            Piece destination = gameBoard[secondNum, secondLet].getPiece();

            if (origin.isValidMove(firstNum, firstLet, secondNum, secondLet, gameBoard))
            {
                gameBoard[firstNum, firstLet].changePiece(new Empty());
                gameBoard[secondNum, secondLet].changePiece(origin);
                return true;
            }
            return false;
        }
    }
}
