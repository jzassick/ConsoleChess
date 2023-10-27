using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.chess_pieces
{
    internal class Rook : Piece
    {
        bool isBlack;
        public Rook(bool isBlack)
        {
            this.isBlack = isBlack;
        }
        public string printPiece() => "R";

        public bool pieceIsBlack() => this.isBlack;

        public bool isValidMove(int originRow, int originCol, int destRow, int destCol, Tile[,] board)
        {
            return true;
        }
    }
}