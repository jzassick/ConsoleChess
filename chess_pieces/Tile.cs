using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.chess_pieces
{
    internal class Tile
    {
        // stores the tile board color (white or blue)
        private bool TileIsWhite { get; set; }

        // stores the piece on the tile square
        private Piece piece { get; set; }
        public Tile(bool TileIsWhite, Piece piece)
        {
            this.TileIsWhite = TileIsWhite;
            this.piece = piece;
        }
        public void printTile()
        {
            if (TileIsWhite)
            {
                if (piece.pieceIsBlack())
                {
                    Console.Write(piece.printPiece(), Console.BackgroundColor = ConsoleColor.White, Console.ForegroundColor = ConsoleColor.Black);
                }
                else
                {
                    Console.Write(piece.printPiece(), Console.BackgroundColor = ConsoleColor.White, Console.ForegroundColor = ConsoleColor.DarkMagenta);
                }
            }
            else
            {
                if (piece.pieceIsBlack())
                {
                    Console.Write(piece.printPiece(), Console.BackgroundColor = ConsoleColor.DarkGray, Console.ForegroundColor = ConsoleColor.Black);
                }
                else
                {
                    Console.Write(piece.printPiece(), Console.BackgroundColor = ConsoleColor.DarkGray, Console.ForegroundColor = ConsoleColor.DarkMagenta);
                }
            }
        }

    }
}
