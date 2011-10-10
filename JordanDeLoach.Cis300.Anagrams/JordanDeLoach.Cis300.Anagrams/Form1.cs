using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RodHowell.Cis300.ConsList;

namespace JordanDeLoach.Cis300.Anagrams
{
    public partial class uxAnagrams : Form
    {
        /// <summary>
        /// Number of words in dictionary
        /// </summary>
        private const int NumberWords = 81539;

        /// <summary>
        /// File name of the dictionary to open
        /// </summary>
        private const String WordFile = "dictionary.txt";

        /// <summary>
        /// Words loaded from dictionary
        /// </summary>
        private string[] _wordList;

        public uxAnagrams()
        {
            InitializeComponent();
            ReadList();
        }

        /// <summary>
        /// Reads the file into the array
        /// </summary>
        private void ReadList()
        {
            _wordList = new string[NumberWords];

            try
            {
                using (StreamReader input = File.OpenText(WordFile))
                    for (int i = 0; i < _wordList.Length; i++)
                        _wordList[i] = input.ReadLine().Trim();
            }
            catch (Exception e)
            {
                MessageBox.Show("The following exception occurred:\n" + e.Message + "\n" + e.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Builds a Queue of chars from the given string
        /// </summary>
        /// <param name="s">String to generate queue from</param>
        /// <returns>queue of chars from given string</returns>
        private Queue<char> BuildQueue(string s)
        {
            return new Queue<char>(s);
        }

        private StringBuilder BuildStringBuilder(ConsList<string> s)
        {
            //while(s.Tail
            return null;
        }

        /// <summary>
        /// Gets anagrams with certain permutations
        /// </summary>
        /// <param name="prefixComplete">A phrase of complete words to be used a prefix; </param>
        /// <param name="prefixPart">A prefix of a word to follow the above phrase; and </param>
        /// <param name="text">The characters from which each anagram will be completed. </param>
        private void GetAnagrams(string prefixComplete, string prefixPart, string text)
        {
            if (text == "")
            {
                if (ContainsWord(prefixPart)) 
                {
                    prefixComplete += " " + prefixPart;
                    uxListBox.Items.Add(prefixComplete);
                }
                else if (prefixPart == "")
                {
                    uxListBox.Items.Add(prefixComplete);
                }
            }
            else
            {
                if(ContainsWord(prefixPart))
                        GetAnagrams(prefixComplete + " " + prefixPart, "", text);
                for (int i = 0; i < text.Length; i++)
                    GetAnagrams(prefixComplete, prefixPart + text[i], text.Substring(0, i) + text.Substring(i + 1));
            }
        }

        /// <summary>
        /// Does a binary search for the word
        /// </summary>
        /// <param name="word">Word to find</param>
        /// <returns>True/False depending on if it was found</returns>
        private bool ContainsWord(string word)
        {
            int start = 0;
            int end = _wordList.Length;
            // Invariant: For 0 <= i < start, _names[i] < name, and
            // for end <= i < _names.Length, _names[i] > name.
            while (start < end)
            {
                int mid = (start + end) / 2;
                int compResult = word.CompareTo(_wordList[mid]);
                if (compResult < 0)
                {
                    end = mid;
                }
                else if (compResult == 0)
                {
                    return true;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return false;
        }

        /// <summary>
        /// Handles the event when the search button is hit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFindAnagrams_Click(object sender, EventArgs e)
        {
            uxListBox.Items.Clear();
            uxString.Text = uxString.Text.ToLower();
            GetAnagrams("", "", uxString.Text);
            uxAnagramCount.Text = "" + uxListBox.Items.Count;         
        }
    }
}
