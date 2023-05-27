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
    }
}
