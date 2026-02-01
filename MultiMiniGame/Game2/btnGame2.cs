using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Text;

namespace MultiMiniGame.Game2
{
    public enum ButtonVisualState
    {
        Normal,
        Hover,
        Selected,
        Correct,
        Wrong,
        Disabled
    }

    public class btnGame2 : Button
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ButtonVisualState VisualState { get; set; } = ButtonVisualState.Normal;

        public btnGame2()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.ResizeRedraw,
                true
            );

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.Transparent;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 11, FontStyle.Bold);
            Cursor = Cursors.Hand;
            Size = new Size(400, 45);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle r = new Rectangle(2, 2, Width - 5, Height - 5);
            using GraphicsPath path = CreateHexPath(r);

            // 🎮 COLORS BASED ON STATE
            Color top, mid, border;

            switch (VisualState)
            {
                case ButtonVisualState.Hover:
                    top = Color.Gold;
                    mid = Color.FromArgb(240, 230, 140);
                    border = Color.Silver;
                    break;

                case ButtonVisualState.Selected:
                    top = Color.FromArgb(80, 80, 80);
                    mid = Color.FromArgb(120, 120, 120);
                    border = Color.Gold;
                    break;

                case ButtonVisualState.Correct:
                    top = Color.FromArgb(0, 140, 60);
                    mid = Color.FromArgb(0, 200, 100);
                    border = Color.Lime;
                    break;

                case ButtonVisualState.Wrong:
                    top = Color.FromArgb(150, 0, 0);
                    mid = Color.FromArgb(220, 0, 0);
                    border = Color.Red;
                    break;

                case ButtonVisualState.Disabled:
                    top = Color.FromArgb(50, 50, 50);
                    mid = Color.FromArgb(70, 70, 70);
                    border = Color.DimGray;
                    break;

                default: // Normal
                    top = Color.FromArgb(0, 30, 120);
                    mid = Color.FromArgb(0, 70, 170);
                    border = Color.Silver;
                    break;
            }

            // Background
            using (LinearGradientBrush bg = new LinearGradientBrush(r, top, top, 90f))
            {
                bg.InterpolationColors = new ColorBlend
                {
                    Colors = new[] { top, mid, top },
                    Positions = new[] { 0f, 0.5f, 1f }
                };
                g.FillPath(bg, path);
            }

            // Border
            using (Pen p = new Pen(border, 2.5f))
                g.DrawPath(p, path);

            // Text (centered)
            TextRenderer.DrawText(
                g,
                Text,
                Font,
                r,
                ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left
            );
        }

        private GraphicsPath CreateHexPath(Rectangle r)
        {
            int s = r.Height / 2;
            GraphicsPath path = new GraphicsPath();

            path.AddPolygon(new Point[]
            {
                new Point(r.X + s, r.Y),
                new Point(r.Right - s, r.Y),
                new Point(r.Right, r.Y + r.Height / 2),
                new Point(r.Right - s, r.Bottom),
                new Point(r.X + s, r.Bottom),
                new Point(r.X, r.Y + r.Height / 2)
            });

            return path;
        }
    }
}
