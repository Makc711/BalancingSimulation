using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalancingSimulation
{
    class GraphicU
    {
        private readonly PictureBox _pictureBox;
        private readonly Graphics _graphics;
        private const int NumberOfCells = 4;
        internal enum IndexOfCell
        {
            Cell1 = 0,
            Cell2 = 1,
            Cell3 = 2,
            Cell4 = 3
        }

        private readonly Pen[] _pens = new Pen[NumberOfCells];
        private readonly Point[] _pointPen = new Point[NumberOfCells];
        private const int BaseX = 35;
        private const int BaseY = 46;
        private const int Width = 1270;
        private const int Height = 406;
        private const int AllTime = 8 * 60 * 60; // s
        private readonly int _minVoltage; // mV
        private readonly int _allVoltage;
        private int _currentChargeCycle = 0;
        private readonly Point[,] _pointsU1;
        private readonly int[] _pointsU1Count;
        private readonly Pen[] _pensU1;

        private readonly Point[,] _pointsU2;
        private readonly int[] _pointsU2Count;
        private readonly Pen[] _pensU2;

        private readonly Point[,] _pointsU3;
        private readonly int[] _pointsU3Count;
        private readonly Pen[] _pensU3;

        private readonly Point[,] _pointsU4;
        private readonly int[] _pointsU4Count;
        private readonly Pen[] _pensU4;
        private const int Alpha = 100;

        public GraphicU(PictureBox motherPicture, int minVoltage, int maxVoltage, Color cell1, Color cell2, Color cell3, Color cell4, int numberOfChargeCycles)
        {
            _minVoltage = minVoltage;
            _allVoltage = maxVoltage - _minVoltage;
            _pictureBox = new PictureBox();
            motherPicture.Controls.Add(_pictureBox);
            _pictureBox.Location = new Point(BaseX, BaseY);
            _pictureBox.Size = new Size(Width, Height);
            _pictureBox.BackColor = Color.Transparent;

            _graphics = _pictureBox.CreateGraphics();
            _pens[(int)IndexOfCell.Cell1] = new Pen(cell1, 3);
            _pens[(int)IndexOfCell.Cell2] = new Pen(cell2, 3);
            _pens[(int)IndexOfCell.Cell3] = new Pen(cell3, 3);
            _pens[(int)IndexOfCell.Cell4] = new Pen(cell4, 3);
            _pointPen[(int)IndexOfCell.Cell1] = new Point(0, Height);
            _pointPen[(int)IndexOfCell.Cell2] = new Point(0, Height);
            _pointPen[(int)IndexOfCell.Cell3] = new Point(0, Height);
            _pointPen[(int)IndexOfCell.Cell4] = new Point(0, Height);

            var numberOfChargeCycles1 = numberOfChargeCycles;
            _pointsU1 = new Point[numberOfChargeCycles1, AllTime + 1];
            _pointsU1Count = new int[numberOfChargeCycles1];
            _pensU1 = new Pen[numberOfChargeCycles1];

            _pointsU2 = new Point[numberOfChargeCycles1, AllTime + 1];
            _pointsU2Count = new int[numberOfChargeCycles1];
            _pensU2 = new Pen[numberOfChargeCycles1];

            _pointsU3 = new Point[numberOfChargeCycles1, AllTime + 1];
            _pointsU3Count = new int[numberOfChargeCycles1];
            _pensU3 = new Pen[numberOfChargeCycles1];

            _pointsU4 = new Point[numberOfChargeCycles1, AllTime + 1];
            _pointsU4Count = new int[numberOfChargeCycles1];
            _pensU4 = new Pen[numberOfChargeCycles1];
        }

        public void DrawAllGraphics()
        {
            Clear();
            _currentChargeCycle++;
            int newAlpha = Alpha / (_currentChargeCycle + 1);
            for (int i = 0; i < _currentChargeCycle; i++)
            {
                _pensU1[i] = new Pen(Color.FromArgb(newAlpha * (i + 1), _pens[(int)IndexOfCell.Cell1].Color), 1);
                _pensU2[i] = new Pen(Color.FromArgb(newAlpha * (i + 1), _pens[(int)IndexOfCell.Cell2].Color), 1);
                _pensU3[i] = new Pen(Color.FromArgb(newAlpha * (i + 1), _pens[(int)IndexOfCell.Cell3].Color), 1);
                _pensU4[i] = new Pen(Color.FromArgb(newAlpha * (i + 1), _pens[(int)IndexOfCell.Cell4].Color), 1);
            }
            for (int i = 0; i < _currentChargeCycle; i++)
            {
                DrawGraphic(_pensU1[i], _pointsU1Count[i], _pointsU1, i);
                DrawGraphic(_pensU2[i], _pointsU2Count[i], _pointsU2, i);
                DrawGraphic(_pensU3[i], _pointsU3Count[i], _pointsU3, i);
                DrawGraphic(_pensU4[i], _pointsU4Count[i], _pointsU4, i);
            }
        }

        private void DrawGraphic(Pen pen, int numberOfPoints, Point[,] arrPoints, int chargeCycle)
        {
            Point[] points = new Point[numberOfPoints];
            for (int j = 0; j < points.Length; j++)
            {
                points[j] = arrPoints[chargeCycle, j];
            }
            _graphics.DrawLines(pen, points);
        }

        private void Clear()
        {
            _pictureBox.Image = null;
            _pictureBox.Refresh();
        }

        public void ClearHistory()
        { // Надо разобраться некорректно отрисовывает
            //Point[] pointsU1 = GetCurrentPoints(_pointsU1, _pointsU1Count[_currentChargeCycle]);
            //Point[] pointsU2 = GetCurrentPoints(_pointsU2, _pointsU2Count[_currentChargeCycle]);
            //Point[] pointsU3 = GetCurrentPoints(_pointsU3, _pointsU3Count[_currentChargeCycle]);
            //Point[] pointsU4 = GetCurrentPoints(_pointsU4, _pointsU4Count[_currentChargeCycle]);
            //int pointsU1Count = _pointsU1Count[_currentChargeCycle];
            //int pointsU2Count = _pointsU2Count[_currentChargeCycle];
            //int pointsU3Count = _pointsU3Count[_currentChargeCycle];
            //int pointsU4Count = _pointsU4Count[_currentChargeCycle];
            ResetAllData();
            //_graphics.DrawLines(_pens[(int)IndexOfCell.Cell1], pointsU1);
            //_graphics.DrawLines(_pens[(int)IndexOfCell.Cell2], pointsU2);
            //_graphics.DrawLines(_pens[(int)IndexOfCell.Cell3], pointsU3);
            //_graphics.DrawLines(_pens[(int)IndexOfCell.Cell4], pointsU4);
        }

        private Point[] GetCurrentPoints(Point[,] arrPoints, int numberOfPoints)
        {
            Point[] pointsU1 = new Point[numberOfPoints];
            for (int i = 0; i < pointsU1.Length; i++)
            {
                pointsU1[i] = arrPoints[_currentChargeCycle, i];
            }
            return pointsU1;
        }

        public void ResetAllData()
        {
            for (int i = 0; i <= _currentChargeCycle; i++)
            {
                _pointsU1Count[i] = 0;
                _pointsU2Count[i] = 0;
                _pointsU3Count[i] = 0;
                _pointsU4Count[i] = 0;
            }
            _currentChargeCycle = 0;
            Clear();
        }

        private void SetStartPoint(int x, int y, IndexOfCell index)
        {
            _pointPen[(int)index].X = x;
            _pointPen[(int)index].Y = InvertY(y);
            SavePoint(x, y, index);
        }

        private void AddPoint(int x, int y, IndexOfCell index)
        {
            _graphics.DrawLine(_pens[(int)index], _pointPen[(int)index].X, _pointPen[(int)index].Y, x, InvertY(y));
            _pointPen[(int)index].X = x;
            _pointPen[(int)index].Y = InvertY(y);
            SavePoint(x, y, index);
        }

        private void SavePoint(int x, int y, IndexOfCell index)
        {
            switch (index)
            {
                case IndexOfCell.Cell1:
                    _pointsU1[_currentChargeCycle, _pointsU1Count[_currentChargeCycle]++] = new Point(x, InvertY(y));
                    break;
                case IndexOfCell.Cell2:
                    _pointsU2[_currentChargeCycle, _pointsU2Count[_currentChargeCycle]++] = new Point(x, InvertY(y));
                    break;
                case IndexOfCell.Cell3:
                    _pointsU3[_currentChargeCycle, _pointsU3Count[_currentChargeCycle]++] = new Point(x, InvertY(y));
                    break;
                case IndexOfCell.Cell4:
                    _pointsU4[_currentChargeCycle, _pointsU4Count[_currentChargeCycle]++] = new Point(x, InvertY(y));
                    break;
            }
        }

        private int InvertY(int y)
        {
            return Height - y;
        }

        public void SetStartPositionU(int time, int voltage, IndexOfCell index)
        {
            SetStartPoint(time * Width / AllTime, (voltage - _minVoltage) * Height / _allVoltage, index);
        }

        public void DrawNextLineU(int time, int voltage, IndexOfCell index)
        {
            AddPoint(time * Width / AllTime, (voltage - _minVoltage) * Height / _allVoltage, index);
        }
    }
}
