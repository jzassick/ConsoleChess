using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.chess_pieces
{
    internal class King : Piece
    {
        bool isBlack;
        public King(bool isBlack)
        {
            this.isBlack = isBlack;
        }
        public string printPiece() => "K";

        public bool pieceIsBlack() => this.isBlack;
    }
}
