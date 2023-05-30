using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.chess_pieces
{
    internal class Knight : Piece
    {
        bool isBlack;
        public Knight(bool isBlack)
        {
            this.isBlack = isBlack;
        }
        public string printPiece() => "k";

        public bool pieceIsBlack() => this.isBlack;
    }
}
