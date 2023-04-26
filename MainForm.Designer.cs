namespace FifthLabwork
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
            this.translationPanel = new System.Windows.Forms.Panel();
            this.translationYLabel = new System.Windows.Forms.Label();
            this.translationXLabel = new System.Windows.Forms.Label();
            this.translationInputY = new System.Windows.Forms.NumericUpDown();
            this.translationInputX = new System.Windows.Forms.NumericUpDown();
            this.translationLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rotationAngleLabel = new System.Windows.Forms.Label();
            this.rotationInputAngle = new System.Windows.Forms.NumericUpDown();
            this.rotationLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scalingYLabel = new System.Windows.Forms.Label();
            this.scalingXLabel = new System.Windows.Forms.Label();
            this.scalingInputY = new System.Windows.Forms.NumericUpDown();
            this.scalingInputX = new System.Windows.Forms.NumericUpDown();
            this.scalingLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reflectingInputAxis = new System.Windows.Forms.ComboBox();
            this.reflectingAxisLabel = new System.Windows.Forms.Label();
            this.reflectingLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.typeInput = new System.Windows.Forms.ComboBox();
            this.translationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translationInputY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationInputX)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationInputAngle)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scalingInputY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalingInputX)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // translationPanel
            // 
            this.translationPanel.Controls.Add(this.translationYLabel);
            this.translationPanel.Controls.Add(this.translationXLabel);
            this.translationPanel.Controls.Add(this.translationInputY);
            this.translationPanel.Controls.Add(this.translationInputX);
            this.translationPanel.Controls.Add(this.translationLabel);
            this.translationPanel.Location = new System.Drawing.Point(12, 618);
            this.translationPanel.Name = "translationPanel";
            this.translationPanel.Size = new System.Drawing.Size(186, 139);
            this.translationPanel.TabIndex = 6;
            // 
            // translationYLabel
            // 
            this.translationYLabel.AutoSize = true;
            this.translationYLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationYLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.translationYLabel.Location = new System.Drawing.Point(9, 93);
            this.translationYLabel.Name = "translationYLabel";
            this.translationYLabel.Size = new System.Drawing.Size(30, 30);
            this.translationYLabel.TabIndex = 14;
            this.translationYLabel.Text = "Y:";
            // 
            // translationXLabel
            // 
            this.translationXLabel.AutoSize = true;
            this.translationXLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationXLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.translationXLabel.Location = new System.Drawing.Point(9, 47);
            this.translationXLabel.Name = "translationXLabel";
            this.translationXLabel.Size = new System.Drawing.Size(30, 30);
            this.translationXLabel.TabIndex = 13;
            this.translationXLabel.Text = "X:";
            // 
            // translationInputY
            // 
            this.translationInputY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationInputY.Location = new System.Drawing.Point(45, 93);
            this.translationInputY.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.translationInputY.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            -2147483648});
            this.translationInputY.Name = "translationInputY";
            this.translationInputY.Size = new System.Drawing.Size(130, 29);
            this.translationInputY.TabIndex = 12;
            this.translationInputY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.translationInputY_KeyDown);
            // 
            // translationInputX
            // 
            this.translationInputX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationInputX.Location = new System.Drawing.Point(45, 52);
            this.translationInputX.Maximum = new decimal(new int[] {
            907,
            0,
            0,
            0});
            this.translationInputX.Minimum = new decimal(new int[] {
            907,
            0,
            0,
            -2147483648});
            this.translationInputX.Name = "translationInputX";
            this.translationInputX.Size = new System.Drawing.Size(130, 29);
            this.translationInputX.TabIndex = 11;
            this.translationInputX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.translationInputX_KeyDown);
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.translationLabel.Location = new System.Drawing.Point(3, 6);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(129, 32);
            this.translationLabel.TabIndex = 10;
            this.translationLabel.Text = "Translation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rotationAngleLabel);
            this.panel1.Controls.Add(this.rotationInputAngle);
            this.panel1.Controls.Add(this.rotationLabel);
            this.panel1.Location = new System.Drawing.Point(204, 618);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 139);
            this.panel1.TabIndex = 15;
            // 
            // rotationAngleLabel
            // 
            this.rotationAngleLabel.AutoSize = true;
            this.rotationAngleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationAngleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rotationAngleLabel.Location = new System.Drawing.Point(9, 47);
            this.rotationAngleLabel.Name = "rotationAngleLabel";
            this.rotationAngleLabel.Size = new System.Drawing.Size(72, 30);
            this.rotationAngleLabel.TabIndex = 13;
            this.rotationAngleLabel.Text = "Angle:";
            // 
            // rotationInputAngle
            // 
            this.rotationInputAngle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationInputAngle.Location = new System.Drawing.Point(87, 52);
            this.rotationInputAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotationInputAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rotationInputAngle.Name = "rotationInputAngle";
            this.rotationInputAngle.Size = new System.Drawing.Size(125, 29);
            this.rotationInputAngle.TabIndex = 11;
            this.rotationInputAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rotationInputAngle_KeyDown);
            // 
            // rotationLabel
            // 
            this.rotationLabel.AutoSize = true;
            this.rotationLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rotationLabel.Location = new System.Drawing.Point(3, 6);
            this.rotationLabel.Name = "rotationLabel";
            this.rotationLabel.Size = new System.Drawing.Size(209, 32);
            this.rotationLabel.TabIndex = 10;
            this.rotationLabel.Text = "Rotation (degrees)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.scalingYLabel);
            this.panel2.Controls.Add(this.scalingXLabel);
            this.panel2.Controls.Add(this.scalingInputY);
            this.panel2.Controls.Add(this.scalingInputX);
            this.panel2.Controls.Add(this.scalingLabel);
            this.panel2.Location = new System.Drawing.Point(428, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 139);
            this.panel2.TabIndex = 15;
            // 
            // scalingYLabel
            // 
            this.scalingYLabel.AutoSize = true;
            this.scalingYLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scalingYLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scalingYLabel.Location = new System.Drawing.Point(9, 93);
            this.scalingYLabel.Name = "scalingYLabel";
            this.scalingYLabel.Size = new System.Drawing.Size(30, 30);
            this.scalingYLabel.TabIndex = 14;
            this.scalingYLabel.Text = "Y:";
            // 
            // scalingXLabel
            // 
            this.scalingXLabel.AutoSize = true;
            this.scalingXLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scalingXLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scalingXLabel.Location = new System.Drawing.Point(9, 47);
            this.scalingXLabel.Name = "scalingXLabel";
            this.scalingXLabel.Size = new System.Drawing.Size(30, 30);
            this.scalingXLabel.TabIndex = 13;
            this.scalingXLabel.Text = "X:";
            // 
            // scalingInputY
            // 
            this.scalingInputY.DecimalPlaces = 1;
            this.scalingInputY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scalingInputY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.scalingInputY.Location = new System.Drawing.Point(45, 93);
            this.scalingInputY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scalingInputY.Name = "scalingInputY";
            this.scalingInputY.Size = new System.Drawing.Size(130, 29);
            this.scalingInputY.TabIndex = 12;
            this.scalingInputY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scalingInputY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scalingInputY_KeyDown);
            // 
            // scalingInputX
            // 
            this.scalingInputX.DecimalPlaces = 1;
            this.scalingInputX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scalingInputX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.scalingInputX.Location = new System.Drawing.Point(45, 52);
            this.scalingInputX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scalingInputX.Name = "scalingInputX";
            this.scalingInputX.Size = new System.Drawing.Size(130, 29);
            this.scalingInputX.TabIndex = 11;
            this.scalingInputX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scalingInputX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scalingInputX_KeyDown);
            // 
            // scalingLabel
            // 
            this.scalingLabel.AutoSize = true;
            this.scalingLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scalingLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scalingLabel.Location = new System.Drawing.Point(3, 6);
            this.scalingLabel.Name = "scalingLabel";
            this.scalingLabel.Size = new System.Drawing.Size(90, 32);
            this.scalingLabel.TabIndex = 10;
            this.scalingLabel.Text = "Scaling";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reflectingInputAxis);
            this.panel3.Controls.Add(this.reflectingAxisLabel);
            this.panel3.Controls.Add(this.reflectingLabel);
            this.panel3.Location = new System.Drawing.Point(620, 618);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 139);
            this.panel3.TabIndex = 16;
            // 
            // reflectingInputAxis
            // 
            this.reflectingInputAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reflectingInputAxis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectingInputAxis.FormattingEnabled = true;
            this.reflectingInputAxis.Items.AddRange(new object[] {
            "X-axis",
            "Y-axis"});
            this.reflectingInputAxis.Location = new System.Drawing.Point(71, 52);
            this.reflectingInputAxis.Name = "reflectingInputAxis";
            this.reflectingInputAxis.Size = new System.Drawing.Size(121, 28);
            this.reflectingInputAxis.TabIndex = 17;
            this.reflectingInputAxis.SelectedIndexChanged += new System.EventHandler(this.reflectingInputAxis_SelectedIndexChanged);
            // 
            // reflectingAxisLabel
            // 
            this.reflectingAxisLabel.AutoSize = true;
            this.reflectingAxisLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectingAxisLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reflectingAxisLabel.Location = new System.Drawing.Point(9, 47);
            this.reflectingAxisLabel.Name = "reflectingAxisLabel";
            this.reflectingAxisLabel.Size = new System.Drawing.Size(56, 30);
            this.reflectingAxisLabel.TabIndex = 13;
            this.reflectingAxisLabel.Text = "Axis:";
            // 
            // reflectingLabel
            // 
            this.reflectingLabel.AutoSize = true;
            this.reflectingLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectingLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reflectingLabel.Location = new System.Drawing.Point(3, 6);
            this.reflectingLabel.Name = "reflectingLabel";
            this.reflectingLabel.Size = new System.Drawing.Size(120, 32);
            this.reflectingLabel.TabIndex = 10;
            this.reflectingLabel.Text = "Reflecting";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetButton.Location = new System.Drawing.Point(839, 666);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(80, 75);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // typeInput
            // 
            this.typeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeInput.FormattingEnabled = true;
            this.typeInput.Items.AddRange(new object[] {
            "Circle",
            "Text"});
            this.typeInput.Location = new System.Drawing.Point(839, 624);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(80, 28);
            this.typeInput.TabIndex = 18;
            this.typeInput.SelectedIndexChanged += new System.EventHandler(this.typeInput_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(934, 761);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.translationPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 800);
            this.MinimumSize = new System.Drawing.Size(950, 800);
            this.Name = "MainForm";
            this.Text = "Лабораторна робота № 5";
            this.translationPanel.ResumeLayout(false);
            this.translationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translationInputY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationInputX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationInputAngle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scalingInputY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalingInputX)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel translationPanel;
        private System.Windows.Forms.Label translationYLabel;
        private System.Windows.Forms.Label translationXLabel;
        private System.Windows.Forms.NumericUpDown translationInputY;
        private System.Windows.Forms.NumericUpDown translationInputX;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label rotationAngleLabel;
        private System.Windows.Forms.NumericUpDown rotationInputAngle;
        private System.Windows.Forms.Label rotationLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label scalingYLabel;
        private System.Windows.Forms.Label scalingXLabel;
        private System.Windows.Forms.NumericUpDown scalingInputY;
        private System.Windows.Forms.NumericUpDown scalingInputX;
        private System.Windows.Forms.Label scalingLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label reflectingAxisLabel;
        private System.Windows.Forms.Label reflectingLabel;
        private System.Windows.Forms.ComboBox reflectingInputAxis;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox typeInput;
    }
}

