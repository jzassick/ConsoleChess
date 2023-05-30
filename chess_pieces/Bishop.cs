using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.chess_pieces
{
    internal class Bishop : Piece
    {
        bool isBlack;
        public Bishop(bool isBlack)
        {
            this.isBlack = isBlack;
        }
        public string printPiece() => "B";

        public bool pieceIsBlack() => this.isBlack;
    }
}
