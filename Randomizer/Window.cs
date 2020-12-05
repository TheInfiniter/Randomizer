using System;
using System.Drawing;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Window : Form
    {
        Bitmap _bmp;
        Graphics _draw;

        readonly double _k = 1.38 * Math.Pow(10, -23);
        double _temperature;

        /// <summary>
        /// Сторона ячейки (actualSize + 2)
        /// </summary>
        int _cellSize;

        /// <summary>
        /// Количество спинов в одном измерении
        /// </summary>
        int _actualSize;
        int _positiveSpins, _negativeSpins;

        int _interval, montecarlo;

        double coefJ;

        /// <summary>
        /// Общее количество используемых спинов
        /// </summary>
        int _quantity;

        /// <summary>
        /// Исходное состояние спинов
        /// </summary>
        Spin[,] _spins;

        /// <summary>
        /// Новое состояние спинов
        /// </summary>
        Spin[,] _newSpins;
        Random rand;

        public Window()
        {
            InitializeComponent();

            _bmp = new Bitmap(pcbMain.Width, pcbMain.Height);
            _draw = Graphics.FromImage(_bmp);
            _draw.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            CmbAmount.SelectedIndex = 1;
            CmbMultiplierT.SelectedIndex = 0;

            rand = new Random();

            _interval = Convert.ToInt32(TxtInterval.Text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _draw.Clear(Color.Wheat);

            if (TimerAnimate.Enabled)
            {
                TimerAnimate.Enabled = false;
            }

            _actualSize = Convert.ToInt32(CmbAmount.SelectedItem);
            _cellSize = _actualSize + 2;
            _quantity = (int)Math.Pow(_actualSize, 2);

            LabelTotal.Text = _quantity.ToString();

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

            _spins = InitSpins(_actualSize, generate);

            DrawAll(pcbMain, _spins, _actualSize);
            /*
            DrawSpins(_spins, _actualSize);
            DrawGrid(_actualSize);
            */

            pcbMain.Image = _bmp;
            
            _positiveSpins = 0;
            _negativeSpins = 0;
            for (int i = 0; i < _spins.GetLength(0); i++)
            {
                for (int j = 0; j < _spins.GetLength(1); j++)
                {
                    if (_spins[i, j].Sign == 1)
                    {
                        _positiveSpins += 1;
                    }
                    if (_spins[i, j].Sign == -1)
                    {
                        _negativeSpins += 1;
                    }
                }
            }
            LabelPositive.Text = _positiveSpins.ToString();
            LabelNegative.Text = _negativeSpins.ToString();

            montecarlo = 0;
            LabelMonteCarlo.Text = montecarlo.ToString();
            BtnStart.Enabled = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            _temperature = Convert.ToDouble(TxtCritT.Text) * Convert.ToDouble(CmbMultiplierT.SelectedItem);
            coefJ = Convert.ToDouble(TxtCoefJ.Text);
            _interval = Convert.ToInt32(TxtInterval.Text);

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

        private void TimerAnimate_Tick(object sender, EventArgs e)
        {
            _interval = Convert.ToInt32(TxtInterval.Text);

            for (int i = 0; i < _interval; i++)
            {
                Metropolis();
            }

            if (++montecarlo == _quantity)
            {
                //TimerAnimate.Enabled = false;
            }

            _positiveSpins = 0;
            _negativeSpins = 0;
            for (int i = 0; i < _spins.GetLength(0); i++)
            {
                for (int j = 0; j < _spins.GetLength(1); j++)
                {
                    if (_spins[i, j].Sign == 1)
                    {
                        _positiveSpins += 1;
                    }
                    if (_spins[i, j].Sign == -1)
                    {
                        _negativeSpins += 1;
                    }
                }
            }
            LabelPositive.Text = _positiveSpins.ToString();
            LabelNegative.Text = _negativeSpins.ToString();

            LabelMonteCarlo.Text = montecarlo.ToString();

            DrawAll(pcbMain, _spins, _actualSize);
        }

        private void Metropolis()
        {
            int row = rand.Next(_actualSize);
            int column = rand.Next(_actualSize);

            _temperature = Convert.ToDouble(TxtCritT.Text) * Convert.ToDouble(CmbMultiplierT.SelectedItem);
            coefJ = Convert.ToDouble(TxtCoefJ.Text);
            
            double prevH = Energy(_spins, row, column, coefJ, _actualSize);

            Spin[,] newSpins = (Spin[,])_spins.Clone();
            newSpins[row, column].Sign = -newSpins[row, column].Sign;
            double nextH = Energy(newSpins, row, column, coefJ, _actualSize);

            double diff = nextH - prevH;
            double w = Math.Exp(-diff / _temperature);

            if (((diff) < 0) || (rand.Next(100) < (100 * w)))
            {
                _spins = newSpins;
            }

            //return newSpins;
        }

        private double Energy(Spin[,] spins, int row, int column, double J, int gridSize)
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
            /*
            double middle = 
                spins[(row - 1 + gridSize) % gridSize, column] +
                spins[(row + 1 + gridSize) % gridSize, column] +
                spins[row, (column - 1 + gridSize) % gridSize] +
                spins[row, (column + 1 + gridSize) % gridSize];

            double energy = -J * spins[row, column] * middle;

            return energy;
            */
        }

        private void DrawAll(PictureBox pcb, Spin[,] spins, int size)
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

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (spins[i, j].Sign == 1)
                    {
                        _draw.FillRectangle(brushRed, (float)(spins[i, j].X - widthStep / 2), (float)(spins[i, j].Y - heightStep / 2), (float)widthStep, (float)heightStep);
                    }
                    else if (spins[i, j].Sign == -1)
                    {
                        _draw.FillRectangle(brushNavy, (float)(spins[i, j].X - widthStep / 2), (float)(spins[i, j].Y - heightStep / 2), 2 * (float)widthStep, (float)heightStep);
                    }
                    else if (spins[i, j].Sign == 0)
                    {
                        _draw.FillRectangle(brushGold, (float)(spins[i, j].X - widthStep / 2), (float)(spins[i, j].Y - heightStep / 2), (float)widthStep, (float)heightStep);
                    }
                }
            }
        }

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

        private Spin[,] RotateSpin(Spin[,] spins, int row, int column)
        {
            spins[row, column].Sign = -spins[row, column].Sign;

            return spins;
        }

        private int GetEdge(int index, int length)
        {
            if (index == 0)
            {
                index = length - 2;
            }
            else if (index == length - 1)
            {
                index = 1;
            }

            return index;
        }

        /// <summary>
        /// Получить случайное число в диапазоне.
        /// </summary>
        /// <param name="minimum">Левая граница диапазона.</param>
        /// <param name="maximum">Правая граница диапазона.</param>
        /// <returns>Случайное число из диапазона.</returns>
        public double GetRandom(double minimum, double maximum)
        {
            double res = rand.NextDouble() * (maximum - minimum) + minimum;
            if (res > 1) res = 1;
            return res;
        }
    }
}
