using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace JordanDeLoach.Cis300.DistanceFinder
{
    public partial class uxDistancefinder : Form
    {

        private Point _startingPoint;
        private Point _endPoint;
        private Bitmap _image;
        private Point[,] _predecessor;
        private Point _empty = new Point(-1, 0);
        private Point _noPredecessor = new Point(-2, 0);

        public uxDistancefinder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructs a new predecessor array with empty values
        /// </summary>
        /// <returns>A point array of value empty.</returns>
        private Point[,] NewPredecessorArray()
        {
            Point[,] points = new Point[uxPictureBox.Width, uxPictureBox.Height];

            for (int i = 0; i < _image.Width; i++)
            {
                for (int j = 0; j < _image.Height; j++)
                {
                    points[i, j] = _empty;
                }
            }

            return points;
        }

        /// <summary>
        /// Returns true if the pixel provided, and the starting point are similar in color, as defined in the NumericUpdown Threshold.
        /// </summary>
        /// <param name="x">X coordinate of point</param>
        /// <param name="y">Y coordinate of point</param>
        /// <returns>True if similar, false if not</returns>
        private bool Similar(int x, int y)
        {
            Color startColor = _image.GetPixel(_startingPoint.X, _startingPoint.Y);
            Color inputColor = _image.GetPixel(x, y);

            int value = Math.Abs(startColor.R - inputColor.R) + Math.Abs(startColor.G - inputColor.G) + Math.Abs(startColor.B - inputColor.B);

            if (value <= uxNumericUpDown.Value)
                return true;
            return false;
        }

        /// <summary>
        /// Updates queue and array if it meets conditions
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="predecessor">Predecessor point</param>
        /// <param name="queue">The point queue used</param>
        private void Update(int x, int y, Point predecessor, Queue<Point> queue)
        {
            if (x <= _image.Width-1 && y <= _image.Height-1 && y >= 0 && x >= 0)
                if (_predecessor[x, y].Equals(_empty))
                    if (Similar(x, y))
                    {
                        queue.Enqueue(new Point(x, y));
                        _predecessor[x, y] = predecessor;
                    }
        }

        /// <summary>
        /// Implements the Breadth-First search
        /// </summary>
        private void Search() 
        {
            _predecessor = NewPredecessorArray();
            _predecessor[_startingPoint.X, _startingPoint.Y] = _noPredecessor;
            
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(_startingPoint);

            while (queue.Count > 0)
            {
                Point test = queue.Dequeue();
                if (test.Equals(_endPoint))
                    break;
                Update(test.X + 1, test.Y, test, queue);
                Update(test.X, test.Y + 1, test, queue);
                Update(test.X - 1, test.Y, test, queue);
                Update(test.X, test.Y - 1, test, queue);
            }
            if (queue.Count == 0)
                _predecessor = null;
        }

        /// <summary>
        /// Draws the path from the queue.
        /// </summary>
        /// <returns></returns>
        private int DrawPath()
        {
            int X = _endPoint.X;
            int Y = _endPoint.Y;
            int i = 0;

            while (true)
            {
                _image.SetPixel(X, Y, uxColorDialog.Color);

                if (!_predecessor[X, Y].Equals(_noPredecessor))
                {
                    int x = _predecessor[X, Y].X;
                    Y = _predecessor[X, Y].Y;
                    // its a little hack so that Y can be set properly with old X
                    X = x;
                }
                else
                {
                    break;
                }
                i++;
            }

            uxPictureBox.Image = _image;
            return i - 1;
        }

        /// <summary>
        /// Handles a button click that opens the file dialog and attempts top open the image on the panel, handling exceptions as needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenFileButton_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap image = new Bitmap(uxOpenFileDialog.FileName);
                    _image = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppRgb);
                    Graphics.FromImage(_image).DrawImage(image, 0, 0, image.Width, image.Height);
                    uxPictureBox.Image = image;
                    _predecessor = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }
        /// <summary>
        /// Handles a click to the button of the color selector.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenColorButton_Click(object sender, EventArgs e)
        {
            if (uxColorDialog.ShowDialog() == DialogResult.OK)
            {
                uxOpenColorButton.BackColor = uxColorDialog.Color;
                if (_predecessor != null)
                    DrawPath();
            }
        }


        /// <summary>
        /// Saves the start part of the maze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _endPoint = e.Location;
            Search();
            if (_predecessor != null)
                MessageBox.Show("Distance = " + DrawPath());
            else
                MessageBox.Show("No path exists between the specified points.");

        }

        /// <summary>
        /// Handles the end click of the path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _startingPoint = e.Location;
        }
    }
}
