using System;
using SharpGL;
using System.Drawing;
using System.Windows.Forms;

namespace SixthLabwork
{
    public partial class MainForm : Form
    {
        private const float AXIS_LENGTH = 5.0f;
        private const float AXIS_THICKNESS = 3.0f;
        private const float AXIS_ARROW_RADIUS = 0.1f;
        private const float AXIS_ARROW_HEIGHT = 0.3f;

        private const float SENSITIVITY = 0.3f;
        private const float CAMERA_SPEED = 0.5f;
        private const float PYRAMID_HEIGHT = 3.0f;
        private const float PYRAMID_SIDE_LENGTH = 1.5f;
        private const float PYRAMID_ORIGIN_OFFSET = 3.0f;

        private readonly OpenGL gl;

        private float cameraX = 0.0f;
        private float cameraY = 0.0f;
        private float cameraZ = 30.0f;
        private float cameraAngleX = 20.0f;
        private float cameraAngleY = -45.0f;
        private PointF startPoint;

        public MainForm()
        {
            InitializeComponent();
            gl = this.viewport.OpenGL;
        }

        private void viewport_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(-cameraX, -cameraY, -cameraZ);
            gl.Rotate(cameraAngleX, 1.0f, 0.0f, 0.0f);
            gl.Rotate(cameraAngleY, 0.0f, 1.0f, 0.0f);

            DrawOrigin(AXIS_THICKNESS, AXIS_LENGTH, AXIS_ARROW_RADIUS, AXIS_ARROW_HEIGHT, 10);
            DrawTetrahedron(PYRAMID_ORIGIN_OFFSET, PYRAMID_HEIGHT, PYRAMID_SIDE_LENGTH);

            gl.Flush();
        }

        private void DrawOrigin(float axisThickness, float axisLength, float arrowRadius, float arrowHeight, int arrowDetalization = 360)
        {
            float x, y;
            float x1, y1, z1, x2, y2, z2;
            float sliceAngle = 2.0f * (float)Math.PI / arrowDetalization;

            #region Axes lines

            gl.LineWidth(axisThickness);

            gl.Begin(OpenGL.GL_LINES);

            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.Vertex(axisLength, 0.0f, 0.0f);

            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, axisLength, 0.0f);

            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 0.0f, axisLength);

            gl.End();

            #endregion

            #region X axis arrow

            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.Color(1.0f, 0.0f, 0.0f);

            for (int i = 0; i < arrowDetalization; ++i)
            {
                x = arrowRadius * (float)Math.Cos(i * Math.PI / 180.0f);
                y = arrowRadius * (float)Math.Sin(i * Math.PI / 180.0f);
                gl.Vertex(axisLength, y, x);
            }

            gl.End();

            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.Color(1.0f, 0.0f, 0.0f);

            for (int i = 0; i < arrowDetalization; i++)
            {
                y1 = arrowRadius * (float)Math.Cos(i * sliceAngle);
                z1 = arrowRadius * (float)Math.Sin(i * sliceAngle);

                y2 = arrowRadius * (float)Math.Cos((i + 1) * sliceAngle);
                z2 = arrowRadius * (float)Math.Sin((i + 1) * sliceAngle);

                gl.Vertex(arrowHeight + axisLength, 0.0f, 0.0f);
                gl.Vertex(axisLength, y1, z1);
                gl.Vertex(axisLength, y2 , z2);
            }

            gl.End();

            #endregion

            #region Y axis arrow

            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.Color(0.0f, 1.0f, 0.0f);

            for (int i = 0; i < arrowDetalization; ++i)
            {
                x = arrowRadius * (float)Math.Cos(i * Math.PI / 180.0f);
                y = arrowRadius * (float)Math.Sin(i * Math.PI / 180.0f);
                gl.Vertex(x, axisLength, y);
            }
            
            gl.End();

            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.Color(0.0f, 1.0f, 0.0f);

            for (int i = 0; i < arrowDetalization; i++)
            {
                x1 = arrowRadius * (float)Math.Cos(i * sliceAngle);
                z1 = arrowRadius * (float)Math.Sin(i * sliceAngle);

                x2 = arrowRadius * (float)Math.Cos((i + 1) * sliceAngle);
                z2 = arrowRadius * (float)Math.Sin((i + 1) * sliceAngle);

                gl.Vertex(0.0f, arrowHeight + axisLength, 0.0f);
                gl.Vertex(x1, axisLength, z1);
                gl.Vertex(x2, axisLength, z2);
            }

            gl.End();

            #endregion

            #region Z axis arrow

            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.Color(0.0f, 0.0f, 1.0f);

            for (int i = 0; i < arrowDetalization; ++i)
            {
                x = arrowRadius * (float)Math.Cos(i * Math.PI / 180.0f);
                y = arrowRadius * (float)Math.Sin(i * Math.PI / 180.0f);
                gl.Vertex(x, y, axisLength);
            }

            gl.End();


            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.Color(0.0f, 0.0f, 1.0f);

            for (int i = 0; i < arrowDetalization; i++)
            {
                x1 = arrowRadius * (float)Math.Cos(i * sliceAngle);
                y1 = arrowRadius * (float)Math.Sin(i * sliceAngle);

                x2 = arrowRadius * (float)Math.Cos((i + 1) * sliceAngle);
                y2 = arrowRadius * (float)Math.Sin((i + 1) * sliceAngle);

                gl.Vertex(0.0f, 0.0f, arrowHeight + axisLength);
                gl.Vertex(x1, y1, axisLength);
                gl.Vertex(x2, y2, axisLength);
            }

            gl.End();

            #endregion
        }

        private void DrawTetrahedron(float location, float height, float sideLength)
        {
            gl.Begin(OpenGL.GL_TRIANGLES);

            gl.Color(1.0f, 1.0f, 0.600f);

            gl.Vertex(location, height, location);
            gl.Vertex(location - sideLength, 0.0f, location + sideLength);
            gl.Vertex(location + sideLength, 0.0f, location + sideLength);

            gl.Color(0.650f, 0.933f, 0.565f);

            gl.Vertex(location, height, location);
            gl.Vertex(location + sideLength, 0.0f, location + sideLength);
            gl.Vertex(location + sideLength, 0.0f, location - sideLength);

            gl.Color(0.678f, 0.650f, 1.0f);

            gl.Vertex(location, height, location);
            gl.Vertex(location + sideLength, 0.0f, location - sideLength);
            gl.Vertex(location - sideLength, 0.0f, location - sideLength);

            gl.Color(1.0f, 0.714f, 0.757f);

            gl.Vertex(location, height, location);
            gl.Vertex(location - sideLength, 0.0f, location - sideLength);
            gl.Vertex(location - sideLength, 0.0f, location + sideLength);

            gl.End();

            gl.Begin(OpenGL.GL_QUADS);

            gl.Color(1.0f, 0.714f, 0.950f);

            gl.Vertex(location + sideLength, 0.0f, location + sideLength);
            gl.Vertex(location - sideLength, 0.0f, location + sideLength);
            gl.Vertex(location - sideLength, 0.0f, location - sideLength);
            gl.Vertex(location + sideLength, 0.0f, location - sideLength);

            gl.End();
        }

        private void viewport_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    cameraX -= CAMERA_SPEED;
                    break;
                case Keys.D:
                    cameraX += CAMERA_SPEED;
                    break;
                case Keys.W:
                    cameraZ -= CAMERA_SPEED;
                    break;
                case Keys.S:
                    cameraZ += CAMERA_SPEED;
                    break;
            }
        }

        private void viewport_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                startPoint = e.Location;
        }

        private void viewport_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                float deltaX = e.X - startPoint.X;
                float deltaY = e.Y - startPoint.Y;

                cameraAngleY += deltaX * SENSITIVITY;
                cameraAngleX += deltaY * SENSITIVITY;

                startPoint = e.Location;
            }
        }
    }
}
