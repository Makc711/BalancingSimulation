using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BalancingSimulation.Controls
{
    class MyLabel : Label
    {
        public MyLabel()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            AutoSize = false;
            Graphics graph = e.Graphics;
            graph.Clear(BackColor);
            graph.RotateTransform(-90);
            SizeF textSize = graph.MeasureString(Text, Font);
            Width = (int)textSize.Height + 2;
            Height = (int)textSize.Width + 2;
            graph.TranslateTransform((float)-Height / 2, (float)Width / 2);
            graph.DrawString(Text, Font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
        }
    }
}
