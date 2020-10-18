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
        int _size;
        List<Spin> _spins;
        bool drawing;

        public Window()
        {
            InitializeComponent();

            _bmp = new Bitmap(pcbMain.Width, pcbMain.Height);
            _draw = Graphics.FromImage(_bmp);
            cmbAmount.SelectedIndex = 0;
            drawing = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _draw.Clear(Color.Wheat);
            _size = Convert.ToInt32(cmbAmount.SelectedItem) + 1;
            labelTotal.Text = Math.Pow(_size - 1, 2).ToString();
            DrawGrid(_size);

            pcbMain.Image = _bmp;
        }

        private void DrawGrid(int amount)
        {
            Pen pen = new Pen(Color.Black, 1);
            double width = pcbMain.Width, height = pcbMain.Height;
            double step = width / amount;

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

        private void DrawSpins()
        {

        }

        private void InitSpins()
        {
            _spins = new List<Spin>();
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
