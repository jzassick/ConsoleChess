using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.chess_pieces
{
    internal class Empty : Piece
    {
        public Empty()
        {
        }
        public string printPiece() => " ";

        public bool pieceIsBlack() => true;

        public bool isValidMove(int originRow, int originCol, int destRow, int destCol, Tile[,] board)
        {
            return false;
        }
    }
}
