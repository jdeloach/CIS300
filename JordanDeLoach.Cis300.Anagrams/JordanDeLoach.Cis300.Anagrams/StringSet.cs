using System;
using System.Collections;
using System.Linq;
using System.Text;
using KansasStateUniversity.TreeViewer2;

namespace JordanDeLoach.Cis300.Anagrams
{
    class StringSet : ITree
    {
        /// <summary>
        /// Binary Search Tree to parse
        /// </summary>
        private GenericBinaryTreeNode<string> _searchTree;
        
        /// <summary>
        /// Gets children of binary search tree
        /// </summary>
        public ITree[] Children
        {
            get
            {
                return _searchTree.Children;
            }
        }

        /// <summary>
        /// Gets boolean of empty or not for binary search tree
        /// </summary>
        public bool IsEmpty
        {
            get 
            {
                return _searchTree.IsEmpty;
            }
        }

        /// <summary>
        /// Gets root value of search tree
        /// </summary>
        public object Root
        {
            get
            {
                return _searchTree.Root;
            }
        }
        
        /// <summary>
        /// Constructor that defaults to empty binary search tree.
        /// </summary>
        public StringSet()
        {
            _searchTree = new GenericBinaryTreeNode<string>();
            _searchTree.IsEmpty = true;
        }

        /// <summary>
        /// Adds a string to the binary search tree
        /// </summary>
        /// <param name="st">String to add</param>
        public void Add(string st)
        {
            AddString(st, _searchTree);
            _searchTree.IsEmpty = false;
        }

        /// <summary>
        /// Implementation for adding a string to the binary search tree
        /// </summary>
        /// <param name="st">String to add</param>
        /// <param name="tree">Tree to add it to</param>
        private void AddString(string st, GenericBinaryTreeNode<string> tree)
        {
            if (tree.LeftChild == null || tree.RightChild == null)
            {
                GenericBinaryTreeNode<string> child1 = new GenericBinaryTreeNode<string>();
                GenericBinaryTreeNode<string> child2 = new GenericBinaryTreeNode<string>();

                tree.LeftChild = child1;
                tree.RightChild = child2;
            }

            if (tree.IsEmpty)
                tree.Root = st;
            else if (st.CompareTo(tree.RootTyped) > 0)
            {
                if (!tree.RightChild.IsEmpty)
                    AddString(st, tree.RightChild);
                else
                {
                    tree.RightChild = new GenericBinaryTreeNode<string>();
                    tree.RightChild.IsEmpty = false;
                    tree.RightChild.RootTyped = st;
                }
            }
            else if (st.CompareTo(tree.RootTyped) < 0)
            {
                if (!tree.LeftChild.IsEmpty)
                    AddString(st, tree.LeftChild);
                else
                {
                    tree.LeftChild = new GenericBinaryTreeNode<string>();
                    tree.LeftChild.IsEmpty = false;
                    tree.LeftChild.RootTyped = st;
                }
            }
            // if it matched... don't add it
        }

        /// <summary>
        /// Method for adding tree to given IList in alphabetical order
        /// </summary>
        /// <param name="strings">List of strings to append to</param>
        public void AddAll(IList strings)
        {
            AddAllStrings(strings, _searchTree);
        }

        /// <summary>
        /// Actual implementation of adding strings to given IList
        /// </summary>
        /// <param name="strings">Strings to add to</param>
        /// <param name="tree">Tree to add from</param>
        private void AddAllStrings(IList strings, GenericBinaryTreeNode<string> tree)
        {
            if(!tree.LeftChild.IsEmpty)
                AddAllStrings(strings, tree.LeftChild);
            strings.Add(tree.RootTyped);
            if (!tree.RightChild.IsEmpty)
                AddAllStrings(strings, tree.RightChild);
        }
    }
}
