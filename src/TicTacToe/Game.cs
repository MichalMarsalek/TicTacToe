using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;

namespace TicTacToe
{
    public class Game
    {
        // ATRIBUTTES
        #region Attributes
        public Dictionary<Mark, Player> PlayerTypes { get; private set; }
        public Size Size { get; private set; }
        public BoardState BoardState { get; private set; }
        public Mark PlayerOnTurn { get; private set; }
        public GameState State { get; private set; }
        public Openings Opening;
        public Quintuplet WinningQuintuplet { get; private set; }
        public int CompODeffQ { get; private set; }
        public int CompXDeffQ { get; private set; }
        public int MoveDuration { get; private set; }
        public DateTime LastMoveTime { get; private set; }
        public bool Skippable { get; private set; }
        public bool LastMoveFinished
        {
            get
            {
                return DateTime.Now >= LastMoveTime + TimeSpan.FromMilliseconds(MoveDuration);
            }
        }
        public bool LastMoveFinishedReserve
        {
            get
            {
                return DateTime.Now >= LastMoveTime + TimeSpan.FromMilliseconds(MoveDuration*2);
            }
        }
        #endregion

        //ENUMS
        #region Enums
        public enum GameState
        {
            Ongoing, OWon, XWon, Draw
        }

        public enum Player
        {
            Human, Computer
        }

        public enum Mark
        {
            None, O, X
        }
        public enum Openings
        {
            Classic, Swap1, Swap2
        }
        #endregion

        //CONSTRUCTOR
        #region Constructor
        public Game(Size boardSize, Player playerO, Player playerX, Mark starts, Openings opening, int compODeffQ, int compXDeffQ, int moveDuration)
        {
            BoardState = new BoardState(boardSize, moveDuration);
            PlayerTypes = new Dictionary<Mark, Player>();
            PlayerTypes.Add(Mark.O, playerO);
            PlayerTypes.Add(Mark.X, playerX);
            Size = boardSize;
            Opening = opening;
            CompODeffQ = compODeffQ;
            CompXDeffQ = compXDeffQ;
            MoveDuration = moveDuration;
            PlayerOnTurn = starts;
            if (starts == Mark.None)
            {
                Random rng = new Random();
                PlayerOnTurn = rng.Next(2) == 0 ? Mark.O : Mark.X;
            }
            NextMove(true);
        }
        #endregion

        //MOVES CONTROLLERS
        #region Moves
        public void HumanMove(Cell move)
        {
            Skippable = false;
            BoardState[move] = PlayerOnTurn;
            CheckState(move);
            NextMove();
        }
        private void CheckState(Cell move)
        {
            Solver solver = new Solver(BoardState);
            WinningQuintuplet = solver.Check4Win(move, PlayerOnTurn);
            bool win = WinningQuintuplet != null;
            if (win)
            {
                State = PlayerOnTurn == Mark.O ? GameState.OWon : GameState.XWon;
            }
            if (BoardState.MarksPlaced == Size.Width * Size.Height)
            {
                State = Game.GameState.Draw;
            }
        }
        private void NextMove(bool first = false)
        {
            LastMoveTime = DateTime.Now;
            if (State == GameState.Ongoing)
            {
                LastMoveTime = DateTime.Now - TimeSpan.FromDays(1);
                if (!first)
                {
                    LastMoveTime = DateTime.Now;
                    PlayerOnTurn = PlayerOnTurn == Mark.X ? Mark.O : Mark.X;
                    ProvideOpening();
                }
                if (PlayerTypes[PlayerOnTurn] == Player.Computer)
                {
                    ComputerMove();
                }
            }
        }
        private void ProvideOpening()
        {
            if (Opening != Openings.Classic && BoardState.MarksPlaced < 3 || Opening == Openings.Swap2 && BoardState.MarksPlaced == 4)
            {
                SwapMarks();
            }
            if(Opening != Openings.Classic && BoardState.MarksPlaced == 3 || Opening == Openings.Swap2 && BoardState.MarksPlaced == 4)
            {
                if(PlayerTypes[PlayerOnTurn] == Player.Human)
                {
                    Skippable = true;
                }
            }
        }
        public void TrySkipping()
        {
            if (Skippable)
            {
                SwapMarks();
                NextMove(true);
                Skippable = false;
            }
        }
        private void SwapMarks()
        {
            Player formerX = PlayerTypes[Mark.X];
            PlayerTypes[Mark.X] = PlayerTypes[Mark.O];
            PlayerTypes[Mark.O] = formerX;
        }
        private void ComputerMove()
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += Bgw_DoWork;
            bgw.RunWorkerCompleted += Bgw_Completed;
            bgw.RunWorkerAsync();
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Solver solver = new Solver(BoardState, PlayerOnTurn == Mark.O ? CompODeffQ : CompXDeffQ);
            e.Result = solver.Solve(PlayerOnTurn);
            if(!LastMoveFinished)
            {
                Thread.Sleep(LastMoveTime + TimeSpan.FromMilliseconds(MoveDuration) - DateTime.Now);
            }
        }

        private void Bgw_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            Cell solvedMove = (Cell)e.Result;
            BoardState[solvedMove] = PlayerOnTurn;
            CheckState(solvedMove);
            NextMove();
        }

        #endregion

        //VALIDATING MOVES
        #region Moves validation
        public static bool Validate(BoardState boardState, Cell move)
        {
            if (move.X < 0 || move.X >= boardState.Size.Width)
                return false;
            if (move.Y < 0 || move.Y >= boardState.Size.Height)
                return false;
            return boardState[move] == Mark.None;
        }

        public bool CanHumanGo(Cell cell)
        {
            return State == GameState.Ongoing && PlayerTypes[PlayerOnTurn] == Player.Human && Validate(BoardState, cell) && LastMoveFinished;
        }
        
        #endregion
    }
}
