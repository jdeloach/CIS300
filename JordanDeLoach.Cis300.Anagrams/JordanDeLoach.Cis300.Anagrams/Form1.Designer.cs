namespace JordanDeLoach.Cis300.Anagrams
{
    partial class uxAnagrams
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
            this.uxEnterStringLabel = new System.Windows.Forms.Label();
            this.uxString = new System.Windows.Forms.TextBox();
            this.uxFindAnagrams = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxListBox = new System.Windows.Forms.ListBox();
            this.uxAnagramCount = new System.Windows.Forms.TextBox();
            this.uxCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxEnterStringLabel
            // 
            this.uxEnterStringLabel.AutoSize = true;
            this.uxEnterStringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxEnterStringLabel.Location = new System.Drawing.Point(13, 13);
            this.uxEnterStringLabel.Name = "uxEnterStringLabel";
            this.uxEnterStringLabel.Size = new System.Drawing.Size(98, 20);
            this.uxEnterStringLabel.TabIndex = 0;
            this.uxEnterStringLabel.Text = "Enter String:";
            // 
            // uxString
            // 
            this.uxString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxString.Location = new System.Drawing.Point(13, 37);
            this.uxString.Name = "uxString";
            this.uxString.Size = new System.Drawing.Size(180, 20);
            this.uxString.TabIndex = 1;
            // 
            // uxFindAnagrams
            // 
            this.uxFindAnagrams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFindAnagrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFindAnagrams.Location = new System.Drawing.Point(12, 63);
            this.uxFindAnagrams.Name = "uxFindAnagrams";
            this.uxFindAnagrams.Size = new System.Drawing.Size(180, 45);
            this.uxFindAnagrams.TabIndex = 2;
            this.uxFindAnagrams.Text = "Find Anagrams";
            this.uxFindAnagrams.UseVisualStyleBackColor = true;
            this.uxFindAnagrams.Click += new System.EventHandler(this.uxFindAnagrams_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anagrams:";
            // 
            // uxListBox
            // 
            this.uxListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxListBox.FormattingEnabled = true;
            this.uxListBox.Location = new System.Drawing.Point(13, 139);
            this.uxListBox.Name = "uxListBox";
            this.uxListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.uxListBox.Size = new System.Drawing.Size(180, 264);
            this.uxListBox.TabIndex = 4;
            // 
            // uxAnagramCount
            // 
            this.uxAnagramCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAnagramCount.Location = new System.Drawing.Point(12, 431);
            this.uxAnagramCount.Name = "uxAnagramCount";
            this.uxAnagramCount.ReadOnly = true;
            this.uxAnagramCount.Size = new System.Drawing.Size(180, 20);
            this.uxAnagramCount.TabIndex = 5;
            // 
            // uxCountLabel
            // 
            this.uxCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxCountLabel.AutoSize = true;
            this.uxCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCountLabel.Location = new System.Drawing.Point(8, 408);
            this.uxCountLabel.Name = "uxCountLabel";
            this.uxCountLabel.Size = new System.Drawing.Size(164, 20);
            this.uxCountLabel.TabIndex = 6;
            this.uxCountLabel.Text = "Number of Anagrams:";
            // 
            // uxAnagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 463);
            this.Controls.Add(this.uxCountLabel);
            this.Controls.Add(this.uxAnagramCount);
            this.Controls.Add(this.uxListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxFindAnagrams);
            this.Controls.Add(this.uxString);
            this.Controls.Add(this.uxEnterStringLabel);
            this.MinimumSize = new System.Drawing.Size(221, 501);
            this.Name = "uxAnagrams";
            this.Text = "Anagrams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxEnterStringLabel;
        private System.Windows.Forms.TextBox uxString;
        private System.Windows.Forms.Button uxFindAnagrams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox uxListBox;
        private System.Windows.Forms.TextBox uxAnagramCount;
        private System.Windows.Forms.Label uxCountLabel;
    }
}

