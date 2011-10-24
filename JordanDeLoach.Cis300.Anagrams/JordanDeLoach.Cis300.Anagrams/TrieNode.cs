using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.Anagrams
{
    class TrieNode
    {
        private char _data;
        private Boolean _contains;
        private TrieNode[] _children;

        public TrieNode() {
        }

        public char Data {
            get 
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public Boolean Contains {
            get
            {
                return _contains;
            }
            set
            {
                _contains = value;
            }
        }
        
        public TrieNode[] Children {
            get 
            {
                return _children;
            }
            set
            {
                _children = value;
            }
        }
    }
}
