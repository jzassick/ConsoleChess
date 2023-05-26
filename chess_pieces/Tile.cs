using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.chess_pieces
{
    internal class Tile
    {
        private bool isWhite { get; set; }
        private Piece piece { get; set; }
        public Tile(bool isWhite, Piece piece)
        {
            this.isWhite = isWhite;
            this.piece = piece;
        }
        public void printTile()
        {
            if (isWhite)
            {
                Console.Write(piece.printPiece(),Console.BackgroundColor = ConsoleColor.White, Console.ForegroundColor = ConsoleColor.Black);
            }
            else
            {
                Console.Write(piece.printPiece(), Console.BackgroundColor = ConsoleColor.Blue, Console.ForegroundColor = ConsoleColor.Black);
            }
        }

    }
}
