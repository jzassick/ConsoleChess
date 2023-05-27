using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.chess_pieces
{
    internal class Pawn : Piece
    {
        bool isBlack;
        public Pawn(bool isBlack)
        {
            this.isBlack = isBlack;
        }
        public string printPiece() => "P";

        public bool pieceIsBlack() => this.isBlack;
    }
}
