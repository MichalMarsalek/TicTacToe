using System.Drawing;

namespace TicTacToe
{
    public class Quintuplet
    {
        public Cell[] Cells { get; private set; }

        public Quintuplet(params Cell[] cells)
        {
            Cells = cells;
        }

        public Quintuplet(Cell cell0, Direction dir, int shift)
        {
            Cells = new Cell[5];
            for (int i = 0; i < 5; i++)
            {
                Cells[i] = new Cell(cell0.X + (i + shift) * dir.X, cell0.Y + (i + shift) * dir.Y);
            }
        }
        public bool Validate(Size boardSize)
        {
            foreach(Cell cell in Cells)
            {
                if(cell.X < 0 || cell.Y < 0 || cell.X >= boardSize.Width || cell.Y >= boardSize.Height)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
