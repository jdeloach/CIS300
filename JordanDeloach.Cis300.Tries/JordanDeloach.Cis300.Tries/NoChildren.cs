using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.Tries
{
    class NoChildren : ITrie
    {
        private bool _containsEmptyString = false;

        public ITrie Add(string word)
        {
            if (word == "")
            {
                _containsEmptyString = true;
                return this;
            }
            else
            {
                return new OneChild(word, _containsEmptyString);
            }

        }

        public ITrie Continuations(char c)
        {
            return null;
        }

        public bool IsEmpty()
        {
            return _containsEmptyString;
        }
    }
}
