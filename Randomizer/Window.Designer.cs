namespace Randomizer
{
    partial class Window
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAllSpins = new System.Windows.Forms.RadioButton();
            this.radioNegativeSpins = new System.Windows.Forms.RadioButton();
            this.radioPositiveSpins = new System.Windows.Forms.RadioButton();
            this.CmbAmount = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPositive = new System.Windows.Forms.Label();
            this.LabelNegative = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtMKSH = new System.Windows.Forms.TextBox();
            this.TxtMultiplierT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCoefJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCritT = new System.Windows.Forms.TextBox();
            this.TimerAnimate = new System.Windows.Forms.Timer(this.components);
            this.BtnStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.LabelTimerTick = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelMetropolis = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.LabelHi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelHeat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelENorm = new System.Windows.Forms.Label();
            this.labelMNorm = new System.Windows.Forms.Label();
            this.BarSpins = new System.Windows.Forms.ProgressBar();
            this.LabelPercent = new System.Windows.Forms.Label();
            this.BtnCalcNormal = new System.Windows.Forms.Button();
            this.ChartNormalM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartNormalE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TimerNormal = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtStepT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtMaxT = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtMinT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartNormalM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartNormalE)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbMain
            // 
            this.pcbMain.Location = new System.Drawing.Point(10, 11);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(734, 511);
            this.pcbMain.TabIndex = 0;
            this.pcbMain.TabStop = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(10, 661);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(330, 33);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Создать";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(163, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сторона ячейки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAllSpins);
            this.groupBox1.Controls.Add(this.radioNegativeSpins);
            this.groupBox1.Controls.Add(this.radioPositiveSpins);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbAmount);
            this.groupBox1.Location = new System.Drawing.Point(10, 560);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 95);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Спины";
            // 
            // radioAllSpins
            // 
            this.radioAllSpins.AutoSize = true;
            this.radioAllSpins.Checked = true;
            this.radioAllSpins.Location = new System.Drawing.Point(6, 19);
            this.radioAllSpins.Name = "radioAllSpins";
            this.radioAllSpins.Size = new System.Drawing.Size(79, 17);
            this.radioAllSpins.TabIndex = 16;
            this.radioAllSpins.TabStop = true;
            this.radioAllSpins.Text = "Все спины";
            this.radioAllSpins.UseVisualStyleBackColor = true;
            // 
            // radioNegativeSpins
            // 
            this.radioNegativeSpins.AutoSize = true;
            this.radioNegativeSpins.Location = new System.Drawing.Point(6, 64);
            this.radioNegativeSpins.Name = "radioNegativeSpins";
            this.radioNegativeSpins.Size = new System.Drawing.Size(143, 17);
            this.radioNegativeSpins.TabIndex = 15;
            this.radioNegativeSpins.Text = "Только отрицательные";
            this.radioNegativeSpins.UseVisualStyleBackColor = true;
            // 
            // radioPositiveSpins
            // 
            this.radioPositiveSpins.AutoSize = true;
            this.radioPositiveSpins.Location = new System.Drawing.Point(6, 41);
            this.radioPositiveSpins.Name = "radioPositiveSpins";
            this.radioPositiveSpins.Size = new System.Drawing.Size(146, 17);
            this.radioPositiveSpins.TabIndex = 14;
            this.radioPositiveSpins.Text = "Только положительные";
            this.radioPositiveSpins.UseVisualStyleBackColor = true;
            // 
            // CmbAmount
            // 
            this.CmbAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAmount.FormattingEnabled = true;
            this.CmbAmount.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "200",
            "500"});
            this.CmbAmount.Location = new System.Drawing.Point(280, 18);
            this.CmbAmount.Name = "CmbAmount";
            this.CmbAmount.Size = new System.Drawing.Size(45, 21);
            this.CmbAmount.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(156, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Вычислений в с";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtInterval
            // 
            this.TxtInterval.Location = new System.Drawing.Point(258, 16);
            this.TxtInterval.Name = "TxtInterval";
            this.TxtInterval.Size = new System.Drawing.Size(45, 20);
            this.TxtInterval.TabIndex = 25;
            this.TxtInterval.Text = "1000";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество частиц";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTotal
            // 
            this.LabelTotal.Location = new System.Drawing.Point(118, 54);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(46, 17);
            this.LabelTotal.TabIndex = 10;
            this.LabelTotal.Text = "0";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "+1 спины";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "-1 спины";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPositive
            // 
            this.LabelPositive.Location = new System.Drawing.Point(118, 14);
            this.LabelPositive.Name = "LabelPositive";
            this.LabelPositive.Size = new System.Drawing.Size(46, 20);
            this.LabelPositive.TabIndex = 17;
            this.LabelPositive.Text = "0";
            this.LabelPositive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNegative
            // 
            this.LabelNegative.Location = new System.Drawing.Point(118, 34);
            this.LabelNegative.Name = "LabelNegative";
            this.LabelNegative.Size = new System.Drawing.Size(46, 20);
            this.LabelNegative.TabIndex = 18;
            this.LabelNegative.Text = "0";
            this.LabelNegative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtMKSH);
            this.groupBox2.Controls.Add(this.TxtMultiplierT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtCoefJ);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtInterval);
            this.groupBox2.Controls.Add(this.TxtCritT);
            this.groupBox2.Location = new System.Drawing.Point(346, 560);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 95);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Метрополис";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(156, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Количество МКШ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtMKSH
            // 
            this.TxtMKSH.Location = new System.Drawing.Point(258, 42);
            this.TxtMKSH.Name = "TxtMKSH";
            this.TxtMKSH.Size = new System.Drawing.Size(45, 20);
            this.TxtMKSH.TabIndex = 28;
            this.TxtMKSH.Text = "100";
            // 
            // TxtMultiplierT
            // 
            this.TxtMultiplierT.Location = new System.Drawing.Point(105, 42);
            this.TxtMultiplierT.Name = "TxtMultiplierT";
            this.TxtMultiplierT.Size = new System.Drawing.Size(45, 20);
            this.TxtMultiplierT.TabIndex = 27;
            this.TxtMultiplierT.Text = "0.5";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Коэфициент J";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCoefJ
            // 
            this.TxtCoefJ.Location = new System.Drawing.Point(105, 68);
            this.TxtCoefJ.Name = "TxtCoefJ";
            this.TxtCoefJ.Size = new System.Drawing.Size(45, 20);
            this.TxtCoefJ.TabIndex = 25;
            this.TxtCoefJ.Text = "1";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Множитель Т";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Критическая Т";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCritT
            // 
            this.TxtCritT.Location = new System.Drawing.Point(105, 16);
            this.TxtCritT.Name = "TxtCritT";
            this.TxtCritT.Size = new System.Drawing.Size(45, 20);
            this.TxtCritT.TabIndex = 21;
            this.TxtCritT.Text = "2.269";
            // 
            // TimerAnimate
            // 
            this.TimerAnimate.Tick += new System.EventHandler(this.TimerAnimate_Tick);
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Location = new System.Drawing.Point(346, 661);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(313, 33);
            this.BtnStart.TabIndex = 22;
            this.BtnStart.Text = "Запуск";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.LabelTimerTick);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.LabelPositive);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.LabelNegative);
            this.groupBox3.Controls.Add(this.LabelTotal);
            this.groupBox3.Controls.Add(this.LabelMetropolis);
            this.groupBox3.Location = new System.Drawing.Point(10, 699);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(177, 122);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Спины";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(5, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Тик таймера";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTimerTick
            // 
            this.LabelTimerTick.Location = new System.Drawing.Point(118, 91);
            this.LabelTimerTick.Name = "LabelTimerTick";
            this.LabelTimerTick.Size = new System.Drawing.Size(46, 20);
            this.LabelTimerTick.TabIndex = 21;
            this.LabelTimerTick.Text = "0";
            this.LabelTimerTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(5, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Текущий МКШ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMetropolis
            // 
            this.LabelMetropolis.Location = new System.Drawing.Point(118, 71);
            this.LabelMetropolis.Name = "LabelMetropolis";
            this.LabelMetropolis.Size = new System.Drawing.Size(46, 20);
            this.LabelMetropolis.TabIndex = 19;
            this.LabelMetropolis.Text = "0";
            this.LabelMetropolis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.LabelHi);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.LabelHeat);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.LabelENorm);
            this.groupBox4.Controls.Add(this.labelMNorm);
            this.groupBox4.Location = new System.Drawing.Point(191, 705);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(177, 116);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(5, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Восприимчивость";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelHi
            // 
            this.LabelHi.Location = new System.Drawing.Point(118, 74);
            this.LabelHi.Name = "LabelHi";
            this.LabelHi.Size = new System.Drawing.Size(46, 20);
            this.LabelHi.TabIndex = 21;
            this.LabelHi.Text = "0";
            this.LabelHi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(5, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Теплоемкость";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelHeat
            // 
            this.LabelHeat.Location = new System.Drawing.Point(118, 54);
            this.LabelHeat.Name = "LabelHeat";
            this.LabelHeat.Size = new System.Drawing.Size(46, 20);
            this.LabelHeat.TabIndex = 19;
            this.LabelHeat.Text = "0";
            this.LabelHeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(5, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Средняя Е";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(5, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Средняя М";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelENorm
            // 
            this.LabelENorm.Location = new System.Drawing.Point(118, 15);
            this.LabelENorm.Name = "LabelENorm";
            this.LabelENorm.Size = new System.Drawing.Size(46, 20);
            this.LabelENorm.TabIndex = 17;
            this.LabelENorm.Text = "0";
            this.LabelENorm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMNorm
            // 
            this.labelMNorm.Location = new System.Drawing.Point(118, 34);
            this.labelMNorm.Name = "labelMNorm";
            this.labelMNorm.Size = new System.Drawing.Size(46, 20);
            this.labelMNorm.TabIndex = 18;
            this.labelMNorm.Text = "0";
            this.labelMNorm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarSpins
            // 
            this.BarSpins.Location = new System.Drawing.Point(10, 527);
            this.BarSpins.Margin = new System.Windows.Forms.Padding(2);
            this.BarSpins.MarqueeAnimationSpeed = 100000;
            this.BarSpins.Name = "BarSpins";
            this.BarSpins.Size = new System.Drawing.Size(685, 27);
            this.BarSpins.Step = 1;
            this.BarSpins.TabIndex = 31;
            // 
            // LabelPercent
            // 
            this.LabelPercent.Location = new System.Drawing.Point(700, 527);
            this.LabelPercent.Name = "LabelPercent";
            this.LabelPercent.Size = new System.Drawing.Size(44, 27);
            this.LabelPercent.TabIndex = 27;
            this.LabelPercent.Text = "0%";
            this.LabelPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCalcNormal
            // 
            this.BtnCalcNormal.Location = new System.Drawing.Point(829, 661);
            this.BtnCalcNormal.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCalcNormal.Name = "BtnCalcNormal";
            this.BtnCalcNormal.Size = new System.Drawing.Size(345, 33);
            this.BtnCalcNormal.TabIndex = 32;
            this.BtnCalcNormal.Text = "Зависимость";
            this.BtnCalcNormal.UseVisualStyleBackColor = true;
            this.BtnCalcNormal.Click += new System.EventHandler(this.BtnCalcNormal_Click);
            // 
            // ChartNormalM
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartNormalM.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.ChartNormalM.Legends.Add(legend1);
            this.ChartNormalM.Location = new System.Drawing.Point(749, 11);
            this.ChartNormalM.Margin = new System.Windows.Forms.Padding(2);
            this.ChartNormalM.Name = "ChartNormalM";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartNormalM.Series.Add(series1);
            this.ChartNormalM.Size = new System.Drawing.Size(504, 260);
            this.ChartNormalM.TabIndex = 33;
            this.ChartNormalM.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Main";
            title1.Text = "Намагниченность";
            this.ChartNormalM.Titles.Add(title1);
            // 
            // ChartNormalE
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartNormalE.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.ChartNormalE.Legends.Add(legend2);
            this.ChartNormalE.Location = new System.Drawing.Point(749, 275);
            this.ChartNormalE.Margin = new System.Windows.Forms.Padding(2);
            this.ChartNormalE.Name = "ChartNormalE";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Orange;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartNormalE.Series.Add(series2);
            this.ChartNormalE.Size = new System.Drawing.Size(504, 247);
            this.ChartNormalE.TabIndex = 34;
            this.ChartNormalE.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Main";
            title2.Text = "Энергия";
            this.ChartNormalE.Titles.Add(title2);
            // 
            // TimerNormal
            // 
            this.TimerNormal.Interval = 1;
            this.TimerNormal.Tick += new System.EventHandler(this.TimerNormal_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtStepT);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.TxtMaxT);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.TxtMinT);
            this.groupBox5.Location = new System.Drawing.Point(665, 560);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(161, 95);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Нормализация";
            // 
            // TxtStepT
            // 
            this.TxtStepT.Location = new System.Drawing.Point(110, 67);
            this.TxtStepT.Name = "TxtStepT";
            this.TxtStepT.Size = new System.Drawing.Size(45, 20);
            this.TxtStepT.TabIndex = 29;
            this.TxtStepT.Text = "0.05";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Шаг по Т";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtMaxT
            // 
            this.TxtMaxT.Location = new System.Drawing.Point(110, 41);
            this.TxtMaxT.Name = "TxtMaxT";
            this.TxtMaxT.Size = new System.Drawing.Size(45, 20);
            this.TxtMaxT.TabIndex = 27;
            this.TxtMaxT.Text = "1.5";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(6, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Максимальная Т";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(9, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 18);
            this.label20.TabIndex = 22;
            this.label20.Text = "Минимальная Т";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtMinT
            // 
            this.TxtMinT.Location = new System.Drawing.Point(110, 16);
            this.TxtMinT.Name = "TxtMinT";
            this.TxtMinT.Size = new System.Drawing.Size(45, 20);
            this.TxtMinT.TabIndex = 21;
            this.TxtMinT.Text = "0.3";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 824);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.ChartNormalE);
            this.Controls.Add(this.ChartNormalM);
            this.Controls.Add(this.BtnCalcNormal);
            this.Controls.Add(this.LabelPercent);
            this.Controls.Add(this.BarSpins);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.pcbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модель Изинга";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartNormalM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartNormalE)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.ComboBox CmbAmount;
        private System.Windows.Forms.RadioButton radioAllSpins;
        private System.Windows.Forms.RadioButton radioNegativeSpins;
        private System.Windows.Forms.RadioButton radioPositiveSpins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelPositive;
        private System.Windows.Forms.Label LabelNegative;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCritT;
        private System.Windows.Forms.Timer TimerAnimate;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtInterval;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelMetropolis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCoefJ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelHeat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabelENorm;
        private System.Windows.Forms.Label labelMNorm;
        private System.Windows.Forms.ProgressBar BarSpins;
        private System.Windows.Forms.Label LabelPercent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LabelTimerTick;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LabelHi;
        private System.Windows.Forms.TextBox TxtMultiplierT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtMKSH;
        private System.Windows.Forms.Button BtnCalcNormal;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartNormalM;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartNormalE;
        private System.Windows.Forms.Timer TimerNormal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtMaxT;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtMinT;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtStepT;
        private System.Windows.Forms.Label label15;
    }
}

