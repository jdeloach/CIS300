using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.Tries
{
    class OneChild : ITrie
    {

        private char _childLabel;
        private ITrie _child;
        private bool _containsEmptyString;

        public OneChild(string st, bool emptyString)
        {
            if (st == "")
                return;
            _containsEmptyString = emptyString;

            _childLabel = st[0];

            _child = new NoChildren();

            _child = _child.Add(st.Substring(1));
        }

        public ITrie Add(string word)
        {
            if (word == "")
            {
                _containsEmptyString = true;
                return this;
            }
            else if (word[0] == _childLabel)
            {
                _child = _child.Add(word.Substring(1));
                return this;
            }
            else
            {
                return new MultipleChildren(_childLabel, _child, word, _containsEmptyString);
            }

        }

        public ITrie Continuations(char c)
        {
            if (c == _childLabel)
                return _child;
            return null;
        }

        public bool IsEmpty()
        {
            return _containsEmptyString;
        }
    }
}
