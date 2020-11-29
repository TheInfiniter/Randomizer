using System;
using System.Drawing;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Window : Form
    {
        Bitmap _bmp;
        Graphics _draw;

        /// <summary>
        /// Сторона ячейки (actualSize + 2)
        /// </summary>
        int _cellSize;

        /// <summary>
        /// Количество спинов в одном измерении
        /// </summary>
        int _actualSize;
        int _positiveSpins, _negativeSpins;

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
            CmbAmount.SelectedIndex = 0;

            rand = new Random();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _draw.Clear(Color.Wheat);

            _actualSize = Convert.ToInt32(CmbAmount.SelectedItem);
            _cellSize = _actualSize + 2;
            _quantity = (int)Math.Pow(_actualSize, 2);

            _positiveSpins = 0;
            _negativeSpins = 0;

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

            _spins = InitSpins(_cellSize, generate);
            DrawGrid(_cellSize);
            DrawSpins(_spins, _cellSize);

            pcbMain.Image = _bmp;
            
            /*
            int positiveSpins = 0;
            int negativeSpins = 0;
            for (int i = 0; i < _spins.GetLength(0); i++)
            {
                for (int j = 0; j < _spins.GetLength(1); j++)
                {
                    if (_spins[i, j].Sign == 1)
                    {
                        positiveSpins += 1;
                    }
                    if (_spins[i, j].Sign == -1)
                    {
                        negativeSpins += 1;
                    }
                }
            }
            LabelNegative.Text = negativeSpins.ToString();
            LabelPositive.Text = positiveSpins.ToString();
            */
        }

        private void DrawGrid(int size)
        {
            Pen pen = new Pen(Color.Black, 1);
            size -= 1;
            double width = pcbMain.Width, height = pcbMain.Height;
            double widthStep = width / size;
            double heightStep = height / size;

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

            double radius = widthStep * 0.25;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (spins[i, j].Sign == 1)
                    {
                        _draw.FillEllipse(brushRed, (float)(spins[i, j].X - radius), (float)(spins[i, j].Y - radius), (float)radius * 2, (float)radius * 2);
                    }
                    else if (spins[i, j].Sign == -1)
                    {
                        _draw.FillEllipse(brushNavy, (float)(spins[i, j].X - radius), (float)(spins[i, j].Y - radius), (float)radius * 2, (float)radius * 2);
                    }
                    else if (spins[i, j].Sign == 0)
                    {
                        _draw.FillEllipse(brushGold, (float)(spins[i, j].X - radius), (float)(spins[i, j].Y - radius), (float)radius * 2, (float)radius * 2);
                    }
                }
            }
        }

        private Spin[,] InitSpins(int size, SpinType type)
        {
            Spin[,] spins = new Spin[size, size];

            double width = pcbMain.Width;
            double height = pcbMain.Height;
            double widthStep = width / (size - 1);
            double heightStep = height / (size - 1);

            double x = 0, y = 0;

            // размещение спинов на сетке
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {   
                    spins[i, j] = new Spin(x, y);

                    x += widthStep;
                }
                y += heightStep;
                x = 0;
            }

            spins = GetRandomSign(spins, size, type);

            return spins;
        }

        private Spin[,] GetRandomSign(Spin[,] spins, int size, SpinType type)
        {
            int row, column;
            int tmp = (int)Math.Pow(_cellSize, 2);

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

        private void Metropolis()
        {
            int row = rand.Next(1, _cellSize - 1);
            int column = rand.Next(1, _cellSize - 1);

            // энергия исходного состояния спина
            int prevSum = _spins[(row - 1 + _cellSize) % _cellSize, column].Sign +
                _spins[(row + 1 + _cellSize) % _cellSize, column].Sign +
                _spins[row, (column - 1 + _cellSize) % _cellSize].Sign +
                _spins[row, (column + 1 + _cellSize) % _cellSize].Sign;

            _newSpins = RotateSpin(_spins, row, column); // переворот спина

            // энергия нового состояния спина
            int newSum = _newSpins[(row - 1 + _cellSize) % _cellSize, column].Sign +
                _newSpins[(row + 1 + _cellSize) % _cellSize, column].Sign +
                _newSpins[row, (column - 1 + _cellSize) % _cellSize].Sign +
                _newSpins[row, (column + 1 + _cellSize) % _cellSize].Sign;

            int diff = newSum - prevSum;
            if (diff <= 0)
            {
                // доделать изменение состояния
            }
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
    }
}
