﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    internal class GameManager
    {
        object[,] gameBoard;
        public GameManager()
        {
            gameBoard = new object[8, 8];
        }
    }
}
