using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.Tries
{
    class MultipleChildren : ITrie
    {
        private ITrie[] _children;
        private bool _containsEmptyString;

        /// <summary>
        /// Constructs a multipleChildren trie.
        /// </summary>
        /// <param name="label">The char of the already created Trie</param>
        /// <param name="oneChild">Trie already existing</param>
        /// <param name="st">String requiring a new trie to be build</param>
        /// <param name="emptyString">Boolean on if this is an empty string</param>
        public MultipleChildren(char label, ITrie oneChild, string st, bool emptyString)
        {
            _children = new ITrie[26];
            _containsEmptyString = emptyString;

            _children[label - 'a'] = oneChild;
            _children[st[0] - 'a'] = new NoChildren();
            _children[st[0] - 'a'] = _children[st[0] - 'a'].Add(st.Substring(1));
        }

        public ITrie Add(string word)
        {
            if (word == "")
            {
                _containsEmptyString = true;
                return this;
            }
            else if (_children[word[0] - 'a'] == null)
            {
                _children[word[0] - 'a'] = new NoChildren();
                _children[word[0] - 'a'] = _children[word[0] - 'a'].Add(word.Substring(1));

                return this;
            }
            else
            {
                _children[word[0] - 'a'] = _children[word[0] - 'a'].Add(word.Substring(1));

                return this;
            }
        }

        public ITrie Continuations(char c)
        {
            if( c <= 'z' && c >= 'a' )
                return _children[c - 'a'];
            return null;
        }

        public bool IsEmpty()
        {
            return _containsEmptyString;
        }
    }
}
