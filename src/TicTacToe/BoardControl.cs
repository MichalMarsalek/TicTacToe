using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TicTacToe
{
    public partial class BoardControl : UserControl
    {
        public Game Game { get; set; }
        public float CellSize { get; private set; }
        public Cell MouseOverCell { get; private set; }
        public BoardControl()
        {
            InitializeComponent();
            MouseOverCell = new Cell(-1, -1);
        }

        //RENDERING
        #region Rendering
        protected override void OnPaint(PaintEventArgs e)
        {
            if(Game == null){
                return;
            }
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            DrawGrid(g);
            DrawCells(g);
            if (Game.State == Game.GameState.OWon || Game.State == Game.GameState.XWon)
            {
                DrawWin(g);
            }
        }
        private void DrawGrid(Graphics g)
        {
            float fX = (float)(Width - 1) / Game.Size.Width;
            float fY = (float)(Height - 1) / Game.Size.Height;
            CellSize = Math.Min(fX, fY);
            for (int i = 0; i <= Game.Size.Width; i++)
            {
                g.DrawLine(Pens.Black, i * CellSize, 0, i * CellSize, Game.Size.Height * CellSize);
            }
            for (int i = 0; i <= Game.Size.Height; i++)
            {
                g.DrawLine(Pens.Black, 0, i * CellSize, Game.Size.Width * CellSize, i * CellSize);
            }
        }

        private void DrawCells(Graphics g)
        {
            for (int i = 0; i < Game.Size.Width; i++)
            {
                for (int j = 0; j < Game.Size.Height; j++)
                {
                    Cell cCell = new Cell(i, j);
                    Game.Mark cCellMark = Game.BoardState[i, j];
                    if (cCellMark == Game.Mark.None)
                    {
                        if (MouseOverCell.Equals(cCell) && Game.State == Game.GameState.Ongoing && Game.CanHumanGo(cCell)){
                            DrawMark(g, Game.PlayerOnTurn, cCell, true, false, 1f);
                        }
                    }
                    else {
                        bool last = Game.BoardState.LastO.Equals(cCell) || Game.BoardState.LastX.Equals(cCell);
                        DrawMark(g, cCellMark, cCell, false, last, Game.BoardState.Completion(cCell));
                    }
                }
            }
        }
        
        private void DrawMark(Graphics g, Game.Mark mark, Cell cell, bool preview, bool last, float completion)
        {
            float markX = ((float)cell.X + 0.2f) * CellSize;
            float markY = ((float)cell.Y + 0.2f) * CellSize;
            float markLength = 0.6f * CellSize;
            float penWidth = CellSize * (last ? 3 : 1) / 20f;
            RectangleF markRect = new RectangleF(markX, markY, markLength, markLength);
            if(mark == Game.Mark.O)
            {
                Color color = preview ? Color.LightBlue : Color.Blue;
                Pen pen = new Pen(color, penWidth);
                DrawO(g, markRect, pen, completion);
            }
            if (mark == Game.Mark.X)
            {
                Color color = preview ? Color.Pink : Color.Red;
                Pen pen = new Pen(color, penWidth);
                DrawX(g, markRect, pen, completion);
            }
        }
        private void DrawO(Graphics g, RectangleF rect, Pen pen, float completion)
        {
            g.DrawArc(pen, rect, 0, 360*completion);
        }
        private void DrawX(Graphics g, RectangleF rect, Pen pen, float completion)
        {
            float d1 = (rect.Right - rect.Left) * Math.Min(1f, 2.5f * completion);
            float d2 = (rect.Right - rect.Left) * Math.Max(0f, 2.5f * (completion - 0.6f));
            g.DrawLine(pen, rect.Left, rect.Top, rect.Left + d1, rect.Top + d1);
            g.DrawLine(pen, rect.Right, rect.Top, rect.Right - d2, rect.Top + d2);
        }
        private void DrawWin(Graphics g)
        {
            float penWidth = CellSize / 5f;
            Pen pen = new Pen(Color.Yellow, penWidth);
            float mark1X = ((float)Game.WinningQuintuplet.Cells[0].X + 0.5f) * CellSize;
            float mark1Y = ((float)Game.WinningQuintuplet.Cells[0].Y + 0.5f) * CellSize;
            float mark2X = ((float)Game.WinningQuintuplet.Cells[4].X + 0.5f) * CellSize;
            float mark2Y = ((float)Game.WinningQuintuplet.Cells[4].Y + 0.5f) * CellSize;
            g.DrawLine(pen, mark1X, mark1Y, mark2X, mark2Y);
        }
        #endregion

        //USER INTERACTION
        #region User Interaction
        protected override void OnMouseMove(MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
            MouseOverCell = MouseLoc2Cell(e.Location);
            Cursor = Game.CanHumanGo(MouseOverCell) ? Cursors.Hand : Cursors.Arrow;
            Refresh();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            MouseOverCell = new Cell(-1, -1);
            Refresh();
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            MouseOverCell = MouseLoc2Cell(e.Location);
            if (Game.CanHumanGo(MouseOverCell))
            {
                Game.HumanMove(MouseOverCell);
            }
        }        
        private Cell MouseLoc2Cell(Point mouseLoc)
        {
            int x = (int)Math.Floor((float)mouseLoc.X / CellSize);
            int y = (int)Math.Floor((float)mouseLoc.Y / CellSize);
            return new Cell(x, y);
        }

        #endregion
    }
}
