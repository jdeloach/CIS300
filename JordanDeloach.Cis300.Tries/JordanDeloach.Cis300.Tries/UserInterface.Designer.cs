namespace JordanDeLoach.Cis300.Tries
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
            this.uxInputLabel = new System.Windows.Forms.Label();
            this.uxInput = new System.Windows.Forms.TextBox();
            this.uxAnagramsLabel = new System.Windows.Forms.Label();
            this.uxAnagrams = new System.Windows.Forms.ListBox();
            this.uxFind = new System.Windows.Forms.Button();
            this.uxNumberLabel = new System.Windows.Forms.Label();
            this.uxNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxInputLabel
            // 
            this.uxInputLabel.AutoSize = true;
            this.uxInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInputLabel.Location = new System.Drawing.Point(12, 9);
            this.uxInputLabel.Name = "uxInputLabel";
            this.uxInputLabel.Size = new System.Drawing.Size(113, 24);
            this.uxInputLabel.TabIndex = 0;
            this.uxInputLabel.Text = "Enter String:";
            // 
            // uxInput
            // 
            this.uxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInput.Location = new System.Drawing.Point(12, 36);
            this.uxInput.Name = "uxInput";
            this.uxInput.Size = new System.Drawing.Size(209, 29);
            this.uxInput.TabIndex = 1;
            // 
            // uxAnagramsLabel
            // 
            this.uxAnagramsLabel.AutoSize = true;
            this.uxAnagramsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAnagramsLabel.Location = new System.Drawing.Point(12, 124);
            this.uxAnagramsLabel.Name = "uxAnagramsLabel";
            this.uxAnagramsLabel.Size = new System.Drawing.Size(101, 24);
            this.uxAnagramsLabel.TabIndex = 2;
            this.uxAnagramsLabel.Text = "Anagrams:";
            // 
            // uxAnagrams
            // 
            this.uxAnagrams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAnagrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAnagrams.FormattingEnabled = true;
            this.uxAnagrams.ItemHeight = 24;
            this.uxAnagrams.Location = new System.Drawing.Point(12, 151);
            this.uxAnagrams.Name = "uxAnagrams";
            this.uxAnagrams.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.uxAnagrams.Size = new System.Drawing.Size(209, 316);
            this.uxAnagrams.TabIndex = 3;
            // 
            // uxFind
            // 
            this.uxFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFind.Location = new System.Drawing.Point(12, 71);
            this.uxFind.Name = "uxFind";
            this.uxFind.Size = new System.Drawing.Size(209, 50);
            this.uxFind.TabIndex = 4;
            this.uxFind.Text = "Find Anagrams";
            this.uxFind.UseVisualStyleBackColor = true;
            this.uxFind.Click += new System.EventHandler(this.uxFind_Click);
            // 
            // uxNumberLabel
            // 
            this.uxNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxNumberLabel.AutoSize = true;
            this.uxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberLabel.Location = new System.Drawing.Point(12, 470);
            this.uxNumberLabel.Name = "uxNumberLabel";
            this.uxNumberLabel.Size = new System.Drawing.Size(195, 24);
            this.uxNumberLabel.TabIndex = 5;
            this.uxNumberLabel.Text = "Number of Anagrams:";
            // 
            // uxNumber
            // 
            this.uxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumber.Location = new System.Drawing.Point(12, 497);
            this.uxNumber.Name = "uxNumber";
            this.uxNumber.ReadOnly = true;
            this.uxNumber.Size = new System.Drawing.Size(209, 29);
            this.uxNumber.TabIndex = 6;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 538);
            this.Controls.Add(this.uxNumber);
            this.Controls.Add(this.uxNumberLabel);
            this.Controls.Add(this.uxFind);
            this.Controls.Add(this.uxAnagrams);
            this.Controls.Add(this.uxAnagramsLabel);
            this.Controls.Add(this.uxInput);
            this.Controls.Add(this.uxInputLabel);
            this.MinimumSize = new System.Drawing.Size(240, 572);
            this.Name = "UserInterface";
            this.Text = "Anagrams";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxInputLabel;
        private System.Windows.Forms.TextBox uxInput;
        private System.Windows.Forms.Label uxAnagramsLabel;
        private System.Windows.Forms.ListBox uxAnagrams;
        private System.Windows.Forms.Button uxFind;
        private System.Windows.Forms.Label uxNumberLabel;
        private System.Windows.Forms.TextBox uxNumber;
    }
}

