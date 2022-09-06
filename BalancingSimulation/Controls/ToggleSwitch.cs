using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using BalancingSimulation.Animation;

namespace BalancingSimulation.Controls
{
    [Designer(typeof(ControlDesignerEx))] // ControlDesignerEx Добавляем для ограничения изменения размеров
    [DefaultEvent("CheckedChanged")]
    public sealed class ToggleSwitch : Control
    {
        #region -- Свойства --

        public bool Checked
        {
            get => _checked;
            set
            {
                _checked = value;

                SwitchToggle();

                UpdateSize();
                UpdateStructures();
            }
        }
        private bool _checked;

        public Color BackColorOn { get; set; } = FlatColors.GreenDark;
        public Color BackColorOff { get; set; } = FlatColors.Red;

        public override string Text
        {
            get => _text;
            set
            {
                _text = value;
                UpdateSize();
                UpdateStructures();
            }
        }
        private string _text = string.Empty;

        public string TextOnChecked
        {
            get => _textOnChecked;
            set
            {
                _textOnChecked = value;
                UpdateSize();
                UpdateStructures();
            }
        }
        private string _textOnChecked = string.Empty;
        
        #endregion

        #region -- Переменные --

        private Rectangle _rectToggleHolder;
        private const int ToggleSwitchWidth = 40;

        private Rectangle _rectText;

        private int _togglePosXOn;
        private int _togglePosXOff;

        private Animation.Animation _toggleAnim = new Animation.Animation();

        private readonly StringFormat _sf = new StringFormat();

        #endregion

        #region -- События --

        [Description("Возникает при каждом изменении свойства Checked")]
        public event OnCheckedChangedHandler CheckedChanged;
        public delegate void OnCheckedChangedHandler(object sender);

        #endregion

        public ToggleSwitch()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            _sf.Alignment = StringAlignment.Near;
            _sf.LineAlignment = StringAlignment.Center;

            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;

            Cursor = Cursors.Hand;

            Size = new Size(ToggleSwitchWidth, 15);
            UpdateSize();
            UpdateStructures();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            
            UpdateStructures();

            _toggleAnim.Value = (Checked == true) ? _togglePosXOn : _togglePosXOff;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);

            Pen penToggleHolder = new Pen(FlatColors.GrayDark, 1.55f);
            Pen penToggle = new Pen(FlatColors.GrayDark, 3);
            
            GraphicsPath gpathToggle = Drawer.RoundedRectangle(_rectToggleHolder, _rectToggleHolder.Height);
            Rectangle rectToggle = new Rectangle((int)_toggleAnim.Value, _rectToggleHolder.Y, _rectToggleHolder.Height, _rectToggleHolder.Height);
            
            graph.DrawPath(penToggleHolder, gpathToggle);

            if (Checked == true)
            {
                if (Animator.IsWork == false)
                    rectToggle.Location = new Point(_togglePosXOn, _rectToggleHolder.Y);

                graph.FillPath(new SolidBrush(BackColorOn), gpathToggle);
            }
            else
            {
                if (Animator.IsWork == false)
                    rectToggle.Location = new Point(_togglePosXOff, _rectToggleHolder.Y);

                graph.FillPath(new SolidBrush(BackColorOff), gpathToggle);
            }

            graph.DrawEllipse(penToggle, rectToggle);
            graph.FillEllipse(new SolidBrush(BackColor), rectToggle);

            string drawText = Text;
            if (!string.IsNullOrEmpty(TextOnChecked) && Checked)
                drawText = TextOnChecked;

            graph.DrawString(drawText, Font, new SolidBrush(ForeColor), _rectText, _sf);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            Checked = !Checked;
        }

        private void SwitchToggle()
        {
            _toggleAnim = (Checked == true) 
                ? new Animation.Animation("Toggle_" + Handle, Invalidate, _toggleAnim.Value, _togglePosXOn) 
                : new Animation.Animation("Toggle_" + Handle, Invalidate, _toggleAnim.Value, _togglePosXOff);

            _toggleAnim.StepDivider = 8;
            Animator.Request(_toggleAnim);

            CheckedChanged?.Invoke(this);
        }
        
        private void UpdateSize()
        {
            string drawText = Text;
            if (!string.IsNullOrEmpty(TextOnChecked) && Checked) drawText = TextOnChecked;

            Size size = TextRenderer.MeasureText(drawText, Font);
            Width = ToggleSwitchWidth + size.Width + 3;
        }

        private void UpdateStructures()
        {
            _rectToggleHolder = new Rectangle(1, 1, ToggleSwitchWidth - 3, Height - 3);

            int rectTextWidth = Width - ToggleSwitchWidth - 3;
            int rectTextX = _rectToggleHolder.Right + 6;
            _rectText = new Rectangle(rectTextX, _rectToggleHolder.Y, rectTextWidth, _rectToggleHolder.Height);

            _togglePosXOff = _rectToggleHolder.X;
            _togglePosXOn = _rectToggleHolder.Right - _rectToggleHolder.Height;
        }

        /// <summary>
        /// В этом классе переопределяем SelectionRules, и даем возможность только изменять ширину и перемещать объект
        /// </summary>
        class ControlDesignerEx : ControlDesigner
        {
            public override SelectionRules SelectionRules
            {
                get
                {
                    SelectionRules sr = SelectionRules.Moveable | SelectionRules.Visible;
                    return sr;
                }
            }
        }
    }
}
