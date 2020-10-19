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
            this.txtPositiveSpins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNegativeSpins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAllSpins = new System.Windows.Forms.RadioButton();
            this.radioNegativeSpins = new System.Windows.Forms.RadioButton();
            this.radioPositiveSpins = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.cmbAmount = new System.Windows.Forms.ComboBox();
            this.radioFull = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioNotFull = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbMain
            // 
            this.pcbMain.Location = new System.Drawing.Point(12, 13);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(720, 720);
            this.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMain.TabIndex = 0;
            this.pcbMain.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(757, 262);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(141, 41);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(749, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сторона ячейки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPositiveSpins
            // 
            this.txtPositiveSpins.Location = new System.Drawing.Point(105, 16);
            this.txtPositiveSpins.Name = "txtPositiveSpins";
            this.txtPositiveSpins.Size = new System.Drawing.Size(45, 20);
            this.txtPositiveSpins.TabIndex = 5;
            this.txtPositiveSpins.Text = "20";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Положительные";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNegativeSpins
            // 
            this.txtNegativeSpins.Location = new System.Drawing.Point(105, 42);
            this.txtNegativeSpins.Name = "txtNegativeSpins";
            this.txtNegativeSpins.Size = new System.Drawing.Size(45, 20);
            this.txtNegativeSpins.TabIndex = 7;
            this.txtNegativeSpins.Text = "20";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отрицательные";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAllSpins);
            this.groupBox1.Controls.Add(this.radioNegativeSpins);
            this.groupBox1.Controls.Add(this.txtPositiveSpins);
            this.groupBox1.Controls.Add(this.radioPositiveSpins);
            this.groupBox1.Controls.Add(this.txtNegativeSpins);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(749, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Спины";
            // 
            // radioAllSpins
            // 
            this.radioAllSpins.AutoSize = true;
            this.radioAllSpins.Checked = true;
            this.radioAllSpins.Location = new System.Drawing.Point(9, 68);
            this.radioAllSpins.Name = "radioAllSpins";
            this.radioAllSpins.Size = new System.Drawing.Size(79, 17);
            this.radioAllSpins.TabIndex = 16;
            this.radioAllSpins.TabStop = true;
            this.radioAllSpins.Text = "Все спины";
            this.radioAllSpins.UseVisualStyleBackColor = true;
            this.radioAllSpins.CheckedChanged += new System.EventHandler(this.radioAllSpins_CheckedChanged);
            // 
            // radioNegativeSpins
            // 
            this.radioNegativeSpins.AutoSize = true;
            this.radioNegativeSpins.Location = new System.Drawing.Point(9, 114);
            this.radioNegativeSpins.Name = "radioNegativeSpins";
            this.radioNegativeSpins.Size = new System.Drawing.Size(143, 17);
            this.radioNegativeSpins.TabIndex = 15;
            this.radioNegativeSpins.Text = "Только отрицательные";
            this.radioNegativeSpins.UseVisualStyleBackColor = true;
            // 
            // radioPositiveSpins
            // 
            this.radioPositiveSpins.AutoSize = true;
            this.radioPositiveSpins.Location = new System.Drawing.Point(9, 91);
            this.radioPositiveSpins.Name = "radioPositiveSpins";
            this.radioPositiveSpins.Size = new System.Drawing.Size(146, 17);
            this.radioPositiveSpins.TabIndex = 14;
            this.radioPositiveSpins.Text = "Только положительные";
            this.radioPositiveSpins.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(752, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество частиц";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(864, 36);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(48, 20);
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
            this.cmbAmount.Location = new System.Drawing.Point(867, 13);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.Size = new System.Drawing.Size(45, 21);
            this.cmbAmount.TabIndex = 11;
            // 
            // radioFull
            // 
            this.radioFull.AutoSize = true;
            this.radioFull.Checked = true;
            this.radioFull.Location = new System.Drawing.Point(6, 19);
            this.radioFull.Name = "radioFull";
            this.radioFull.Size = new System.Drawing.Size(63, 17);
            this.radioFull.TabIndex = 12;
            this.radioFull.TabStop = true;
            this.radioFull.Text = "Полное";
            this.radioFull.UseVisualStyleBackColor = true;
            this.radioFull.CheckedChanged += new System.EventHandler(this.radioFull_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioNotFull);
            this.groupBox2.Controls.Add(this.radioFull);
            this.groupBox2.Location = new System.Drawing.Point(749, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 44);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рисование";
            // 
            // radioNotFull
            // 
            this.radioNotFull.AutoSize = true;
            this.radioNotFull.Location = new System.Drawing.Point(76, 19);
            this.radioNotFull.Name = "radioNotFull";
            this.radioNotFull.Size = new System.Drawing.Size(75, 17);
            this.radioNotFull.TabIndex = 13;
            this.radioNotFull.Text = "Неполное";
            this.radioNotFull.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 748);
            this.Controls.Add(this.groupBox2);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPositiveSpins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNegativeSpins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox cmbAmount;
        private System.Windows.Forms.RadioButton radioFull;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioNotFull;
        private System.Windows.Forms.RadioButton radioAllSpins;
        private System.Windows.Forms.RadioButton radioNegativeSpins;
        private System.Windows.Forms.RadioButton radioPositiveSpins;
    }
}

