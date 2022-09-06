
using BalancingSimulation.Controls;

namespace BalancingSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxCellState = new System.Windows.Forms.GroupBox();
            this.groupBoxBalancingAlgorithm = new System.Windows.Forms.GroupBox();
            this.radioButtonAlgorithm4 = new System.Windows.Forms.RadioButton();
            this.radioButtonAlgorithm3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAlgorithm2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAlgorithm1 = new System.Windows.Forms.RadioButton();
            this.textBoxCapacityLevel4 = new System.Windows.Forms.TextBox();
            this.myLabel11 = new BalancingSimulation.Controls.MyLabel();
            this.textBoxCapacityLevel3 = new System.Windows.Forms.TextBox();
            this.myLabel12 = new BalancingSimulation.Controls.MyLabel();
            this.textBoxCapacityLevel2 = new System.Windows.Forms.TextBox();
            this.textBoxCapacityLevel1 = new System.Windows.Forms.TextBox();
            this.textBoxBalanceCurrent4 = new System.Windows.Forms.TextBox();
            this.myLabel10 = new BalancingSimulation.Controls.MyLabel();
            this.textBoxBalanceCurrent3 = new System.Windows.Forms.TextBox();
            this.myLabel9 = new BalancingSimulation.Controls.MyLabel();
            this.textBoxBalanceCurrent2 = new System.Windows.Forms.TextBox();
            this.myLabel4 = new BalancingSimulation.Controls.MyLabel();
            this.textBoxBalanceCurrent1 = new System.Windows.Forms.TextBox();
            this.myProgressBarСellVoltage4 = new BalancingSimulation.Controls.MyProgressBar();
            this.myProgressBarСellVoltage3 = new BalancingSimulation.Controls.MyProgressBar();
            this.myProgressBarSOC4 = new BalancingSimulation.Controls.MyProgressBar();
            this.myProgressBarSOC1 = new BalancingSimulation.Controls.MyProgressBar();
            this.myProgressBarСellVoltage2 = new BalancingSimulation.Controls.MyProgressBar();
            this.myProgressBarСellVoltage1 = new BalancingSimulation.Controls.MyProgressBar();
            this.myProgressBarSOC3 = new BalancingSimulation.Controls.MyProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.myProgressBarSOC2 = new BalancingSimulation.Controls.MyProgressBar();
            this.textBoxMaxSoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxBalanceResistance = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxImbalance = new System.Windows.Forms.TextBox();
            this.textBoxDod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMinSoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxCell4Color = new System.Windows.Forms.PictureBox();
            this.pictureBoxCell3Color = new System.Windows.Forms.PictureBox();
            this.pictureBoxCell2Color = new System.Windows.Forms.PictureBox();
            this.pictureBoxCell1Color = new System.Windows.Forms.PictureBox();
            this.textBoxSOC4 = new System.Windows.Forms.TextBox();
            this.textBoxSOC3 = new System.Windows.Forms.TextBox();
            this.textBoxSOC2 = new System.Windows.Forms.TextBox();
            this.textBoxSOC1 = new System.Windows.Forms.TextBox();
            this.myLabel3 = new BalancingSimulation.Controls.MyLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.myRadioButtonBalanceCell4 = new BalancingSimulation.Controls.MyRadioButton();
            this.myLabel2 = new BalancingSimulation.Controls.MyLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.myRadioButtonBalanceCell3 = new BalancingSimulation.Controls.MyRadioButton();
            this.myLabel1 = new BalancingSimulation.Controls.MyLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.myRadioButtonBalanceCell2 = new BalancingSimulation.Controls.MyRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.myRadioButtonBalanceCell1 = new BalancingSimulation.Controls.MyRadioButton();
            this.SwitchBalancing = new BalancingSimulation.Controls.ToggleSwitch();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBoxCVMAX4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCVMIN4 = new System.Windows.Forms.PictureBox();
            this.textBoxСellVoltage4 = new System.Windows.Forms.TextBox();
            this.pictureBoxCVMAX3 = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.pictureBoxCVMIN3 = new System.Windows.Forms.PictureBox();
            this.textBoxСellVoltage3 = new System.Windows.Forms.TextBox();
            this.pictureBoxCVMAX2 = new System.Windows.Forms.PictureBox();
            this.label31 = new System.Windows.Forms.Label();
            this.pictureBoxCVMIN2 = new System.Windows.Forms.PictureBox();
            this.textBoxСellVoltage2 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxСellVoltage1 = new System.Windows.Forms.TextBox();
            this.pictureBoxCVMAX1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCVMIN1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCycleNumber = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonPlay = new BalancingSimulation.Controls.RoundButton();
            this.ButtonStop = new BalancingSimulation.Controls.RoundButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.myLabel13 = new BalancingSimulation.Controls.MyLabel();
            this.myLabel14 = new BalancingSimulation.Controls.MyLabel();
            this.textBoxInternalResistance4 = new System.Windows.Forms.TextBox();
            this.textBoxInternalResistance3 = new System.Windows.Forms.TextBox();
            this.textBoxInternalResistance2 = new System.Windows.Forms.TextBox();
            this.textBoxInternalResistance1 = new System.Windows.Forms.TextBox();
            this.myLabel8 = new BalancingSimulation.Controls.MyLabel();
            this.myLabel7 = new BalancingSimulation.Controls.MyLabel();
            this.myLabel6 = new BalancingSimulation.Controls.MyLabel();
            this.myLabel5 = new BalancingSimulation.Controls.MyLabel();
            this.textBoxSelfDischarge4 = new System.Windows.Forms.TextBox();
            this.textBoxSelfDischarge3 = new System.Windows.Forms.TextBox();
            this.textBoxSelfDischarge2 = new System.Windows.Forms.TextBox();
            this.textBoxSelfDischarge1 = new System.Windows.Forms.TextBox();
            this.textBoxCapacity4 = new System.Windows.Forms.TextBox();
            this.textBoxCapacity3 = new System.Windows.Forms.TextBox();
            this.textBoxCapacity2 = new System.Windows.Forms.TextBox();
            this.textBoxCapacity1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCapacityImbalance = new System.Windows.Forms.TextBox();
            this.myProgressBarBalanceStatus = new BalancingSimulation.Controls.MyProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxMaxDischargeCapacity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxDischargeCapacity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxFlagEn = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlagDe = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlagRu = new System.Windows.Forms.PictureBox();
            this.pictureBoxGraphic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBoxCellState.SuspendLayout();
            this.groupBoxBalancingAlgorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCell4Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCell3Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCell2Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCell1Color)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMAX4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMIN4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMAX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMIN3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMAX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMIN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMAX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMIN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagEn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagRu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSpeed.Location = new System.Drawing.Point(6, 31);
            this.trackBarSpeed.Maximum = 6;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(173, 45);
            this.trackBarSpeed.TabIndex = 8;
            this.trackBarSpeed.Value = 5;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Скорость моделирования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Автоматическая балансировка";
            // 
            // groupBoxCellState
            // 
            this.groupBoxCellState.Controls.Add(this.groupBoxBalancingAlgorithm);
            this.groupBoxCellState.Controls.Add(this.textBoxCapacityLevel4);
            this.groupBoxCellState.Controls.Add(this.myLabel11);
            this.groupBoxCellState.Controls.Add(this.textBoxCapacityLevel3);
            this.groupBoxCellState.Controls.Add(this.myLabel12);
            this.groupBoxCellState.Controls.Add(this.textBoxCapacityLevel2);
            this.groupBoxCellState.Controls.Add(this.textBoxCapacityLevel1);
            this.groupBoxCellState.Controls.Add(this.textBoxBalanceCurrent4);
            this.groupBoxCellState.Controls.Add(this.myLabel10);
            this.groupBoxCellState.Controls.Add(this.textBoxBalanceCurrent3);
            this.groupBoxCellState.Controls.Add(this.myLabel9);
            this.groupBoxCellState.Controls.Add(this.textBoxBalanceCurrent2);
            this.groupBoxCellState.Controls.Add(this.myLabel4);
            this.groupBoxCellState.Controls.Add(this.textBoxBalanceCurrent1);
            this.groupBoxCellState.Controls.Add(this.myProgressBarСellVoltage4);
            this.groupBoxCellState.Controls.Add(this.myProgressBarСellVoltage3);
            this.groupBoxCellState.Controls.Add(this.myProgressBarSOC4);
            this.groupBoxCellState.Controls.Add(this.myProgressBarSOC1);
            this.groupBoxCellState.Controls.Add(this.myProgressBarСellVoltage2);
            this.groupBoxCellState.Controls.Add(this.myProgressBarСellVoltage1);
            this.groupBoxCellState.Controls.Add(this.myProgressBarSOC3);
            this.groupBoxCellState.Controls.Add(this.label15);
            this.groupBoxCellState.Controls.Add(this.myProgressBarSOC2);
            this.groupBoxCellState.Controls.Add(this.textBoxMaxSoc);
            this.groupBoxCellState.Controls.Add(this.label14);
            this.groupBoxCellState.Controls.Add(this.textBoxBalanceResistance);
            this.groupBoxCellState.Controls.Add(this.label13);
            this.groupBoxCellState.Controls.Add(this.textBoxImbalance);
            this.groupBoxCellState.Controls.Add(this.textBoxDod);
            this.groupBoxCellState.Controls.Add(this.label12);
            this.groupBoxCellState.Controls.Add(this.textBoxMinSoc);
            this.groupBoxCellState.Controls.Add(this.label5);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCell4Color);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCell3Color);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCell2Color);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCell1Color);
            this.groupBoxCellState.Controls.Add(this.textBoxSOC4);
            this.groupBoxCellState.Controls.Add(this.textBoxSOC3);
            this.groupBoxCellState.Controls.Add(this.textBoxSOC2);
            this.groupBoxCellState.Controls.Add(this.textBoxSOC1);
            this.groupBoxCellState.Controls.Add(this.myLabel3);
            this.groupBoxCellState.Controls.Add(this.panel5);
            this.groupBoxCellState.Controls.Add(this.myLabel2);
            this.groupBoxCellState.Controls.Add(this.panel4);
            this.groupBoxCellState.Controls.Add(this.myLabel1);
            this.groupBoxCellState.Controls.Add(this.panel3);
            this.groupBoxCellState.Controls.Add(this.panel2);
            this.groupBoxCellState.Controls.Add(this.label3);
            this.groupBoxCellState.Controls.Add(this.SwitchBalancing);
            this.groupBoxCellState.Controls.Add(this.label11);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCVMAX4);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCVMIN4);
            this.groupBoxCellState.Controls.Add(this.textBoxСellVoltage4);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCVMAX3);
            this.groupBoxCellState.Controls.Add(this.label36);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCVMIN3);
            this.groupBoxCellState.Controls.Add(this.textBoxСellVoltage3);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCVMAX2);
            this.groupBoxCellState.Controls.Add(this.label31);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCVMIN2);
            this.groupBoxCellState.Controls.Add(this.textBoxСellVoltage2);
            this.groupBoxCellState.Controls.Add(this.label29);
            this.groupBoxCellState.Controls.Add(this.pictureBox3);
            this.groupBoxCellState.Controls.Add(this.label27);
            this.groupBoxCellState.Controls.Add(this.textBoxСellVoltage1);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCVMAX1);
            this.groupBoxCellState.Controls.Add(this.pictureBoxCVMIN1);
            this.groupBoxCellState.Controls.Add(this.pictureBox2);
            this.groupBoxCellState.Location = new System.Drawing.Point(13, 512);
            this.groupBoxCellState.Name = "groupBoxCellState";
            this.groupBoxCellState.Size = new System.Drawing.Size(779, 210);
            this.groupBoxCellState.TabIndex = 24;
            this.groupBoxCellState.TabStop = false;
            this.groupBoxCellState.Text = "Состояние ячеек";
            // 
            // groupBoxBalancingAlgorithm
            // 
            this.groupBoxBalancingAlgorithm.Controls.Add(this.radioButtonAlgorithm4);
            this.groupBoxBalancingAlgorithm.Controls.Add(this.radioButtonAlgorithm3);
            this.groupBoxBalancingAlgorithm.Controls.Add(this.radioButtonAlgorithm2);
            this.groupBoxBalancingAlgorithm.Controls.Add(this.radioButtonAlgorithm1);
            this.groupBoxBalancingAlgorithm.Location = new System.Drawing.Point(6, 15);
            this.groupBoxBalancingAlgorithm.Name = "groupBoxBalancingAlgorithm";
            this.groupBoxBalancingAlgorithm.Size = new System.Drawing.Size(149, 51);
            this.groupBoxBalancingAlgorithm.TabIndex = 169;
            this.groupBoxBalancingAlgorithm.TabStop = false;
            this.groupBoxBalancingAlgorithm.Text = "Алгоритм балансировки";
            // 
            // radioButtonAlgorithm4
            // 
            this.radioButtonAlgorithm4.AutoSize = true;
            this.radioButtonAlgorithm4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonAlgorithm4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAlgorithm4.Location = new System.Drawing.Point(75, 14);
            this.radioButtonAlgorithm4.Name = "radioButtonAlgorithm4";
            this.radioButtonAlgorithm4.Size = new System.Drawing.Size(17, 30);
            this.radioButtonAlgorithm4.TabIndex = 11;
            this.radioButtonAlgorithm4.Text = "4";
            this.radioButtonAlgorithm4.UseVisualStyleBackColor = true;
            this.radioButtonAlgorithm4.Click += new System.EventHandler(this.radioButtonAlgorithm4_Click);
            // 
            // radioButtonAlgorithm3
            // 
            this.radioButtonAlgorithm3.AutoSize = true;
            this.radioButtonAlgorithm3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonAlgorithm3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAlgorithm3.Location = new System.Drawing.Point(52, 14);
            this.radioButtonAlgorithm3.Name = "radioButtonAlgorithm3";
            this.radioButtonAlgorithm3.Size = new System.Drawing.Size(17, 30);
            this.radioButtonAlgorithm3.TabIndex = 10;
            this.radioButtonAlgorithm3.Text = "3";
            this.radioButtonAlgorithm3.UseVisualStyleBackColor = true;
            this.radioButtonAlgorithm3.Click += new System.EventHandler(this.radioButtonAlgorithm3_Click);
            // 
            // radioButtonAlgorithm2
            // 
            this.radioButtonAlgorithm2.AutoSize = true;
            this.radioButtonAlgorithm2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonAlgorithm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAlgorithm2.Location = new System.Drawing.Point(29, 14);
            this.radioButtonAlgorithm2.Name = "radioButtonAlgorithm2";
            this.radioButtonAlgorithm2.Size = new System.Drawing.Size(17, 30);
            this.radioButtonAlgorithm2.TabIndex = 9;
            this.radioButtonAlgorithm2.Text = "2";
            this.radioButtonAlgorithm2.UseVisualStyleBackColor = true;
            this.radioButtonAlgorithm2.Click += new System.EventHandler(this.radioButtonAlgorithm2_Click);
            // 
            // radioButtonAlgorithm1
            // 
            this.radioButtonAlgorithm1.AutoSize = true;
            this.radioButtonAlgorithm1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonAlgorithm1.Checked = true;
            this.radioButtonAlgorithm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAlgorithm1.Location = new System.Drawing.Point(6, 14);
            this.radioButtonAlgorithm1.Name = "radioButtonAlgorithm1";
            this.radioButtonAlgorithm1.Size = new System.Drawing.Size(17, 30);
            this.radioButtonAlgorithm1.TabIndex = 8;
            this.radioButtonAlgorithm1.TabStop = true;
            this.radioButtonAlgorithm1.Text = "1";
            this.radioButtonAlgorithm1.UseVisualStyleBackColor = true;
            this.radioButtonAlgorithm1.Click += new System.EventHandler(this.radioButtonAlgorithm1_Click);
            // 
            // textBoxCapacityLevel4
            // 
            this.textBoxCapacityLevel4.Location = new System.Drawing.Point(732, 178);
            this.textBoxCapacityLevel4.Name = "textBoxCapacityLevel4";
            this.textBoxCapacityLevel4.ReadOnly = true;
            this.textBoxCapacityLevel4.Size = new System.Drawing.Size(40, 20);
            this.textBoxCapacityLevel4.TabIndex = 168;
            this.textBoxCapacityLevel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myLabel11
            // 
            this.myLabel11.Location = new System.Drawing.Point(752, 69);
            this.myLabel11.Name = "myLabel11";
            this.myLabel11.Size = new System.Drawing.Size(15, 27);
            this.myLabel11.TabIndex = 164;
            this.myLabel11.Text = "мАч";
            // 
            // textBoxCapacityLevel3
            // 
            this.textBoxCapacityLevel3.Location = new System.Drawing.Point(732, 152);
            this.textBoxCapacityLevel3.Name = "textBoxCapacityLevel3";
            this.textBoxCapacityLevel3.ReadOnly = true;
            this.textBoxCapacityLevel3.Size = new System.Drawing.Size(40, 20);
            this.textBoxCapacityLevel3.TabIndex = 167;
            this.textBoxCapacityLevel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myLabel12
            // 
            this.myLabel12.Location = new System.Drawing.Point(735, 55);
            this.myLabel12.Name = "myLabel12";
            this.myLabel12.Size = new System.Drawing.Size(15, 41);
            this.myLabel12.TabIndex = 163;
            this.myLabel12.Text = "Заряд,";
            // 
            // textBoxCapacityLevel2
            // 
            this.textBoxCapacityLevel2.Location = new System.Drawing.Point(732, 126);
            this.textBoxCapacityLevel2.Name = "textBoxCapacityLevel2";
            this.textBoxCapacityLevel2.ReadOnly = true;
            this.textBoxCapacityLevel2.Size = new System.Drawing.Size(40, 20);
            this.textBoxCapacityLevel2.TabIndex = 166;
            this.textBoxCapacityLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCapacityLevel1
            // 
            this.textBoxCapacityLevel1.Location = new System.Drawing.Point(732, 100);
            this.textBoxCapacityLevel1.Name = "textBoxCapacityLevel1";
            this.textBoxCapacityLevel1.ReadOnly = true;
            this.textBoxCapacityLevel1.Size = new System.Drawing.Size(40, 20);
            this.textBoxCapacityLevel1.TabIndex = 165;
            this.textBoxCapacityLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBalanceCurrent4
            // 
            this.textBoxBalanceCurrent4.Location = new System.Drawing.Point(432, 178);
            this.textBoxBalanceCurrent4.Name = "textBoxBalanceCurrent4";
            this.textBoxBalanceCurrent4.ReadOnly = true;
            this.textBoxBalanceCurrent4.Size = new System.Drawing.Size(40, 20);
            this.textBoxBalanceCurrent4.TabIndex = 162;
            this.textBoxBalanceCurrent4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myLabel10
            // 
            this.myLabel10.Location = new System.Drawing.Point(453, 75);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.Size = new System.Drawing.Size(15, 21);
            this.myLabel10.TabIndex = 156;
            this.myLabel10.Text = "мА";
            // 
            // textBoxBalanceCurrent3
            // 
            this.textBoxBalanceCurrent3.Location = new System.Drawing.Point(432, 152);
            this.textBoxBalanceCurrent3.Name = "textBoxBalanceCurrent3";
            this.textBoxBalanceCurrent3.ReadOnly = true;
            this.textBoxBalanceCurrent3.Size = new System.Drawing.Size(40, 20);
            this.textBoxBalanceCurrent3.TabIndex = 161;
            this.textBoxBalanceCurrent3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myLabel9
            // 
            this.myLabel9.Location = new System.Drawing.Point(436, 28);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.Size = new System.Drawing.Size(15, 68);
            this.myLabel9.TabIndex = 155;
            this.myLabel9.Text = "Ток баланс.";
            // 
            // textBoxBalanceCurrent2
            // 
            this.textBoxBalanceCurrent2.Location = new System.Drawing.Point(432, 126);
            this.textBoxBalanceCurrent2.Name = "textBoxBalanceCurrent2";
            this.textBoxBalanceCurrent2.ReadOnly = true;
            this.textBoxBalanceCurrent2.Size = new System.Drawing.Size(40, 20);
            this.textBoxBalanceCurrent2.TabIndex = 160;
            this.textBoxBalanceCurrent2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myLabel4
            // 
            this.myLabel4.Location = new System.Drawing.Point(484, 50);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(15, 46);
            this.myLabel4.TabIndex = 154;
            this.myLabel4.Text = "SOC, %";
            // 
            // textBoxBalanceCurrent1
            // 
            this.textBoxBalanceCurrent1.Location = new System.Drawing.Point(432, 100);
            this.textBoxBalanceCurrent1.Name = "textBoxBalanceCurrent1";
            this.textBoxBalanceCurrent1.ReadOnly = true;
            this.textBoxBalanceCurrent1.Size = new System.Drawing.Size(40, 20);
            this.textBoxBalanceCurrent1.TabIndex = 159;
            this.textBoxBalanceCurrent1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myProgressBarСellVoltage4
            // 
            this.myProgressBarСellVoltage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.myProgressBarСellVoltage4.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.myProgressBarСellVoltage4.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.myProgressBarСellVoltage4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.myProgressBarСellVoltage4.Location = new System.Drawing.Point(110, 184);
            this.myProgressBarСellVoltage4.Maximum = 3800;
            this.myProgressBarСellVoltage4.Minimum = 2600;
            this.myProgressBarСellVoltage4.Name = "myProgressBarСellVoltage4";
            this.myProgressBarСellVoltage4.Size = new System.Drawing.Size(241, 10);
            this.myProgressBarСellVoltage4.Step = 10;
            this.myProgressBarСellVoltage4.TabIndex = 36;
            this.myProgressBarСellVoltage4.Text = "myProgressBar1";
            this.myProgressBarСellVoltage4.Value = 2600;
            // 
            // myProgressBarСellVoltage3
            // 
            this.myProgressBarСellVoltage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.myProgressBarСellVoltage3.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.myProgressBarСellVoltage3.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.myProgressBarСellVoltage3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.myProgressBarСellVoltage3.Location = new System.Drawing.Point(110, 158);
            this.myProgressBarСellVoltage3.Maximum = 3800;
            this.myProgressBarСellVoltage3.Minimum = 2600;
            this.myProgressBarСellVoltage3.Name = "myProgressBarСellVoltage3";
            this.myProgressBarСellVoltage3.Size = new System.Drawing.Size(241, 10);
            this.myProgressBarСellVoltage3.Step = 10;
            this.myProgressBarСellVoltage3.TabIndex = 37;
            this.myProgressBarСellVoltage3.Text = "myProgressBar1";
            this.myProgressBarСellVoltage3.Value = 2600;
            // 
            // myProgressBarSOC4
            // 
            this.myProgressBarSOC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.myProgressBarSOC4.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.myProgressBarSOC4.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.myProgressBarSOC4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.myProgressBarSOC4.Location = new System.Drawing.Point(514, 184);
            this.myProgressBarSOC4.Maximum = 10000;
            this.myProgressBarSOC4.Minimum = 0;
            this.myProgressBarSOC4.Name = "myProgressBarSOC4";
            this.myProgressBarSOC4.Size = new System.Drawing.Size(201, 10);
            this.myProgressBarSOC4.Step = 10;
            this.myProgressBarSOC4.TabIndex = 32;
            this.myProgressBarSOC4.Text = "myProgressBar1";
            this.myProgressBarSOC4.Value = 0;
            // 
            // myProgressBarSOC1
            // 
            this.myProgressBarSOC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.myProgressBarSOC1.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.myProgressBarSOC1.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.myProgressBarSOC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.myProgressBarSOC1.Location = new System.Drawing.Point(514, 106);
            this.myProgressBarSOC1.Maximum = 10000;
            this.myProgressBarSOC1.Minimum = 0;
            this.myProgressBarSOC1.Name = "myProgressBarSOC1";
            this.myProgressBarSOC1.Size = new System.Drawing.Size(201, 10);
            this.myProgressBarSOC1.Step = 100;
            this.myProgressBarSOC1.TabIndex = 29;
            this.myProgressBarSOC1.Text = "myProgressBar1";
            this.myProgressBarSOC1.Value = 0;
            // 
            // myProgressBarСellVoltage2
            // 
            this.myProgressBarСellVoltage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.myProgressBarСellVoltage2.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.myProgressBarСellVoltage2.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.myProgressBarСellVoltage2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.myProgressBarСellVoltage2.Location = new System.Drawing.Point(110, 132);
            this.myProgressBarСellVoltage2.Maximum = 3800;
            this.myProgressBarСellVoltage2.Minimum = 2600;
            this.myProgressBarСellVoltage2.Name = "myProgressBarСellVoltage2";
            this.myProgressBarСellVoltage2.Size = new System.Drawing.Size(241, 10);
            this.myProgressBarСellVoltage2.Step = 10;
            this.myProgressBarСellVoltage2.TabIndex = 34;
            this.myProgressBarСellVoltage2.Text = "myProgressBar1";
            this.myProgressBarСellVoltage2.Value = 2600;
            // 
            // myProgressBarСellVoltage1
            // 
            this.myProgressBarСellVoltage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.myProgressBarСellVoltage1.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.myProgressBarСellVoltage1.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.myProgressBarСellVoltage1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.myProgressBarСellVoltage1.Location = new System.Drawing.Point(110, 106);
            this.myProgressBarСellVoltage1.Maximum = 3800;
            this.myProgressBarСellVoltage1.Minimum = 2600;
            this.myProgressBarСellVoltage1.Name = "myProgressBarСellVoltage1";
            this.myProgressBarСellVoltage1.Size = new System.Drawing.Size(241, 10);
            this.myProgressBarСellVoltage1.Step = 10;
            this.myProgressBarСellVoltage1.TabIndex = 35;
            this.myProgressBarСellVoltage1.Text = "myProgressBar1";
            this.myProgressBarСellVoltage1.Value = 2600;
            // 
            // myProgressBarSOC3
            // 
            this.myProgressBarSOC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.myProgressBarSOC3.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.myProgressBarSOC3.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.myProgressBarSOC3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.myProgressBarSOC3.Location = new System.Drawing.Point(514, 158);
            this.myProgressBarSOC3.Maximum = 10000;
            this.myProgressBarSOC3.Minimum = 0;
            this.myProgressBarSOC3.Name = "myProgressBarSOC3";
            this.myProgressBarSOC3.Size = new System.Drawing.Size(201, 10);
            this.myProgressBarSOC3.Step = 10;
            this.myProgressBarSOC3.TabIndex = 31;
            this.myProgressBarSOC3.Text = "myProgressBar1";
            this.myProgressBarSOC3.Value = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(662, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 153;
            this.label15.Text = "Max SOC, %";
            // 
            // myProgressBarSOC2
            // 
            this.myProgressBarSOC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.myProgressBarSOC2.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.myProgressBarSOC2.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.myProgressBarSOC2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.myProgressBarSOC2.Location = new System.Drawing.Point(514, 132);
            this.myProgressBarSOC2.Maximum = 10000;
            this.myProgressBarSOC2.Minimum = 0;
            this.myProgressBarSOC2.Name = "myProgressBarSOC2";
            this.myProgressBarSOC2.Size = new System.Drawing.Size(201, 10);
            this.myProgressBarSOC2.Step = 10;
            this.myProgressBarSOC2.TabIndex = 30;
            this.myProgressBarSOC2.Text = "myProgressBar1";
            this.myProgressBarSOC2.Value = 0;
            // 
            // textBoxMaxSoc
            // 
            this.textBoxMaxSoc.Location = new System.Drawing.Point(673, 52);
            this.textBoxMaxSoc.Name = "textBoxMaxSoc";
            this.textBoxMaxSoc.ReadOnly = true;
            this.textBoxMaxSoc.Size = new System.Drawing.Size(42, 20);
            this.textBoxMaxSoc.TabIndex = 152;
            this.textBoxMaxSoc.Text = "100";
            this.textBoxMaxSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(594, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 151;
            this.label14.Text = "DOD, %";
            // 
            // textBoxBalanceResistance
            // 
            this.textBoxBalanceResistance.Location = new System.Drawing.Point(673, 12);
            this.textBoxBalanceResistance.Name = "textBoxBalanceResistance";
            this.textBoxBalanceResistance.Size = new System.Drawing.Size(50, 20);
            this.textBoxBalanceResistance.TabIndex = 149;
            this.textBoxBalanceResistance.Text = "13";
            this.textBoxBalanceResistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBalanceResistance.TextChanged += new System.EventHandler(this.textBoxBalanceResistance_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(503, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 150;
            this.label13.Text = "Min SOC, %";
            // 
            // textBoxImbalance
            // 
            this.textBoxImbalance.Location = new System.Drawing.Point(267, 47);
            this.textBoxImbalance.Name = "textBoxImbalance";
            this.textBoxImbalance.ReadOnly = true;
            this.textBoxImbalance.Size = new System.Drawing.Size(42, 20);
            this.textBoxImbalance.TabIndex = 146;
            this.textBoxImbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDod
            // 
            this.textBoxDod.Location = new System.Drawing.Point(594, 52);
            this.textBoxDod.Name = "textBoxDod";
            this.textBoxDod.Size = new System.Drawing.Size(42, 20);
            this.textBoxDod.TabIndex = 149;
            this.textBoxDod.Text = "100";
            this.textBoxDod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDod.TextChanged += new System.EventHandler(this.textBoxDod_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(503, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 13);
            this.label12.TabIndex = 148;
            this.label12.Text = "Сопротивление балансира, Ом";
            // 
            // textBoxMinSoc
            // 
            this.textBoxMinSoc.Location = new System.Drawing.Point(514, 52);
            this.textBoxMinSoc.Name = "textBoxMinSoc";
            this.textBoxMinSoc.Size = new System.Drawing.Size(42, 20);
            this.textBoxMinSoc.TabIndex = 148;
            this.textBoxMinSoc.Text = "0";
            this.textBoxMinSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMinSoc.TextChanged += new System.EventHandler(this.textBoxMinSoc_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 50);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 145;
            this.label5.Text = "Дисбаланс, мВ";
            // 
            // pictureBoxCell4Color
            // 
            this.pictureBoxCell4Color.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCell4Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCell4Color.Location = new System.Drawing.Point(89, 180);
            this.pictureBoxCell4Color.Name = "pictureBoxCell4Color";
            this.pictureBoxCell4Color.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCell4Color.TabIndex = 144;
            this.pictureBoxCell4Color.TabStop = false;
            // 
            // pictureBoxCell3Color
            // 
            this.pictureBoxCell3Color.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCell3Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCell3Color.Location = new System.Drawing.Point(89, 154);
            this.pictureBoxCell3Color.Name = "pictureBoxCell3Color";
            this.pictureBoxCell3Color.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCell3Color.TabIndex = 143;
            this.pictureBoxCell3Color.TabStop = false;
            // 
            // pictureBoxCell2Color
            // 
            this.pictureBoxCell2Color.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCell2Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCell2Color.Location = new System.Drawing.Point(89, 128);
            this.pictureBoxCell2Color.Name = "pictureBoxCell2Color";
            this.pictureBoxCell2Color.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCell2Color.TabIndex = 142;
            this.pictureBoxCell2Color.TabStop = false;
            // 
            // pictureBoxCell1Color
            // 
            this.pictureBoxCell1Color.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCell1Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCell1Color.Location = new System.Drawing.Point(89, 102);
            this.pictureBoxCell1Color.Name = "pictureBoxCell1Color";
            this.pictureBoxCell1Color.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCell1Color.TabIndex = 141;
            this.pictureBoxCell1Color.TabStop = false;
            // 
            // textBoxSOC4
            // 
            this.textBoxSOC4.Location = new System.Drawing.Point(476, 178);
            this.textBoxSOC4.Name = "textBoxSOC4";
            this.textBoxSOC4.Size = new System.Drawing.Size(30, 20);
            this.textBoxSOC4.TabIndex = 134;
            this.textBoxSOC4.Text = "0";
            this.textBoxSOC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSOC4.TextChanged += new System.EventHandler(this.textBoxSOC4_TextChanged);
            // 
            // textBoxSOC3
            // 
            this.textBoxSOC3.Location = new System.Drawing.Point(476, 152);
            this.textBoxSOC3.Name = "textBoxSOC3";
            this.textBoxSOC3.Size = new System.Drawing.Size(30, 20);
            this.textBoxSOC3.TabIndex = 133;
            this.textBoxSOC3.Text = "0";
            this.textBoxSOC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSOC3.TextChanged += new System.EventHandler(this.textBoxSOC3_TextChanged);
            // 
            // textBoxSOC2
            // 
            this.textBoxSOC2.Location = new System.Drawing.Point(476, 126);
            this.textBoxSOC2.Name = "textBoxSOC2";
            this.textBoxSOC2.Size = new System.Drawing.Size(30, 20);
            this.textBoxSOC2.TabIndex = 132;
            this.textBoxSOC2.Text = "0";
            this.textBoxSOC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSOC2.TextChanged += new System.EventHandler(this.textBoxSOC2_TextChanged);
            // 
            // textBoxSOC1
            // 
            this.textBoxSOC1.Location = new System.Drawing.Point(476, 100);
            this.textBoxSOC1.Name = "textBoxSOC1";
            this.textBoxSOC1.Size = new System.Drawing.Size(30, 20);
            this.textBoxSOC1.TabIndex = 131;
            this.textBoxSOC1.Text = "0";
            this.textBoxSOC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSOC1.TextChanged += new System.EventHandler(this.textBoxSOC1_TextChanged);
            // 
            // myLabel3
            // 
            this.myLabel3.Location = new System.Drawing.Point(411, 15);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(15, 81);
            this.myLabel3.TabIndex = 28;
            this.myLabel3.Text = "Балансировка";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.myRadioButtonBalanceCell4);
            this.panel5.Location = new System.Drawing.Point(411, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(17, 16);
            this.panel5.TabIndex = 104;
            // 
            // myRadioButtonBalanceCell4
            // 
            this.myRadioButtonBalanceCell4.AutoSize = true;
            this.myRadioButtonBalanceCell4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myRadioButtonBalanceCell4.Location = new System.Drawing.Point(1, 2);
            this.myRadioButtonBalanceCell4.Name = "myRadioButtonBalanceCell4";
            this.myRadioButtonBalanceCell4.Size = new System.Drawing.Size(14, 13);
            this.myRadioButtonBalanceCell4.TabIndex = 25;
            this.myRadioButtonBalanceCell4.TabStop = true;
            this.myRadioButtonBalanceCell4.UseVisualStyleBackColor = true;
            this.myRadioButtonBalanceCell4.CheckedChanged += new System.EventHandler(this.myRadioButtonCell4_CheckedChanged);
            // 
            // myLabel2
            // 
            this.myLabel2.Location = new System.Drawing.Point(387, 58);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(15, 38);
            this.myLabel2.TabIndex = 27;
            this.myLabel2.Text = "U max";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.myRadioButtonBalanceCell3);
            this.panel4.Location = new System.Drawing.Point(411, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 16);
            this.panel4.TabIndex = 104;
            // 
            // myRadioButtonBalanceCell3
            // 
            this.myRadioButtonBalanceCell3.AutoSize = true;
            this.myRadioButtonBalanceCell3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myRadioButtonBalanceCell3.Location = new System.Drawing.Point(1, 2);
            this.myRadioButtonBalanceCell3.Name = "myRadioButtonBalanceCell3";
            this.myRadioButtonBalanceCell3.Size = new System.Drawing.Size(14, 13);
            this.myRadioButtonBalanceCell3.TabIndex = 25;
            this.myRadioButtonBalanceCell3.TabStop = true;
            this.myRadioButtonBalanceCell3.UseVisualStyleBackColor = true;
            this.myRadioButtonBalanceCell3.CheckedChanged += new System.EventHandler(this.myRadioButtonCell3_CheckedChanged);
            // 
            // myLabel1
            // 
            this.myLabel1.Location = new System.Drawing.Point(366, 61);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(15, 35);
            this.myLabel1.TabIndex = 26;
            this.myLabel1.Text = "U min";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.myRadioButtonBalanceCell2);
            this.panel3.Location = new System.Drawing.Point(411, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 16);
            this.panel3.TabIndex = 104;
            // 
            // myRadioButtonBalanceCell2
            // 
            this.myRadioButtonBalanceCell2.AutoSize = true;
            this.myRadioButtonBalanceCell2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myRadioButtonBalanceCell2.Location = new System.Drawing.Point(1, 2);
            this.myRadioButtonBalanceCell2.Name = "myRadioButtonBalanceCell2";
            this.myRadioButtonBalanceCell2.Size = new System.Drawing.Size(14, 13);
            this.myRadioButtonBalanceCell2.TabIndex = 25;
            this.myRadioButtonBalanceCell2.TabStop = true;
            this.myRadioButtonBalanceCell2.UseVisualStyleBackColor = true;
            this.myRadioButtonBalanceCell2.CheckedChanged += new System.EventHandler(this.myRadioButtonCell2_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.myRadioButtonBalanceCell1);
            this.panel2.Location = new System.Drawing.Point(411, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 16);
            this.panel2.TabIndex = 103;
            // 
            // myRadioButtonBalanceCell1
            // 
            this.myRadioButtonBalanceCell1.AutoSize = true;
            this.myRadioButtonBalanceCell1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myRadioButtonBalanceCell1.Location = new System.Drawing.Point(1, 2);
            this.myRadioButtonBalanceCell1.Name = "myRadioButtonBalanceCell1";
            this.myRadioButtonBalanceCell1.Size = new System.Drawing.Size(14, 13);
            this.myRadioButtonBalanceCell1.TabIndex = 25;
            this.myRadioButtonBalanceCell1.TabStop = true;
            this.myRadioButtonBalanceCell1.UseVisualStyleBackColor = true;
            this.myRadioButtonBalanceCell1.CheckedChanged += new System.EventHandler(this.myRadioButtonCell1_CheckedChanged);
            // 
            // SwitchBalancing
            // 
            this.SwitchBalancing.BackColor = System.Drawing.Color.White;
            this.SwitchBalancing.BackColorOff = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.SwitchBalancing.BackColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.SwitchBalancing.Checked = false;
            this.SwitchBalancing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchBalancing.Font = new System.Drawing.Font("Verdana", 9F);
            this.SwitchBalancing.Location = new System.Drawing.Point(331, 19);
            this.SwitchBalancing.Name = "SwitchBalancing";
            this.SwitchBalancing.Size = new System.Drawing.Size(74, 15);
            this.SwitchBalancing.TabIndex = 11;
            this.SwitchBalancing.Text = "OFF";
            this.SwitchBalancing.TextOnChecked = "ON";
            this.SwitchBalancing.CheckedChanged += new BalancingSimulation.Controls.ToggleSwitch.OnCheckedChangedHandler(this.SwitchBalancing_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 130;
            this.label11.Text = "U cell, mV";
            // 
            // pictureBoxCVMAX4
            // 
            this.pictureBoxCVMAX4.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCVMAX4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCVMAX4.Location = new System.Drawing.Point(387, 181);
            this.pictureBoxCVMAX4.Name = "pictureBoxCVMAX4";
            this.pictureBoxCVMAX4.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCVMAX4.TabIndex = 117;
            this.pictureBoxCVMAX4.TabStop = false;
            // 
            // pictureBoxCVMIN4
            // 
            this.pictureBoxCVMIN4.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCVMIN4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCVMIN4.Location = new System.Drawing.Point(365, 181);
            this.pictureBoxCVMIN4.Name = "pictureBoxCVMIN4";
            this.pictureBoxCVMIN4.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCVMIN4.TabIndex = 118;
            this.pictureBoxCVMIN4.TabStop = false;
            // 
            // textBoxСellVoltage4
            // 
            this.textBoxСellVoltage4.Location = new System.Drawing.Point(43, 178);
            this.textBoxСellVoltage4.Name = "textBoxСellVoltage4";
            this.textBoxСellVoltage4.ReadOnly = true;
            this.textBoxСellVoltage4.Size = new System.Drawing.Size(42, 20);
            this.textBoxСellVoltage4.TabIndex = 25;
            this.textBoxСellVoltage4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxCVMAX3
            // 
            this.pictureBoxCVMAX3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCVMAX3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCVMAX3.Location = new System.Drawing.Point(387, 155);
            this.pictureBoxCVMAX3.Name = "pictureBoxCVMAX3";
            this.pictureBoxCVMAX3.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCVMAX3.TabIndex = 112;
            this.pictureBoxCVMAX3.TabStop = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 181);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(36, 13);
            this.label36.TabIndex = 24;
            this.label36.Text = "Cell 4:";
            // 
            // pictureBoxCVMIN3
            // 
            this.pictureBoxCVMIN3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCVMIN3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCVMIN3.Location = new System.Drawing.Point(365, 155);
            this.pictureBoxCVMIN3.Name = "pictureBoxCVMIN3";
            this.pictureBoxCVMIN3.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCVMIN3.TabIndex = 113;
            this.pictureBoxCVMIN3.TabStop = false;
            // 
            // textBoxСellVoltage3
            // 
            this.textBoxСellVoltage3.Location = new System.Drawing.Point(43, 152);
            this.textBoxСellVoltage3.Name = "textBoxСellVoltage3";
            this.textBoxСellVoltage3.ReadOnly = true;
            this.textBoxСellVoltage3.Size = new System.Drawing.Size(42, 20);
            this.textBoxСellVoltage3.TabIndex = 22;
            this.textBoxСellVoltage3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxCVMAX2
            // 
            this.pictureBoxCVMAX2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCVMAX2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCVMAX2.Location = new System.Drawing.Point(387, 129);
            this.pictureBoxCVMAX2.Name = "pictureBoxCVMAX2";
            this.pictureBoxCVMAX2.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCVMAX2.TabIndex = 107;
            this.pictureBoxCVMAX2.TabStop = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 155);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 13);
            this.label31.TabIndex = 21;
            this.label31.Text = "Cell 3:";
            // 
            // pictureBoxCVMIN2
            // 
            this.pictureBoxCVMIN2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCVMIN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCVMIN2.Location = new System.Drawing.Point(365, 129);
            this.pictureBoxCVMIN2.Name = "pictureBoxCVMIN2";
            this.pictureBoxCVMIN2.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCVMIN2.TabIndex = 108;
            this.pictureBoxCVMIN2.TabStop = false;
            // 
            // textBoxСellVoltage2
            // 
            this.textBoxСellVoltage2.Location = new System.Drawing.Point(43, 126);
            this.textBoxСellVoltage2.Name = "textBoxСellVoltage2";
            this.textBoxСellVoltage2.ReadOnly = true;
            this.textBoxСellVoltage2.Size = new System.Drawing.Size(42, 20);
            this.textBoxСellVoltage2.TabIndex = 19;
            this.textBoxСellVoltage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(5, 129);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(36, 13);
            this.label29.TabIndex = 18;
            this.label29.Text = "Cell 2:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(100, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(261, 125);
            this.pictureBox3.TabIndex = 125;
            this.pictureBox3.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 103);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 13);
            this.label27.TabIndex = 15;
            this.label27.Text = "Cell 1:";
            // 
            // textBoxСellVoltage1
            // 
            this.textBoxСellVoltage1.Location = new System.Drawing.Point(43, 100);
            this.textBoxСellVoltage1.Name = "textBoxСellVoltage1";
            this.textBoxСellVoltage1.ReadOnly = true;
            this.textBoxСellVoltage1.Size = new System.Drawing.Size(42, 20);
            this.textBoxСellVoltage1.TabIndex = 16;
            this.textBoxСellVoltage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxCVMAX1
            // 
            this.pictureBoxCVMAX1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCVMAX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCVMAX1.Location = new System.Drawing.Point(387, 103);
            this.pictureBoxCVMAX1.Name = "pictureBoxCVMAX1";
            this.pictureBoxCVMAX1.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCVMAX1.TabIndex = 101;
            this.pictureBoxCVMAX1.TabStop = false;
            // 
            // pictureBoxCVMIN1
            // 
            this.pictureBoxCVMIN1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxCVMIN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCVMIN1.Location = new System.Drawing.Point(365, 103);
            this.pictureBoxCVMIN1.Name = "pictureBoxCVMIN1";
            this.pictureBoxCVMIN1.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxCVMIN1.TabIndex = 103;
            this.pictureBoxCVMIN1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(504, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 125);
            this.pictureBox2.TabIndex = 140;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxCycleNumber);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.textBoxCurrent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonPlay);
            this.groupBox1.Controls.Add(this.ButtonStop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBarSpeed);
            this.groupBox1.Location = new System.Drawing.Point(1154, 512);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 210);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Моделирование";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 148;
            this.label10.Text = "Количество циклов";
            // 
            // textBoxCycleNumber
            // 
            this.textBoxCycleNumber.Location = new System.Drawing.Point(122, 157);
            this.textBoxCycleNumber.Name = "textBoxCycleNumber";
            this.textBoxCycleNumber.ReadOnly = true;
            this.textBoxCycleNumber.Size = new System.Drawing.Size(56, 20);
            this.textBoxCycleNumber.TabIndex = 149;
            this.textBoxCycleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Location = new System.Drawing.Point(24, 126);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(135, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить историю";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.Location = new System.Drawing.Point(142, 183);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.Size = new System.Drawing.Size(36, 20);
            this.textBoxCurrent.TabIndex = 12;
            this.textBoxCurrent.Text = "20";
            this.textBoxCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurrent.TextChanged += new System.EventHandler(this.textBoxCurrent_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ток заряда/разряда, А";
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPlay.FlatAppearance.BorderSize = 0;
            this.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlay.Image = global::BalancingSimulation.Properties.Resources.Play;
            this.ButtonPlay.Location = new System.Drawing.Point(23, 64);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(60, 60);
            this.ButtonPlay.TabIndex = 6;
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStop.FlatAppearance.BorderSize = 0;
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStop.Image = global::BalancingSimulation.Properties.Resources.Stop;
            this.ButtonStop.Location = new System.Drawing.Point(98, 64);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(60, 60);
            this.ButtonStop.TabIndex = 7;
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.myLabel13);
            this.groupBox2.Controls.Add(this.myLabel14);
            this.groupBox2.Controls.Add(this.textBoxInternalResistance4);
            this.groupBox2.Controls.Add(this.textBoxInternalResistance3);
            this.groupBox2.Controls.Add(this.textBoxInternalResistance2);
            this.groupBox2.Controls.Add(this.textBoxInternalResistance1);
            this.groupBox2.Controls.Add(this.myLabel8);
            this.groupBox2.Controls.Add(this.myLabel7);
            this.groupBox2.Controls.Add(this.myLabel6);
            this.groupBox2.Controls.Add(this.myLabel5);
            this.groupBox2.Controls.Add(this.textBoxSelfDischarge4);
            this.groupBox2.Controls.Add(this.textBoxSelfDischarge3);
            this.groupBox2.Controls.Add(this.textBoxSelfDischarge2);
            this.groupBox2.Controls.Add(this.textBoxSelfDischarge1);
            this.groupBox2.Controls.Add(this.textBoxCapacity4);
            this.groupBox2.Controls.Add(this.textBoxCapacity3);
            this.groupBox2.Controls.Add(this.textBoxCapacity2);
            this.groupBox2.Controls.Add(this.textBoxCapacity1);
            this.groupBox2.Location = new System.Drawing.Point(798, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 210);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики ячеек";
            // 
            // myLabel13
            // 
            this.myLabel13.Location = new System.Drawing.Point(120, 55);
            this.myLabel13.Name = "myLabel13";
            this.myLabel13.Size = new System.Drawing.Size(15, 36);
            this.myLabel13.TabIndex = 164;
            this.myLabel13.Text = "мкОм";
            // 
            // myLabel14
            // 
            this.myLabel14.Location = new System.Drawing.Point(105, 18);
            this.myLabel14.Name = "myLabel14";
            this.myLabel14.Size = new System.Drawing.Size(15, 73);
            this.myLabel14.TabIndex = 163;
            this.myLabel14.Text = "Внутр. сопр.,";
            // 
            // textBoxInternalResistance4
            // 
            this.textBoxInternalResistance4.Location = new System.Drawing.Point(101, 178);
            this.textBoxInternalResistance4.Name = "textBoxInternalResistance4";
            this.textBoxInternalResistance4.Size = new System.Drawing.Size(35, 20);
            this.textBoxInternalResistance4.TabIndex = 162;
            this.textBoxInternalResistance4.Text = "350";
            this.textBoxInternalResistance4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInternalResistance4.TextChanged += new System.EventHandler(this.textBoxInternalResistance4_TextChanged);
            // 
            // textBoxInternalResistance3
            // 
            this.textBoxInternalResistance3.Location = new System.Drawing.Point(101, 152);
            this.textBoxInternalResistance3.Name = "textBoxInternalResistance3";
            this.textBoxInternalResistance3.Size = new System.Drawing.Size(35, 20);
            this.textBoxInternalResistance3.TabIndex = 161;
            this.textBoxInternalResistance3.Text = "350";
            this.textBoxInternalResistance3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInternalResistance3.TextChanged += new System.EventHandler(this.textBoxInternalResistance3_TextChanged);
            // 
            // textBoxInternalResistance2
            // 
            this.textBoxInternalResistance2.Location = new System.Drawing.Point(101, 126);
            this.textBoxInternalResistance2.Name = "textBoxInternalResistance2";
            this.textBoxInternalResistance2.Size = new System.Drawing.Size(35, 20);
            this.textBoxInternalResistance2.TabIndex = 160;
            this.textBoxInternalResistance2.Text = "350";
            this.textBoxInternalResistance2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInternalResistance2.TextChanged += new System.EventHandler(this.textBoxInternalResistance2_TextChanged);
            // 
            // textBoxInternalResistance1
            // 
            this.textBoxInternalResistance1.Location = new System.Drawing.Point(101, 100);
            this.textBoxInternalResistance1.Name = "textBoxInternalResistance1";
            this.textBoxInternalResistance1.Size = new System.Drawing.Size(35, 20);
            this.textBoxInternalResistance1.TabIndex = 159;
            this.textBoxInternalResistance1.Text = "350";
            this.textBoxInternalResistance1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInternalResistance1.TextChanged += new System.EventHandler(this.textBoxInternalResistance1_TextChanged);
            // 
            // myLabel8
            // 
            this.myLabel8.Location = new System.Drawing.Point(78, 64);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Size = new System.Drawing.Size(15, 26);
            this.myLabel8.TabIndex = 158;
            this.myLabel8.Text = "мкА";
            // 
            // myLabel7
            // 
            this.myLabel7.Location = new System.Drawing.Point(63, 26);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(15, 65);
            this.myLabel7.TabIndex = 157;
            this.myLabel7.Text = "Ток утечки,";
            // 
            // myLabel6
            // 
            this.myLabel6.Location = new System.Drawing.Point(32, 64);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(15, 27);
            this.myLabel6.TabIndex = 156;
            this.myLabel6.Text = "мАч";
            // 
            // myLabel5
            // 
            this.myLabel5.Location = new System.Drawing.Point(16, 39);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(15, 53);
            this.myLabel5.TabIndex = 155;
            this.myLabel5.Text = "Емкость,";
            // 
            // textBoxSelfDischarge4
            // 
            this.textBoxSelfDischarge4.Location = new System.Drawing.Point(59, 178);
            this.textBoxSelfDischarge4.Name = "textBoxSelfDischarge4";
            this.textBoxSelfDischarge4.Size = new System.Drawing.Size(35, 20);
            this.textBoxSelfDischarge4.TabIndex = 145;
            this.textBoxSelfDischarge4.Text = "270";
            this.textBoxSelfDischarge4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSelfDischarge4.TextChanged += new System.EventHandler(this.textBoxSelfDischarge4_TextChanged);
            // 
            // textBoxSelfDischarge3
            // 
            this.textBoxSelfDischarge3.Location = new System.Drawing.Point(59, 152);
            this.textBoxSelfDischarge3.Name = "textBoxSelfDischarge3";
            this.textBoxSelfDischarge3.Size = new System.Drawing.Size(35, 20);
            this.textBoxSelfDischarge3.TabIndex = 144;
            this.textBoxSelfDischarge3.Text = "270";
            this.textBoxSelfDischarge3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSelfDischarge3.TextChanged += new System.EventHandler(this.textBoxSelfDischarge3_TextChanged);
            // 
            // textBoxSelfDischarge2
            // 
            this.textBoxSelfDischarge2.Location = new System.Drawing.Point(59, 126);
            this.textBoxSelfDischarge2.Name = "textBoxSelfDischarge2";
            this.textBoxSelfDischarge2.Size = new System.Drawing.Size(35, 20);
            this.textBoxSelfDischarge2.TabIndex = 143;
            this.textBoxSelfDischarge2.Text = "270";
            this.textBoxSelfDischarge2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSelfDischarge2.TextChanged += new System.EventHandler(this.textBoxSelfDischarge2_TextChanged);
            // 
            // textBoxSelfDischarge1
            // 
            this.textBoxSelfDischarge1.Location = new System.Drawing.Point(59, 100);
            this.textBoxSelfDischarge1.Name = "textBoxSelfDischarge1";
            this.textBoxSelfDischarge1.Size = new System.Drawing.Size(35, 20);
            this.textBoxSelfDischarge1.TabIndex = 142;
            this.textBoxSelfDischarge1.Text = "270";
            this.textBoxSelfDischarge1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSelfDischarge1.TextChanged += new System.EventHandler(this.textBoxSelfDischarge1_TextChanged);
            // 
            // textBoxCapacity4
            // 
            this.textBoxCapacity4.Location = new System.Drawing.Point(11, 178);
            this.textBoxCapacity4.Name = "textBoxCapacity4";
            this.textBoxCapacity4.Size = new System.Drawing.Size(40, 20);
            this.textBoxCapacity4.TabIndex = 138;
            this.textBoxCapacity4.Text = "60000";
            this.textBoxCapacity4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCapacity4.TextChanged += new System.EventHandler(this.textBoxCapacity4_TextChanged);
            // 
            // textBoxCapacity3
            // 
            this.textBoxCapacity3.Location = new System.Drawing.Point(11, 152);
            this.textBoxCapacity3.Name = "textBoxCapacity3";
            this.textBoxCapacity3.Size = new System.Drawing.Size(40, 20);
            this.textBoxCapacity3.TabIndex = 137;
            this.textBoxCapacity3.Text = "60000";
            this.textBoxCapacity3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCapacity3.TextChanged += new System.EventHandler(this.textBoxCapacity3_TextChanged);
            // 
            // textBoxCapacity2
            // 
            this.textBoxCapacity2.Location = new System.Drawing.Point(11, 126);
            this.textBoxCapacity2.Name = "textBoxCapacity2";
            this.textBoxCapacity2.Size = new System.Drawing.Size(40, 20);
            this.textBoxCapacity2.TabIndex = 136;
            this.textBoxCapacity2.Text = "60000";
            this.textBoxCapacity2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCapacity2.TextChanged += new System.EventHandler(this.textBoxCapacity2_TextChanged);
            // 
            // textBoxCapacity1
            // 
            this.textBoxCapacity1.Location = new System.Drawing.Point(11, 100);
            this.textBoxCapacity1.Name = "textBoxCapacity1";
            this.textBoxCapacity1.Size = new System.Drawing.Size(40, 20);
            this.textBoxCapacity1.TabIndex = 135;
            this.textBoxCapacity1.Text = "60000";
            this.textBoxCapacity1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCapacity1.TextChanged += new System.EventHandler(this.textBoxCapacity1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxCapacityImbalance);
            this.groupBox3.Controls.Add(this.myProgressBarBalanceStatus);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textBoxMaxDischargeCapacity);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textBoxDischargeCapacity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(949, 512);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 154);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Накопитель энергии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 153;
            this.label4.Text = "Дисбаланс, мАч";
            // 
            // textBoxCapacityImbalance
            // 
            this.textBoxCapacityImbalance.Location = new System.Drawing.Point(143, 85);
            this.textBoxCapacityImbalance.Name = "textBoxCapacityImbalance";
            this.textBoxCapacityImbalance.ReadOnly = true;
            this.textBoxCapacityImbalance.Size = new System.Drawing.Size(50, 20);
            this.textBoxCapacityImbalance.TabIndex = 152;
            this.textBoxCapacityImbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myProgressBarBalanceStatus
            // 
            this.myProgressBarBalanceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.myProgressBarBalanceStatus.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.myProgressBarBalanceStatus.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.myProgressBarBalanceStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.myProgressBarBalanceStatus.Location = new System.Drawing.Point(6, 135);
            this.myProgressBarBalanceStatus.Maximum = 10000;
            this.myProgressBarBalanceStatus.Minimum = 0;
            this.myProgressBarBalanceStatus.Name = "myProgressBarBalanceStatus";
            this.myProgressBarBalanceStatus.Size = new System.Drawing.Size(187, 10);
            this.myProgressBarBalanceStatus.Step = 100;
            this.myProgressBarBalanceStatus.TabIndex = 38;
            this.myProgressBarBalanceStatus.Text = "myProgressBar1";
            this.myProgressBarBalanceStatus.Value = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 13);
            this.label18.TabIndex = 151;
            this.label18.Text = "Прогресс балансировки";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 13);
            this.label17.TabIndex = 150;
            this.label17.Text = "полезная емкость, мАч";
            // 
            // textBoxMaxDischargeCapacity
            // 
            this.textBoxMaxDischargeCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMaxDischargeCapacity.Location = new System.Drawing.Point(143, 28);
            this.textBoxMaxDischargeCapacity.Name = "textBoxMaxDischargeCapacity";
            this.textBoxMaxDischargeCapacity.ReadOnly = true;
            this.textBoxMaxDischargeCapacity.Size = new System.Drawing.Size(50, 20);
            this.textBoxMaxDischargeCapacity.TabIndex = 149;
            this.textBoxMaxDischargeCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 148;
            this.label16.Text = "Максимальная";
            // 
            // textBoxDischargeCapacity
            // 
            this.textBoxDischargeCapacity.Location = new System.Drawing.Point(143, 56);
            this.textBoxDischargeCapacity.Name = "textBoxDischargeCapacity";
            this.textBoxDischargeCapacity.ReadOnly = true;
            this.textBoxDischargeCapacity.Size = new System.Drawing.Size(50, 20);
            this.textBoxDischargeCapacity.TabIndex = 147;
            this.textBoxDischargeCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 140;
            this.label9.Text = "Разрядная емкость, мАч";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton8);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(949, 670);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 52);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Исходные состояния ячеек";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton8.Location = new System.Drawing.Point(170, 14);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(17, 30);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Click += new System.EventHandler(this.radioButton8_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton7.Location = new System.Drawing.Point(147, 14);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(17, 30);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Click += new System.EventHandler(this.radioButton7_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton6.Location = new System.Drawing.Point(124, 14);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(17, 30);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton5.Location = new System.Drawing.Point(101, 14);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(17, 30);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Location = new System.Drawing.Point(78, 14);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(17, 30);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Location = new System.Drawing.Point(55, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 30);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(32, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 30);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(9, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 30);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(542, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 22);
            this.label6.TabIndex = 170;
            this.label6.Text = "Напряжение ячеек, В";
            // 
            // pictureBoxFlagEn
            // 
            this.pictureBoxFlagEn.BackColor = System.Drawing.Color.White;
            this.pictureBoxFlagEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFlagEn.Image = global::BalancingSimulation.Properties.Resources.FlagEN;
            this.pictureBoxFlagEn.Location = new System.Drawing.Point(1299, 22);
            this.pictureBoxFlagEn.Name = "pictureBoxFlagEn";
            this.pictureBoxFlagEn.Size = new System.Drawing.Size(28, 20);
            this.pictureBoxFlagEn.TabIndex = 31;
            this.pictureBoxFlagEn.TabStop = false;
            this.pictureBoxFlagEn.Click += new System.EventHandler(this.pictureBoxFlagEn_Click);
            // 
            // pictureBoxFlagDe
            // 
            this.pictureBoxFlagDe.BackColor = System.Drawing.Color.White;
            this.pictureBoxFlagDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFlagDe.Image = global::BalancingSimulation.Properties.Resources.FlagDE;
            this.pictureBoxFlagDe.Location = new System.Drawing.Point(1265, 22);
            this.pictureBoxFlagDe.Name = "pictureBoxFlagDe";
            this.pictureBoxFlagDe.Size = new System.Drawing.Size(28, 20);
            this.pictureBoxFlagDe.TabIndex = 30;
            this.pictureBoxFlagDe.TabStop = false;
            this.pictureBoxFlagDe.Click += new System.EventHandler(this.pictureBoxFlagDe_Click);
            // 
            // pictureBoxFlagRu
            // 
            this.pictureBoxFlagRu.BackColor = System.Drawing.Color.White;
            this.pictureBoxFlagRu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFlagRu.Image = global::BalancingSimulation.Properties.Resources.FlagRU;
            this.pictureBoxFlagRu.Location = new System.Drawing.Point(1231, 22);
            this.pictureBoxFlagRu.Name = "pictureBoxFlagRu";
            this.pictureBoxFlagRu.Size = new System.Drawing.Size(28, 20);
            this.pictureBoxFlagRu.TabIndex = 29;
            this.pictureBoxFlagRu.TabStop = false;
            this.pictureBoxFlagRu.Click += new System.EventHandler(this.pictureBoxFlagRu_Click);
            // 
            // pictureBoxGraphic
            // 
            this.pictureBoxGraphic.Image = global::BalancingSimulation.Properties.Resources.CoordinateGrid;
            this.pictureBoxGraphic.InitialImage = null;
            this.pictureBoxGraphic.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxGraphic.Name = "pictureBoxGraphic";
            this.pictureBoxGraphic.Size = new System.Drawing.Size(1326, 500);
            this.pictureBoxGraphic.TabIndex = 0;
            this.pictureBoxGraphic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBoxFlagEn);
            this.Controls.Add(this.pictureBoxFlagDe);
            this.Controls.Add(this.pictureBoxFlagRu);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCellState);
            this.Controls.Add(this.pictureBoxGraphic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BalancingSimulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBoxCellState.ResumeLayout(false);
            this.groupBoxCellState.PerformLayout();
            this.groupBoxBalancingAlgorithm.ResumeLayout(false);
            this.groupBoxBalancingAlgorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCell4Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCell3Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCell2Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCell1Color)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMAX4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMIN4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMAX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMIN3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMAX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMIN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMAX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVMIN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagEn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagRu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGraphic;
        private System.Windows.Forms.Timer timer1;
        private RoundButton ButtonPlay;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label1;
        private ToggleSwitch SwitchBalancing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxCellState;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBoxCVMAX4;
        private System.Windows.Forms.PictureBox pictureBoxCVMIN4;
        private System.Windows.Forms.TextBox textBoxСellVoltage4;
        private System.Windows.Forms.PictureBox pictureBoxCVMAX3;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.PictureBox pictureBoxCVMIN3;
        private System.Windows.Forms.TextBox textBoxСellVoltage3;
        private System.Windows.Forms.PictureBox pictureBoxCVMAX2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.PictureBox pictureBoxCVMIN2;
        private System.Windows.Forms.TextBox textBoxСellVoltage2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxСellVoltage1;
        private System.Windows.Forms.PictureBox pictureBoxCVMAX1;
        private System.Windows.Forms.PictureBox pictureBoxCVMIN1;
        private System.Windows.Forms.Panel panel5;
        private MyRadioButton myRadioButtonBalanceCell4;
        private System.Windows.Forms.Panel panel4;
        private MyRadioButton myRadioButtonBalanceCell3;
        private System.Windows.Forms.Panel panel3;
        private MyRadioButton myRadioButtonBalanceCell2;
        private System.Windows.Forms.Panel panel2;
        private MyRadioButton myRadioButtonBalanceCell1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCurrent;
        private System.Windows.Forms.Label label2;
        private MyLabel myLabel3;
        private MyLabel myLabel2;
        private MyLabel myLabel1;
        private System.Windows.Forms.TextBox textBoxSOC4;
        private System.Windows.Forms.TextBox textBoxSOC3;
        private System.Windows.Forms.TextBox textBoxSOC2;
        private System.Windows.Forms.TextBox textBoxSOC1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxImbalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSelfDischarge4;
        private System.Windows.Forms.TextBox textBoxSelfDischarge3;
        private System.Windows.Forms.TextBox textBoxSelfDischarge2;
        private System.Windows.Forms.TextBox textBoxSelfDischarge1;
        private System.Windows.Forms.TextBox textBoxCapacity4;
        private System.Windows.Forms.TextBox textBoxCapacity3;
        private System.Windows.Forms.TextBox textBoxCapacity2;
        private System.Windows.Forms.TextBox textBoxCapacity1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDischargeCapacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCycleNumber;
        private System.Windows.Forms.TextBox textBoxBalanceResistance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDod;
        private System.Windows.Forms.TextBox textBoxMinSoc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMaxSoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxMaxDischargeCapacity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private MyProgressBar myProgressBarSOC1;
        private MyProgressBar myProgressBarSOC2;
        private MyProgressBar myProgressBarSOC4;
        private MyProgressBar myProgressBarSOC3;
        private MyProgressBar myProgressBarСellVoltage2;
        private MyProgressBar myProgressBarСellVoltage1;
        private MyProgressBar myProgressBarСellVoltage3;
        private MyProgressBar myProgressBarСellVoltage4;
        private MyProgressBar myProgressBarBalanceStatus;
        private System.Windows.Forms.PictureBox pictureBoxCell4Color;
        private System.Windows.Forms.PictureBox pictureBoxCell3Color;
        private System.Windows.Forms.PictureBox pictureBoxCell2Color;
        private System.Windows.Forms.PictureBox pictureBoxCell1Color;
        private MyLabel myLabel4;
        private MyLabel myLabel8;
        private MyLabel myLabel7;
        private MyLabel myLabel6;
        private MyLabel myLabel5;
        private System.Windows.Forms.TextBox textBoxCapacityLevel4;
        private MyLabel myLabel11;
        private System.Windows.Forms.TextBox textBoxCapacityLevel3;
        private MyLabel myLabel12;
        private System.Windows.Forms.TextBox textBoxCapacityLevel2;
        private System.Windows.Forms.TextBox textBoxCapacityLevel1;
        private System.Windows.Forms.TextBox textBoxBalanceCurrent4;
        private MyLabel myLabel10;
        private System.Windows.Forms.TextBox textBoxBalanceCurrent3;
        private MyLabel myLabel9;
        private System.Windows.Forms.TextBox textBoxBalanceCurrent2;
        private System.Windows.Forms.TextBox textBoxBalanceCurrent1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCapacityImbalance;
        private System.Windows.Forms.GroupBox groupBoxBalancingAlgorithm;
        private System.Windows.Forms.RadioButton radioButtonAlgorithm1;
        private System.Windows.Forms.RadioButton radioButtonAlgorithm2;
        private System.Windows.Forms.RadioButton radioButtonAlgorithm3;
        private MyLabel myLabel13;
        private MyLabel myLabel14;
        private System.Windows.Forms.TextBox textBoxInternalResistance4;
        private System.Windows.Forms.TextBox textBoxInternalResistance3;
        private System.Windows.Forms.TextBox textBoxInternalResistance2;
        private System.Windows.Forms.TextBox textBoxInternalResistance1;
        private RoundButton ButtonStop;
        private System.Windows.Forms.RadioButton radioButtonAlgorithm4;
        private System.Windows.Forms.PictureBox pictureBoxFlagRu;
        private System.Windows.Forms.PictureBox pictureBoxFlagDe;
        private System.Windows.Forms.PictureBox pictureBoxFlagEn;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

