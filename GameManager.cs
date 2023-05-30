﻿using ConsoleChess.chess_pieces;
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

        // initialize the gameboard for a new game of chess
        public GameManager()
        {
            this.gameBoard = new Tile[8, 8];
            bool isWhite = true;

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
    }
}
