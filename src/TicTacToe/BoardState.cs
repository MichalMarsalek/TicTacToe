using System.Drawing;

namespace TicTacToe
{
    public class BoardState
    {
        public Size Size { get; private set; }
        private CellData[,] cells;
        public Cell LastX { get; private set; }
        public Cell LastO { get; private set; }
        public int MarksPlaced { get; private set; }
        public int MoveDuration { get; private set; }

        public BoardState(int width, int height, int moveDuration)
            : this(new Size(width, height), moveDuration) { }
        public BoardState(Size size, int moveDuration)
        {
            Size = size;
            cells = new CellData[size.Width, size.Height];
            MoveDuration = moveDuration;
        }

        public Game.Mark this[Cell key]
        {
            get
            {
                return this[key.X, key.Y];
            }
            set
            {
                this[key.X, key.Y] = value;
            }
        }

        public Game.Mark this[int x, int y]
        {
            get
            {
                return cells[x, y] == null ? Game.Mark.None : cells[x, y].Mark;
            }
            set
            {
                cells[x, y] = new CellData(value);
                if (value == Game.Mark.X)
                {
                    LastX = new Cell(x, y);
                }
                else
                {
                    LastO = new Cell(x, y);
                }
                MarksPlaced++;
            }
        }
        public float Completion(int x, int y)
        {
            return cells[x, y].Completion(MoveDuration);
        }
        public float Completion(Cell cell)
        {
            return Completion(cell.X, cell.Y);
        }
    }
}
