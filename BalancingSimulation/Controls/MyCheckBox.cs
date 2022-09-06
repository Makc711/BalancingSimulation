using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BalancingSimulation.Controls
{
    class MyCheckBox : CheckBox
    {
        public MyCheckBox()
        {
            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            //DoubleBuffered = true;

            Size = new Size(150, 50);

            //Font = new Font("Verdana", 9F, FontStyle.Regular);
            //BackColor = Color.White;

            //SF.LineAlignment = StringAlignment.Center;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            Size = new Size(150, 50);
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //Graphics graph = e.Graphics;
        //graph.SmoothingMode = SmoothingMode.HighQuality;
        //graph.Clear(Parent.BackColor);

        //Pen RBPen = new Pen(FlatColors.GrayDark, 3);

        //Rectangle RBrect = new Rectangle(1, 1, Height - 3, Height - 3);
        //Rectangle RBrectText = new Rectangle(Height + 1, 0, Width - Height, Height);

        //Rectangle RBrectChecked = new Rectangle(RBrect.X + 3, RBrect.Y + 3, RBrect.Width - 6, RBrect.Height - 6);

        //graph.DrawRectangle(RBPen, RBrect);

        //graph.DrawEllipse(RBPen, RBrect);
        //graph.FillEllipse(new SolidBrush(Color.White), RBrect);

        //if (Checked)
        //{
        //    //graph.DrawEllipse(RBPen, RBrectChecked);
        //    graph.FillEllipse(new SolidBrush(FlatColors.Green), RBrectChecked);
        //}

        //graph.DrawString(Text, Font, new SolidBrush(ForeColor), RBrectText, SF);
        //}
    }
}
