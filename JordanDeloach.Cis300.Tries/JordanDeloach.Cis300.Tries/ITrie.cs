using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.Tries
{
    /// <summary>
    /// An interface containing the outline for a Trie.
    /// </summary>
    interface ITrie
    {
        /// <summary>
        /// Adds a given word to the ITrie
        /// </summary>
        /// <param name="word">Word to add</param>
        /// <returns>Returns a new trie with the word added</returns>
        ITrie Add(string word);

        /// <summary>
        /// Returns a ITrie with all of the continuations of character
        /// </summary>
        /// <param name="c">Character to return continuations of</param>
        /// <returns>ITrie with continuation of given character</returns>
        ITrie Continuations(char c);

        /// <summary>
        /// Determines if the try is empty.
        /// </summary>
        /// <returns>Bool if empty or not.</returns>
        bool IsEmpty();
    }
}
