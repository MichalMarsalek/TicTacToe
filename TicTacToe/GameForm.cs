using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        public Game game;
        bool winShown;
        public GameForm()
        {
            InitializeComponent();
            
        }
        public void InitGame(Size boardSize, Game.Player playerO, Game.Player playerX, Game.Mark starts, Game.Openings opening, int compODeffQ, int compXDeffQ, int moveDuration)
        {
            game = new Game(boardSize, playerO, playerX, starts, opening, compODeffQ, compXDeffQ, moveDuration);
            BoardControl.Game = game;
        }

        private void Check4Win()
        {
            if (game.State != Game.GameState.Ongoing && !winShown && game.LastMoveFinished)
            {
                timer.Stop();
                winShown = true;
                string[] messages = { Locale.T("GameIsInProgress"), Locale.T("OWon"), Locale.T("XWon"), Locale.T("ItsDraw") };
                Text = Locale.T("TicTacToe") + " - " + messages[(int)game.State];
                DialogResult dr = MessageBox.Show(messages[(int)game.State] + "\n" + Locale.T("DoYouWantToCloseTheGame"), Locale.T("GameOver"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        
        private void BoardControl_Resize(object sender, EventArgs e)
        {
            BoardControl.Refresh();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(game.State != Game.GameState.Ongoing)
            {
                return;
            }
            DialogResult dr = MessageBox.Show(Locale.T("YourGameIsInProgressDoYouReallyWantToQuit"), Locale.T("QuitTheGame"), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            e.Cancel = dr == DialogResult.No;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            BoardControl.Refresh();
            Text = Locale.T("TicTacToe") + "- " + (game.PlayerOnTurn == Game.Mark.X ? Locale.T("ItsXTurn") : Locale.T("ItsOTurn"));
            if (game.Skippable)
            {
                Text += " - " + Locale.T("PressEscToPassTheTurnToYourOpponent");
            }
            Check4Win();
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                game.TrySkipping();
            }
        }
    }
}
