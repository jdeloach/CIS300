using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RodHowell.Cis300.BitIO;
using KansasStateUniversity.TreeViewer2;

namespace JordanDeLoach.Cis300.FileCompressor
{
    /// <summary>
    /// UI for the FileCompressor class
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The bits of encodings at the given byte position (0-255)
        /// </summary>
        private long[] _encodings;

        /// <summary>
        /// The length of bits in the encodings at given byte position (0-255)
        /// </summary>
        private int[] _encodingLength;

        /// <summary>
        /// Standard error message to throw.
        /// </summary>
        private string _errorMessage = "The compressed file is corrupt.";

        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a Compress button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCompressFile_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream input = File.OpenRead(uxOpenFileDialog.FileName))
                        {
                            using (BitOutputStream output = new BitOutputStream(uxSaveFileDialog.FileName))
                            {
                                CompressStream(input, output);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        DisplayError(ex);
                    }
                }
            }
        }
        
        /// <summary>
        /// Handles a decompress button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDecompress_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (BitInputStream input = new BitInputStream(uxOpenFileDialog.FileName))
                        {
                            using (FileStream output = File.OpenWrite(uxSaveFileDialog.FileName))
                            {
                                DecompressStream(input, output);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        DisplayError(ex);
                    }
                }
            }
        }

        /// <summary>
        /// Returns the frequency of the bytes in a given FileStream, as well as returns the length of the input.
        /// </summary>
        /// <param name="fs">FileStream to read from</param>
        /// <param name="inputLength">Size of file that we are reading from</param>
        /// <returns>The array of frequency of a given byte, at that position in the array.</returns>
        private long[] GetFrequency(FileStream fs, out int inputLength)
        {
            long[] result = new long[256];
            inputLength = (int)fs.Length;
            int b = fs.ReadByte();
            while (b != -1)
            {
                result[b]++;
                b = fs.ReadByte();
            }

            return result;
        }

        /// <summary>
        /// Builds a Huffman tree out of the given frequencies.
        /// </summary>
        /// <param name="freq">Array of frequencies for a byte at index of byte</param>
        /// <param name="numberOfNodes">Returns number of nodes in Huffman tree</param>
        /// <returns>A fully loaded Huffman tree.</returns>
        private BinaryTreeNode<byte> BuildHuffmanTree(long[] freq, out int numberOfNodes)
        {
            MinPriorityQueue<BinaryTreeNode<byte>> pq = new MinPriorityQueue<BinaryTreeNode<byte>>();
            
            int count = 0;

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != 0)
                {
                    BinaryTreeNode<byte> tmp = new BinaryTreeNode<byte>();
                    tmp.RootValue = (byte)i;
                    pq.AddElement(tmp, freq[i]);
                }

            }

            while (pq.Count > 1)
            {
                BinaryTreeNode<byte> root = new BinaryTreeNode<byte>();
                root.IsEmpty = false;
                int weight1 = (int)pq.LowestPriority;

                BinaryTreeNode<byte> child1 = pq.RemoveLowestPriority();
                child1.IsEmpty = false;

                int weight2 = (int)pq.LowestPriority;

                BinaryTreeNode<byte> child2 = pq.RemoveLowestPriority();
                child2.IsEmpty = false;

                root.LeftChild = child1;
                root.RightChild = child2;

                pq.AddElement(root, weight1 + weight2);
                count++;
            }
            numberOfNodes = count + 1;
            BinaryTreeNode<byte> huf = pq.RemoveLowestPriority();

            return huf;
        }

        /// <summary>
        /// Generates the encodings needed for a given Huffman tree.
        /// </summary>
        /// <param name="huff">Huffman tree to generate encodings for.</param>
        /// <param name="numberSteps">Number of steps the given Huffman tree is from the top.</param>
        /// <param name="lowOrderBits">Order of bits that form the path to the leaf.</param>
        private void ComputeEncodings(BinaryTreeNode<byte> huff, int numberSteps, long lowOrderBits)
        {

            if (huff.LeftChild == null && huff.RightChild == null)
            {
                _encodings[huff.RootValue] = lowOrderBits;
                _encodingLength[huff.RootValue] = numberSteps;
            }
            else
            {
                numberSteps++;
                ComputeEncodings(huff.LeftChild, numberSteps, lowOrderBits << 1);
                ComputeEncodings(huff.RightChild, numberSteps, (lowOrderBits << 1 | 1L));
            }
        }

        /// <summary>
        /// Writes the Huffman tree to the given OutputStream
        /// </summary>
        /// <param name="huff">Huffman tree to write</param>
        /// <param name="numberWritten">Amount of nodes written.</param>
        /// <param name="outputStream">BitOutputStream of file to write to.</param>
        /// <returns>An integer of the number of that node.</returns>
        private int WriteHuffmanTree(BinaryTreeNode<byte> huff, int numberWritten, BitOutputStream outputStream)
        {
            if (huff.LeftChild == null && huff.RightChild == null)
            {
                outputStream.WriteBits(1L, 1);
                outputStream.WriteBits(huff.RootValue, 8);
                return numberWritten;
            }
            else
            {
                int num1 = WriteHuffmanTree(huff.LeftChild, numberWritten++, outputStream);
                int num2 = WriteHuffmanTree(huff.RightChild, num1 + 1, outputStream);
                outputStream.WriteBits(0 << 1, 1);
                outputStream.WriteBits((byte)num1,9);
                outputStream.WriteBits((byte)num2,9);
                return num2 + 1;
            }
        }

        /// <summary>
        /// Writes the encodings generated for each byte in FileStream to a outputstream.
        /// </summary>
        /// <param name="fs">FileStream of uncompressed data</param>
        /// <param name="outputStream">BitOutputStream of file to write compressed data to</param>
        private void WriteEncodings(FileStream fs, BitOutputStream outputStream)
        {
            int b = fs.ReadByte();
            while (b != -1)
            {
                if (_encodingLength[b] > 0)
                {
                    outputStream.WriteBits(_encodings[b], _encodingLength[b]);
                }
                b = fs.ReadByte();
            }
        }

        /// <summary>
        /// Takes an in and out file, and configures all other methods to build the huffman tree and write it, as well as compress data.
        /// </summary>
        /// <param name="fs">Input file</param>
        /// <param name="outputStream">Output File</param>
        private void CompressStream(FileStream fs, BitOutputStream outputStream)
        {
            _encodingLength = new int[256];
            _encodings = new long[256];
            int numberOfNodes = 0;
            int inputLength;

            long[] frequency = GetFrequency(fs, out inputLength);
            outputStream.WriteBits(inputLength, 63);
            if(inputLength != 0)
            {
                BinaryTreeNode<byte> huff = BuildHuffmanTree(frequency, out numberOfNodes);/*
                TreeForm t = new TreeForm(huff, 100);
                t.Show();*/
                ComputeEncodings(huff, 0, 0L);
                outputStream.WriteBits((2*numberOfNodes) - 1, 9);
                WriteHuffmanTree(huff, 0, outputStream);

                fs.Seek(0, SeekOrigin.Begin);
                WriteEncodings(fs, outputStream);
            }
        }

        /// <summary>
        /// Reads Bits from given BitInputStream
        /// </summary>
        /// <param name="inputStream">Stream to read from</param>
        /// <param name="numberToRead">Number of bits to read from the stream.</param>
        /// <returns>A long of the bits in the stream.</returns>
        private long ReadBits(BitInputStream inputStream, int numberToRead)
        {
            int numRead = 0;
            long results = inputStream.ReadBits(numberToRead, out numRead);

            if (numRead == 0)
                throw new IOException(_errorMessage);
            else
                return results;
        }

        /// <summary>
        /// Retrieves a specific Huffman tree from the array of them.
        /// </summary>
        /// <param name="inputStream">Stream to read bits from</param>
        /// <param name="huffTrees">Array of Huffman trees to choose from</param>
        /// <param name="numberOfTrees">Number of filled trees in the array</param>
        /// <returns>Returns the Huffman tree that is needed that is requested in the BitStream.</returns>
        private BinaryTreeNode<byte> RetrieveHuffmanTree(BitInputStream inputStream, BinaryTreeNode<byte>[] huffTrees, int numberOfTrees)
        {
            int bitsRead = 0;
            int spot = (int)inputStream.ReadBits(9, out bitsRead);

            if (bitsRead < 9)
                throw new IOException(_errorMessage);

            return huffTrees[spot];
        }

        /// <summary>
        /// Reconstructs a Huffman tree from BitInputStreams
        /// </summary>
        /// <param name="inputStream">InputStream to read bits from to construct tree from.</param>
        /// <param name="numberOfNodes">Number of nodes to construct in tree.</param>
        /// <returns>A fully generated Huffman Tree</returns>
        private BinaryTreeNode<byte> RecontstructHuffmanTree(BitInputStream inputStream, long numberOfNodes)
        {
            BinaryTreeNode<byte>[] nodes = new BinaryTreeNode<byte>[numberOfNodes];
            int index = 0;

            foreach(BinaryTreeNode<byte> node in nodes)
            {
                if (ReadBits(inputStream, 1) == 1)
                {
                    BinaryTreeNode<byte> tmp = new BinaryTreeNode<byte>();
                    tmp.IsEmpty = false;
                    tmp.RootValue = (byte)ReadBits(inputStream, 8);
                    nodes[index] = tmp;
                    index++;
                }
                else
                {
                    BinaryTreeNode<byte> tmp = new BinaryTreeNode<byte>();
                     tmp.IsEmpty = false;

                    tmp.LeftChild = RetrieveHuffmanTree(inputStream, nodes, index);
                    tmp.RightChild = RetrieveHuffmanTree(inputStream, nodes, index);

                    nodes[index] = tmp;
                    index++;
                }
            }

            return nodes[index - 1];
        }

        /// <summary>
        /// Decompressses and writes the current byte in the inputStream to the outputstream.
        /// </summary>
        /// <param name="inputStream">File of compressed data to decompress.</param>
        /// <param name="outputStream">File to write uncompressed data to.</param>
        /// <param name="huffTree">Huffman tree used to decode with</param>
        private void WriteDecompressedByte(BitInputStream inputStream, FileStream outputStream, BinaryTreeNode<byte> huffTree)
        {
            while (huffTree.LeftChild != null || huffTree.RightChild != null)
            {
                if (ReadBits(inputStream, 1) == 0)
                    huffTree = huffTree.LeftChild;
                else
                    huffTree = huffTree.RightChild;
            }
            outputStream.WriteByte(huffTree.RootValue);
            
        }

        /// <summary>
        /// General method which takes an Input and Output file and rebuilds a Huffman trees and takes the compressed data and uses the Huffman tree to decompress it.
        /// </summary>
        /// <param name="inputStream">Compressed file stream to decompress</param>
        /// <param name="outputStream">Uncompressed file stream to write decompressed bytes to</param>
        private void DecompressStream(BitInputStream inputStream, FileStream outputStream)
        {
            long numBytes = ReadBits(inputStream, 63);
            long numNodes = ReadBits(inputStream, 9);

            if (numBytes > 0 && numNodes == 0)
                throw new IOException(_errorMessage);

            BinaryTreeNode<byte> huffTree = RecontstructHuffmanTree(inputStream, numNodes);
            for (int i = 0; i < numBytes; i++)
                WriteDecompressedByte(inputStream, outputStream, huffTree);
        }

        private void DisplayError(Exception ex)
        {
            MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
