using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Solver
    {
        public BoardState BoardState { get; private set; }
        public double DeffensiveQ { get; private set; }

        public Solver(BoardState state, double deffensiveQ = 1)
        {
            BoardState = state;
            DeffensiveQ = (deffensiveQ + 1) / 2d;
        }
        public Cell SolveRandom(Game.Mark mark)
        {
            int x, y;
            int width = BoardState.Size.Width;
            int height = BoardState.Size.Height;
            Random rng = new Random();
            do
            {
                x = rng.Next(width);
                y = rng.Next(height);
            }
            while (!Game.Validate(BoardState, new Cell(x, y)));
            return new Cell(x, y);
        }
        public Cell Solve(Game.Mark mark)
        {
            double bestScore = -1;
            List<Cell> bestCells = new List<Cell>();
            for (int i = 0; i < BoardState.Size.Width; i++)
            {
                for (int j = 0; j < BoardState.Size.Height; j++)
                {
                    Cell cCell = new Cell(i, j);
                    if(BoardState[cCell] != Game.Mark.None)
                    {
                        continue;
                    }
                    List<Quintuplet> quins = GetCellQuintuplets(cCell);
                    double score = 0;
                    foreach(Quintuplet quin in quins)
                    {
                        score += EvalQuintuplet(quin, mark, BoardState);
                    }
                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestCells = new List<Cell>();
                        bestCells.Add(cCell);
                    }
                    else if (score == bestScore)
                    {
                        bestCells.Add(cCell);
                    }
                }
            }
            Random rng = new Random();
            return bestCells[rng.Next(bestCells.Count())];
        }
        private double EvalQuintuplet(Quintuplet quin, Game.Mark mark, BoardState boardState)
        {
            int[] evaluationKeyHis = { 1, 2, 10, 200, 10000 };
            int[] evaluationKeyMy = { 1, 4, 50, 1000, 585858 };
            int myMarks = 0;
            int hisMarks = 0;
            for(int i = 0; i < 5; i++)
            {
                if(boardState[quin.Cells[i]] == mark)
                {
                    myMarks++;
                }
                else if (boardState[quin.Cells[i]] != Game.Mark.None)
                {
                    hisMarks++;
                }
            }

            if(myMarks != 0 && hisMarks != 0)
            {
                return 0;
            }
            else if(myMarks == 0)
            {
                return DeffensiveQ*(double)evaluationKeyHis[hisMarks];
            }
            return evaluationKeyMy[myMarks];
        }

        private List<Quintuplet> GetCellQuintuplets(Cell cell)
        {
            List<Quintuplet> cellQuins = new List<Quintuplet>();
            for(int direction = 0; direction < 4; direction++)
            {
                for(int shift = -4; shift <= 0; shift++)
                {
                    Quintuplet quintuplet = new Quintuplet(cell, new Direction(direction), shift);
                    if (quintuplet.Validate(BoardState.Size))
                    {
                        cellQuins.Add(quintuplet);
                    }
                }
            }
            return cellQuins;
        }
        public Quintuplet Check4Win(Cell cell, Game.Mark mark)
        {
            List<Quintuplet> cellQuins = GetCellQuintuplets(cell);
            foreach(Quintuplet quintuplet in cellQuins)
            {
                bool win = true;
                for (int i = 0; i < 5; i++)
                {
                    if(BoardState[quintuplet.Cells[i]] != mark)
                    {
                        win = false;
                        break;
                    }
                }
                if (win)
                {
                    return quintuplet;
                }
            }
            return null;
        }
    }
}
