using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BalancingSimulation.Controls
{
    sealed class MyProgressBar : Control
    {
        #region -- Свойства --

        public Color BorderColor { get; set; } = FlatColors.GrayDark;
        public Color BackColorProgressLeft { get; set; } = FlatColors.Green;
        public Color BackColorProgressRight { get; set; } = FlatColors.GreenSea;

        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                if (value >= Minimum && value <= Maximum)
                {
                    _value = value;
                    Invalidate();
                }
            }
        }

        private int _minimum;
        public int Minimum
        {
            get => _minimum;
            set
            {
                if (value < Maximum)
                {
                    _minimum = value;

                    if (_minimum > Value)
                    {
                        Value = _minimum;
                        Invalidate();
                    }
                }
            }
        }

        private int _maximum = 100;
        public int Maximum
        {
            get => _maximum;
            set
            {
                if (value > Minimum)
                {
                    _maximum = value;
                    Invalidate();
                }
            }
        }

        public int Step { get; set; } = 10;

        #endregion
        
        public MyProgressBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(200, 20);

            BackColor = FlatColors.GrayLight;
        }
        

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rectBase = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectProgress = new Rectangle(
                rectBase.X,
                rectBase.Y,
                CalculateProgressRectSize(rectBase),
                rectBase.Height);

            DrawBase(graph, rectBase);
            DrawProgress(graph, rectProgress);
            DrawBorder(graph, rectBase);
        }
        
        private int CalculateProgressRectSize(Rectangle rect)
        {
            int margin = Maximum - Minimum;
            return rect.Width * (Value - Minimum) / margin;
        }
        
        #region -- Рисование объектов --

        private void DrawBase(Graphics graph, Rectangle rect)
        {
            graph.FillRectangle(new SolidBrush(BackColor), rect);
        }

        private void DrawBorder(Graphics graph, Rectangle rect)
        {
            graph.DrawRectangle(new Pen(BorderColor), rect);
        }

        private void DrawProgress(Graphics graph, Rectangle rect)
        {
            if (rect.Width > 0)
            {
                LinearGradientBrush lgb = new LinearGradientBrush(rect, BackColorProgressLeft, BackColorProgressRight, 360);

                graph.DrawRectangle(new Pen(lgb), rect);
                graph.FillRectangle(lgb, rect);
            }
        }

        #endregion
        
        #region -- Public методы --

        public bool PerformStep()
        {
            if (Value < Maximum)
            {
                if (Value + Step >= Maximum)
                {
                    Value = Maximum;
                    return false;
                }
                else
                {
                    Value += Step;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        
        public void ResetProgress()
        {
            Value = Minimum;
        }

        #endregion
        
    }
}
