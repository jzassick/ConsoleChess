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
            if (this.isBlack)
            {
                // check moving forward one move
                if (originRow == destRow && destCol == originCol+1 && board[destRow, destCol].getPiece() is Empty)
                {
                    this.notMoved = false;
                    return true;
                }
                // check moving forward two moves on first pawn move
                else if (originRow == destRow && destCol == originCol+2 && board[destRow, destCol].getPiece() is Empty && board[destRow, destCol-1].getPiece() is Empty && this.notMoved)
                {
                    this.notMoved = false;
                    return true;
                }
                // check capture move
                else if ((destRow == originRow+1 || destRow == originRow-1) && destCol == originCol+1 && board[destRow, destCol].getPiece() is not Empty)
                {
                    this.notMoved = false;
                    return true;
                }
            }
            else if (!this.isBlack)
            {
                // check moving forward one move
                if (originRow == destRow && destCol == originCol-1 && board[destRow, destCol].getPiece() is Empty)
                {
                    this.notMoved = false;
                    return true;
                }
                // check moving forward two moves on first pawn move
                else if (originRow == destRow && destCol == originCol-2 && board[destRow, destCol].getPiece() is Empty && board[destRow, destCol+1].getPiece() is Empty && this.notMoved)
                {
                    this.notMoved = false;
                    return true;
                }
                // check capture move
                else if ((destRow == originRow + 1 || destRow == originRow - 1) && destCol == originCol-1 && board[destRow, destCol].getPiece() is not Empty)
                {
                    this.notMoved = false;
                    return true;
                }
            }
            return false;
        }
    }
}
