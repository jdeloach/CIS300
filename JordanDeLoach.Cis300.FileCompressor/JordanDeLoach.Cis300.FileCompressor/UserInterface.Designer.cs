namespace JordanDeLoach.Cis300.FileCompressor
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
            this.uxCompressFile = new System.Windows.Forms.Button();
            this.uxDecompress = new System.Windows.Forms.Button();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // uxCompressFile
            // 
            this.uxCompressFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxCompressFile.Location = new System.Drawing.Point(12, 12);
            this.uxCompressFile.Name = "uxCompressFile";
            this.uxCompressFile.Size = new System.Drawing.Size(198, 49);
            this.uxCompressFile.TabIndex = 0;
            this.uxCompressFile.Text = "Compress a File";
            this.uxCompressFile.UseVisualStyleBackColor = true;
            this.uxCompressFile.Click += new System.EventHandler(this.uxCompressFile_Click);
            // 
            // uxDecompress
            // 
            this.uxDecompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxDecompress.Location = new System.Drawing.Point(12, 67);
            this.uxDecompress.Name = "uxDecompress";
            this.uxDecompress.Size = new System.Drawing.Size(198, 49);
            this.uxDecompress.TabIndex = 1;
            this.uxDecompress.Text = "Decompress a File";
            this.uxDecompress.UseVisualStyleBackColor = true;
            this.uxDecompress.Click += new System.EventHandler(this.uxDecompress_Click);
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.Title = "Input File";
            // 
            // uxSaveFileDialog
            // 
            this.uxSaveFileDialog.Title = "Output File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 129);
            this.Controls.Add(this.uxDecompress);
            this.Controls.Add(this.uxCompressFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "File Compressor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxCompressFile;
        private System.Windows.Forms.Button uxDecompress;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
    }
}

