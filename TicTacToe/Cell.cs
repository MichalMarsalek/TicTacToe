﻿namespace TicTacToe
{
    public struct Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
