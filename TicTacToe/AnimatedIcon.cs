using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TicTacToe
{
    public partial class AnimatedIcon : UserControl
    {
        [Category("Data"), Description("Completion.")]
        public float Completion { get; set; }
        public AnimatedIcon()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            float d1 = 50 * Math.Min(1f, 2.5f * Completion);
            float d2 = 50 * Math.Min(1f, Math.Max(0f, 2.5f * (Completion - 0.6f)));
            Pen pen = new Pen(Color.Blue, 10);
            float completion2 = Math.Max(0, Completion - 1);
            g.DrawArc(pen, new RectangleF(40, 40, 50, 50), 0, 360 * completion2);
            pen = new Pen(Color.Red, 10);
            g.DrawLine(pen, 10, 10, 10 + d1, 10 + d1);
            g.DrawLine(pen, 60, 10, 60 - d2, 10 + d2);
        }
    }
}
