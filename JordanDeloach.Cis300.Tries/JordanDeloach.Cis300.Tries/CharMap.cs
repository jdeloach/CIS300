using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.Tries
{
    struct CharMap
    {
        /// <summary>
        /// The index half of the map
        /// </summary>
        private int[] _indexes;
        
        /// <summary>
        /// The char half of the map
        /// </summary>
        private List<char> _charMap;

        /// <summary>
        /// Gets the Count of the List of Chars
        /// </summary>
        public int CharacterCount
        {
            get
            {
                return _charMap.Count;
            }
        }

        /// <summary>
        /// Constructor for Map
        /// </summary>
        /// <param name="charsToMap">Chars in word that need mapped</param>
        public CharMap(char[] charsToMap)
        {
            try
            {
                Array.Sort(charsToMap);
                _charMap = new List<char>();
                _charMap.Add(' ');
                _indexes = new int[26];

                foreach (char c in charsToMap)
                {
                    if (c == ' ')
                        throw new ArgumentException("Spaces are not a valid character.");

                    if (c != _charMap[_charMap.Count - 1])
                    {
                        _indexes[c - 'a'] = _charMap.Count;
                        _charMap.Add(c);
                    }
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                throw new ArgumentException("Chars can only be lower case.");
            }
        }

        /// <summary>
        /// Gets a char at a specific spot
        /// </summary>
        /// <param name="spot">Spot to look for char</param>
        /// <returns>Char at given spot</returns>
        public char GetChar(int spot)
        {
            return _charMap[spot];
        }

        /// <summary>
        /// Gets location of a specific character
        /// </summary>
        /// <param name="c">Character to retrieve spot of</param>
        /// <returns>Spot of character</returns>
        public int GetLocation(char c)
        {
            if (c == ' ')
                return 0;
            return _charMap.IndexOf(c);
        }
    }
}
