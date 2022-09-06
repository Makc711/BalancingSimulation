using System.Drawing;
using System.Drawing.Drawing2D;

namespace BalancingSimulation
{
    public static class Drawer
    {
        public static GraphicsPath RoundedRectangle(Rectangle rect, float roundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, roundSize, roundSize, 180, 90);
            gp.AddArc(rect.X + rect.Width - roundSize, rect.Y, roundSize, roundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - roundSize, rect.Y + rect.Height - roundSize, roundSize, roundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - roundSize, roundSize, roundSize, 90, 90);

            gp.CloseFigure();

            return gp;
        }
        
        public static void DrawBlurredLine(Graphics graph, Color lineColor, Point p1, Point p2, int maxAlpha, int penWidth)
        {
            float stepAlpha = (float)maxAlpha / penWidth;

            float actualAlpha = stepAlpha;
            for (int pWidth = penWidth; pWidth > 0; pWidth--)
            {
                Color blurredColor = Color.FromArgb((int)actualAlpha, lineColor);
                Pen blurredPen = new Pen(blurredColor, pWidth);
                blurredPen.StartCap = LineCap.Round;
                blurredPen.EndCap = LineCap.Round;
                
                graph.DrawLine(blurredPen, p1, p2);

                actualAlpha += stepAlpha;
            }
        }

        public static void DrawBlurredRectangle(Graphics graph, Color lineColor, Rectangle rect, int maxAlpha, int penWidth)
        {
            float stepAlpha = (float)maxAlpha / penWidth;

            float actualAlpha = stepAlpha;
            for (int pWidth = penWidth; pWidth > 0; pWidth--)
            {
                Color blurredColor = Color.FromArgb((int)actualAlpha, lineColor);
                Pen blurredPen = new Pen(blurredColor, pWidth);
                blurredPen.StartCap = LineCap.Round;
                blurredPen.EndCap = LineCap.Round;
                
                graph.DrawRectangle(blurredPen, rect);

                actualAlpha += stepAlpha;
            }
        }
    }
}
