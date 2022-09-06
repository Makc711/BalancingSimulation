using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using BalancingSimulation.Animation;
using BalancingSimulation.Controls;
using BalancingSimulation.Properties;

namespace BalancingSimulation
{
    public partial class Form1 : Form
    {
        private GraphicU _graphicU;
        private Cell _cell1;
        private Cell _cell2;
        private Cell _cell3;
        private Cell _cell4;
        private int _time;
        private const int MaxTime = 8 * 60 * 60;
        private bool _isButtonPlayActive;
        private bool _isGraphicStart;
        private const int TimeIncrement = 1;
        private int _timerPeriod = 1;
        private int _current; // mA
        private int _chargeCurrent; // mA
        private int _chargeCount;
        private const int NumberOfChargeCycles = 1000;
        private double _dischargeCapacity;
        private const int SecondsInHour = 60 * 60;
        private int _minSoc;
        private int _maxSoc;
        private int _dod;
        private int _startDeltaCapacity;
        private const int MinChargeCurrent = 270; // mA
        private const int BalanceVoltageToReduceThreshold = 3500;
        private const int BalanceVoltageThreshold = 3390;
        private const int BalanceVoltageRecovery = 3340;
        private const int BalanceDeltaVoltage = 20;
        private bool _isAutoBalanceStart;
        private static int _maxNominalCapacity;
        private const int MinNominalCapacity = 8000; //20000 При емкости менее 20000 показывал фигню.
        private const int MaxSoc = 100;
        private const int MinSoc = 0;
        private bool _isDischargeFinished;
        private bool _isChargeFinished;
        private const double MinCurrentC = 0.3; // 0.3C
        private const int MaxCurrentC = 3; // 3C
        private const int MaxCellVoltage = 3600;
        private const int MinCellVoltage = 2600;
        private double _deltaCapacityCell1;
        private double _deltaCapacityCell2;
        private double _deltaCapacityCell3;
        private double _deltaCapacityCell4; 
        private int _minSocBeforeBalancing;
        private Color _progressBarBackColorLeftGreen;
        private Color _progressBarBackColorRightGreen;
        private readonly Color _progressBarBackColorLeftRed = FlatColors.Red3;
        private readonly Color _progressBarBackColorRightRed = FlatColors.Red4;

        internal enum IndexOfBalancing
        {
            Algorithm1 = 0,
            Algorithm2 = 1,
            Algorithm3 = 2,
            Algorithm4 = 3
        }
        private IndexOfBalancing _balancingAlgorithm = IndexOfBalancing.Algorithm1;


        #region -- Initial data --

        private int _startCurrent;
        private int _startSoc1;
        private int _startSoc2;
        private int _startSoc3;
        private int _startSoc4;
        private int _startCapacity1;
        private int _startCapacity2;
        private int _startCapacity3;
        private int _startCapacity4;
        private int _startSelfDischarge1;
        private int _startSelfDischarge2;
        private int _startSelfDischarge3;
        private int _startSelfDischarge4;
        private int _startInternalResistance1;
        private int _startInternalResistance2;
        private int _startInternalResistance3;
        private int _startInternalResistance4;
        private int _startBalanceResistance;
        private int _startMinSoc;
        private int _startDod;
        private int _startMaxNominalCapacity;

        #endregion
        
        public Form1()
        {
            InitializeComponent();

            Animator.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEnglishLanguage();
            pictureBoxCell1Color.BackColor = Color.Orange;
            pictureBoxCell2Color.BackColor = Color.ForestGreen;
            pictureBoxCell3Color.BackColor = Color.Red;
            pictureBoxCell4Color.BackColor = Color.Blue;
            _graphicU = new GraphicU(pictureBoxGraphic, myProgressBarСellVoltage1.Minimum, myProgressBarСellVoltage1.Maximum, pictureBoxCell1Color.BackColor, pictureBoxCell2Color.BackColor, pictureBoxCell3Color.BackColor, pictureBoxCell4Color.BackColor, NumberOfChargeCycles);
            _startCapacity1 = Int32.Parse(textBoxCapacity1.Text);
            _startCapacity2 = Int32.Parse(textBoxCapacity2.Text);
            _startCapacity3 = Int32.Parse(textBoxCapacity3.Text);
            _startCapacity4 = Int32.Parse(textBoxCapacity4.Text);
            _startSelfDischarge1 = Int32.Parse(textBoxSelfDischarge1.Text);
            _startSelfDischarge2 = Int32.Parse(textBoxSelfDischarge2.Text);
            _startSelfDischarge3 = Int32.Parse(textBoxSelfDischarge3.Text);
            _startSelfDischarge4 = Int32.Parse(textBoxSelfDischarge4.Text);
            _startInternalResistance1 = Int32.Parse(textBoxInternalResistance1.Text);
            _startInternalResistance2 = Int32.Parse(textBoxInternalResistance2.Text);
            _startInternalResistance3 = Int32.Parse(textBoxInternalResistance3.Text);
            _startInternalResistance4 = Int32.Parse(textBoxInternalResistance4.Text);
            _startBalanceResistance = Int32.Parse(textBoxBalanceResistance.Text);
            _startMinSoc = Int32.Parse(textBoxMinSoc.Text);
            _startDod = Int32.Parse(textBoxDod.Text);
            _dod = _startDod * 100;
            _minSoc = _startMinSoc * 100;
            _maxSoc = _minSoc + _dod;
            _cell1 = new Cell(_startCapacity1, _startSelfDischarge1, _startInternalResistance1, _startBalanceResistance);
            _cell2 = new Cell(_startCapacity2, _startSelfDischarge2, _startInternalResistance2, _startBalanceResistance);
            _cell3 = new Cell(_startCapacity3, _startSelfDischarge3, _startInternalResistance3, _startBalanceResistance);
            _cell4 = new Cell(_startCapacity4, _startSelfDischarge4, _startInternalResistance4, _startBalanceResistance);
            textBoxMaxDischargeCapacity.Text = GetMaxDischargeCapacity().ToString();
            SetSpeed();
            _startCurrent = Int32.Parse(textBoxCurrent.Text);
            _current = _startCurrent * 1000;
            _chargeCurrent = _current;
            _startSoc1 = Int32.Parse(textBoxSOC1.Text);
            _startSoc2 = Int32.Parse(textBoxSOC2.Text);
            _startSoc3 = Int32.Parse(textBoxSOC3.Text);
            _startSoc4 = Int32.Parse(textBoxSOC4.Text);
            _cell1.SetSoc(_startSoc1 * 100);
            _cell2.SetSoc(_startSoc2 * 100);
            _cell3.SetSoc(_startSoc3 * 100);
            _cell4.SetSoc(_startSoc4 * 100);
            _dischargeCapacity = 0;
            _startDeltaCapacity = 0;
            _startMaxNominalCapacity = GetMaxNominalCapacity();
            _maxNominalCapacity = _startMaxNominalCapacity;
            _progressBarBackColorLeftGreen = myProgressBarСellVoltage1.BackColorProgressLeft;
            _progressBarBackColorRightGreen = myProgressBarСellVoltage1.BackColorProgressRight;
        }

        #region -- Load culture --

        private void LoadCulture(string nameOfCulture)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(nameOfCulture);
            groupBoxCellState.Text = strings.cellState;
            groupBoxBalancingAlgorithm.Text = strings.balancingAlgorithm;
            label3.Text = strings.automaticBalancing;
            label5.Text = strings.imbalanceMV;
            myLabel3.Text = strings.balancing;
            myLabel9.Text = strings.balancingCurrent;
            myLabel10.Text = strings.mA;
            label12.Text = strings.balancerResistance;
            myLabel12.Text = strings.chargeLevel;
            myLabel11.Text = strings.mAh;
            groupBox2.Text = strings.cellCharacteristics;
            myLabel5.Text = strings.capacity;
            myLabel6.Text = strings.mAh;
            myLabel7.Text = strings.leakageCurrent;
            myLabel8.Text = strings.uA;
            myLabel14.Text = strings.internalResistance;
            myLabel13.Text = strings.uOhm;
            groupBox3.Text = strings.energyStorage;
            label16.Text = strings.maximum;
            label17.Text = strings.usableCapacity;
            label9.Text = strings.dischargeCapacity;
            label4.Text = strings.imbalanceMAh;
            label18.Text = strings.balancingProgress;
            groupBox4.Text = strings.cellInitialStates;
            groupBox1.Text = strings.simulation;
            label1.Text = strings.simulationSpeed;
            buttonClear.Text = strings.clearHistory;
            label10.Text = strings.numberOfCycles;
            label2.Text = strings.chargeCurrent;
            label6.Text = strings.cellVoltage;
        }

        private void LoadRussianLanguage()
        {
            LoadCulture("ru-RU");
            label3.Location = new Point(159, 19);
            label5.Location = new Point(181, 50);
            myLabel3.Location = new Point(411, 15);
            myLabel9.Location = new Point(436, 28);
            label12.Location = new Point(503, 15);
            myLabel12.Location = new Point(735, 55);
            myLabel5.Location = new Point(16, 39);
            myLabel7.Location = new Point(63, 26);
            myLabel8.Location = new Point(78, 64);
            myLabel14.Location = new Point(105, 18);
            label16.Location = new Point(13, 19);
            label17.Location = new Point(13, 33);
            label9.Location = new Point(6, 59);
            label4.Location = new Point(50, 88);
            label18.Location = new Point(35, 115);
            label1.Location = new Point(20, 15);
            label10.Location = new Point(11, 160);
            label2.Location = new Point(11, 187);
            label6.Location = new Point(542, 22);
        }

        private void LoadEnglishLanguage()
        {
            LoadCulture("en-US");
            label3.Location = new Point(159 + 65, 19);
            label5.Location = new Point(159 + 30, 50);
            myLabel3.Location = new Point(411, 15 + 26);
            myLabel9.Location = new Point(436, 28 - 13);
            label12.Location = new Point(503 + 35, 15);
            myLabel12.Location = new Point(735, 55 - 31);
            myLabel5.Location = new Point(16, 39);
            myLabel7.Location = new Point(63, 26 - 12);
            myLabel8.Location = new Point(78, 64 + 8);
            myLabel14.Location = new Point(105, 18 - 6);
            label16.Location = new Point(13 + 20, 19);
            label17.Location = new Point(13 + 20, 33);
            label9.Location = new Point(6 + 10, 59);
            label4.Location = new Point(50 + 9, 88);
            label18.Location = new Point(35 + 19, 115);
            label1.Location = new Point(20 + 25, 15);
            label10.Location = new Point(11, 160);
            label2.Location = new Point(11, 187);
            label6.Location = new Point(542 + 30, 22);
        }

        private void LoadGermanLanguage()
        {
            LoadCulture("de-DE");
            label3.Location = new Point(159 + 30, 19);
            label5.Location = new Point(159, 50);
            myLabel3.Location = new Point(411, 15 + 25);
            myLabel9.Location = new Point(436, 28 - 21);
            label12.Location = new Point(503 + 26, 15);
            myLabel12.Location = new Point(735, 55 - 33);
            myLabel5.Location = new Point(16, 39 - 3);
            myLabel7.Location = new Point(63, 26 + 5);
            myLabel8.Location = new Point(78, 64 + 8);
            myLabel14.Location = new Point(105, 18 + 3);
            label16.Location = new Point(13 + 6, 19);
            label17.Location = new Point(13 + 6, 33);
            label9.Location = new Point(6 + 22, 59);
            label4.Location = new Point(50 - 21, 88);
            label18.Location = new Point(35 + 8, 115);
            label1.Location = new Point(20, 15);
            label10.Location = new Point(11 + 11, 160);
            label2.Location = new Point(11 + 11, 187);
            label6.Location = new Point(542 + 22, 22);
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _timerPeriod; i++)
            {
                DrawNextGraphicLines();
                UpdateIndicators();
            }
            if (_chargeCount >= NumberOfChargeCycles)
            {
                ButtonPlay_Click(this, EventArgs.Empty);
                ButtonPlay.Enabled = false;
            }
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (_isButtonPlayActive == false)
            {
                if (_isGraphicStart == false)
                {
                    SetStartGraphicPoint();
                    textBoxSOC1.ReadOnly = true;
                    textBoxSOC2.ReadOnly = true;
                    textBoxSOC3.ReadOnly = true;
                    textBoxSOC4.ReadOnly = true;
                    textBoxCapacity1.ReadOnly = true;
                    textBoxCapacity2.ReadOnly = true;
                    textBoxCapacity3.ReadOnly = true;
                    textBoxCapacity4.ReadOnly = true;
                    textBoxSelfDischarge1.ReadOnly = true;
                    textBoxSelfDischarge2.ReadOnly = true;
                    textBoxSelfDischarge3.ReadOnly = true;
                    textBoxSelfDischarge4.ReadOnly = true;
                    textBoxInternalResistance1.ReadOnly = true;
                    textBoxInternalResistance2.ReadOnly = true;
                    textBoxInternalResistance3.ReadOnly = true;
                    textBoxInternalResistance4.ReadOnly = true;
                    textBoxBalanceResistance.ReadOnly = true;
                    textBoxMinSoc.ReadOnly = true;
                    textBoxDod.ReadOnly = true;
                    _isGraphicStart = true;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    radioButton8.Enabled = false;
                    radioButton7.Enabled = false;
                    radioButton6.Enabled = false;
                    radioButton5.Enabled = false;
                    _chargeCurrent = Int32.Parse(textBoxCurrent.Text) * 1000;
                }
                textBoxCurrent.ReadOnly = true;
                _current = Int32.Parse(textBoxCurrent.Text) * 1000;

                ChangeImageButtonPlay("BalancingSimulation.Resources.Pause.png");
                timer1.Enabled = true;
                _isButtonPlayActive = true;
            }
            else
            {
                ChangeImageButtonPlay("BalancingSimulation.Resources.Play.png");
                timer1.Enabled = false;
                _isButtonPlayActive = false;
                if (IsCellRelaxFinished())
                {
                    textBoxCurrent.ReadOnly = false;
                }
            }
        }

        private void SetStartGraphicPoint()
        {
            _time = 0;
            _graphicU.SetStartPositionU(_time, _cell1.GetVoltage(), GraphicU.IndexOfCell.Cell1);
            _graphicU.SetStartPositionU(_time, _cell2.GetVoltage(), GraphicU.IndexOfCell.Cell2);
            _graphicU.SetStartPositionU(_time, _cell3.GetVoltage(), GraphicU.IndexOfCell.Cell3);
            _graphicU.SetStartPositionU(_time, _cell4.GetVoltage(), GraphicU.IndexOfCell.Cell4);
        }

        private void ChangeImageButtonPlay(string resourcePath)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(resourcePath))
            {
                Bitmap picture = (Bitmap)Image.FromStream(stream ?? throw new InvalidOperationException());
                ButtonPlay.Image = picture;
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            _time = 0;
            ChangeImageButtonPlay("BalancingSimulation.Resources.Play.png");
            _isButtonPlayActive = false;
            _cell1.ResetData();
            _cell2.ResetData();
            _cell3.ResetData();
            _cell4.ResetData();
            SwitchBalancing.Checked = false;
            _isGraphicStart = false;
            _graphicU.ResetAllData();
            _chargeCount = 0;
            textBoxCycleNumber.Text = "";
            _dischargeCapacity = 0;
            textBoxDischargeCapacity.Text = "";
            textBoxCapacityImbalance.Text = "";
            myProgressBarBalanceStatus.Value = 0;
            _startDeltaCapacity = 0;
            textBoxCurrent.ReadOnly = false;
            textBoxSOC1.ReadOnly = false;
            textBoxSOC2.ReadOnly = false;
            textBoxSOC3.ReadOnly = false;
            textBoxSOC4.ReadOnly = false;
            textBoxSOC1.Text = _startSoc1.ToString();
            textBoxSOC2.Text = _startSoc2.ToString();
            textBoxSOC3.Text = _startSoc3.ToString();
            textBoxSOC4.Text = _startSoc4.ToString();
            myProgressBarSOC1.Value = _startSoc1;
            myProgressBarSOC2.Value = _startSoc2;
            myProgressBarSOC3.Value = _startSoc3;
            myProgressBarSOC4.Value = _startSoc4;
            textBoxCurrent.Text = _startCurrent.ToString();
            textBoxCapacity1.ReadOnly = false;
            textBoxCapacity2.ReadOnly = false;
            textBoxCapacity3.ReadOnly = false;
            textBoxCapacity4.ReadOnly = false;
            textBoxCapacity1.Text = _startCapacity1.ToString();
            textBoxCapacity2.Text = _startCapacity2.ToString();
            textBoxCapacity3.Text = _startCapacity3.ToString();
            textBoxCapacity4.Text = _startCapacity4.ToString();
            textBoxSelfDischarge1.ReadOnly = false;
            textBoxSelfDischarge2.ReadOnly = false;
            textBoxSelfDischarge3.ReadOnly = false;
            textBoxSelfDischarge4.ReadOnly = false;
            textBoxSelfDischarge1.Text = _startSelfDischarge1.ToString();
            textBoxSelfDischarge2.Text = _startSelfDischarge2.ToString();
            textBoxSelfDischarge3.Text = _startSelfDischarge3.ToString();
            textBoxSelfDischarge4.Text = _startSelfDischarge4.ToString();
            textBoxInternalResistance1.ReadOnly = false;
            textBoxInternalResistance2.ReadOnly = false;
            textBoxInternalResistance3.ReadOnly = false;
            textBoxInternalResistance4.ReadOnly = false;
            textBoxInternalResistance1.Text = _startInternalResistance1.ToString();
            textBoxInternalResistance2.Text = _startInternalResistance2.ToString();
            textBoxInternalResistance3.Text = _startInternalResistance3.ToString();
            textBoxInternalResistance4.Text = _startInternalResistance4.ToString();
            textBoxBalanceResistance.ReadOnly = false;
            textBoxBalanceResistance.Text = _startBalanceResistance.ToString();
            textBoxMinSoc.ReadOnly = false;
            textBoxDod.ReadOnly = false;
            textBoxMinSoc.Text = _startMinSoc.ToString();
            textBoxDod.Text = _startDod.ToString();
            textBoxСellVoltage1.Text = "";
            textBoxСellVoltage2.Text = "";
            textBoxСellVoltage3.Text = "";
            textBoxСellVoltage4.Text = "";
            textBoxBalanceCurrent1.Text = "";
            textBoxBalanceCurrent2.Text = "";
            textBoxBalanceCurrent3.Text = "";
            textBoxBalanceCurrent4.Text = "";
            textBoxCapacityLevel1.Text = "";
            textBoxCapacityLevel2.Text = "";
            textBoxCapacityLevel3.Text = "";
            textBoxCapacityLevel4.Text = "";
            textBoxImbalance.Text = "";
            myProgressBarСellVoltage1.Value = myProgressBarСellVoltage1.Minimum;
            myProgressBarСellVoltage2.Value = myProgressBarСellVoltage2.Minimum;
            myProgressBarСellVoltage3.Value = myProgressBarСellVoltage3.Minimum;
            myProgressBarСellVoltage4.Value = myProgressBarСellVoltage4.Minimum;
            pictureBoxCVMAX1.BackColor = FlatColors.GrayLight2;
            pictureBoxCVMAX2.BackColor = FlatColors.GrayLight2;
            pictureBoxCVMAX3.BackColor = FlatColors.GrayLight2;
            pictureBoxCVMAX4.BackColor = FlatColors.GrayLight2;
            pictureBoxCVMIN1.BackColor = FlatColors.GrayLight2;
            pictureBoxCVMIN2.BackColor = FlatColors.GrayLight2;
            pictureBoxCVMIN3.BackColor = FlatColors.GrayLight2;
            pictureBoxCVMIN4.BackColor = FlatColors.GrayLight2;
            myRadioButtonBalanceCell1.Checked = false;
            myRadioButtonBalanceCell2.Checked = false;
            myRadioButtonBalanceCell3.Checked = false;
            myRadioButtonBalanceCell4.Checked = false;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton8.Enabled = true;
            radioButton7.Enabled = true;
            radioButton6.Enabled = true;
            radioButton5.Enabled = true;
            radioButton1.Checked = true;
            ButtonPlay.Enabled = true;
            ResetBalancingAlgorithm2();
        }

        private void DrawNextGraphicLines()
        {
            _time += TimeIncrement;
            if (_isAutoBalanceStart)
            {
                switch (_balancingAlgorithm)
                {
                    case IndexOfBalancing.Algorithm1:
                        BalancingAlgorithm1();
                        break;
                    case IndexOfBalancing.Algorithm2:
                        BalancingAlgorithm2();
                        break;
                    case IndexOfBalancing.Algorithm3:
                        BalancingAlgorithm3();
                        break;
                    case IndexOfBalancing.Algorithm4:
                        BalancingAlgorithm4();
                        break;
                    default:
                        BalancingAlgorithm1();
                        break;
                }
            }
            if ((_current > 0) && ((GetMaxVoltage() >= MaxCellVoltage) || (GetMaxSoc() >= _maxSoc) /*|| (GetMaxSoc() >= MaxSoc * 100)*/))
            {
                _dischargeCapacity = 0;
                _current = 0;
                _cell1.StartChargeRelax();
                _cell2.StartChargeRelax();
                _cell3.StartChargeRelax();
                _cell4.StartChargeRelax();
                _isChargeFinished = true;
            }
            if ((_current < 0) && ((GetMinVoltage() <= MinCellVoltage) || (GetMinSoc() <= _minSoc)))
            {
                _chargeCount++;
                textBoxCycleNumber.Text = _chargeCount.ToString();
                _current = 0;
                _cell1.StartDischargeRelax();
                _cell2.StartDischargeRelax();
                _cell3.StartDischargeRelax();
                _cell4.StartDischargeRelax();
                _isDischargeFinished = true;
            }
            
            _cell1.UpdateData(_current, TimeIncrement);
            _cell2.UpdateData(_current, TimeIncrement);
            _cell3.UpdateData(_current, TimeIncrement);
            _cell4.UpdateData(_current, TimeIncrement);
            _graphicU.DrawNextLineU(_time, _cell1.GetVoltage(), GraphicU.IndexOfCell.Cell1);
            _graphicU.DrawNextLineU(_time, _cell2.GetVoltage(), GraphicU.IndexOfCell.Cell2);
            _graphicU.DrawNextLineU(_time, _cell3.GetVoltage(), GraphicU.IndexOfCell.Cell3);
            _graphicU.DrawNextLineU(_time, _cell4.GetVoltage(), GraphicU.IndexOfCell.Cell4);
            UpdateDischargeCapacity();

            if ((_current == 0) && _cell1.IsRelaxFinish() && _cell2.IsRelaxFinish() && _cell3.IsRelaxFinish() && _cell4.IsRelaxFinish())
            {
                if (_isChargeFinished)
                {
                    _current = -_chargeCurrent;
                    _isChargeFinished = false;
                } 
                else if (_isDischargeFinished)
                {
                    SetStartGraphicPosition();
                }
            }

            if (_time >= MaxTime)
            {
                SetStartGraphicPosition();
            }
        }

        private void SetStartGraphicPosition()
        {
            _current = _chargeCurrent;
            _cell1.NextCharge();
            _cell2.NextCharge();
            _cell3.NextCharge();
            _cell4.NextCharge();
            _graphicU.DrawAllGraphics();
            SetStartGraphicPoint();
            _isDischargeFinished = false;
        }

        #region -- Balancing algorithm 1 --
        private void BalancingAlgorithm1()
        {
            _cell1.StatusBalancing = StatusBalancing(_cell1.GetVoltage());
            _cell2.StatusBalancing = StatusBalancing(_cell2.GetVoltage());
            _cell3.StatusBalancing = StatusBalancing(_cell3.GetVoltage());
            _cell4.StatusBalancing = StatusBalancing(_cell4.GetVoltage());
        }

        private bool StatusBalancing(int cellVoltage)
        {
            int deltaVoltageCell = cellVoltage - GetMinVoltage();
            bool statusBalancing = (cellVoltage > BalanceVoltageThreshold) && (deltaVoltageCell >= BalanceDeltaVoltage) && (_current > 0);
            if ((cellVoltage < BalanceVoltageRecovery) || (deltaVoltageCell < BalanceDeltaVoltage) || (_current <= 0))
            {
                statusBalancing = false;
            }
            return statusBalancing;
        }
        #endregion

        #region -- Balancing algorithm 2 --
        private void BalancingAlgorithm2()
        {
            BalancingAlgorithm1();

            if (GetMaxVoltage() >= BalanceVoltageToReduceThreshold && _current != 0 && (_cell1.StatusBalancing || _cell2.StatusBalancing || _cell3.StatusBalancing || _cell4.StatusBalancing))
            {
                int chargeCurrent = new[] { _cell1.GetBalanceCurrent(), _cell2.GetBalanceCurrent(), _cell3.GetBalanceCurrent(), _cell4.GetBalanceCurrent() }.Max();
                if (chargeCurrent <= MinChargeCurrent)
                {
                    chargeCurrent = MinChargeCurrent;
                }

                double k = ((double)(MaxCellVoltage - GetMaxVoltage()) / (MaxCellVoltage - BalanceVoltageToReduceThreshold));
                _current = CheckLimits((int)(k * _chargeCurrent), chargeCurrent, MaxCurrentC * _maxNominalCapacity);
            }
        }
        #endregion

        #region -- Balancing algorithm 3 --
        private void BalancingAlgorithm3()
        {
            _deltaCapacityCell1 = DecrementDeltaCapacity(_deltaCapacityCell1, _cell1);
            _deltaCapacityCell2 = DecrementDeltaCapacity(_deltaCapacityCell2, _cell2);
            _deltaCapacityCell3 = DecrementDeltaCapacity(_deltaCapacityCell3, _cell3);
            _deltaCapacityCell4 = DecrementDeltaCapacity(_deltaCapacityCell4, _cell4);
            if ((_current > 0) && (GetMaxVoltage() >= MaxCellVoltage))
            {
                int socCell1 = _cell1.GetSocFromUCharge(_current);
                int socCell2 = _cell2.GetSocFromUCharge(_current);
                int socCell3 = _cell3.GetSocFromUCharge(_current);
                int socCell4 = _cell4.GetSocFromUCharge(_current);
                int minSoc = new[] { socCell1, socCell2, socCell3, socCell4 }.Min();
                _deltaCapacityCell1 = (double)(socCell1 - minSoc) * _maxNominalCapacity / (MaxSoc * 100);
                _deltaCapacityCell2 = (double)(socCell2 - minSoc) * _maxNominalCapacity / (MaxSoc * 100);
                _deltaCapacityCell3 = (double)(socCell3 - minSoc) * _maxNominalCapacity / (MaxSoc * 100);
                _deltaCapacityCell4 = (double)(socCell4 - minSoc) * _maxNominalCapacity / (MaxSoc * 100);
            }
        }

        double DecrementDeltaCapacity(double deltaCapacity, Cell cell)
        {
            if (deltaCapacity > 0)
            {
                deltaCapacity -= (double)TimeIncrement * cell.GetBalanceCurrent() / SecondsInHour;
                cell.StatusBalancing = true;
            }
            else
            {
                deltaCapacity = 0;
                cell.StatusBalancing = false;
            }
            return deltaCapacity;
        }

        private void ResetBalancingAlgorithm2()
        {
            _deltaCapacityCell1 = 0;
            _deltaCapacityCell2 = 0;
            _deltaCapacityCell3 = 0;
            _deltaCapacityCell4 = 0;
        }
        #endregion

        #region -- Balancing algorithm 4 --
        private void BalancingAlgorithm4()
        {
            _deltaCapacityCell1 = DecrementDeltaCapacity(_deltaCapacityCell1, _cell1);
            _deltaCapacityCell2 = DecrementDeltaCapacity(_deltaCapacityCell2, _cell2);
            _deltaCapacityCell3 = DecrementDeltaCapacity(_deltaCapacityCell3, _cell3);
            _deltaCapacityCell4 = DecrementDeltaCapacity(_deltaCapacityCell4, _cell4);
            UpdateStatusBalancingAlgorithm3(_cell1);
            UpdateStatusBalancingAlgorithm3(_cell2);
            UpdateStatusBalancingAlgorithm3(_cell3);
            UpdateStatusBalancingAlgorithm3(_cell4);
            if ((_current > 0) && (GetMaxVoltage() >= MaxCellVoltage))
            {
                int socCell1 = _cell1.GetSocFromUCharge(_current);
                int socCell2 = _cell2.GetSocFromUCharge(_current);
                int socCell3 = _cell3.GetSocFromUCharge(_current);
                int socCell4 = _cell4.GetSocFromUCharge(_current);
                int minSoc = new[] { socCell1, socCell2, socCell3, socCell4 }.Min();
                _deltaCapacityCell1 = (double)(socCell1 - minSoc) * _maxNominalCapacity / (MaxSoc * 100);
                _deltaCapacityCell2 = (double)(socCell2 - minSoc) * _maxNominalCapacity / (MaxSoc * 100);
                _deltaCapacityCell3 = (double)(socCell3 - minSoc) * _maxNominalCapacity / (MaxSoc * 100);
                _deltaCapacityCell4 = (double)(socCell4 - minSoc) * _maxNominalCapacity / (MaxSoc * 100);
            }
        }

        private void UpdateStatusBalancingAlgorithm3(Cell cell)
        {
            int deltaVoltageCell = cell.GetVoltage() - GetMinVoltage();
            if ((cell.GetVoltage() > BalanceVoltageThreshold) && (deltaVoltageCell >= BalanceDeltaVoltage) && (_current > 0) && (_current <= GetMinBalanceCurrent()))
            {
                cell.StatusBalancing = true;
            }
        }
        #endregion

        private void UpdateDischargeCapacity()
        {
            if (_current < 0)
            {
                _dischargeCapacity -= IncrementCapacity(_current, TimeIncrement);
                int maxDischargeCapacity = GetMaxDischargeCapacity();
                _dischargeCapacity = CheckLimits(_dischargeCapacity, 0, maxDischargeCapacity);
                if ((GetMinSoc() <= _minSoc) || (GetMinVoltage() <= MinCellVoltage))
                {
                    int dischargeCapacity = (int)Math.Round(_dischargeCapacity);
                    textBoxDischargeCapacity.Text = dischargeCapacity.ToString();
                    textBoxCapacityImbalance.Text = (maxDischargeCapacity - dischargeCapacity).ToString();
                    UpdateProgressBarBalanceStatus();
                }
            }
        }

        private void UpdateProgressBarBalanceStatus()
        {
            int currentDeltaCapacity = Math.Abs(GetMaxDischargeCapacity() - (int)Math.Round(_dischargeCapacity));
            if ((_startDeltaCapacity != 0) && (currentDeltaCapacity < _startDeltaCapacity))
            {
                myProgressBarBalanceStatus.Value = myProgressBarBalanceStatus.Maximum - (currentDeltaCapacity * myProgressBarBalanceStatus.Maximum / _startDeltaCapacity);
            }
            else
            {
                _startDeltaCapacity = currentDeltaCapacity;
                myProgressBarBalanceStatus.Value = (_startDeltaCapacity == 0) ? myProgressBarBalanceStatus.Maximum : myProgressBarBalanceStatus.Minimum;
            }
        }

        private double IncrementCapacity(int current, int time)
        {
            return (double)current * time / SecondsInHour;
        }

        private void UpdateIndicators()
        {
            textBoxСellVoltage1.Text = _cell1.GetVoltage().ToString();
            textBoxСellVoltage2.Text = _cell2.GetVoltage().ToString();
            textBoxСellVoltage3.Text = _cell3.GetVoltage().ToString();
            textBoxСellVoltage4.Text = _cell4.GetVoltage().ToString();
            textBoxBalanceCurrent1.Text = _cell1.GetBalanceCurrent().ToString();
            textBoxBalanceCurrent2.Text = _cell2.GetBalanceCurrent().ToString();
            textBoxBalanceCurrent3.Text = _cell3.GetBalanceCurrent().ToString();
            textBoxBalanceCurrent4.Text = _cell4.GetBalanceCurrent().ToString();
            textBoxCapacityLevel1.Text = _cell1.GetCapacityLevel().ToString();
            textBoxCapacityLevel2.Text = _cell2.GetCapacityLevel().ToString();
            textBoxCapacityLevel3.Text = _cell3.GetCapacityLevel().ToString();
            textBoxCapacityLevel4.Text = _cell4.GetCapacityLevel().ToString();
            textBoxImbalance.Text = (GetMaxVoltage() - GetMinVoltage()).ToString();
            myProgressBarСellVoltage1.Value = CheckLimits(_cell1.GetVoltage(), myProgressBarСellVoltage1.Minimum, myProgressBarСellVoltage1.Maximum);
            myProgressBarСellVoltage2.Value = CheckLimits(_cell2.GetVoltage(), myProgressBarСellVoltage2.Minimum, myProgressBarСellVoltage2.Maximum);
            myProgressBarСellVoltage3.Value = CheckLimits(_cell3.GetVoltage(), myProgressBarСellVoltage3.Minimum, myProgressBarСellVoltage3.Maximum);
            myProgressBarСellVoltage4.Value = CheckLimits(_cell4.GetVoltage(), myProgressBarСellVoltage4.Minimum, myProgressBarСellVoltage4.Maximum);
            pictureBoxCVMAX1.BackColor = _cell1.StatusVMax ? FlatColors.GreenDark : FlatColors.GrayLight2;
            pictureBoxCVMAX2.BackColor = _cell2.StatusVMax ? FlatColors.GreenDark : FlatColors.GrayLight2;
            pictureBoxCVMAX3.BackColor = _cell3.StatusVMax ? FlatColors.GreenDark : FlatColors.GrayLight2;
            pictureBoxCVMAX4.BackColor = _cell4.StatusVMax ? FlatColors.GreenDark : FlatColors.GrayLight2;
            pictureBoxCVMIN1.BackColor = _cell1.StatusVMin ? FlatColors.GreenDark : FlatColors.GrayLight2;
            pictureBoxCVMIN2.BackColor = _cell2.StatusVMin ? FlatColors.GreenDark : FlatColors.GrayLight2;
            pictureBoxCVMIN3.BackColor = _cell3.StatusVMin ? FlatColors.GreenDark : FlatColors.GrayLight2;
            pictureBoxCVMIN4.BackColor = _cell4.StatusVMin ? FlatColors.GreenDark : FlatColors.GrayLight2;
            textBoxSOC1.Text = (_cell1.GetSoc() / 100).ToString();
            textBoxSOC2.Text = (_cell2.GetSoc() / 100).ToString();
            textBoxSOC3.Text = (_cell3.GetSoc() / 100).ToString();
            textBoxSOC4.Text = (_cell4.GetSoc() / 100).ToString();
            myProgressBarSOC1.Value = _cell1.GetSoc();
            myProgressBarSOC2.Value = _cell2.GetSoc();
            myProgressBarSOC3.Value = _cell3.GetSoc();
            myProgressBarSOC4.Value = _cell4.GetSoc();
            myRadioButtonBalanceCell1.Checked = _cell1.StatusBalancing;
            myRadioButtonBalanceCell2.Checked = _cell2.StatusBalancing;
            myRadioButtonBalanceCell3.Checked = _cell3.StatusBalancing;
            myRadioButtonBalanceCell4.Checked = _cell4.StatusBalancing;
            textBoxCurrent.Text = (_current / 1000).ToString();
        }

        int CheckLimits(int value, int min, int max)
        {
            return (value > max)
                ? max
                : (value < min)
                    ? min
                    : value;
        }

        double CheckLimits(double value, double min, double max)
        {
            return (value > max)
                ? max
                : (value < min)
                    ? min
                    : value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SetSpeed();
        }

        private void SetSpeed()
        {
            switch (trackBarSpeed.Value)
            {
                case 1:
                    _timerPeriod = 1;
                    break;
                case 2:
                    _timerPeriod = 5; // 90 s
                    break;
                case 3:
                    _timerPeriod = 15; // 30 s
                    break;
                case 4:
                    _timerPeriod = 30; // 15 s
                    break;
                case 5:
                    _timerPeriod = 60; // 10 s
                    break;
                case 6:
                    _timerPeriod = 128; // 8 s
                    break;
                default:
                    _timerPeriod = 1;
                    break;
            }
        }

        private bool IsCellRelaxFinished()
        {
            return _cell1.IsRelaxFinish() && _cell2.IsRelaxFinish() && _cell3.IsRelaxFinish() && _cell4.IsRelaxFinish();
        }

        private int GetMaxVoltage()
        {
            int value = _cell1.GetVoltage();
            _cell1.StatusVMax = true;
            _cell2.StatusVMax = false;
            _cell3.StatusVMax = false;
            _cell4.StatusVMax = false;
            if (_cell2.GetVoltage() > value)
            {
                value = _cell2.GetVoltage();
                _cell1.StatusVMax = false;
                _cell2.StatusVMax = true;
                _cell3.StatusVMax = false;
                _cell4.StatusVMax = false;
            }
            if (_cell3.GetVoltage() > value)
            {
                value = _cell3.GetVoltage();
                _cell1.StatusVMax = false;
                _cell2.StatusVMax = false;
                _cell3.StatusVMax = true;
                _cell4.StatusVMax = false;
            }
            if (_cell4.GetVoltage() > value)
            {
                value = _cell4.GetVoltage();
                _cell1.StatusVMax = false;
                _cell2.StatusVMax = false;
                _cell3.StatusVMax = false;
                _cell4.StatusVMax = true;
            }
            return value;
        }

        private int GetMinVoltage()
        {
            int value = _cell1.GetVoltage();
            _cell1.StatusVMin = true;
            _cell2.StatusVMin = false;
            _cell3.StatusVMin = false;
            _cell4.StatusVMin = false;
            if (_cell2.GetVoltage() < value)
            {
                value = _cell2.GetVoltage();
                _cell1.StatusVMin = false;
                _cell2.StatusVMin = true;
                _cell3.StatusVMin = false;
                _cell4.StatusVMin = false;
            }
            if (_cell3.GetVoltage() < value)
            {
                value = _cell3.GetVoltage();
                _cell1.StatusVMin = false;
                _cell2.StatusVMin = false;
                _cell3.StatusVMin = true;
                _cell4.StatusVMin = false;
            }
            if (_cell4.GetVoltage() < value)
            {
                value = _cell4.GetVoltage();
                _cell1.StatusVMin = false;
                _cell2.StatusVMin = false;
                _cell3.StatusVMin = false;
                _cell4.StatusVMin = true;
            }
            return value;
        }
        
        private int GetMaxSoc()
        {
            return new[] { _cell1.GetSoc(), _cell2.GetSoc(), _cell3.GetSoc(), _cell4.GetSoc() }.Max();
        }

        private int GetMinSoc()
        {
            return new[] { _cell1.GetSoc(), _cell2.GetSoc(), _cell3.GetSoc(), _cell4.GetSoc() }.Min();
        }

        private int GetMaxNominalCapacity()
        {
            return new[] { _cell1.NominalCapacity, _cell2.NominalCapacity, _cell3.NominalCapacity, _cell4.NominalCapacity }.Max();
        }

        private int GetMinNominalCapacity()
        {
            return new[] { _cell1.NominalCapacity, _cell2.NominalCapacity, _cell3.NominalCapacity, _cell4.NominalCapacity }.Min();
        }

        private int GetMaxDischargeCapacity()
        {
            return GetMinNominalCapacity() * _dod / 10000;
        }

        private int GetMinBalanceCurrent()
        {
            return new[] { _cell1.GetBalanceCurrent(), _cell2.GetBalanceCurrent(), _cell3.GetBalanceCurrent(), _cell4.GetBalanceCurrent() }.Min();
        }

        private void SwitchBalancing_CheckedChanged(object sender)
        {
            if (SwitchBalancing.Checked)
            {
                myRadioButtonBalanceCell1.Checked = false;
                myRadioButtonBalanceCell2.Checked = false;
                myRadioButtonBalanceCell3.Checked = false;
                myRadioButtonBalanceCell4.Checked = false;
                myRadioButtonBalanceCell1.Enabled = false;
                myRadioButtonBalanceCell2.Enabled = false;
                myRadioButtonBalanceCell3.Enabled = false;
                myRadioButtonBalanceCell4.Enabled = false;
                radioButtonAlgorithm1.Enabled = false;
                radioButtonAlgorithm2.Enabled = false;
                radioButtonAlgorithm3.Enabled = false;
                radioButtonAlgorithm4.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                radioButton7.Enabled = false;
                radioButton8.Enabled = false;
                textBoxMinSoc.ReadOnly = true;
                textBoxDod.ReadOnly = true;
                textBoxSOC1.ReadOnly = true;
                textBoxSOC2.ReadOnly = true;
                textBoxSOC3.ReadOnly = true;
                textBoxSOC4.ReadOnly = true;
                _minSocBeforeBalancing = _minSoc / 100;
                _isAutoBalanceStart = true;
                textBoxMinSoc.Text = (100 - _dod / 100).ToString();
            }
            else
            {
                myRadioButtonBalanceCell1.Enabled = true;
                myRadioButtonBalanceCell2.Enabled = true;
                myRadioButtonBalanceCell3.Enabled = true;
                myRadioButtonBalanceCell4.Enabled = true;
                myRadioButtonBalanceCell1.Checked = false;
                myRadioButtonBalanceCell2.Checked = false;
                myRadioButtonBalanceCell3.Checked = false;
                myRadioButtonBalanceCell4.Checked = false;
                radioButtonAlgorithm1.Enabled = true;
                radioButtonAlgorithm2.Enabled = true;
                radioButtonAlgorithm3.Enabled = true;
                radioButtonAlgorithm4.Enabled = true;
                textBoxMinSoc.Text = _minSocBeforeBalancing.ToString();
                _isAutoBalanceStart = false;
                if (_isGraphicStart == false)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    radioButton5.Enabled = true;
                    radioButton6.Enabled = true;
                    radioButton7.Enabled = true;
                    radioButton8.Enabled = true;
                    textBoxMinSoc.ReadOnly = false;
                    textBoxDod.ReadOnly = false;
                    textBoxSOC1.ReadOnly = false;
                    textBoxSOC2.ReadOnly = false;
                    textBoxSOC3.ReadOnly = false;
                    textBoxSOC4.ReadOnly = false;
                }
            }
        }

        private void myRadioButtonCell1_CheckedChanged(object sender, EventArgs e)
        {
            _cell1.StatusBalancing = myRadioButtonBalanceCell1.Checked;
            SetProgressBarColor(myProgressBarСellVoltage1, myRadioButtonBalanceCell1.Checked);
        }

        private void myRadioButtonCell2_CheckedChanged(object sender, EventArgs e)
        {
            _cell2.StatusBalancing = myRadioButtonBalanceCell2.Checked;
            SetProgressBarColor(myProgressBarСellVoltage2, myRadioButtonBalanceCell2.Checked);
        }

        private void myRadioButtonCell3_CheckedChanged(object sender, EventArgs e)
        {
            _cell3.StatusBalancing = myRadioButtonBalanceCell3.Checked;
            SetProgressBarColor(myProgressBarСellVoltage3, myRadioButtonBalanceCell3.Checked);
        }

        private void myRadioButtonCell4_CheckedChanged(object sender, EventArgs e)
        {
            _cell4.StatusBalancing = myRadioButtonBalanceCell4.Checked;
            SetProgressBarColor(myProgressBarСellVoltage4, myRadioButtonBalanceCell4.Checked);
        }

        private void SetProgressBarColor(MyProgressBar bar, bool isRed)
        {
            if (isRed)
            {
                bar.BackColorProgressLeft = _progressBarBackColorLeftRed;
                bar.BackColorProgressRight = _progressBarBackColorRightRed;
            }
            else
            {
                bar.BackColorProgressLeft = _progressBarBackColorLeftGreen;
                bar.BackColorProgressRight = _progressBarBackColorRightGreen;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _graphicU.ClearHistory();
        }

        private void UpdateTextBoxSoc(TextBox textBox, Cell cell)
        {
            if (textBox.ReadOnly == false)
            {
                int soc;
                try
                {
                    soc = CheckLimits(Int32.Parse(textBox.Text), MinSoc, MaxSoc);
                }
                catch (Exception)
                {
                    soc = MinSoc;
                }
                textBox.Text = soc.ToString();
                cell.SetSoc(soc * 100);
                myProgressBarSOC1.Value = _cell1.GetSoc();
                myProgressBarSOC2.Value = _cell2.GetSoc();
                myProgressBarSOC3.Value = _cell3.GetSoc();
                myProgressBarSOC4.Value = _cell4.GetSoc();
            }
        }

        private void textBoxSOC1_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxSoc(textBoxSOC1, _cell1);
        }

        private void textBoxSOC2_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxSoc(textBoxSOC2, _cell2);
        }

        private void textBoxSOC3_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxSoc(textBoxSOC3, _cell3);
        }

        private void textBoxSOC4_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxSoc(textBoxSOC4, _cell4);
        }

        private void textBoxCapacity1_TextChanged(object sender, EventArgs e)
        {
            _cell1.NominalCapacity = CheckLimits(Int32.Parse(textBoxCapacity1.Text), MinNominalCapacity, _startMaxNominalCapacity);
            textBoxCapacity1.Text = _cell1.NominalCapacity.ToString();
            textBoxMaxDischargeCapacity.Text = GetMaxDischargeCapacity().ToString();
            _maxNominalCapacity = GetMaxNominalCapacity();
            SetMaxCurrentToTextBoxCurrent();
        }

        private void textBoxCapacity2_TextChanged(object sender, EventArgs e)
        {
            _cell2.NominalCapacity = CheckLimits(Int32.Parse(textBoxCapacity2.Text), MinNominalCapacity, _startMaxNominalCapacity);
            textBoxCapacity2.Text = _cell2.NominalCapacity.ToString();
            textBoxMaxDischargeCapacity.Text = GetMaxDischargeCapacity().ToString();
            _maxNominalCapacity = GetMaxNominalCapacity();
            SetMaxCurrentToTextBoxCurrent();
        }

        private void textBoxCapacity3_TextChanged(object sender, EventArgs e)
        {
            _cell3.NominalCapacity = CheckLimits(Int32.Parse(textBoxCapacity3.Text), MinNominalCapacity, _startMaxNominalCapacity);
            textBoxCapacity3.Text = _cell3.NominalCapacity.ToString();
            textBoxMaxDischargeCapacity.Text = GetMaxDischargeCapacity().ToString();
            _maxNominalCapacity = GetMaxNominalCapacity();
            SetMaxCurrentToTextBoxCurrent();
        }

        private void textBoxCapacity4_TextChanged(object sender, EventArgs e)
        {
            _cell4.NominalCapacity = CheckLimits(Int32.Parse(textBoxCapacity4.Text), MinNominalCapacity, _startMaxNominalCapacity);
            textBoxCapacity4.Text = _cell4.NominalCapacity.ToString();
            textBoxMaxDischargeCapacity.Text = GetMaxDischargeCapacity().ToString();
            _maxNominalCapacity = GetMaxNominalCapacity();
            SetMaxCurrentToTextBoxCurrent();
        }

        private void SetMaxCurrentToTextBoxCurrent()
        {
            if (_chargeCurrent > _maxNominalCapacity)
            {
                textBoxCurrent.Text = ((int)Math.Round((double)_maxNominalCapacity / 1000)).ToString();
            }
        }

        private void textBoxSelfDischarge1_TextChanged(object sender, EventArgs e)
        {
            _cell1.SelfDischargeCurrent = Int32.Parse(textBoxSelfDischarge1.Text);
        }

        private void textBoxSelfDischarge2_TextChanged(object sender, EventArgs e)
        {
            _cell2.SelfDischargeCurrent = Int32.Parse(textBoxSelfDischarge2.Text);
        }

        private void textBoxSelfDischarge3_TextChanged(object sender, EventArgs e)
        {
            _cell3.SelfDischargeCurrent = Int32.Parse(textBoxSelfDischarge3.Text);
        }

        private void textBoxSelfDischarge4_TextChanged(object sender, EventArgs e)
        {
            _cell4.SelfDischargeCurrent = Int32.Parse(textBoxSelfDischarge4.Text);
        }

        private void textBoxInternalResistance1_TextChanged(object sender, EventArgs e)
        {
            _cell1.InternalResistance = Int32.Parse(textBoxInternalResistance1.Text);
        }

        private void textBoxInternalResistance2_TextChanged(object sender, EventArgs e)
        {
            _cell2.InternalResistance = Int32.Parse(textBoxInternalResistance2.Text);
        }

        private void textBoxInternalResistance3_TextChanged(object sender, EventArgs e)
        {
            _cell3.InternalResistance = Int32.Parse(textBoxInternalResistance3.Text);
        }

        private void textBoxInternalResistance4_TextChanged(object sender, EventArgs e)
        {
            _cell4.InternalResistance = Int32.Parse(textBoxInternalResistance4.Text);
        }

        private void textBoxBalanceResistance_TextChanged(object sender, EventArgs e)
        {
            int balanceResistance = Int32.Parse(textBoxBalanceResistance.Text);
            _cell1.BalancingResistance = balanceResistance;
            _cell2.BalancingResistance = balanceResistance;
            _cell3.BalancingResistance = balanceResistance;
            _cell4.BalancingResistance = balanceResistance;
        }

        private void textBoxMinSoc_TextChanged(object sender, EventArgs e)
        {
            _minSoc = CheckLimits(Int32.Parse(textBoxMinSoc.Text), MinSoc, MaxSoc) * 100;
            textBoxMinSoc.Text = (_minSoc / 100).ToString();
            if ((10000 - _minSoc) < _dod)
            {
                textBoxDod.Text = (100 - (_minSoc / 100)).ToString();
            }
            _maxSoc = _minSoc + _dod;
            textBoxMaxSoc.Text = (_maxSoc / 100).ToString();
            if (_isAutoBalanceStart == false)
            {
                textBoxSOC1.Text = (_minSoc / 100).ToString();
                textBoxSOC2.Text = (_minSoc / 100).ToString();
                textBoxSOC3.Text = (_minSoc / 100).ToString();
                textBoxSOC4.Text = (_minSoc / 100).ToString();
            }
        }

        private void textBoxDod_TextChanged(object sender, EventArgs e)
        {
            _dod = CheckLimits(Int32.Parse(textBoxDod.Text) * 100, MinSoc, MaxSoc * 100 - _minSoc);
            textBoxDod.Text = (_dod / 100).ToString();
            textBoxMaxDischargeCapacity.Text = GetMaxDischargeCapacity().ToString();
            _maxSoc = _minSoc + _dod;
            textBoxMaxSoc.Text = (_maxSoc / 100).ToString();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBoxCapacity1.Text = 60000.ToString();
            textBoxCapacity2.Text = 60000.ToString();
            textBoxCapacity3.Text = 60000.ToString();
            textBoxCapacity4.Text = 60000.ToString();
            textBoxSelfDischarge1.Text = 270.ToString();
            textBoxSelfDischarge2.Text = 270.ToString();
            textBoxSelfDischarge3.Text = 270.ToString();
            textBoxSelfDischarge4.Text = 270.ToString();
            textBoxInternalResistance1.Text = 350.ToString();
            textBoxInternalResistance2.Text = 350.ToString();
            textBoxInternalResistance3.Text = 350.ToString();
            textBoxInternalResistance4.Text = 350.ToString();
            textBoxBalanceResistance.Text = 13.ToString();
            textBoxCurrent.Text = 20.ToString();
            textBoxMinSoc.Text = 0.ToString();
            textBoxDod.Text = 100.ToString();
            textBoxSOC1.Text = 0.ToString();
            textBoxSOC2.Text = 0.ToString();
            textBoxSOC3.Text = 0.ToString();
            textBoxSOC4.Text = 0.ToString();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBoxCapacity1.Text = 60000.ToString();
            textBoxCapacity2.Text = 60000.ToString();
            textBoxCapacity3.Text = 60000.ToString();
            textBoxCapacity4.Text = 60000.ToString();
            textBoxSelfDischarge1.Text = 270.ToString();
            textBoxSelfDischarge2.Text = 270.ToString();
            textBoxSelfDischarge3.Text = 270.ToString();
            textBoxSelfDischarge4.Text = 270.ToString();
            textBoxInternalResistance1.Text = 350.ToString();
            textBoxInternalResistance2.Text = 350.ToString();
            textBoxInternalResistance3.Text = 350.ToString();
            textBoxInternalResistance4.Text = 350.ToString();
            textBoxBalanceResistance.Text = 13.ToString();
            textBoxCurrent.Text = 20.ToString();
            textBoxMinSoc.Text = 0.ToString();
            textBoxDod.Text = 100.ToString();
            textBoxSOC1.Text = 1.ToString();
            textBoxSOC2.Text = 1.ToString();
            textBoxSOC3.Text = 0.ToString();
            textBoxSOC4.Text = 1.ToString();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            textBoxCapacity1.Text = 60000.ToString();
            textBoxCapacity2.Text = 58500.ToString();
            textBoxCapacity3.Text = 59000.ToString();
            textBoxCapacity4.Text = 60000.ToString();
            textBoxSelfDischarge1.Text = 570.ToString();
            textBoxSelfDischarge2.Text = 330.ToString();
            textBoxSelfDischarge3.Text = 270.ToString();
            textBoxSelfDischarge4.Text = 450.ToString();
            textBoxInternalResistance1.Text = 450.ToString();
            textBoxInternalResistance2.Text = 380.ToString();
            textBoxInternalResistance3.Text = 210.ToString();
            textBoxInternalResistance4.Text = 350.ToString();
            textBoxBalanceResistance.Text = 13.ToString();
            textBoxCurrent.Text = 20.ToString();
            textBoxMinSoc.Text = 0.ToString();
            textBoxDod.Text = 100.ToString();
            textBoxSOC1.Text = 3.ToString();
            textBoxSOC2.Text = 2.ToString();
            textBoxSOC3.Text = 1.ToString();
            textBoxSOC4.Text = 0.ToString();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            textBoxCapacity1.Text = 60000.ToString();
            textBoxCapacity2.Text = 60000.ToString();
            textBoxCapacity3.Text = 60000.ToString();
            textBoxCapacity4.Text = 60000.ToString();
            textBoxSelfDischarge1.Text = 270.ToString();
            textBoxSelfDischarge2.Text = 270.ToString();
            textBoxSelfDischarge3.Text = 270.ToString();
            textBoxSelfDischarge4.Text = 270.ToString();
            textBoxInternalResistance1.Text = 350.ToString();
            textBoxInternalResistance2.Text = 350.ToString();
            textBoxInternalResistance3.Text = 350.ToString();
            textBoxInternalResistance4.Text = 350.ToString();
            textBoxBalanceResistance.Text = 13.ToString();
            textBoxCurrent.Text = 20.ToString();
            textBoxMinSoc.Text = 10.ToString();
            textBoxDod.Text = 80.ToString();
            textBoxSOC1.Text = 12.ToString();
            textBoxSOC2.Text = 11.ToString();
            textBoxSOC3.Text = 10.ToString();
            textBoxSOC4.Text = 12.ToString();
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            textBoxCapacity1.Text = _startMaxNominalCapacity.ToString();
            textBoxCapacity2.Text = (_startMaxNominalCapacity - 800).ToString();
            textBoxCapacity3.Text = (_startMaxNominalCapacity - 600).ToString();
            textBoxCapacity4.Text = (_startMaxNominalCapacity - 400).ToString();
            textBoxSelfDischarge1.Text = 270.ToString();
            textBoxSelfDischarge2.Text = 270.ToString();
            textBoxSelfDischarge3.Text = 270.ToString();
            textBoxSelfDischarge4.Text = 270.ToString();
            textBoxInternalResistance1.Text = 350.ToString();
            textBoxInternalResistance2.Text = 350.ToString();
            textBoxInternalResistance3.Text = 350.ToString();
            textBoxInternalResistance4.Text = 350.ToString();
            textBoxBalanceResistance.Text = 13.ToString();
            textBoxCurrent.Text = 20.ToString();
            textBoxMinSoc.Text = 0.ToString();
            textBoxDod.Text = 100.ToString();
            textBoxSOC1.Text = 0.ToString();
            textBoxSOC2.Text = 0.ToString();
            textBoxSOC3.Text = 0.ToString();
            textBoxSOC4.Text = 0.ToString();
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            textBoxCapacity1.Text = (_startMaxNominalCapacity - 1000).ToString();
            textBoxCapacity2.Text = (_startMaxNominalCapacity - 2000).ToString();
            textBoxCapacity3.Text = _startMaxNominalCapacity.ToString();
            textBoxCapacity4.Text = (_startMaxNominalCapacity - 4000).ToString();
            textBoxSelfDischarge1.Text = 580.ToString();
            textBoxSelfDischarge2.Text = 850.ToString();
            textBoxSelfDischarge3.Text = 970.ToString();
            textBoxSelfDischarge4.Text = 740.ToString();
            textBoxCurrent.Text = 20.ToString();
            textBoxMinSoc.Text = 10.ToString();
            textBoxDod.Text = 80.ToString();
            textBoxSOC1.Text = 15.ToString();
            textBoxSOC2.Text = 10.ToString();
            textBoxSOC3.Text = 5.ToString();
            textBoxSOC4.Text = 0.ToString();
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            textBoxCapacity1.Text = (_startMaxNominalCapacity - 5000).ToString();
            textBoxCapacity2.Text = _startMaxNominalCapacity.ToString();
            textBoxCapacity3.Text = _startMaxNominalCapacity.ToString();
            textBoxCapacity4.Text = _startMaxNominalCapacity.ToString();
            textBoxSelfDischarge1.Text = 580.ToString();
            textBoxSelfDischarge2.Text = 850.ToString();
            textBoxSelfDischarge3.Text = 970.ToString();
            textBoxSelfDischarge4.Text = 740.ToString();
            textBoxCurrent.Text = 20.ToString();
            textBoxMinSoc.Text = 0.ToString();
            textBoxDod.Text = 100.ToString();
            textBoxSOC1.Text = 0.ToString();
            textBoxSOC2.Text = 6.ToString();
            textBoxSOC3.Text = 6.ToString();
            textBoxSOC4.Text = 6.ToString();
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            textBoxCapacity1.Text = (_startMaxNominalCapacity - 5000).ToString();
            textBoxCapacity2.Text = (_startMaxNominalCapacity - 6000).ToString();
            textBoxCapacity3.Text = (_startMaxNominalCapacity - 3000).ToString();
            textBoxCapacity4.Text = (_startMaxNominalCapacity - 1000).ToString();
            textBoxSelfDischarge1.Text = 970.ToString();
            textBoxSelfDischarge2.Text = 330.ToString();
            textBoxSelfDischarge3.Text = 580.ToString();
            textBoxSelfDischarge4.Text = 850.ToString();
            textBoxCurrent.Text = 120.ToString();
            textBoxMinSoc.Text = 0.ToString();
            textBoxDod.Text = 100.ToString();
            textBoxSOC1.Text = 0.ToString();
            textBoxSOC2.Text = 15.ToString();
            textBoxSOC3.Text = 7.ToString();
            textBoxSOC4.Text = 3.ToString();
            textBoxInternalResistance1.Text = 1150.ToString();
            textBoxInternalResistance2.Text = 1350.ToString();
            textBoxInternalResistance3.Text = 1550.ToString();
            textBoxInternalResistance4.Text = 1750.ToString();
        }

        private void textBoxCurrent_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCurrent.ReadOnly == false)
            {
                int nominalCapacity = GetMinNominalCapacity() / 1000;
                int enteredCurrent;
                try
                {
                    enteredCurrent = Int32.Parse(textBoxCurrent.Text);
                }
                catch (Exception)
                {
                    enteredCurrent = (int)(nominalCapacity * MinCurrentC);
                }
                int value = CheckLimits(enteredCurrent, -nominalCapacity * MaxCurrentC, nominalCapacity);
                textBoxCurrent.Text = value.ToString();
            }
        }

        private void radioButtonAlgorithm1_Click(object sender, EventArgs e)
        {
            _balancingAlgorithm = IndexOfBalancing.Algorithm1;
        }

        private void radioButtonAlgorithm2_Click(object sender, EventArgs e)
        {
            _balancingAlgorithm = IndexOfBalancing.Algorithm2;
        }

        private void radioButtonAlgorithm3_Click(object sender, EventArgs e)
        {
            _balancingAlgorithm = IndexOfBalancing.Algorithm3;
        }

        private void radioButtonAlgorithm4_Click(object sender, EventArgs e)
        {
            _balancingAlgorithm = IndexOfBalancing.Algorithm4;
        }

        private void pictureBoxFlagRu_Click(object sender, EventArgs e)
        {
            LoadRussianLanguage();
        }

        private void pictureBoxFlagDe_Click(object sender, EventArgs e)
        {
            LoadGermanLanguage();
        }

        private void pictureBoxFlagEn_Click(object sender, EventArgs e)
        {
            LoadEnglishLanguage();
        }
    }
}
