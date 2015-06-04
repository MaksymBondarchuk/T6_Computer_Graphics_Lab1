using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maine
{
    public partial class MainForm : Form
    {
        const int x_size = 1200;
        const int y_size = 600;

        bool _dda = false;
        bool _bresenham = false;
        bool _wu = false;

        bool _line = false;
        bool _circle = false;
        bool _ellipse = false;
        bool _initials = false;


        Bitmap bmp = new Bitmap(x_size, y_size);
        Color _color = Color.Black;
        bool color_selected = true;

        public MainForm()
        {
            InitializeComponent();
        }

        public delegate void line_drawer(Bitmap bmp, Color color, int x1, int y1, int x2, int y2);

        //--------------------------------------------------------------------------------
        // DDA
        //--------------------------------------------------------------------------------

        void draw_line_DDA(Bitmap bmp, Color color, int x1, int y1, int x2, int y2)
        {
            int max = Math.Max(Math.Abs(y2 - y1), Math.Abs(x2 - x1));
            double dx = (x2 - x1) / (double)max;
            double dy = (y2 - y1) / (double)max;

            double x = x1;
            double y = y1;
            for (int i = 0; i < max; i++)
            {
                bmp.SetPixel((int)x, (int)y, color);
                x += dx;
                y += dy;
            }
        }

        //--------------------------------------------------------------------------------
        // Bresenham's
        //--------------------------------------------------------------------------------

        void draw_line_Bresenham(Bitmap bmp, Color color, int x1, int y1, int x2, int y2)
        {
            int dx = Math.Sign(x2 - x1);

            if (dx == 0)
            {
                draw_line_DDA(bmp, color, x1, y1, x2, y2);
                return;
            }

            double k = (y2 - y1) / (double)(x2 - x1);
            double b = y1 - k * x1;

            for (int x = x1; x * dx <= x2 * dx; x += dx)
            {
                double y = k * x + b;
                bmp.SetPixel(x, (int)y, color);
            }
        }

        void draw_circle(Bitmap bmp, Color color, int x, int y, int R)
        {
            double _x = x - 1;
            double _y = y + R;

            while (y <= _y)
            {
                double y_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y, 2) - R * R);
                double y_above = Math.Abs(Math.Pow(_x - x, 2) + Math.Pow(_y - y - 1, 2) - R * R);
                double y_above_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y - 1, 2) - R * R);

                if (y_right < y_above)
                {
                    if (y_right < y_above_right)
                        _x++;
                    else
                    {
                        _x++;
                        _y--;
                    }
                }
                else
                {
                    if (y_above < y_above_right)
                        _y--;
                    else
                    {
                        _x++;
                        _y--;
                    }
                }

                bmp.SetPixel((int)_x, (int)_y, color);
                bmp.SetPixel(2 * x - (int)_x, 2 * y - (int)_y, color);
                bmp.SetPixel(2 * x - (int)_x, (int)_y, color);
                bmp.SetPixel((int)_x, 2 * y - (int)_y, color);
            }
            pbox.Image = bmp;
        }

        void draw_circle_improved(Bitmap bmp, Color color, int x, int y, int R)
        {
            double _x = x - 1;
            double _y = y + R;

            while (y + R / (double)Math.Sqrt(2) <= _y)
            {
                double y_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y, 2) - R * R);
                double y_above_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y - 1, 2) - R * R);

                if (y_right < y_above_right)
                    _x++;
                else
                {
                    _x++;
                    _y--;
                }

                bmp.SetPixel((int)_x, (int)_y, color);
                bmp.SetPixel(2 * x - (int)_x, 2 * y - (int)_y, color);
                bmp.SetPixel(2 * x - (int)_x, (int)_y, color);
                bmp.SetPixel((int)_x, 2 * y - (int)_y, color);
            }

            while (y <= _y)
            {
                double y_above = Math.Abs(Math.Pow(_x - x, 2) + Math.Pow(_y - y - 1, 2) - R * R);
                double y_above_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y - 1, 2) - R * R);

                if (y_above < y_above_right)
                    _y--;
                else
                {
                    _x++;
                    _y--;
                }

                bmp.SetPixel((int)_x, (int)_y, color);
                bmp.SetPixel(2 * x - (int)_x, 2 * y - (int)_y, color);
                bmp.SetPixel(2 * x - (int)_x, (int)_y, color);
                bmp.SetPixel((int)_x, 2 * y - (int)_y, color);
            }

            pbox.Image = bmp;
        }

        void draw_ellipse_improved(Bitmap bmp, Color color, int x, int y, int Rx, int Ry)
        {
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();

            int R;
            bool _rx;
            bool _ry;
            if (Rx < Ry)
            {
                R = Ry;
                _ry = true;
                _rx = false;
            }
            else
            {
                R = Rx;
                _ry = false;
                _rx = true;
            }

            double _x = x - 1;
            double _y = y + R;

            while (y + R / (double)Math.Sqrt(2) <= _y)
            {
                double y_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y, 2) - R * R);
                double y_above_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y - 1, 2) - R * R);

                if (y_right < y_above_right)
                    _x++;
                else
                {
                    _x++;
                    _y--;
                }

                double __x = _x;
                double __y = _y;

                if (_rx)
                    __y = (_y - y) * Ry / (double)Rx + y;
                else
                    __x = (_x - x) * Rx / (double)Ry + x;

                bmp.SetPixel((int)__x, (int)__y, color);
                bmp.SetPixel(2 * x - (int)__x, 2 * y - (int)__y, color);
                bmp.SetPixel(2 * x - (int)__x, (int)__y, color);
                bmp.SetPixel((int)__x, 2 * y - (int)__y, color);
            }

            while (y <= _y)
            {
                double y_above = Math.Abs(Math.Pow(_x - x, 2) + Math.Pow(_y - y - 1, 2) - R * R);
                double y_above_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y - 1, 2) - R * R);

                if (y_above < y_above_right)
                    _y--;
                else
                {
                    _x++;
                    _y--;
                }

                double __x = _x;
                double __y = _y;

                if (_rx)
                    __y = (_y - y) * Ry / (double)Rx + y;
                else
                    __x = (_x - x) * Rx / (double)Ry + x;

                bmp.SetPixel((int)__x, (int)__y, color);
                bmp.SetPixel(2 * x - (int)__x, 2 * y - (int)__y, color);
                bmp.SetPixel(2 * x - (int)__x, (int)__y, color);
                bmp.SetPixel((int)__x, 2 * y - (int)__y, color);
            }

            pbox.Image = bmp;
        }

        void draw_half_ellipse_improved(Bitmap bmp, Color color, int x, int y, int Rx, int Ry)
        {
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();

            int R;
            bool _rx;
            bool _ry;
            if (Rx < Ry)
            {
                R = Ry;
                _ry = true;
                _rx = false;
            }
            else
            {
                R = Rx;
                _ry = false;
                _rx = true;
            }

            double _x = x - 1;
            double _y = y + R;

            while (y + R / (double)Math.Sqrt(2) <= _y)
            {
                double y_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y, 2) - R * R);
                double y_above_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y - 1, 2) - R * R);

                if (y_right < y_above_right)
                    _x++;
                else
                {
                    _x++;
                    _y--;
                }

                double __x = _x;
                double __y = _y;

                if (_rx)
                    __y = (_y - y) * Ry / (double)Rx + y;
                else
                    __x = (_x - x) * Rx / (double)Ry + x;

                bmp.SetPixel((int)__x, (int)__y, color);
                bmp.SetPixel((int)__x, 2 * y - (int)__y, color);
            }

            while (y <= _y)
            {
                double y_above = Math.Abs(Math.Pow(_x - x, 2) + Math.Pow(_y - y - 1, 2) - R * R);
                double y_above_right = Math.Abs(Math.Pow(_x - x + 1, 2) + Math.Pow(_y - y - 1, 2) - R * R);

                if (y_above < y_above_right)
                    _y--;
                else
                {
                    _x++;
                    _y--;
                }

                double __x = _x;
                double __y = _y;

                if (_rx)
                    __y = (_y - y) * Ry / (double)Rx + y;
                else
                    __x = (_x - x) * Rx / (double)Ry + x;

                bmp.SetPixel((int)__x, (int)__y, color);
                bmp.SetPixel((int)__x, 2 * y - (int)__y, color);
            }

            pbox.Image = bmp;
        }

        //--------------------------------------------------------------------------------
        // Xiaolin Wu's line algorithm
        //--------------------------------------------------------------------------------

        void draw_line_Wu(Bitmap bmp, Color color, int x1, int y1, int x2, int y2)
        {
            int dx = Math.Sign(x2 - x1);

            if (dx == 0)
            {
                draw_line_DDA(bmp, color, x1, y1, x2, y2);
                return;
            }

            double k = (y2 - y1) / (double)(x2 - x1);
            double b = y1 - k * x1;

            for (int x = x1; x * dx <= x2 * dx; x += dx)
            {
                double y = k * x + b;
                double fraction = (y - Math.Floor(y)) * 100;
                bmp.SetPixel(x, (int)Math.Floor(y) + 1, Color.FromArgb((int)(fraction * 2.56), color.R, color.G, color.B));
                bmp.SetPixel(x, (int)Math.Floor(y), Color.FromArgb(255 - (int)(fraction * 2.56), color.R, color.G, color.B));
            }
        }

        //--------------------------------------------------------------------------------
        // Universal
        //--------------------------------------------------------------------------------

        void draw_ellipse_angles(Bitmap bmp, Color color, line_drawer f, int x, int y, int Rx, int Ry, int angle1, int angle2, int dots)
        {
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();

            if (angle1 > angle2)
            {
                int buf = angle1;
                angle1 = angle2;
                angle2 = buf;
            }

            double _angle1 = angle1 * Math.PI / (double)180;
            double _angle2 = angle2 * Math.PI / (double)180;

            for (double i = _angle1; i <= _angle2; i += (_angle2 - _angle1) / (double)dots)
            {
                xs.Add(Math.Cos(i) * Rx + x);
                ys.Add(-Math.Sin(i) * Ry + y);
            }

            //draw_line_DDA(bmp, color, (int)xs[0], (int)ys[0], (int)xs[dots - 1], (int)ys[dots - 1]);
            for (int i = 1; i < dots; i++)
                f(bmp, color, (int)xs[i], (int)ys[i], (int)xs[i - 1], (int)ys[i - 1]);
        }

        void draw_initials(Bitmap bmp, Color color, line_drawer f)
        {
            // M
            f(bmp, color, 50, 50, 50, 550);
            f(bmp, color, 50, 50, 300, 300);
            f(bmp, color, 300, 300, 550, 50);
            f(bmp, color, 550, 50, 550, 550);

            // B
            f(bmp, color, 650, 50, 650, 550);
            draw_half_ellipse_improved(bmp, color, 650, 175, 500, 125);
            draw_half_ellipse_improved(bmp, color, 650, 425, 500, 125);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (color_selected && (_line || _circle || _ellipse || _initials))
            {
                line_drawer f;
                if (_dda) f = draw_line_DDA;
                else
                    if (_bresenham) f = draw_line_Bresenham;
                    else
                        f = draw_line_Wu;

                if (_line)
                    if (_dda || _bresenham || _wu)
                        f(bmp, _color, (int)x1.Value, (int)y1.Value, (int)x2.Value, (int)y2.Value);
                    else
                        MessageBox.Show("Select line type", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (_circle)
                    draw_circle_improved(bmp, _color, (int)x1.Value, (int)y1.Value, (int)x2.Value);

                if (_ellipse)
                    draw_ellipse_improved(bmp, _color, (int)x1.Value, (int)y1.Value, (int)x2.Value, (int)y2.Value);

                if (_initials)
                    if (_dda || _bresenham || _wu)
                        draw_initials(bmp, _color, f);
                    else
                        MessageBox.Show("Select line type", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show("Select figure", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            //draw_half_ellipse_improved(bmp, _color, 600, 300, 250, 100);

            pbox.Image = bmp;
        }

        private void DDA_CheckedChanged(object sender, EventArgs e)
        {
            _dda = true;
            _bresenham = false;
            _wu = false;
        }

        private void Bresenham_CheckedChanged(object sender, EventArgs e)
        {
            _dda = false;
            _bresenham = true;
            _wu = false;
        }

        private void Wu_CheckedChanged(object sender, EventArgs e)
        {
            _dda = false;
            _bresenham = false;
            _wu = true;
        }

        private void line_CheckedChanged(object sender, EventArgs e)
        {
            _line = true;
            _circle = false;
            _ellipse = false;
            _initials = false;

            _x1.Enabled = true;
            _y1.Enabled = true;
            _x2.Enabled = true;
            _y2.Enabled = true;
            x1.Enabled = true;
            y1.Enabled = true;
            x2.Enabled = true;
            y2.Enabled = true;
            dda.Enabled = true;
            bresenham.Enabled = true;
            wu.Enabled = true;

            _x1.Text = "x1";
            x1.Minimum = 1;
            x1.Maximum = 1198;
            _y1.Text = "y1";
            y1.Minimum = 1;
            y1.Maximum = 598;
            _x2.Text = "x2";
            x2.Minimum = 1;
            x2.Maximum = 1198;
            _y2.Text = "y2";
            y2.Minimum = 1;
            y2.Maximum = 598;
        }

        private void circle_CheckedChanged(object sender, EventArgs e)
        {
            _line = false;
            _circle = true;
            _ellipse = false;
            _initials = false;

            _x1.Enabled = true;
            _y1.Enabled = true;
            _x2.Enabled = true;
            _y2.Enabled = false;
            x1.Enabled = true;
            y1.Enabled = true;
            x2.Enabled = true;
            y2.Enabled = false;
            dda.Enabled = false;
            bresenham.Enabled = false;
            wu.Enabled = false;

            _x1.Text = "x";
            _y1.Text = "y";
            _x2.Text = "R";
            x2.Minimum = 0;
            x2.Maximum = 299;
        }

        private void ellipse_CheckedChanged(object sender, EventArgs e)
        {
            _line = false;
            _circle = false;
            _ellipse = true;
            _initials = false;

            _x1.Enabled = true;
            _y1.Enabled = true;
            _x2.Enabled = true;
            _y2.Enabled = true;
            x1.Enabled = true;
            y1.Enabled = true;
            x2.Enabled = true;
            y2.Enabled = true;
            dda.Enabled = false;
            bresenham.Enabled = false;
            wu.Enabled = false;

            _x1.Text = "x";
            _y1.Text = "y";
            _x2.Text = "R1";
            x2.Minimum = 1;
            x2.Maximum = 599;
            _y2.Text = "R2";
            y2.Minimum = 1;
            y2.Maximum = 299;
        }

        private void initials_CheckedChanged(object sender, EventArgs e)
        {
            _line = false;
            _circle = false;
            _ellipse = false;
            _initials = true;

            _x1.Enabled = false;
            _y1.Enabled = false;
            _x2.Enabled = false;
            _y2.Enabled = false;
            x1.Enabled = false;
            y1.Enabled = false;
            x2.Enabled = false;
            y2.Enabled = false;
            dda.Enabled = true;
            bresenham.Enabled = true;
            wu.Enabled = true;
        }

        private void x2_ValueChanged(object sender, EventArgs e)
        {
            if (_circle)
            {
                x1.Minimum = x2.Value;
                x1.Maximum = 1199 - x2.Value;
                y1.Minimum = x2.Value;
                y1.Maximum = 599 - x2.Value;
            }

            if (_ellipse)
            {
                x1.Minimum = x2.Value;
                x1.Maximum = 1199 - x2.Value;
            }
        }

        private void y2_ValueChanged(object sender, EventArgs e)
        {
            if (_ellipse)
            {
                y1.Minimum = y2.Value;
                y1.Maximum = 599 - y2.Value;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bSelectColor_Click(object sender, EventArgs e)
        {
            if (color_dialog.ShowDialog() == DialogResult.OK)
            {
                _color = color_dialog.Color;
                color_selected = true;
                cbox.BackColor = _color;
            }

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(x_size, y_size);
            pbox.Image = bmp;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (save_file.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(save_file.FileName);
            }
        }

        private void pbox_Click(object sender, EventArgs e)
        {

        }
    }
}
