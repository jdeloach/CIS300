﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RodHowell.Cis300.ConsList;
using KansasStateUniversity.TreeViewer2;

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
        /// A binary tree of found anagrams
        /// </summary>
        private StringSet FoundAnagrams = new StringSet();

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
                        _wordList[i] = input.ReadLine();                             
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace,
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

        /// <summary>
        /// Builds a string builder from a cons list
        /// </summary>
        /// <param name="s">ConsList of prefix's</param>
        /// <returns>A stringbuilder with spaces seperating prefixes</returns>
        private string BuildStringBuilder(ConsList<string> s)
        {
            StringBuilder st = new StringBuilder();
            while (s != null)
            {
                st.Append(s.Head + " ");
                s = s.Tail;
            }
            return st.ToString();
        }
        
        /// <summary>
        /// Compares a string builder to a string for equality
        /// </summary>
        /// <param name="builder">String builder used to compare</param>
        /// <param name="s">String used to compare</param>
        /// <returns>Negative if builder is shorter, positive if builder is longer, 0 if equal.</returns>
        private int CompareStringBuilder(StringBuilder builder, string s)
        {
            char[] builderArray = builder.ToString().ToCharArray();
            char[] stringArray = s.ToCharArray();

            int shorter = Math.Min(builder.Length, s.Length);

            for (int i = 0; i < shorter; i++)
            {
                if (builderArray[i] != stringArray[i])
                    return builderArray[i] - stringArray[i];
            }

            return builder.Length - s.Length;
        }

        /// <summary>
        /// Gets anagrams with certain permutations
        /// </summary>
        /// <param name="prefixComplete">A phrase of complete words to be used a prefix; </param>
        /// <param name="prefixPart">A prefix of a word to follow the above phrase; and </param>
        /// <param name="text">The characters from which each anagram will be completed. </param>
        private void GetAnagrams(ConsList<string> prefixComplete, StringBuilder prefixPart, Queue<char> text)
        {
            if (text.Count == 0)
            {
                if (ContainsWord(prefixPart)) 
                {
                    prefixComplete = new ConsList<string>(prefixPart.ToString(), prefixComplete);
                    FoundAnagrams.Add(BuildStringBuilder(prefixComplete).ToString());
                }
                else if (prefixPart.Length == 0)
                {
                    FoundAnagrams.Add(BuildStringBuilder(prefixComplete).ToString());
                }
            }
            else
            {
                if(ContainsWord(prefixPart))
                    GetAnagrams(new ConsList<string>(prefixPart.ToString(), prefixComplete), new StringBuilder(""), text);
                for (int i = 0; i < text.Count; i++)
                {
                    char character = text.Dequeue();
                    GetAnagrams(prefixComplete, prefixPart.Append(character), text);
                    text.Enqueue(character);
                    prefixPart.Remove(prefixPart.Length - 1, 1);
                }
            }
        }

        /// <summary>
        /// Does a binary search for the word
        /// </summary>
        /// <param name="word">Word to find</param>
        /// <returns>True/False depending on if it was found</returns>
        private bool ContainsWord(StringBuilder word)
        {
            int start = 0;
            int end = _wordList.Length;

            while (start < end)
            {
                int mid = (start + end) / 2;

                if (CompareStringBuilder(word, _wordList[mid]) > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            if (0 <= start && start <= _wordList.Length - 1)
                if (_wordList[start] == word.ToString())
                    return true;

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
            FoundAnagrams = new StringSet();
            uxString.Text = uxString.Text.ToLower();
            GetAnagrams(new ConsList<string>("", null), new StringBuilder(""), BuildQueue(uxString.Text.Trim()));
            FoundAnagrams.AddAll(uxListBox.Items);

            TreeForm form = new TreeForm(FoundAnagrams, 100);
            form.Text = uxString.Text;
            form.Show();

            uxAnagramCount.Text = "" + uxListBox.Items.Count;         
        }
        
        /// <summary>
        /// Deals with a failure to load file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAnagrams_Load(object sender, EventArgs e)
        {
            if (_wordList[_wordList.Length - 1] == null)
            {
                Application.Exit();
            }
        }
    }
}
