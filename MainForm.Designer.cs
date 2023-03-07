namespace SecondLabwork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.DrawTriangles = new System.Windows.Forms.Button();
            this.DrawSquares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 82);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(760, 667);
            this.panel.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Image = ((System.Drawing.Image)(resources.GetObject("Clear.Image")));
            this.Clear.Location = new System.Drawing.Point(429, 12);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(64, 64);
            this.Clear.TabIndex = 1;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // DrawTriangles
            // 
            this.DrawTriangles.FlatAppearance.BorderSize = 0;
            this.DrawTriangles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawTriangles.Image = ((System.Drawing.Image)(resources.GetObject("DrawTriangles.Image")));
            this.DrawTriangles.Location = new System.Drawing.Point(359, 12);
            this.DrawTriangles.Name = "DrawTriangles";
            this.DrawTriangles.Size = new System.Drawing.Size(64, 64);
            this.DrawTriangles.TabIndex = 2;
            this.DrawTriangles.UseVisualStyleBackColor = true;
            this.DrawTriangles.Click += new System.EventHandler(this.DrawTriangles_Click);
            // 
            // DrawSquares
            // 
            this.DrawSquares.FlatAppearance.BorderSize = 0;
            this.DrawSquares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawSquares.Image = ((System.Drawing.Image)(resources.GetObject("DrawSquares.Image")));
            this.DrawSquares.Location = new System.Drawing.Point(289, 12);
            this.DrawSquares.Name = "DrawSquares";
            this.DrawSquares.Size = new System.Drawing.Size(64, 64);
            this.DrawSquares.TabIndex = 3;
            this.DrawSquares.UseVisualStyleBackColor = true;
            this.DrawSquares.Click += new System.EventHandler(this.DrawSquares_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.DrawSquares);
            this.Controls.Add(this.DrawTriangles);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "MainForm";
            this.Text = "Лабораторна робота № 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button DrawTriangles;
        private System.Windows.Forms.Button DrawSquares;
    }
}

