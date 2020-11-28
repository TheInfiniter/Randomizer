using System;
using System.Drawing;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Window : Form
    {
        Bitmap _bmp;
        Graphics _draw;
        int _cellSize, _actualSize, _positiveSpins, _negativeSpins;
        int _quantity;
        Spin[,] _spins;
        bool drawing;
        Random rand;
        SpinType generate;

        public Window()
        {
            InitializeComponent();

            _bmp = new Bitmap(pcbMain.Width, pcbMain.Height);
            _draw = Graphics.FromImage(_bmp);
            cmbAmount.SelectedIndex = 0;
            drawing = true;

            rand = new Random();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _draw.Clear(Color.Wheat);

            _actualSize = Convert.ToInt32(cmbAmount.SelectedItem);
            _cellSize = _actualSize + 2;
            _quantity = (int)Math.Pow(_actualSize, 2);

            labelTotal.Text = _quantity.ToString();

            if(radioAllSpins.Checked)
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

            pen = new Pen(Color.Crimson, 2);
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
                    if (spins[i,j].Sign == 1)
                    {
                        _draw.FillEllipse(brushRed, (float)(spins[i, j].X - radius), (float)(spins[i, j].Y - radius), (float)radius * 2, (float)radius * 2);
                    }
                    else if (spins[i, j].Sign == -1)
                    {
                        _draw.FillEllipse(brushNavy, (float)(spins[i, j].X - radius), (float)(spins[i, j].Y - radius), (float)radius * 2, (float)radius * 2);
                    }
                    else
                    {
                        _draw.FillEllipse(brushGold, (float)(spins[i, j].X - radius), (float)(spins[i, j].Y - radius), (float)radius * 2, (float)radius * 2);
                    }
                }
            }
        }

        private Spin[,] InitSpins(int size, SpinType type)
        {
            Spin[,] spins = new Spin[size, size];

            //size += 2;

            double width = pcbMain.Width;
            double height = pcbMain.Height;
            double widthStep = width / (size - 1);
            double heightStep = height / (size - 1);

            double x = 0, y = 0;
            int sign;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j == 0 | j == (size - 1)) | (i == 0 | i == (size - 1)))
                    {
                        sign = 0;
                    }
                    else
                    {
                        sign = GetRandomInt(ref _positiveSpins, ref _negativeSpins, type);
                    }
                    spins[i, j] = new Spin(x, y, sign);
                    x += widthStep;
                }
                y += heightStep;
                x = 0;
            }

            return spins;
        }

        private int GetRandomInt(ref int positive, ref int negative, SpinType type)
        {
            int res = 0;

            switch(type)
            {
                case SpinType.Positive:
                    {
                        return 1;
                    }
                case SpinType.Negative:
                    {
                        return -1;
                    }
                case SpinType.All:
                    {
                        do
                        {
                            res = rand.Next(-1, 2);

                            if (res == 1 & positive <= (_quantity / 2))
                            {
                                positive += 1;
                                break;
                            }
                            if (res == -1 & negative <= (_quantity / 2))
                            {
                                negative += 1;
                                break;
                            }
                        } while (res == 0);
                        
                        break;
                    }
            }
            /*
            while(res == 0)
            {
                res = rand.Next(-1, 2);
            }
            */
            return res;
        }

        private void BtnTestRotate_Click(object sender, EventArgs e)
        {
            _spins = RotateSpin(_spins);

            DrawGrid(_cellSize);
            DrawSpins(_spins, _cellSize);

            pcbMain.Image = _bmp;
        }

        private void radioAllSpins_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private Spin[,] RotateSpin(Spin[,] spins)
        {
            int row = rand.Next(0, spins.GetLength(0));
            int column = rand.Next(0, spins.GetLength(1));

            /*
            LabelRow.Text = row.ToString();
            LabelColumn.Text = column.ToString();
            */

            spins[row, column].Sign = -spins[row, column].Sign;

            return spins;
        }
    }
}
