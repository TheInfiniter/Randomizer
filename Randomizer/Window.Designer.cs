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
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAllSpins = new System.Windows.Forms.RadioButton();
            this.radioNegativeSpins = new System.Windows.Forms.RadioButton();
            this.radioPositiveSpins = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.cmbAmount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPositive = new System.Windows.Forms.Label();
            this.LabelNegative = new System.Windows.Forms.Label();
            this.TxtMCS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbMain
            // 
            this.pcbMain.Location = new System.Drawing.Point(10, 13);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(734, 633);
            this.pcbMain.TabIndex = 0;
            this.pcbMain.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(752, 154);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 41);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(749, 12);
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
            this.groupBox1.Location = new System.Drawing.Point(752, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 88);
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
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(749, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество частиц";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(866, 36);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 20);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAmount
            // 
            this.cmbAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmount.FormattingEnabled = true;
            this.cmbAmount.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "200",
            "500"});
            this.cmbAmount.Location = new System.Drawing.Point(866, 13);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.Size = new System.Drawing.Size(45, 21);
            this.cmbAmount.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(752, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "положительные";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(752, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "отрицательные";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPositive
            // 
            this.LabelPositive.Location = new System.Drawing.Point(867, 606);
            this.LabelPositive.Name = "LabelPositive";
            this.LabelPositive.Size = new System.Drawing.Size(44, 20);
            this.LabelPositive.TabIndex = 17;
            this.LabelPositive.Text = "0";
            this.LabelPositive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNegative
            // 
            this.LabelNegative.Location = new System.Drawing.Point(867, 626);
            this.LabelNegative.Name = "LabelNegative";
            this.LabelNegative.Size = new System.Drawing.Size(44, 20);
            this.LabelNegative.TabIndex = 18;
            this.LabelNegative.Text = "0";
            this.LabelNegative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtMCS
            // 
            this.TxtMCS.Location = new System.Drawing.Point(106, 16);
            this.TxtMCS.Name = "TxtMCS";
            this.TxtMCS.Size = new System.Drawing.Size(33, 20);
            this.TxtMCS.TabIndex = 19;
            this.TxtMCS.Text = "100";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Число МКШ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtMCS);
            this.groupBox2.Location = new System.Drawing.Point(752, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 71);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Монте-Карло";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Критическая Т";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "100";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LabelNegative);
            this.Controls.Add(this.LabelPositive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAmount);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pcbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox cmbAmount;
        private System.Windows.Forms.RadioButton radioAllSpins;
        private System.Windows.Forms.RadioButton radioNegativeSpins;
        private System.Windows.Forms.RadioButton radioPositiveSpins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelPositive;
        private System.Windows.Forms.Label LabelNegative;
        private System.Windows.Forms.TextBox TxtMCS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

