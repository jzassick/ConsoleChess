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
            // move left
            if (destCol < originCol && destRow == originRow)
            {
                for (int i = originCol-1; i > destCol; i--)
                {
                    if (board[destRow, i].getPiece() is not Empty) { return false; }
                }
                return true;
            }
            // move right
            else if (destCol > originCol && destRow == originRow)
            {
                for (int i = originCol+1; i < destCol; i++)
                {
                    if (board[destRow, i].getPiece() is not Empty) { return false; }
                }
                return true;
            }
            // move up
            else if (destCol == originCol && destRow < originRow)
            {
                for (int i = originRow - 1; i > destRow; i--)
                {
                    if (board[i, destCol].getPiece() is not Empty) { return false; }
                }
                return true;
            }
            // move down
            else if (destCol == originCol && destRow > originRow)
            {
                for (int i = originRow + 1; i < destRow; i++)
                {
                    if (board[i, destCol].getPiece() is not Empty) { return false; }
                }
                return true;
            }
            return false;
        }
    }
}