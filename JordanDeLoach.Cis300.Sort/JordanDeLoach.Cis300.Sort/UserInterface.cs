using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JordanDeLoach.Cis300.Sort
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a click on a button for selecting the input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxInputButton_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                uxInputFile.Text = uxOpenFileDialog.FileName;

                EnableSort();
            }
        }
        
        /// <summary>
        /// Handles a click on the button for selecting the output.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOutputButton_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                uxOutputFile.Text = uxSaveFileDialog.FileName;

                EnableSort();
            }
        }

        /// <summary>
        /// Handles a click on the button for selecting the temp folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxTempFolderButton_Click(object sender, EventArgs e)
        {
            if(uxFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                uxTempFolder.Text = uxFolderBrowserDialog.SelectedPath;

                EnableSort();
            }
        }

        /// <summary>
        /// Handles a click on the Sort button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSortButton_Click(object sender, EventArgs e)
        {
            try
            {
                string file1 = uxTempFolder.Text + "\\file1.txt";
                string file2 = uxTempFolder.Text + "\\file2.txt";
                string file3 = uxTempFolder.Text + "\\file3.txt";
                string file4 = uxTempFolder.Text + "\\file4.txt";

                InitializeSortingAlgorithm(file1, file2);
                FormOutputFile(Sort(file1, file2, file3, file4), uxOutputFile.Text);

                File.Delete(file1);
                File.Delete(file2);
                File.Delete(file3);
                File.Delete(file4);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occured: \n" + ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Swaps the values of x and y.
        /// </summary>
        /// <typeparam name="T">The type of x and y.</typeparam>
        /// <param name="x">One of the variables to be swapped.</param>
        /// <param name="y">The other variable to be swapped.</param>
        private void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        /// <summary>
        /// Enabales the sort button, if all three input fields are not blank
        /// </summary>
        private void EnableSort()
        {
            if (uxInputFile.Text != "" && uxOutputFile.Text != "" && uxTempFolder.Text != "")
                uxSortButton.Enabled = true;
        }

        /// <summary>
        /// Loads a set of data into an array.
        /// </summary>
        /// <param name="values">Array to put numbers to sort in</param>
        /// <param name="inputStream">Input stream to file to read from</param>
        /// <returns>Amount of spots in array that were filled</returns>
        private int LoadInputValues(long[] values, StreamReader inputStream)
        {
            string line = inputStream.ReadLine();
            if (line == "")
                return 0;
            int count = 0;

            while (line != null)
            {
                values[count++] = Convert.ToInt64(line);
                if (count == values.Length)
                    return count;
                line = inputStream.ReadLine();
            }
            return count;
        }

        /// <summary>
        /// Setups up the sorting algorithim, initially splitting data into two files, in sets of array size.
        /// </summary>
        /// <param name="file1">First file to store data in</param>
        /// <param name="file2">Second file to store data in</param>
        private void InitializeSortingAlgorithm(string file1, string file2)
        {
            using(StreamReader inputFile = File.OpenText(uxInputFile.Text)) {
                using(StreamWriter file1Handle = new StreamWriter(File.Open(file1, FileMode.Create)), file2Handle = new StreamWriter(File.Open(file2, FileMode.Create)))
                {
                    StreamWriter current = file1Handle;
                    StreamWriter other = file2Handle;
                    int size = (int)uxNumericUpDown.Value;
                    long[] values = new long[size];
                    int count = LoadInputValues(values, inputFile);
                    while (count != 0)
                    {
                        Array.Sort(values,0 , count);
                        current.WriteLine();

                        for (int i = 0; i < count; i++)
                            current.WriteLine(values[i]);

                        current.WriteLine();
                        values = new long[size];
                        count = LoadInputValues(values, inputFile);
                        Swap<StreamWriter>(ref current, ref other);
                    }
                }
            }
        }

        /// <summary>
        /// Merges data sets between two bank lines.
        /// </summary>
        /// <param name="file1">First file to pull data from</param>
        /// <param name="file2">Second file to pull data from</param>
        /// <param name="output">File to write compiled data to</param>
        private void MergeSegments(StreamReader file1, StreamReader file2, StreamWriter output)
        {
            string file1Next = file1.ReadLine();
            string file2Next = file2.ReadLine();

            while (file1Next != null && file2Next != null && file1Next != "" && file2Next != "")
            {
                    long num1 = Convert.ToInt64(file1Next);
                    long num2 = Convert.ToInt64(file2Next);
                
                if (num1 <= num2)
                {
                    output.WriteLine(file1Next);
                    file1Next = file1.ReadLine();
                }
                else
                {
                    output.WriteLine(file2Next);
                    file2Next = file2.ReadLine();
                }

            }
            while (file1Next != null && file1Next != "")
            {
                output.WriteLine(file1Next);
                file1Next = file1.ReadLine();
            }
            while (file2Next != null && file2Next != "")
            {
                output.WriteLine(file2Next);
                file2Next = file2.ReadLine();
            }

        }

        /// <summary>
        /// Merges two files into two other files, combining data sets
        /// </summary>
        /// <param name="input1">Input file containing the same or more data sets than input2</param>
        /// <param name="input2">Input file containing equal, or one less data sets than input1</param>
        /// <param name="output1">A file (not necessarily created) to write to.</param>
        /// <param name="output2">A file (not necessarily created) to write to.</param>
       
        private void MergeFiles(string input1, string input2, string output1, string output2)
        {
            File.Create(output1).Close();
            File.Create(output2).Close();
                using (StreamReader inputFile1 = new StreamReader(input1), inputFile2 = new StreamReader(input2))
                {
                    using (StreamWriter outputFile1 = new StreamWriter(output1), outputFile2 = new StreamWriter(output2))
                    {
                        StreamWriter handle1 = outputFile1;
                        StreamWriter handle2 = outputFile2;
                        string nextLine = inputFile2.ReadLine();
                        inputFile1.ReadLine();

                        while (nextLine != null)
                        {
                            handle1.WriteLine();
                            MergeSegments(inputFile1, inputFile2, handle1);
                            
                            nextLine = inputFile2.ReadLine();
                            inputFile1.ReadLine();
                            handle1.WriteLine();
                            Swap<StreamWriter>(ref handle1, ref handle2);
                        }
                        nextLine = inputFile1.ReadLine();
                        if (nextLine != null)
                        {
                            handle1.WriteLine();
                            while (nextLine != null)
                            {
                                handle1.WriteLine(nextLine);
                                nextLine = inputFile1.ReadLine();
                            }
                            handle1.WriteLine();
                        }
                    }
                }
        }

        /// <summary>
        /// Sorts data that has been setup.
        /// </summary>
        /// <param name="input1">First input file created by the setup of the algorithm</param>
        /// <param name="input2">Second input file created by thte setup of the algorithm</param>
        /// <param name="add1">Additional file to manipulate when sorting sets</param>
        /// <param name="add2">Additional file to manipulate when sorting sets</param>
        /// <returns>The path of the sorted file</returns>
        private string Sort(string input1, string input2, string add1, string add2)
        {
            FileInfo fi = new FileInfo(input2);

            while (fi.Length > 0)
            {
                MergeFiles(input1, input2, add1, add2);
                Swap<string>(ref add1, ref input1);
                Swap<string>(ref add2, ref input2);
                fi = new FileInfo(input2);
            }
            return input1;
        }

        /// <summary>
        /// Moves a file to the correct location.
        /// </summary>
        /// <param name="outputFile">Destination of the ouput of the sorting algorithim.</param>
        /// <param name="destination">Destination provided by the user for the file to go to.</param>
        private void FormOutputFile(string outputFile, string destination)
        {
            using (StreamReader input = new StreamReader(outputFile))
            {
                using (StreamWriter output = new StreamWriter(destination))
                {
                    
                    string next = input.ReadLine();
                    while (next != null)
                    {
                        if (next == "")
                        {
                            next = input.ReadLine();
                            continue;
                        }
                        output.WriteLine(next);
                        next = input.ReadLine();
                    }
                }
            }
        }
    }
}
