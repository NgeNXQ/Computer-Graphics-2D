using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThirdLabwork
{
    public partial class MainForm : Form
    {
        private readonly Graphics graphics;
        private const float PEN_WIDTH = 1f;
        private const float SIDE_LENGTH = 300.0f;
        private const float BOTTOM_OFFSET = 75.0f;
        private readonly Pen whitePen;

        public MainForm()
        {
            InitializeComponent();
            graphics = panel.CreateGraphics();
            whitePen = new Pen(Color.White, PEN_WIDTH);
        }

        private void DrawButton_Click(object sender, System.EventArgs e)
        {
            float height = (float)Math.Sqrt(3.0f) / 2.0f;
            float halfSide = SIDE_LENGTH / 2.0f;
            PointF panelCenter = new PointF(panel.Width / 2.0f, panel.Height / 2.0f);

            PointF point1 = new PointF(panelCenter.X - halfSide, panelCenter.Y + halfSide * height - BOTTOM_OFFSET);
            PointF point2 = new PointF(panelCenter.X + halfSide, panelCenter.Y + halfSide * height - BOTTOM_OFFSET);
            PointF point3 = new PointF(panelCenter.X, panelCenter.Y - halfSide * height - BOTTOM_OFFSET);

            DrawKochSnowflake(graphics, whitePen, point1, point2, point3, (int)NumberInputBar.Value);
        }

        private void ClearButton_Click(object sender, System.EventArgs e) => graphics.Clear(this.BackColor);

        private void DrawKochSnowflake(Graphics graphics, Pen pen, PointF point1, PointF point2, PointF point3, int depth)
        {
            graphics.Clear(this.BackColor);

            if (depth == 0)
            {
                graphics.DrawLine(pen, point1, point2);
                graphics.DrawLine(pen, point2, point3);
                graphics.DrawLine(pen, point3, point1);
            }

            float angle = (float)(Math.PI / 3.0f);
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            float[,] rotationMatrix = new float[2, 2] { { cos, -sin }, { sin, cos } };

            DrawOuterTriangle(point1, point2, depth);
            DrawOuterTriangle(point2, point3, depth);
            DrawOuterTriangle(point3, point1, depth);

            void DrawOuterTriangle(PointF p1, PointF p2, int currentDepth)
            {
                if (currentDepth < 1)
                {
                    graphics.DrawLine(pen, p1, p2);
                    return;
                }

                float dx = (p2.X - p1.X) / 3.0f;
                float dy = (p2.Y - p1.Y) / 3.0f;

                PointF t1 = new PointF((p2.X + 2.0f * p1.X) / 3.0f, (p2.Y + 2.0f * p1.Y) / 3.0f);
                PointF t2 = new PointF((2.0f * p2.X + p1.X) / 3.0f, (2.0f * p2.Y + p1.Y) / 3.0f);
                PointF tV = new PointF(t1.X + rotationMatrix[0, 0] * dx + rotationMatrix[0, 1] * dy,
                                       t1.Y + rotationMatrix[1, 0] * dx + rotationMatrix[1, 1] * dy);

                DrawOuterTriangle(p1, t1, currentDepth - 1);
                DrawOuterTriangle(t1, tV, currentDepth - 1);
                DrawOuterTriangle(tV, t2, currentDepth - 1);
                DrawOuterTriangle(t2, p2, currentDepth - 1);
            }
        }
    }
}
