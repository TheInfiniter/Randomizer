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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAllSpins = new System.Windows.Forms.RadioButton();
            this.radioNegativeSpins = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioPositiveSpins = new System.Windows.Forms.RadioButton();
            this.TxtInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.CmbAmount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPositive = new System.Windows.Forms.Label();
            this.LabelNegative = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCoefJ = new System.Windows.Forms.TextBox();
            this.CmbMultiplierT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCritT = new System.Windows.Forms.TextBox();
            this.TimerAnimate = new System.Windows.Forms.Timer(this.components);
            this.BtnStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelMonteCarlo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelENorm = new System.Windows.Forms.Label();
            this.labelMNorm = new System.Windows.Forms.Label();
            this.BarSpins = new System.Windows.Forms.ProgressBar();
            this.LabelPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbMain
            // 
            this.pcbMain.Location = new System.Drawing.Point(13, 13);
            this.pcbMain.Margin = new System.Windows.Forms.Padding(4);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(979, 629);
            this.pcbMain.TabIndex = 0;
            this.pcbMain.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(13, 814);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(440, 41);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(217, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сторона ячейки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAllSpins);
            this.groupBox1.Controls.Add(this.radioNegativeSpins);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radioPositiveSpins);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtInterval);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LabelTotal);
            this.groupBox1.Controls.Add(this.CmbAmount);
            this.groupBox1.Location = new System.Drawing.Point(13, 689);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(440, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Спины";
            // 
            // radioAllSpins
            // 
            this.radioAllSpins.AutoSize = true;
            this.radioAllSpins.Checked = true;
            this.radioAllSpins.Location = new System.Drawing.Point(8, 23);
            this.radioAllSpins.Margin = new System.Windows.Forms.Padding(4);
            this.radioAllSpins.Name = "radioAllSpins";
            this.radioAllSpins.Size = new System.Drawing.Size(98, 21);
            this.radioAllSpins.TabIndex = 16;
            this.radioAllSpins.TabStop = true;
            this.radioAllSpins.Text = "Все спины";
            this.radioAllSpins.UseVisualStyleBackColor = true;
            // 
            // radioNegativeSpins
            // 
            this.radioNegativeSpins.AutoSize = true;
            this.radioNegativeSpins.Location = new System.Drawing.Point(8, 79);
            this.radioNegativeSpins.Margin = new System.Windows.Forms.Padding(4);
            this.radioNegativeSpins.Name = "radioNegativeSpins";
            this.radioNegativeSpins.Size = new System.Drawing.Size(183, 21);
            this.radioNegativeSpins.TabIndex = 15;
            this.radioNegativeSpins.Text = "Только отрицательные";
            this.radioNegativeSpins.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(221, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Вычислений в с";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioPositiveSpins
            // 
            this.radioPositiveSpins.AutoSize = true;
            this.radioPositiveSpins.Location = new System.Drawing.Point(8, 50);
            this.radioPositiveSpins.Margin = new System.Windows.Forms.Padding(4);
            this.radioPositiveSpins.Name = "radioPositiveSpins";
            this.radioPositiveSpins.Size = new System.Drawing.Size(185, 21);
            this.radioPositiveSpins.TabIndex = 14;
            this.radioPositiveSpins.Text = "Только положительные";
            this.radioPositiveSpins.UseVisualStyleBackColor = true;
            // 
            // TxtInterval
            // 
            this.TxtInterval.Location = new System.Drawing.Point(373, 78);
            this.TxtInterval.Margin = new System.Windows.Forms.Padding(4);
            this.TxtInterval.Name = "TxtInterval";
            this.TxtInterval.Size = new System.Drawing.Size(59, 22);
            this.TxtInterval.TabIndex = 25;
            this.TxtInterval.Text = "100";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(221, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество частиц";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTotal
            // 
            this.LabelTotal.Location = new System.Drawing.Point(373, 50);
            this.LabelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(59, 21);
            this.LabelTotal.TabIndex = 10;
            this.LabelTotal.Text = "0";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CmbAmount.Location = new System.Drawing.Point(373, 22);
            this.CmbAmount.Margin = new System.Windows.Forms.Padding(4);
            this.CmbAmount.Name = "CmbAmount";
            this.CmbAmount.Size = new System.Drawing.Size(59, 24);
            this.CmbAmount.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "+1 спины";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "-1 спины";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPositive
            // 
            this.LabelPositive.Location = new System.Drawing.Point(157, 17);
            this.LabelPositive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPositive.Name = "LabelPositive";
            this.LabelPositive.Size = new System.Drawing.Size(45, 25);
            this.LabelPositive.TabIndex = 17;
            this.LabelPositive.Text = "0";
            this.LabelPositive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNegative
            // 
            this.LabelNegative.Location = new System.Drawing.Point(157, 42);
            this.LabelNegative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNegative.Name = "LabelNegative";
            this.LabelNegative.Size = new System.Drawing.Size(45, 25);
            this.LabelNegative.TabIndex = 18;
            this.LabelNegative.Text = "0";
            this.LabelNegative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtCoefJ);
            this.groupBox2.Controls.Add(this.CmbMultiplierT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtCritT);
            this.groupBox2.Location = new System.Drawing.Point(461, 689);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(215, 117);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Монте-Карло";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Коэфициент J";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCoefJ
            // 
            this.TxtCoefJ.Location = new System.Drawing.Point(140, 84);
            this.TxtCoefJ.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCoefJ.Name = "TxtCoefJ";
            this.TxtCoefJ.Size = new System.Drawing.Size(59, 22);
            this.TxtCoefJ.TabIndex = 25;
            this.TxtCoefJ.Text = "0.5";
            // 
            // CmbMultiplierT
            // 
            this.CmbMultiplierT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMultiplierT.FormattingEnabled = true;
            this.CmbMultiplierT.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5"});
            this.CmbMultiplierT.Location = new System.Drawing.Point(140, 50);
            this.CmbMultiplierT.Margin = new System.Windows.Forms.Padding(4);
            this.CmbMultiplierT.Name = "CmbMultiplierT";
            this.CmbMultiplierT.Size = new System.Drawing.Size(59, 24);
            this.CmbMultiplierT.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Множитель Т";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Критическая Т";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCritT
            // 
            this.TxtCritT.Location = new System.Drawing.Point(140, 20);
            this.TxtCritT.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCritT.Name = "TxtCritT";
            this.TxtCritT.Size = new System.Drawing.Size(59, 22);
            this.TxtCritT.TabIndex = 21;
            this.TxtCritT.Text = "1";
            // 
            // TimerAnimate
            // 
            this.TimerAnimate.Tick += new System.EventHandler(this.TimerAnimate_Tick);
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Location = new System.Drawing.Point(461, 814);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(215, 41);
            this.BtnStart.TabIndex = 22;
            this.BtnStart.Text = "Запуск";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.LabelMonteCarlo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.LabelPositive);
            this.groupBox3.Controls.Add(this.LabelNegative);
            this.groupBox3.Location = new System.Drawing.Point(999, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(216, 107);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Спины";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Текущий МКШ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMonteCarlo
            // 
            this.LabelMonteCarlo.Location = new System.Drawing.Point(157, 66);
            this.LabelMonteCarlo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMonteCarlo.Name = "LabelMonteCarlo";
            this.LabelMonteCarlo.Size = new System.Drawing.Size(45, 25);
            this.LabelMonteCarlo.TabIndex = 19;
            this.LabelMonteCarlo.Text = "0";
            this.LabelMonteCarlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.LabelENorm);
            this.groupBox4.Controls.Add(this.labelMNorm);
            this.groupBox4.Location = new System.Drawing.Point(999, 124);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(216, 107);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "еще что-то";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(141, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "0";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(7, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Средняя Е";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(7, 42);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Средняя М";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelENorm
            // 
            this.LabelENorm.Location = new System.Drawing.Point(141, 17);
            this.LabelENorm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelENorm.Name = "LabelENorm";
            this.LabelENorm.Size = new System.Drawing.Size(61, 25);
            this.LabelENorm.TabIndex = 17;
            this.LabelENorm.Text = "0";
            this.LabelENorm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMNorm
            // 
            this.labelMNorm.Location = new System.Drawing.Point(141, 42);
            this.labelMNorm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMNorm.Name = "labelMNorm";
            this.labelMNorm.Size = new System.Drawing.Size(61, 25);
            this.labelMNorm.TabIndex = 18;
            this.labelMNorm.Text = "0";
            this.labelMNorm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarSpins
            // 
            this.BarSpins.Location = new System.Drawing.Point(12, 649);
            this.BarSpins.MarqueeAnimationSpeed = 100000;
            this.BarSpins.Name = "BarSpins";
            this.BarSpins.Size = new System.Drawing.Size(914, 33);
            this.BarSpins.Step = 1;
            this.BarSpins.TabIndex = 31;
            // 
            // LabelPercent
            // 
            this.LabelPercent.Location = new System.Drawing.Point(933, 649);
            this.LabelPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPercent.Name = "LabelPercent";
            this.LabelPercent.Size = new System.Drawing.Size(59, 33);
            this.LabelPercent.TabIndex = 27;
            this.LabelPercent.Text = "0%";
            this.LabelPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 868);
            this.Controls.Add(this.LabelPercent);
            this.Controls.Add(this.BarSpins);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pcbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.Button btnCreate;
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
        private System.Windows.Forms.ComboBox CmbMultiplierT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtInterval;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelMonteCarlo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCoefJ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabelENorm;
        private System.Windows.Forms.Label labelMNorm;
        private System.Windows.Forms.ProgressBar BarSpins;
        private System.Windows.Forms.Label LabelPercent;
    }
}

