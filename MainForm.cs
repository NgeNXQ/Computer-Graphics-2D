using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerGraphics
{
    public partial class MainForm : Form
    {
        private const float THICKNESS = 5.0f;
        private readonly Pen PEN = new Pen(Color.GhostWhite, THICKNESS);
        private readonly Brush BRUSH = new SolidBrush(Color.GhostWhite);
        private Graphics graphics;

        public MainForm()
        {
            InitializeComponent();
            graphics = panel.CreateGraphics();
        }

        private void DrawSurname_Click(object sender, EventArgs e)
        {
            //Б
            graphics.DrawLine(PEN, 5, 5, 5, panel.Height);
            graphics.DrawLine(PEN, 5, 5, 100, 5);
            graphics.DrawArc(PEN, -55, 70, 150, 175, 100.0F, -200.0f);

            //a
            graphics.DrawArc(PEN, 130, 90, 75, 150, 45.0f, 270.0f);
            graphics.DrawLine(PEN, 201, 70, 201, panel.Height);

            //б
            graphics.DrawArc(PEN, 209, 100, 100, 145, 100.0f, -200.0f);
            graphics.DrawLine(PEN, 245, 80, 245, panel.Height);
            graphics.DrawCurve(PEN, new Point[] { new Point(244, 80), new Point(260, 70), new Point(290, 70), new Point(300, 60) });

            //i
            graphics.DrawLine(PEN, 360, 90, 360, panel.Height);
            graphics.FillEllipse(BRUSH, 350, 30, 18, 18);

            //ч
            graphics.DrawArc(PEN, 410, 50, 80, 100, -10.0f, 200.0f);
            graphics.DrawLine(PEN, 490, 100, 490, panel.Height);
        }

        private void Close_Click(object sender, EventArgs e) => this.Close();
    }
}
