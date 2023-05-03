namespace SixthLabwork
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewport = new SharpGL.OpenGLControl();
            ((System.ComponentModel.ISupportInitialize)(this.viewport)).BeginInit();
            this.SuspendLayout();
            // 
            // viewport
            // 
            this.viewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewport.DrawFPS = true;
            this.viewport.FrameRate = 60;
            this.viewport.Location = new System.Drawing.Point(0, 0);
            this.viewport.Name = "viewport";
            this.viewport.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.viewport.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.viewport.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.viewport.Size = new System.Drawing.Size(884, 861);
            this.viewport.TabIndex = 0;
            this.viewport.OpenGLDraw += new SharpGL.RenderEventHandler(this.viewport_OpenGLDraw);
            this.viewport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewport_KeyDown);
            this.viewport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewport_MouseDown);
            this.viewport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewport_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.viewport);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.MinimumSize = new System.Drawing.Size(900, 900);
            this.Name = "MainForm";
            this.Text = "Лабораторна робота № 6";
            ((System.ComponentModel.ISupportInitialize)(this.viewport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl viewport;
    }
}

