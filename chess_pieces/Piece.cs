﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.chess_pieces
{
    internal interface Piece
    {
        string printPiece();

        bool pieceIsBlack();
    }
}
