using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class SettingsForm : Form
    {
        private DateTime aboutSelected;
        public SettingsForm()
        {
            InitializeComponent();
            Locale.AddLocale("", Properties.Resources.en);
            Locale.AddLocale("cs", Properties.Resources.cs);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            comboBoxLocalization.Items.AddRange(Locale.Locales.ToArray());
            comboBoxLocalization.SelectedItem = Locale.GetBestLocale();
        }

        private void LocalizeForm()
        {
            Locale.SetLocale(((LocaleID)comboBoxLocalization.SelectedItem).Value);
            Locale.LocalizeControl(this);
            labelVersion.Text = Locale.T("TicTacToe") + " " + Properties.Resources.Version;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            Size size = new Size((int)NumberWidth.Value, (int)NumberHeight.Value);
            Game.Player playerO = RadioOComputer.Checked == true ? Game.Player.Computer : Game.Player.Human;
            Game.Player playerX = RadioXComputer.Checked == true ? Game.Player.Computer : Game.Player.Human;
            Game.Mark starts = RadioStartsO.Checked == true ? Game.Mark.O : (RadioStartsX.Checked == true ? Game.Mark.X : Game.Mark.None);
            Game.Openings opening = RadioClassic.Checked == true ? Game.Openings.Classic : (RadioSwap1.Checked ? Game.Openings.Swap1 : Game.Openings.Swap2);
            gameForm.InitGame(size, playerO, playerX, starts, opening, SliderODeffQ.Value, SliderXDeffQ.Value, (int)numericUpDownMoveDuration.Value);
            gameForm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            this.Hide();
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private Color GetColor()
        {
            ColorDialog.ShowDialog();
            return ColorDialog.Color;
        }
        private void ButtonTest_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex == 2)
            {
                animatedIcon.Completion = 0;
                animatedIcon.Refresh();
                aboutSelected = DateTime.Now;
                timer.Start();
            }
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            animatedIcon.Completion = (float)Math.Min(2f, (1f * (DateTime.Now - aboutSelected).TotalMilliseconds / (float)numericUpDownMoveDuration.Value));
            if (animatedIcon.Completion == 2)
            {
                timer.Stop();
            }
            animatedIcon.Refresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://michalmarsalek.cz");
        }

        private void comboBoxLocalization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLocalization.SelectedItem != null)
            {
                LocalizeForm();
            }
        }

    }
}
