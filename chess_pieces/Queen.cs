using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.chess_pieces
{
    internal class Queen : Piece
    {
        bool isBlack;
        public Queen(bool isBlack)
        {
            this.isBlack = isBlack;
        }
        public string printPiece() => "Q";

        public bool pieceIsBlack() => this.isBlack;
    }
}
