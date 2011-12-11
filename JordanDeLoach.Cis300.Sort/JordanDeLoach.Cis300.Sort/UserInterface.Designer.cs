namespace JordanDeLoach.Cis300.Sort
{
    partial class UserInterface
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
            this.uxInputButton = new System.Windows.Forms.Button();
            this.uxInputFile = new System.Windows.Forms.TextBox();
            this.uxTempFolder = new System.Windows.Forms.TextBox();
            this.uxTempFolderButton = new System.Windows.Forms.Button();
            this.uxOutputFile = new System.Windows.Forms.TextBox();
            this.uxOutputButton = new System.Windows.Forms.Button();
            this.uxArraySizeLabel = new System.Windows.Forms.Label();
            this.uxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxSortButton = new System.Windows.Forms.Button();
            this.uxFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxInputButton
            // 
            this.uxInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxInputButton.Location = new System.Drawing.Point(12, 12);
            this.uxInputButton.Name = "uxInputButton";
            this.uxInputButton.Size = new System.Drawing.Size(141, 36);
            this.uxInputButton.TabIndex = 0;
            this.uxInputButton.Text = "Input File:";
            this.uxInputButton.UseVisualStyleBackColor = true;
            this.uxInputButton.Click += new System.EventHandler(this.uxInputButton_Click);
            // 
            // uxInputFile
            // 
            this.uxInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.uxInputFile.Location = new System.Drawing.Point(159, 12);
            this.uxInputFile.Name = "uxInputFile";
            this.uxInputFile.ReadOnly = true;
            this.uxInputFile.Size = new System.Drawing.Size(330, 32);
            this.uxInputFile.TabIndex = 1;
            // 
            // uxTempFolder
            // 
            this.uxTempFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.uxTempFolder.Location = new System.Drawing.Point(159, 99);
            this.uxTempFolder.Name = "uxTempFolder";
            this.uxTempFolder.ReadOnly = true;
            this.uxTempFolder.Size = new System.Drawing.Size(330, 32);
            this.uxTempFolder.TabIndex = 3;
            // 
            // uxTempFolderButton
            // 
            this.uxTempFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxTempFolderButton.Location = new System.Drawing.Point(12, 96);
            this.uxTempFolderButton.Name = "uxTempFolderButton";
            this.uxTempFolderButton.Size = new System.Drawing.Size(141, 36);
            this.uxTempFolderButton.TabIndex = 2;
            this.uxTempFolderButton.Text = "Temp Folder:";
            this.uxTempFolderButton.UseVisualStyleBackColor = true;
            this.uxTempFolderButton.Click += new System.EventHandler(this.uxTempFolderButton_Click);
            // 
            // uxOutputFile
            // 
            this.uxOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.uxOutputFile.Location = new System.Drawing.Point(159, 54);
            this.uxOutputFile.Name = "uxOutputFile";
            this.uxOutputFile.ReadOnly = true;
            this.uxOutputFile.Size = new System.Drawing.Size(330, 32);
            this.uxOutputFile.TabIndex = 5;
            // 
            // uxOutputButton
            // 
            this.uxOutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxOutputButton.Location = new System.Drawing.Point(12, 54);
            this.uxOutputButton.Name = "uxOutputButton";
            this.uxOutputButton.Size = new System.Drawing.Size(141, 36);
            this.uxOutputButton.TabIndex = 4;
            this.uxOutputButton.Text = "Ouput File:";
            this.uxOutputButton.UseVisualStyleBackColor = true;
            this.uxOutputButton.Click += new System.EventHandler(this.uxOutputButton_Click);
            // 
            // uxArraySizeLabel
            // 
            this.uxArraySizeLabel.AutoSize = true;
            this.uxArraySizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxArraySizeLabel.Location = new System.Drawing.Point(12, 146);
            this.uxArraySizeLabel.Name = "uxArraySizeLabel";
            this.uxArraySizeLabel.Size = new System.Drawing.Size(117, 25);
            this.uxArraySizeLabel.TabIndex = 6;
            this.uxArraySizeLabel.Text = "Array Size:";
            // 
            // uxNumericUpDown
            // 
            this.uxNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uxNumericUpDown.Location = new System.Drawing.Point(135, 141);
            this.uxNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.uxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxNumericUpDown.Name = "uxNumericUpDown";
            this.uxNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.uxNumericUpDown.TabIndex = 7;
            this.uxNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxNumericUpDown.ThousandsSeparator = true;
            this.uxNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // uxSortButton
            // 
            this.uxSortButton.Enabled = false;
            this.uxSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxSortButton.Location = new System.Drawing.Point(262, 133);
            this.uxSortButton.Name = "uxSortButton";
            this.uxSortButton.Size = new System.Drawing.Size(227, 38);
            this.uxSortButton.TabIndex = 8;
            this.uxSortButton.Text = "Sort";
            this.uxSortButton.UseVisualStyleBackColor = true;
            this.uxSortButton.Click += new System.EventHandler(this.uxSortButton_Click);
            // 
            // uxFolderBrowserDialog
            // 
            this.uxFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "openFileDialog1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 183);
            this.Controls.Add(this.uxSortButton);
            this.Controls.Add(this.uxNumericUpDown);
            this.Controls.Add(this.uxArraySizeLabel);
            this.Controls.Add(this.uxOutputFile);
            this.Controls.Add(this.uxOutputButton);
            this.Controls.Add(this.uxTempFolder);
            this.Controls.Add(this.uxTempFolderButton);
            this.Controls.Add(this.uxInputFile);
            this.Controls.Add(this.uxInputButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Sort";
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxInputButton;
        private System.Windows.Forms.TextBox uxInputFile;
        private System.Windows.Forms.TextBox uxTempFolder;
        private System.Windows.Forms.Button uxTempFolderButton;
        private System.Windows.Forms.TextBox uxOutputFile;
        private System.Windows.Forms.Button uxOutputButton;
        private System.Windows.Forms.Label uxArraySizeLabel;
        private System.Windows.Forms.NumericUpDown uxNumericUpDown;
        private System.Windows.Forms.Button uxSortButton;
        private System.Windows.Forms.FolderBrowserDialog uxFolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
    }
}

