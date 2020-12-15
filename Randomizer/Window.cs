using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Window : Form
    {
        Bitmap _bmp;
        Graphics _draw;

        readonly double _k = 1.38 * Math.Pow(10, -23);

        /// <summary>
        /// Температура системы (критическая * множитель).
        /// </summary>
        double _temperature;
        double _criticalT;

        /// <summary>
        /// Сторона ячейки (actualSize + 2)
        /// </summary>
        int _cellSize;

        /// <summary>
        /// Общий размер ячейки.
        /// </summary>
        int _grid;

        /// <summary>
        /// Количество спинов в одном измерении
        /// </summary>
        int _actualSize;

        /// <summary>
        /// Положительные спины.
        /// </summary>
        int _positiveSpins;

        /// <summary>
        /// Отрицательные спины.
        /// </summary>
        int _negativeSpins;

        /// <summary>
        /// Количество шагов Метрополиса за тик таймера (который по умолчанию равен 0.1 секунды).
        /// </summary>
        int _interval;

        /// <summary>
        /// Текущий тик таймера (хотя по задумке это текущий МКШ).
        /// </summary>
        int _tick;

        /// <summary>
        /// Истинный МКШ.
        /// </summary>
        int _metropolis;
        int _montecarlo;

        /// <summary>
        /// Необходимое количество МКШ.
        /// </summary>
        int _requiredMKSH;

        /// <summary>
        /// Коэффициент J (для ферромагнетиков > 0, для антиферромагнетиков < 0).
        /// </summary>
        double _coefJ;

        /// <summary>
        /// Общее количество используемых спинов.
        /// </summary>
        int _quantity;

        /// <summary>
        /// Текущее состояние спинов.
        /// </summary>
        Spin[,] _spins;

        /// <summary>
        /// Средняя намагниченность.
        /// </summary>
        double _normalM;

        /// <summary>
        /// Средняя энергия.
        /// </summary>
        double _normalE;

        List<NormalValue> _result;
        double _tempStart, _tempStop, _tempStep;

        Random rand;

        public Window()
        {
            InitializeComponent();

            _bmp = new Bitmap(pcbMain.Width, pcbMain.Height);
            _draw = Graphics.FromImage(_bmp);
            _draw.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            CmbAmount.SelectedIndex = 1;

            rand = new Random();

            _interval = int.Parse(TxtInterval.Text);
        }

        private void Window_Load(object sender, EventArgs e)
        {
            BtnCreate_Click(sender, e);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // красивый цвет фона
            _draw.Clear(Color.Wheat);


            // тормозим таймер на всякий случай
            TimerAnimate.Stop();
            BtnStart.Text = "Запуск";

            // задаем переменные
            _actualSize = int.Parse((string)CmbAmount.SelectedItem);
            _quantity = (int)Math.Pow(_actualSize, 2);

            _cellSize = _actualSize + 2;
            _grid = (int)Math.Pow(_cellSize, 2);

            BarSpins.Maximum = _quantity;

            LabelTotal.Text = _quantity.ToString();

            // выбираем тип генерации
            SpinType generate = SpinType.All;

            if (radioAllSpins.Checked)
            {
                generate = SpinType.All;
            }
            else if (radioPositiveSpins.Checked)
            {
                generate = SpinType.Positive;
            }
            else if (radioNegativeSpins.Checked)
            {
                generate = SpinType.Negative;
            }

            // задаем начальное положение спинов
            _spins = InitSpins(_cellSize, generate);

            // универсальный метод для отрисовки текущего состояния системы
            DrawState(pcbMain, _spins, _cellSize);

            // считаем, сколько каких спинов получилось
            GetSpinsQuantity(_spins);

            // средняя намагниченность
            //_normalM = GetNormalM(_spins);
            labelMNorm.Text = _normalM.ToString();

            // средняя энергия
            //_normalE = GetNormalE(_spins, _cellSize);
            LabelENorm.Text = _normalE.ToString();

            // немного красоты на окошке
            BarSpins.Value = _positiveSpins;
            LabelPercent.Text = GetPercent(_positiveSpins, _quantity).ToString() + "%";

            // и готовим плацдарм для метрополиса
            _montecarlo = 0;
            LabelMetropolis.Text = _montecarlo.ToString();

            _tick = 0;
            LabelTimerTick.Text = _tick.ToString();

            BtnStart.Enabled = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            _temperature = double.Parse(TxtCritT.Text) * double.Parse(TxtMultiplierT.Text);
            _coefJ = double.Parse(TxtCoefJ.Text);
            _interval = int.Parse(TxtInterval.Text);
            _requiredMKSH = int.Parse(TxtMKSH.Text);

            if (!TimerAnimate.Enabled)
            {
                TimerAnimate.Enabled = true;
                BtnStart.Text = "Стоп";
            }
            else
            {
                TimerAnimate.Enabled = false;
                BtnStart.Text = "Запуск";
            }
        }

        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        public struct NormalValue
        {
            public NormalValue(double M,double E,double T)
            {
                this.M = M;
                this.E = E;
                this.Temp = T;
            }
            public double Temp { get; set; }
            public double M { get; set; }
            public double E { get; set; }
        }
        
        private void TimerAnimate_Tick(object sender, EventArgs e)
        {
            _interval = int.Parse(TxtInterval.Text);
            _temperature = double.Parse(TxtCritT.Text) * double.Parse(TxtMultiplierT.Text);

            // выполняется сразу куча шагов Метрополиса (иначе слишком медленно)
            for (int i = 0; i < _interval; i++)
            {
                Metropolis(_temperature);
            }

            LabelPositive.Text = _positiveSpins.ToString();
            LabelNegative.Text = _negativeSpins.ToString();

            if (_metropolis > _requiredMKSH)
            {
                _normalM = GetNormalM(_spins);
                _normalE = GetNormalE(_spins, _cellSize);
            }

            // вычисляется средняя намагниченность и средняя энергия
            labelMNorm.Text = Math.Abs(_normalM/ _quantity).ToString();
            LabelENorm.Text = (_normalE / _quantity).ToString();

            BarSpins.Value = _positiveSpins;
            LabelPercent.Text = GetPercent(_positiveSpins, _quantity).ToString() + "%";

            _tick++;
            LabelTimerTick.Text = _tick.ToString();

            _montecarlo += _interval;
            _metropolis = _montecarlo / _quantity;
            LabelMetropolis.Text = _metropolis.ToString();

            // рисуется обновленное состояние
            DrawState(pcbMain, _spins, _cellSize);
        }

        /// <summary>
        /// Один шаг алгоритма Метрополиса.
        /// </summary>
        private void Metropolis(double temperature)
        {
            // случайные координаты
            int row = rand.Next(_cellSize);
            int column = rand.Next(_cellSize);

            //_temperature = double.Parse(TxtCritT.Text) * double.Parse(TxtMultiplierT.Text);
            _coefJ = double.Parse(TxtCoefJ.Text);

            // энергия текущего состояния
            double prevH = GetEnergy(_spins, row, column, _coefJ, _cellSize);

            // новое состояние, поворот спина, энергия нового состояния
            Spin[,] newSpins = (Spin[,])_spins.Clone();
            newSpins[row, column].Sign = -newSpins[row, column].Sign;
            double nextH = GetEnergy(newSpins, row, column, _coefJ, _cellSize);

            double diff = nextH - prevH;
            double w = Math.Exp(-diff / temperature);

            if ((diff < 0) || (rand.Next(100) < (100 * w))) // принимается новое состояние, если одно из условий выполнено
            {
                _spins[row, column].Sign = -_spins[row, column].Sign;

                if (_spins[row, column].Sign < 0)
                {
                    _positiveSpins--;
                    _negativeSpins++;
                }
                else
                {
                    _positiveSpins++;
                    _negativeSpins--;
                }
                
                //_normalM += 2 * _spins[row, column].Sign;
                //_normalE -= 2 * _spins[row, column].Sign * prevH;
            }
        }

        /// <summary>
        /// Вычислить энергию взаимодействия с соседями спина.
        /// </summary>
        /// <param name="spins">Матрица спинов.</param>
        /// <param name="row">Строка нужного спина.</param>
        /// <param name="column">Столбец нужного спина.</param>
        /// <param name="J">Энергия взаимодействия соседей.</param>
        /// <param name="gridSize">Размер матрицы спинов.</param>
        /// <returns>Значение энергии взаимодействия выбранного спина с соседями.</returns>
        private double GetEnergy(Spin[,] spins, int row, int column, double J, int gridSize)
        {
            Point left = new Point
            {
                Y = column
            };
            if (row == 0)
                left.X = 1;
            else
                left.X = row - 1;

            Point right = new Point
            {
                Y = column
            };
            if (row == gridSize - 1)
                right.X = gridSize - 2;
            else
                right.X = row + 1;

            Point up = new Point
            {
                X = row
            };
            if (column == 0)
                up.Y = 1;
            else
                up.Y = column - 1;

            Point down = new Point
            {
                X = row
            };
            if (column == gridSize - 1)
                down.Y = gridSize - 2;
            else
                down.Y = column + 1;

            return -J * (spins[row, column].Sign * spins[left.X, left.Y].Sign +
                spins[row, column].Sign * spins[right.X, right.Y].Sign +
                spins[row, column].Sign * spins[up.X, up.Y].Sign +
                spins[row, column].Sign * spins[down.X, down.Y].Sign);
        }

        /// <summary>
        /// Получить текущий процент положительных спинов.
        /// </summary>
        /// <param name="positiveSpins">Число положительных спинов.</param>
        /// <param name="quantity">Число всех спинов.</param>
        /// <returns>Процент положительных спинов относительно всех.</returns>
        private double GetPercent(double positiveSpins, double quantity)
        {
            return positiveSpins / quantity * 100;
        }

        /// <summary>
        /// Получить среднюю намагниченность (на самом деле она нифига не средняя).
        /// </summary>
        /// <param name="spins">Состояние спинов.</param>
        /// <returns>Значение намагниченности.</returns>
        private double GetNormalM(Spin[,] spins)
        {
            int outerEdge = 1;
            double res = 0;

            for (int i = outerEdge; i < spins.GetLength(0) - outerEdge; i++)
            {
                for (int j = outerEdge; j < spins.GetLength(1) - outerEdge; j++)
                {
                    res += spins[i, j].Sign;
                }
            }

            return res;
        }

        /// <summary>
        /// Получить среднюю энергию (на самом деле нифига она не средняя).
        /// </summary>
        /// <param name="spins">Состояние спинов.</param>
        /// <param name="size">Размер решетки спинов.</param>
        /// <returns>Значение энергии</returns>
        private double GetNormalE(Spin[,] spins, int size)
        {
            int outerEdge = 0;
            double res = 0;

            for (int i = outerEdge; i < size - outerEdge; i++)
            {
                for (int j = outerEdge; j < size - outerEdge; j++)
                {
                    res += GetEnergy(spins, i, j, _coefJ, size - outerEdge);
                }
            }
            
            return res;
        }

        /// <summary>
        /// Считает количество положительных и отрицательных спинов.
        /// </summary>
        /// <param name="spins">Матрица спинов.</param>
        private void GetSpinsQuantity(Spin[,] spins)
        {
            _positiveSpins = 0;
            _negativeSpins = 0;

            // внешняя граница (захотим - отсечем один слой, захотим - два слоя, и так далее)
            int outerEdge = 1;

            for (int i = outerEdge; i < spins.GetLength(0) - outerEdge; i++)
            {
                for (int j = outerEdge; j < spins.GetLength(1) - outerEdge; j++)
                {
                    if (spins[i, j].Sign == 1)
                    {
                        _positiveSpins += 1;
                    }
                    if (spins[i, j].Sign == -1)
                    {
                        _negativeSpins += 1;
                    }
                }
            }
            LabelPositive.Text = _positiveSpins.ToString();
            LabelNegative.Text = _negativeSpins.ToString();
        }

        /// <summary>
        /// Нарисовать текущее состояние спинов.
        /// </summary>
        /// <param name="pcb">Контрол для рисования.</param>
        /// <param name="spins">Матрица спинов.</param>
        /// <param name="size">Размер ячейки.</param>
        private void DrawState(PictureBox pcb, Spin[,] spins, int size)
        {
            DrawSpins(spins, size);
            DrawGrid(size);

            pcb.Image = _bmp;
        }

        private void DrawGrid(int size)
        {
            Pen pen = new Pen(Color.Black, 1);
            
            double width = pcbMain.Width, height = pcbMain.Height;
            double widthStep = width / (size);
            double heightStep = height / (size);

            for (int i = 1; i < width - 1; i++)
            {
                _draw.DrawLine(pen, (float)(i * widthStep), 0, (float)(i * widthStep), (float)(height));
            }

            for (int i = 1; i < height - 1; i++)
            {
                _draw.DrawLine(pen, 0, (float)(i * heightStep), (float)(width), (float)(i * heightStep));
            }

            pen = new Pen(Color.Black, 2);
            _draw.DrawLine(pen, 1, 0, 1, (float)height);
            _draw.DrawLine(pen, 0, 1, (float)width, 1);
            _draw.DrawLine(pen, (float)width - 1, 0, (float)width - 1, (float)height);
            _draw.DrawLine(pen, 0, (float)height - 1, (float)width, (float)height - 1);
        }

        private void DrawSpins(Spin[,] spins, int size)
        {
            SolidBrush brushRed = new SolidBrush(Color.Red);
            SolidBrush brushNavy = new SolidBrush(Color.Navy);
            SolidBrush brushGold = new SolidBrush(Color.Gold);

            double width = pcbMain.Width;
            double height = pcbMain.Height;
            double widthStep = width / (size);
            double heightStep = height / (size);

            for (int i = 1; i < size-1; i++)
            {
                for (int j = 1; j < size-1; j++)
                {
                    if (spins[i, j].Sign == 1)
                    {
                        _draw.FillRectangle(brushRed, (float)(spins[i, j].X - widthStep / 2), (float)(spins[i, j].Y - heightStep / 2), (float)widthStep, (float)heightStep);
                    }
                    else if (spins[i, j].Sign == -1)
                    {
                        _draw.FillRectangle(brushNavy, (float)(spins[i, j].X - widthStep / 2), (float)(spins[i, j].Y - heightStep / 2), (float)widthStep, (float)heightStep);
                    }
                    else if (spins[i, j].Sign == 0)
                    {
                        _draw.FillRectangle(brushGold, (float)(spins[i, j].X - widthStep / 2), (float)(spins[i, j].Y - heightStep / 2), (float)widthStep, (float)heightStep);
                    }
                }
            }
        }

        /// <summary>
        /// Создать первичное расположение спинов.
        /// </summary>
        /// <param name="size">Размер ячейки со спинами.</param>
        /// <param name="type">Тип генерации (см перечисление).</param>
        /// <returns>Первичное расположение спинов.</returns>
        private Spin[,] InitSpins(int size, SpinType type)
        {
            Spin[,] spins = new Spin[size, size];

            double width = pcbMain.Width;
            double height = pcbMain.Height;
            double widthStep = width / (size);
            double heightStep = height / (size);

            double x = widthStep / 2, y = heightStep / 2;

            // размещение спинов на сетке
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {   
                    spins[i, j] = new Spin(x, y);

                    x += widthStep;
                }
                y += heightStep;
                x = widthStep / 2;
            }

            spins = GetRandomSign(spins, size, type);

            return spins;
        }

        private Spin[,] GetRandomSign(Spin[,] spins, int size, SpinType type)
        {
            int row, column;
            int tmp = (int)Math.Pow(size, 2);

            switch(type)
            {
                case SpinType.All:
                    {
                        for (int i = 0; i < tmp / 2; i++)
                        {
                            while (true)
                            {
                                row = rand.Next(0, size);
                                column = rand.Next(0, size);

                                if (spins[row, column].Sign == 0)
                                {
                                    spins[row, column].Sign = 1;
                                    break;
                                }
                            }
                        }

                        for (int i = 0; i < tmp / 2; i++)
                        {
                            while (true)
                            {
                                row = rand.Next(0, size);
                                column = rand.Next(0, size);

                                if (spins[row, column].Sign == 0)
                                {
                                    spins[row, column].Sign = -1;
                                    break;
                                }
                            }
                        }
                        break;
                    }
                case SpinType.Positive:
                    {
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                spins[i, j].Sign = 1;
                            }
                        }
                        break;
                    }
                case SpinType.Negative:
                    {
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                spins[i, j].Sign = -1;
                            }
                        }
                        break;
                    }
            }

            return spins;
        }

        /// <summary>
        /// Получить значение теплоемкости.
        /// </summary>
        /// <returns></returns>
        private double GetHeatCapacity()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получить значение магнитной восприимчивости.
        /// </summary>
        /// <returns></returns>
        private double GetMagneticSensibility()
        {
            throw new NotImplementedException();
        }

        private void TimerNormal_Tick(object sender, EventArgs e)
        {
            Recursion(_result, _tempStart);

            int count = _result.Count;

            ChartNormalM.Series[0].Points.AddXY(_result[count - 1].Temp, _result[count - 1].M);
            ChartNormalE.Series[0].Points.AddXY(_result[count - 1].Temp, _result[count - 1].E);

            _tempStart += _tempStep;

            if(_tempStart > _tempStop)
            {
                TimerNormal.Stop();
                BtnCalcNormal.Enabled = true;
            }
        }

        private void Recursion(List<NormalValue> result, double temp)
        {
            /*
            double tempStart = 0.3;
            double tempStop = 1.5;
            List<NormalValue> result = new List<NormalValue>();
            */
            double normalM = 0;
            double normalE = 0;

            temp *= _criticalT;

            for (int i = 0; i < Convert.ToInt32(TxtMKSH.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt32(TxtInterval.Text); j++)
                {
                    Metropolis(temp);
                }
            }

            normalM = Math.Abs(GetNormalM(_spins)) / _quantity;
            normalE = GetNormalE(_spins, _cellSize) / _quantity;
            result.Add(new NormalValue(normalM, normalE, temp));
            //tempStart += 0.05;

            /*
            while (tempStart < tempStop)
            {
                
            }
            
            for (int j = 0; j < result.Count; j++)
            {
                ChartNormalM.Series[0].Points.AddXY(result[j].Temp, result[j].M);
            }
            */
        }

        private void BtnCalcNormal_Click(object sender, EventArgs e)
        {
            _result = new List<NormalValue>();

            _tempStart = double.Parse(TxtMinT.Text);
            _tempStop = double.Parse(TxtMaxT.Text);
            _tempStep = double.Parse(TxtStepT.Text);
            _criticalT = double.Parse(TxtCritT.Text);

            ChartNormalE.Series[0].Points.Clear();
            ChartNormalM.Series[0].Points.Clear();

            TimerNormal.Start();
            BtnCalcNormal.Enabled = false;
            //Recursion();
        }
    }
}
