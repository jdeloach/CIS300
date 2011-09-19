namespace JordanDeLoach.Cis300.DistanceFinder
{
    partial class uxDistancefinder
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
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxThresholdLabel = new System.Windows.Forms.Label();
            this.uxPathColorLabel = new System.Windows.Forms.Label();
            this.uxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxColorDialog = new System.Windows.Forms.ColorDialog();
            this.uxPanel = new System.Windows.Forms.Panel();
            this.uxPictureBox = new System.Windows.Forms.PictureBox();
            this.uxOpenFileButton = new System.Windows.Forms.Button();
            this.uxOpenColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).BeginInit();
            this.uxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uxThresholdLabel
            // 
            this.uxThresholdLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uxThresholdLabel.AutoSize = true;
            this.uxThresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxThresholdLabel.Location = new System.Drawing.Point(127, 415);
            this.uxThresholdLabel.Name = "uxThresholdLabel";
            this.uxThresholdLabel.Size = new System.Drawing.Size(83, 20);
            this.uxThresholdLabel.TabIndex = 0;
            this.uxThresholdLabel.Text = "Threshold:";
            // 
            // uxPathColorLabel
            // 
            this.uxPathColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uxPathColorLabel.AutoSize = true;
            this.uxPathColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxPathColorLabel.Location = new System.Drawing.Point(319, 415);
            this.uxPathColorLabel.Name = "uxPathColorLabel";
            this.uxPathColorLabel.Size = new System.Drawing.Size(87, 20);
            this.uxPathColorLabel.TabIndex = 1;
            this.uxPathColorLabel.Text = "Path Color:";
            // 
            // uxNumericUpDown
            // 
            this.uxNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uxNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uxNumericUpDown.Location = new System.Drawing.Point(216, 411);
            this.uxNumericUpDown.Maximum = new decimal(new int[] {
            765,
            0,
            0,
            0});
            this.uxNumericUpDown.Name = "uxNumericUpDown";
            this.uxNumericUpDown.Size = new System.Drawing.Size(82, 26);
            this.uxNumericUpDown.TabIndex = 2;
            this.uxNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // uxPanel
            // 
            this.uxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPanel.AutoScroll = true;
            this.uxPanel.Controls.Add(this.uxPictureBox);
            this.uxPanel.Location = new System.Drawing.Point(15, 14);
            this.uxPanel.Name = "uxPanel";
            this.uxPanel.Size = new System.Drawing.Size(454, 387);
            this.uxPanel.TabIndex = 3;
            // 
            // uxPictureBox
            // 
            this.uxPictureBox.Location = new System.Drawing.Point(4, 4);
            this.uxPictureBox.Name = "uxPictureBox";
            this.uxPictureBox.Size = new System.Drawing.Size(0, 0);
            this.uxPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.uxPictureBox.TabIndex = 0;
            this.uxPictureBox.TabStop = false;
            this.uxPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uxPictureBox_MouseDown);
            this.uxPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uxPictureBox_MouseUp);
            // 
            // uxOpenFileButton
            // 
            this.uxOpenFileButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uxOpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpenFileButton.Location = new System.Drawing.Point(19, 408);
            this.uxOpenFileButton.Name = "uxOpenFileButton";
            this.uxOpenFileButton.Size = new System.Drawing.Size(86, 35);
            this.uxOpenFileButton.TabIndex = 4;
            this.uxOpenFileButton.Text = "Open File";
            this.uxOpenFileButton.UseVisualStyleBackColor = true;
            this.uxOpenFileButton.Click += new System.EventHandler(this.uxOpenFileButton_Click);
            // 
            // uxOpenColorButton
            // 
            this.uxOpenColorButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uxOpenColorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uxOpenColorButton.Location = new System.Drawing.Point(412, 406);
            this.uxOpenColorButton.Name = "uxOpenColorButton";
            this.uxOpenColorButton.Size = new System.Drawing.Size(56, 37);
            this.uxOpenColorButton.TabIndex = 5;
            this.uxOpenColorButton.UseVisualStyleBackColor = false;
            this.uxOpenColorButton.Click += new System.EventHandler(this.uxOpenColorButton_Click);
            // 
            // uxDistancefinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 458);
            this.Controls.Add(this.uxOpenColorButton);
            this.Controls.Add(this.uxOpenFileButton);
            this.Controls.Add(this.uxPanel);
            this.Controls.Add(this.uxNumericUpDown);
            this.Controls.Add(this.uxPathColorLabel);
            this.Controls.Add(this.uxThresholdLabel);
            this.MinimumSize = new System.Drawing.Size(499, 496);
            this.Name = "uxDistancefinder";
            this.Text = "Distance Finder";
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).EndInit();
            this.uxPanel.ResumeLayout(false);
            this.uxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.Label uxThresholdLabel;
        private System.Windows.Forms.Label uxPathColorLabel;
        private System.Windows.Forms.NumericUpDown uxNumericUpDown;
        private System.Windows.Forms.ColorDialog uxColorDialog;
        private System.Windows.Forms.Panel uxPanel;
        private System.Windows.Forms.PictureBox uxPictureBox;
        private System.Windows.Forms.Button uxOpenFileButton;
        private System.Windows.Forms.Button uxOpenColorButton;
    }
}

