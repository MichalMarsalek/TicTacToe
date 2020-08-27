using System.Drawing;

namespace TicTacToe
{
    public struct Direction
    {
        public readonly int X;
        public readonly int Y;
        public Direction(int code)
        {
            Point[] directions = new Point[] { new Point(0, -1), new Point(1, -1), new Point(1, 0), new Point(1,1) };
            X = directions[code].X;
            Y = directions[code].Y;
        }        
    }
}
