using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecondLabwork
{
    public partial class MainForm : Form
    {
        private const float THICKNESS = 1.0f;
        private const float P_SQUARES = 0.08f;
        private const float P_TRIANGLES = 0.5f;
        private const int NUMBER_OF_SQUARES = 50;
        private const int DEPTH = 5;
        private readonly Graphics graphics;
        private readonly Pen pen = new Pen(Color.White, THICKNESS);

        public MainForm()
        {
            InitializeComponent();
            graphics = panel.CreateGraphics();
        }

        private void DrawSquares_Click(object sender, EventArgs e)
        {
            graphics.Clear(this.BackColor);

            PointF[] points = { new PointF(THICKNESS, THICKNESS), 
                                new PointF(THICKNESS, panel.Height - THICKNESS), 
                                new PointF(panel.Width - THICKNESS, panel.Height - THICKNESS), 
                                new PointF(panel.Width - THICKNESS, THICKNESS), 
                                new PointF(THICKNESS, THICKNESS) };

            for (int i = 0; i < NUMBER_OF_SQUARES; ++i)
            {
                graphics.DrawLines(pen, points);
                points = TranslatePoints(points, P_SQUARES);
            }
        }

        private void DrawTriangles_Click(object sender, EventArgs e)
        {
            graphics.Clear(this.BackColor);

            PointF[] points = { new PointF((panel.Width - THICKNESS) / 2.0f, THICKNESS),
                                new PointF(THICKNESS, panel.Height - THICKNESS),
                                new PointF(panel.Width - THICKNESS, panel.Height - THICKNESS),
                                new PointF((panel.Width - THICKNESS) / 2.0f, THICKNESS) };

            graphics.DrawLines(pen, points);
            DivideTriangle(points, P_TRIANGLES, DEPTH);
        }

        private void Clear_Click(object sender, EventArgs e) => graphics.Clear(this.BackColor);

        private PointF[] TranslatePoints(PointF[] points, float p)
        {
            float x, y;
            PointF[] newPoints = new PointF[points.Length];

            for (int i = 1; i < points.Length; ++i)
            {
                x = GetCoordinate(points[i].X, points[i - 1].X, p);
                y = GetCoordinate(points[i].Y, points[i - 1].Y, p);
                newPoints[i - 1] = new PointF(x, y);
            }

            newPoints[newPoints.Length - 1] = newPoints[0];
            return newPoints;

            float GetCoordinate(float num1, float num2, float pParameter) => num1 + (num2 - num1) * pParameter;
        }

        private void DivideTriangle(PointF[] points, float p, int depth)
        {
            if (depth < 1) 
                return;

            PointF[] newPoints = TranslatePoints(points, p);
            PointF[] top = new PointF[] { points[0], newPoints[0], newPoints[2], points[0] };
            PointF[] left = new PointF[] { newPoints[0], points[1], newPoints[1], newPoints[0] };
            PointF[] right = new PointF[] { newPoints[2], newPoints[1], points[2], newPoints[2] };

            graphics.DrawLines(pen, top);
            graphics.DrawLines(pen, left);
            graphics.DrawLines(pen, right);
            
            DivideTriangle(top, p, depth - 1);          // top
            DivideTriangle(left, p, depth - 1);         // left
            DivideTriangle(right, p, depth - 1);        // right 
        }
    }       
}
