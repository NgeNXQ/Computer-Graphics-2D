using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FifthLabwork
{
    public partial class MainForm : Form
    {
        private const float RADIUS = 75.0f;
        private const int Y_AXIS = 0;
        private const int X_AXIS = 1;
        private const int TEXT_INDEX = 1;
        private const int CIRCLE_INDEX = 0;
        private const string TEXT = "Denys";

        private readonly Graphics graphics;
        private readonly Font font;
        private readonly PointF origin;
        private readonly SolidBrush greenSolidBrush;
        private readonly SolidBrush redSolidBrush;

        public MainForm()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            font = new Font("Arial", 56);
            origin = new PointF(0.0f, 0.0f);
            redSolidBrush = new SolidBrush(Color.Red);
            greenSolidBrush = new SolidBrush(Color.Green);
        }

        private void translationInputX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                graphics.Clear(this.BackColor);

                switch (typeInput.SelectedIndex)
                {
                    case CIRCLE_INDEX:
                        DrawCircle(origin, RADIUS, Brushes.Red);
                        graphics.TranslateTransform((int)translationInputX.Value, 0.0f);
                        DrawCircle(origin, RADIUS, Brushes.Green);
                        break;
                    case TEXT_INDEX:
                        graphics.DrawString(TEXT, font, redSolidBrush, origin);
                        graphics.TranslateTransform((int)translationInputX.Value, 0.0f);
                        graphics.DrawString(TEXT, font, greenSolidBrush, origin);
                        break;
                }
            }
        }

        private void translationInputY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                graphics.Clear(this.BackColor);

                switch (typeInput.SelectedIndex)
                {
                    case CIRCLE_INDEX:
                        DrawCircle(origin, RADIUS, Brushes.Red);
                        graphics.TranslateTransform(0.0f, (int)translationInputY.Value);
                        DrawCircle(origin, RADIUS, Brushes.Green);
                        break;
                    case TEXT_INDEX:
                        graphics.DrawString(TEXT, font, redSolidBrush, origin);
                        graphics.TranslateTransform(0.0f, (int)translationInputY.Value);
                        graphics.DrawString(TEXT, font, greenSolidBrush, origin);
                        break;
                }
            }
        }

        private void rotationInputAngle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                graphics.Clear(this.BackColor);

                switch (typeInput.SelectedIndex)
                {
                    case CIRCLE_INDEX:
                        DrawCircle(origin, RADIUS, Brushes.Red);
                        graphics.RotateTransform((int)rotationInputAngle.Value);
                        DrawCircle(origin, RADIUS, Brushes.Green);
                        break;
                    case TEXT_INDEX:
                        graphics.DrawString(TEXT, font, redSolidBrush, origin);
                        graphics.RotateTransform((int)rotationInputAngle.Value);
                        graphics.DrawString(TEXT, font, greenSolidBrush, origin);
                        break;
                }
            }
        }

        private void scalingInputX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                float temp = (float)scalingInputX.Value;

                if (temp != 0.0f)
                {
                    graphics.Clear(this.BackColor);

                    switch (typeInput.SelectedIndex)
                    {
                        case CIRCLE_INDEX:
                            DrawCircle(origin, RADIUS, Brushes.Red);
                            graphics.ScaleTransform(temp, 1.0f);
                            DrawCircle(origin, RADIUS, Brushes.Green);
                            break;
                        case TEXT_INDEX:
                            graphics.DrawString(TEXT, font, redSolidBrush, origin);
                            graphics.ScaleTransform(temp, 1.0f);
                            graphics.DrawString(TEXT, font, greenSolidBrush, origin);
                            break;
                    }
                }
            }
        }

        private void scalingInputY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                float temp = (float)scalingInputY.Value;

                if (temp != 0.0f)
                {
                    graphics.Clear(this.BackColor);

                    switch (typeInput.SelectedIndex)
                    {
                        case CIRCLE_INDEX:
                            DrawCircle(origin, RADIUS, Brushes.Red);
                            graphics.ScaleTransform(1.0f, temp);
                            DrawCircle(origin, RADIUS, Brushes.Green);
                            break;
                        case TEXT_INDEX:
                            graphics.DrawString(TEXT, font, redSolidBrush, origin);
                            graphics.ScaleTransform(1.0f, temp);
                            graphics.DrawString(TEXT, font, greenSolidBrush, origin);
                            break;
                    }
                }
            }
        }

        private void reflectingInputAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            graphics.Clear(this.BackColor);

            switch (typeInput.SelectedIndex)
            {
                case CIRCLE_INDEX:
                    {
                        if (reflectingInputAxis.SelectedIndex == X_AXIS)
                        {
                            DrawCircle(origin, RADIUS, Brushes.Red);
                            graphics.ScaleTransform(-1.0f, 1.0f);
                            DrawCircle(origin, RADIUS, Brushes.Green);
                        }
                        else if (reflectingInputAxis.SelectedIndex == Y_AXIS)
                        {
                            DrawCircle(origin, RADIUS, Brushes.Red);
                            graphics.ScaleTransform(1.0f, -1.0f);
                            DrawCircle(origin, RADIUS, Brushes.Green);
                        }
                    }
                    break;
                case TEXT_INDEX:
                    {
                        if (reflectingInputAxis.SelectedIndex == X_AXIS)
                        {
                            graphics.DrawString(TEXT, font, redSolidBrush, origin);
                            graphics.ScaleTransform(-1.0f, 1.0f);
                            graphics.DrawString(TEXT, font, greenSolidBrush, origin);
                        }
                        else if (reflectingInputAxis.SelectedIndex == Y_AXIS)
                        {
                            graphics.DrawString(TEXT, font, redSolidBrush, origin);
                            graphics.ScaleTransform(1.0f, -1.0f);
                            graphics.DrawString(TEXT, font, greenSolidBrush, origin);
                        }
                    }
                    break;
            }
        }

        private void resetButton_Click(object sender, EventArgs e) => ResetTransform();

        private void typeInput_SelectedIndexChanged(object sender, EventArgs e) => ResetTransform();

        private void DrawCircle(PointF pivot, float radius, Brush brush) => graphics.FillEllipse(brush, pivot.X, pivot.Y, radius, radius);

        private void ResetTransform()
        {
            graphics.ResetTransform();
            graphics.Clear(this.BackColor);

            switch (typeInput.SelectedIndex)
            {
                case CIRCLE_INDEX:
                    DrawCircle(origin, RADIUS, Brushes.Green);
                    break;
                case TEXT_INDEX:
                    graphics.DrawString(TEXT, font, greenSolidBrush, origin);
                    break;
            }
        }  
    }
}
