using System;
using System.Collections.Generic;
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

            _positiveSpins = Convert.ToInt32(txtPositiveSpins.Text);
            _negativeSpins = Convert.ToInt32(txtNegativeSpins.Text);

            _actualSize = Convert.ToInt32(cmbAmount.SelectedItem);
            _cellSize = _actualSize + 1;
            _quantity = (int)Math.Pow(_actualSize, 2);

            if ((_positiveSpins + _negativeSpins) != _quantity)
            {
                
            }

            labelTotal.Text = _quantity.ToString();

            _spins = InitSpins(_actualSize);
            DrawGrid(_cellSize);
            DrawSpins(_spins, _actualSize);

            pcbMain.Image = _bmp;
        }

        private void DrawGrid(int size)
        {
            Pen pen = new Pen(Color.Black, 1);
            double width = pcbMain.Width, height = pcbMain.Height;
            double step = width / size;

            if (drawing)
            {
                for (int i = 1; i < width; i++)
                {
                    _draw.DrawLine(pen, (float)(i * step), 0, (float)(i * step), (float)(height));
                }

                for (int i = 1; i < height; i++)
                {
                    _draw.DrawLine(pen, 0, (float)(i * step), (float)(width), (float)(i * step));
                }
            }
            else
            {
                for (int i = 1; i < width; i++)
                {
                    _draw.DrawLine(pen, (float)(i * step), (float)step, (float)(i * step), (float)(height - step));
                }

                for (int i = 1; i < height; i++)
                {
                    _draw.DrawLine(pen, (float)step, (float)(i * step), (float)(width - step), (float)(i * step));
                }
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

            double width = pcbMain.Width;
            double step = width / (size + 1);

            double radius = step * 0.3;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (spins[i,j].Sign == 1)
                    {
                        _draw.FillEllipse(brushRed, (float)(spins[i, j].X - radius), (float)(spins[i, j].Y - radius), (float)radius * 2, (float)radius * 2);
                    }
                    else
                    {
                        _draw.FillEllipse(brushNavy, (float)(spins[i, j].X - radius), (float)(spins[i, j].Y - radius), (float)radius * 2, (float)radius * 2);
                    }
                }
            }
        }

        private Spin[,] InitSpins(int size)
        {
            Spin[,] spins = new Spin[size, size];

            double width = pcbMain.Width;
            double step = width / (size + 1);

            double x = 0, y = step;
            int sign;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x += step;
                    sign = GetRandomInt();
                    spins[i, j] = new Spin(x, y, sign);
                }
                y += step;
                x = 0;
            }

            return spins;
        }

        private int GetRandomInt()
        {
            int res = 0;

            while(res == 0)
            {
                res = rand.Next(-1, 2);
            }

            return res;
        }

        private void radioFull_CheckedChanged(object sender, EventArgs e)
        {
            drawing = radioFull.Checked;
        }

        private void radioAllSpins_CheckedChanged(object sender, EventArgs e)
        {
            txtPositiveSpins.Enabled = radioAllSpins.Checked;
            txtNegativeSpins.Enabled = radioAllSpins.Checked;
        }
    }
}
