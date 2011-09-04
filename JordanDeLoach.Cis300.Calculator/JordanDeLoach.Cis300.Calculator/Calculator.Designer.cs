namespace JordanDeLoach.Cis300.Calculator
{
    partial class Calculator
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
            this.uxResult = new System.Windows.Forms.TextBox();
            this.uxPeriod = new System.Windows.Forms.Button();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxPosNeg = new System.Windows.Forms.Button();
            this.uxZero = new System.Windows.Forms.Button();
            this.uxTwo = new System.Windows.Forms.Button();
            this.uxThree = new System.Windows.Forms.Button();
            this.uxSubtract = new System.Windows.Forms.Button();
            this.uxOne = new System.Windows.Forms.Button();
            this.uxFive = new System.Windows.Forms.Button();
            this.uxSix = new System.Windows.Forms.Button();
            this.uxMultiply = new System.Windows.Forms.Button();
            this.uxFour = new System.Windows.Forms.Button();
            this.uxEight = new System.Windows.Forms.Button();
            this.uxNine = new System.Windows.Forms.Button();
            this.uxDivide = new System.Windows.Forms.Button();
            this.uxSeven = new System.Windows.Forms.Button();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxEnter = new System.Windows.Forms.Button();
            this.uxClearScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxResult
            // 
            this.uxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxResult.Location = new System.Drawing.Point(12, 12);
            this.uxResult.Name = "uxResult";
            this.uxResult.ReadOnly = true;
            this.uxResult.Size = new System.Drawing.Size(260, 26);
            this.uxResult.TabIndex = 0;
            this.uxResult.Text = "0";
            this.uxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxPeriod
            // 
            this.uxPeriod.Location = new System.Drawing.Point(12, 170);
            this.uxPeriod.Name = "uxPeriod";
            this.uxPeriod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxPeriod.Size = new System.Drawing.Size(61, 36);
            this.uxPeriod.TabIndex = 2;
            this.uxPeriod.Text = ".";
            this.uxPeriod.UseVisualStyleBackColor = true;
            this.uxPeriod.Click += new System.EventHandler(this.uxPeriod_Click);
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(213, 170);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxAdd.Size = new System.Drawing.Size(61, 36);
            this.uxAdd.TabIndex = 4;
            this.uxAdd.Text = "+";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxPosNeg
            // 
            this.uxPosNeg.Location = new System.Drawing.Point(146, 170);
            this.uxPosNeg.Name = "uxPosNeg";
            this.uxPosNeg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxPosNeg.Size = new System.Drawing.Size(61, 36);
            this.uxPosNeg.TabIndex = 5;
            this.uxPosNeg.Text = "+/-";
            this.uxPosNeg.UseVisualStyleBackColor = true;
            // 
            // uxZero
            // 
            this.uxZero.Location = new System.Drawing.Point(79, 170);
            this.uxZero.Name = "uxZero";
            this.uxZero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxZero.Size = new System.Drawing.Size(61, 36);
            this.uxZero.TabIndex = 6;
            this.uxZero.Text = "0";
            this.uxZero.UseVisualStyleBackColor = true;
            this.uxZero.Click += new System.EventHandler(this.uxZero_Click);
            // 
            // uxTwo
            // 
            this.uxTwo.Location = new System.Drawing.Point(79, 128);
            this.uxTwo.Name = "uxTwo";
            this.uxTwo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxTwo.Size = new System.Drawing.Size(61, 36);
            this.uxTwo.TabIndex = 10;
            this.uxTwo.Text = "2";
            this.uxTwo.UseVisualStyleBackColor = true;
            this.uxTwo.Click += new System.EventHandler(this.uxTwo_Click);
            // 
            // uxThree
            // 
            this.uxThree.Location = new System.Drawing.Point(146, 128);
            this.uxThree.Name = "uxThree";
            this.uxThree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxThree.Size = new System.Drawing.Size(61, 36);
            this.uxThree.TabIndex = 9;
            this.uxThree.Text = "3";
            this.uxThree.UseVisualStyleBackColor = true;
            this.uxThree.Click += new System.EventHandler(this.uxThree_Click);
            // 
            // uxSubtract
            // 
            this.uxSubtract.Location = new System.Drawing.Point(213, 128);
            this.uxSubtract.Name = "uxSubtract";
            this.uxSubtract.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxSubtract.Size = new System.Drawing.Size(61, 36);
            this.uxSubtract.TabIndex = 8;
            this.uxSubtract.Text = "-";
            this.uxSubtract.UseVisualStyleBackColor = true;
            this.uxSubtract.Click += new System.EventHandler(this.uxSubtract_Click);
            // 
            // uxOne
            // 
            this.uxOne.Location = new System.Drawing.Point(12, 128);
            this.uxOne.Name = "uxOne";
            this.uxOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxOne.Size = new System.Drawing.Size(61, 36);
            this.uxOne.TabIndex = 7;
            this.uxOne.Text = "1";
            this.uxOne.UseVisualStyleBackColor = true;
            this.uxOne.Click += new System.EventHandler(this.uxOne_Click);
            // 
            // uxFive
            // 
            this.uxFive.Location = new System.Drawing.Point(79, 86);
            this.uxFive.Name = "uxFive";
            this.uxFive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxFive.Size = new System.Drawing.Size(61, 36);
            this.uxFive.TabIndex = 14;
            this.uxFive.Text = "5";
            this.uxFive.UseVisualStyleBackColor = true;
            this.uxFive.Click += new System.EventHandler(this.uxFive_Click);
            // 
            // uxSix
            // 
            this.uxSix.Location = new System.Drawing.Point(146, 86);
            this.uxSix.Name = "uxSix";
            this.uxSix.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxSix.Size = new System.Drawing.Size(61, 36);
            this.uxSix.TabIndex = 13;
            this.uxSix.Text = "6";
            this.uxSix.UseVisualStyleBackColor = true;
            this.uxSix.Click += new System.EventHandler(this.uxSix_Click);
            // 
            // uxMultiply
            // 
            this.uxMultiply.Location = new System.Drawing.Point(213, 86);
            this.uxMultiply.Name = "uxMultiply";
            this.uxMultiply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxMultiply.Size = new System.Drawing.Size(61, 36);
            this.uxMultiply.TabIndex = 12;
            this.uxMultiply.Text = "X";
            this.uxMultiply.UseVisualStyleBackColor = true;
            this.uxMultiply.Click += new System.EventHandler(this.uxMultiply_Click);
            // 
            // uxFour
            // 
            this.uxFour.Location = new System.Drawing.Point(12, 86);
            this.uxFour.Name = "uxFour";
            this.uxFour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxFour.Size = new System.Drawing.Size(61, 36);
            this.uxFour.TabIndex = 11;
            this.uxFour.Text = "4";
            this.uxFour.UseVisualStyleBackColor = true;
            this.uxFour.Click += new System.EventHandler(this.uxFour_Click);
            // 
            // uxEight
            // 
            this.uxEight.Location = new System.Drawing.Point(79, 44);
            this.uxEight.Name = "uxEight";
            this.uxEight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxEight.Size = new System.Drawing.Size(61, 36);
            this.uxEight.TabIndex = 18;
            this.uxEight.Text = "8";
            this.uxEight.UseVisualStyleBackColor = true;
            this.uxEight.Click += new System.EventHandler(this.uxEight_Click);
            // 
            // uxNine
            // 
            this.uxNine.Location = new System.Drawing.Point(146, 44);
            this.uxNine.Name = "uxNine";
            this.uxNine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxNine.Size = new System.Drawing.Size(61, 36);
            this.uxNine.TabIndex = 17;
            this.uxNine.Text = "9";
            this.uxNine.UseVisualStyleBackColor = true;
            this.uxNine.Click += new System.EventHandler(this.uxNine_Click);
            // 
            // uxDivide
            // 
            this.uxDivide.Location = new System.Drawing.Point(213, 44);
            this.uxDivide.Name = "uxDivide";
            this.uxDivide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxDivide.Size = new System.Drawing.Size(61, 36);
            this.uxDivide.TabIndex = 16;
            this.uxDivide.Text = "/";
            this.uxDivide.UseVisualStyleBackColor = true;
            this.uxDivide.Click += new System.EventHandler(this.uxDivide_Click);
            // 
            // uxSeven
            // 
            this.uxSeven.Location = new System.Drawing.Point(12, 44);
            this.uxSeven.Name = "uxSeven";
            this.uxSeven.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxSeven.Size = new System.Drawing.Size(61, 36);
            this.uxSeven.TabIndex = 15;
            this.uxSeven.Text = "7";
            this.uxSeven.UseVisualStyleBackColor = true;
            this.uxSeven.Click += new System.EventHandler(this.uxSeven_Click);
            // 
            // uxClear
            // 
            this.uxClear.Location = new System.Drawing.Point(79, 214);
            this.uxClear.Name = "uxClear";
            this.uxClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxClear.Size = new System.Drawing.Size(61, 36);
            this.uxClear.TabIndex = 22;
            this.uxClear.Text = "C";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // uxEnter
            // 
            this.uxEnter.Location = new System.Drawing.Point(146, 214);
            this.uxEnter.Name = "uxEnter";
            this.uxEnter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxEnter.Size = new System.Drawing.Size(128, 36);
            this.uxEnter.TabIndex = 20;
            this.uxEnter.Text = "Enter";
            this.uxEnter.UseVisualStyleBackColor = true;
            this.uxEnter.Click += new System.EventHandler(this.uxEnter_Click);
            // 
            // uxClearScreen
            // 
            this.uxClearScreen.Location = new System.Drawing.Point(12, 214);
            this.uxClearScreen.Name = "uxClearScreen";
            this.uxClearScreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxClearScreen.Size = new System.Drawing.Size(61, 36);
            this.uxClearScreen.TabIndex = 19;
            this.uxClearScreen.Text = "CS";
            this.uxClearScreen.UseVisualStyleBackColor = true;
            this.uxClearScreen.Click += new System.EventHandler(this.uxClearScreen_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxEnter);
            this.Controls.Add(this.uxClearScreen);
            this.Controls.Add(this.uxEight);
            this.Controls.Add(this.uxNine);
            this.Controls.Add(this.uxDivide);
            this.Controls.Add(this.uxSeven);
            this.Controls.Add(this.uxFive);
            this.Controls.Add(this.uxSix);
            this.Controls.Add(this.uxMultiply);
            this.Controls.Add(this.uxFour);
            this.Controls.Add(this.uxTwo);
            this.Controls.Add(this.uxThree);
            this.Controls.Add(this.uxSubtract);
            this.Controls.Add(this.uxOne);
            this.Controls.Add(this.uxZero);
            this.Controls.Add(this.uxPosNeg);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxPeriod);
            this.Controls.Add(this.uxResult);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxResult;
        private System.Windows.Forms.Button uxPeriod;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxPosNeg;
        private System.Windows.Forms.Button uxZero;
        private System.Windows.Forms.Button uxTwo;
        private System.Windows.Forms.Button uxThree;
        private System.Windows.Forms.Button uxSubtract;
        private System.Windows.Forms.Button uxOne;
        private System.Windows.Forms.Button uxFive;
        private System.Windows.Forms.Button uxSix;
        private System.Windows.Forms.Button uxMultiply;
        private System.Windows.Forms.Button uxFour;
        private System.Windows.Forms.Button uxEight;
        private System.Windows.Forms.Button uxNine;
        private System.Windows.Forms.Button uxDivide;
        private System.Windows.Forms.Button uxSeven;
        private System.Windows.Forms.Button uxClear;
        private System.Windows.Forms.Button uxEnter;
        private System.Windows.Forms.Button uxClearScreen;
    }
}

