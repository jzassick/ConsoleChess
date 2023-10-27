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
        bool notMoved;
        public Pawn(bool isBlack)
        {
            this.isBlack = isBlack;
            this.notMoved = true;
        }
        public string printPiece() => "P";

        public bool pieceIsBlack() => this.isBlack;

        public bool isValidMove(int originRow, int originCol, int destRow, int destCol, Tile[,] board)
        {
            return true;
        }
    }
}
