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

namespace JordanDeLoach.Cis300.Tries
{
    /// <summary>
    /// A GUI for a program that finds multi-word anagrams.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The size of the dictionary.
        /// </summary>
        private const int _dictionarySize = 81539;

        /// <summary>
        /// The dictionary.
        /// </summary>
        private ITrie trie = new NoChildren();

        /// <summary>
        /// Number of words in Trie.
        /// </summary>
        private int _wordsRead;

        /// <summary>
        /// The file where the dictionary should be found.
        /// </summary>
        private const string _dictionaryFile = "dictionary.txt";

        /// <summary>
        /// Character to incides map
        /// </summary>
        private CharMap _map;

        /// <summary>
        /// Dictionary for the hash table.
        /// </summary>
        private Dictionary<Key, ImmutableTrie> _dictionary;

        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            GetDictionary();
        }

        /// <summary>
        /// Reads the dictionary.
        /// </summary>
        private void GetDictionary()
        {
            try
            {
                using (StreamReader input = File.OpenText(_dictionaryFile))
                {
                    for (int i = 0; i < _dictionarySize; i++)
                    {
                        trie = trie.Add(input.ReadLine());
                        _wordsRead++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles a Load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInterface_Load(object sender, EventArgs e)
        {
            if (_dictionarySize != _wordsRead)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Handles a Find event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFind_Click(object sender, EventArgs e)
        {
            uxAnagrams.Items.Clear();
            _dictionary = new Dictionary<Key, ImmutableTrie>();

            if (uxInput.Text == "")
                uxNumber.Text = "0";
            else
            {
                try
                {
                    _map = new CharMap(uxInput.Text.ToLower().ToCharArray());
                    ImmutableTrie results = FindAnagrams(trie, GetQueue(uxInput.Text.ToLower().ToCharArray()));
                    if (results != null)
                        results.CopyToList(uxAnagrams.Items);    
                    uxNumber.Text = uxAnagrams.Items.Count.ToString();
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show("Text can only be lower case letters. " + ae.Message);
                }
            }
        }

        /// <summary>
        /// Forms a queue from the characters in the given string.
        /// </summary>
        /// <param name="s">The string from which the queue is to be 
        /// derived.</param>
        /// <returns>A queue containing the characters of s.</returns>
        private Queue<char> GetQueue(char[] chars)
        {
            Queue<char> q = new Queue<char>();
            foreach (char c in chars)
            {
                q.Enqueue(c);
            }
            return q;
        }

        /// <summary>
        /// Finds all permutations of chars that form multiword
        /// anagrams when the first word is prefixed by wordPrefix.
        /// For each of these permutations, adds the words in phrasePrefix
        /// appended by the permutation to StringSet, with the word order
        /// reversed.
        /// </summary>
        /// <param name="phrasePrefix">The phrase to prefix 
        /// each anagram with.</param>
        /// <param name="wordPrefix">The string to include as
        /// the prefix for the first word in each anagram.</param>
        /// <param name="chars">The characters for which to find
        /// anagrams.</param>
        private ImmutableTrie FindAnagrams(ITrie lastWord, Queue<char> chars)
        {
            if (lastWord == null)
                return null;

            ImmutableTrie[] tries = new ImmutableTrie[_map.CharacterCount];
            bool nonNull = false;

            if (chars.Count == 0)
            {
                if (lastWord.IsEmpty())
                {
                    Key k = new Key(chars, _map);
                    ImmutableTrie result = null;
                    if (_dictionary.TryGetValue(k, out result))
                    {
                        tries[_map.GetLocation(' ')] = result;
                    }
                    else
                    {
                        tries[_map.GetLocation(' ')] = new ImmutableTrie(new ImmutableTrie[0], true, _map);
                        _dictionary.Add(k, tries[_map.GetLocation(' ')]);
                    }
                    if(tries[_map.GetLocation(' ')] != null)
                        nonNull = true;
                }
                else //if (prefix.Length == 0)
                    return null;
                    //_anagrams.Add("");
            }
            else
            {
                if (lastWord.IsEmpty())
                {
                    //char x = chars.Dequeue();
                    tries[_map.GetLocation(' ')] = FindAnagrams(trie, chars);
                    if (tries[_map.GetLocation(' ')] != null)
                        nonNull = true;
                    //chars.Enqueue(x);
                    //tries[_map.GetLocation(' ')] = new ImmutableTrie(new ImmutableTrie[0], true, _map);
                }
                char c = 'Z';
                for (int i = 0; i < chars.Count; i++)
                {
                    //if (c == chars.Peek())
                      //  continue;
                    c = chars.Dequeue();
                    tries[_map.GetLocation(c)] = FindAnagrams(lastWord.Continuations(c), chars);
                    if (tries[_map.GetLocation(c)] != null)
                        nonNull = true;
                    chars.Enqueue(c);
                }
            }
            if(nonNull)
                return new ImmutableTrie(tries, false, _map);
            return null;
        }

        /// <summary>
        /// Concatenates the given words into a single string in reverse
        /// order, separated by blanks and terminated by a blank. 
        /// </summary>
        /// <param name="words">The words to concatenate</param>
        /// <returns>The resulting phrase.</returns>
        private string FormPhrase(ConsList<string> words)
        {
            StringBuilder s = new StringBuilder();
            for (ConsList<string> p = words; p != null; p = p.Tail)
            {
                s.Append(p.Head);
                s.Append(' ');
            }
            return s.ToString();
        }

        /// <summary>
        /// Compares the given StringBuilder and String.
        /// </summary>
        /// <param name="sb">The StringBuilder to compare.</param>
        /// <param name="s">The string to compare.</param>
        /// <returns>A negative value if sb is less than s, 0 if they are
        /// equal, and a positive value if sb is greater than s.</returns>
        private int Compare(StringBuilder sb, string s)
        {
            for (int i = 0; i < sb.Length && i < s.Length; i++)
            {
                if (sb[i] != s[i])
                {
                    return sb[i] - s[i];
                }
            }
            return sb.Length - s.Length;
        }
    }
}
