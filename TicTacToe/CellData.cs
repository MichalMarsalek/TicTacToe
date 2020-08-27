using System;

namespace TicTacToe
{
    public class CellData
    {
        public DateTime Placed { get; private set; }
        public Game.Mark Mark { get; private set; }
        public float Completion(int moveDuration)
        {
            return (float)Math.Min(1f, (float)(DateTime.Now - Placed).TotalMilliseconds / moveDuration);
        }
        public CellData(Game.Mark mark)
        {
            Mark = mark;
            Placed = DateTime.Now;
        }
    }
}
