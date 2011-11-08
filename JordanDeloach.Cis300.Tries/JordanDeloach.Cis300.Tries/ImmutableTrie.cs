using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.Tries
{
    class ImmutableTrie
    {
        /// <summary>
        /// Boolean wether it contains ' ' and if this is a word
        /// </summary>
        private bool _containsEmptyString;

        /// <summary>
        /// Array of children, whatever size it may be
        /// </summary>
        private ImmutableTrie[] _children;

        /// <summary>
        /// Map of chars to indices
        /// </summary>
        private CharMap _map;

        /// <summary>
        /// Constructor... creates new Trie with given properrties
        /// </summary>
        /// <param name="children">Children tries in tree</param>
        /// <param name="containsEmptyString">Boolean if it is a word</param>
        /// <param name="map">Map of Chars to Indices and vice versa to use</param>
        public ImmutableTrie(ImmutableTrie[] children, bool containsEmptyString, CharMap map)
        {
            _containsEmptyString = containsEmptyString;
            _map = map;

            _children = (ImmutableTrie[])children.Clone();
        }

        /// <summary>
        /// Copies tree to given IList
        /// </summary>
        /// <param name="list">IList to add on to</param>
        public void CopyToList(IList list)
        {
            CopyToList(list, new StringBuilder(), this);
        }

        /// <summary>
        /// Private method to implement adding to IList
        /// </summary>
        /// <param name="list">List to add to</param>
        /// <param name="builder">StringBuilder of prefixes</param>
        /// <param name="trie">Trie to add from</param>
        private static void CopyToList(IList list, StringBuilder builder, ImmutableTrie trie)
        {
            if (trie != null)
            {
                for (int i = 0; i < trie._children.Length; i++)
                {
                    builder.Append(trie._map.GetChar(i));
                    CopyToList(list, builder, trie._children[i]);
                    builder.Remove(builder.Length - 1, 1);
                }
                if (trie._containsEmptyString)
                    list.Add(builder.ToString());
            }
        }
    }
}
