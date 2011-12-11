using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.Tries
{
    class Key
    {
        /// <summary>
        ///  Map to use
        /// </summary>
        private CharMap _charmap;

        /// <summary>
        /// Array of occurances of certain character
        /// </summary>
        private byte[] _amountOccurances;

        /// <summary>
        /// Hash code represented by this class
        /// </summary>
        private int _hashCode;

        /// <summary>
        /// Consturcts a new Key
        /// </summary>
        /// <param name="chars">Chars in the word</param>
        /// <param name="charMap">Charmap mapping the chars to indices</param>
        public Key(Queue<char> chars, CharMap charMap)
        {
            _charmap = charMap;

            foreach (char c in chars)
            {
                char dequeued = chars.Dequeue();
                _amountOccurances[charMap.GetLocation(c)]++;

                chars.Enqueue(dequeued);
            }

            // Use polynomial hashing to compute the hash code.
            foreach (char c in chars)
            {
                unchecked
                {
                    _hashCode *= 35;
                    _hashCode += _amountOccurances[charMap.GetLocation(c)];
                }
            }
        }

        /// <summary>
        /// Compares two Keys
        /// </summary>
        /// <param name="x">Key1</param>
        /// <param name="y">Key2</param>
        /// <returns>True/False depending on equality</returns>
        public static bool operator ==(Key x, Key y)
        {
            bool pass = false;

            if (x._hashCode == y._hashCode)
                if (Equals(x, y))
                    for (int i = 0; i < x._amountOccurances.Length; i++)
                    {
                        pass = true;
                        if (x._amountOccurances[i] != y._amountOccurances[i])
                            pass = false;
                    }

            return pass;
        }

        /// <summary>
        /// Compares for inequallity
        /// </summary>
        /// <param name="x">Key1</param>
        /// <param name="y">Key2</param>
        /// <returns>True if unequal, false if equal</returns>
        public static bool operator !=(Key x, Key y)
        {
            return !(x == y);
        }

        /// <summary>
        /// Compares two keys for equality
        /// </summary>
        /// <param name="obj">Obj to compare against</param>
        /// <returns>True if equal, false if not</returns>
        public override bool Equals(object obj)
        {
            if (obj is Key)
            {
                // changed as to not be recursive
                return this._charmap.Equals(((Key)obj)._charmap) && this._amountOccurances == ((Key)obj)._amountOccurances;
            }
            else
            {
                return false;
            }
        }
    }
}
