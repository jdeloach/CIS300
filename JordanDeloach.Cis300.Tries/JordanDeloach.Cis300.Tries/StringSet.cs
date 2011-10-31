using System;
using System.Collections;
using System.Linq;
using System.Text;
using KansasStateUniversity.TreeViewer2;

namespace JordanDeLoach.Cis300.Tries
{
    /// <summary>
    /// A set of strings implemented using a binary search
    /// tree that can be displayed.
    /// </summary>
    class StringSet : ITree
    {
        /// <summary>
        /// The elements of the set.
        /// </summary>
        private BinaryTreeNode<string> _elements 
            = new BinaryTreeNode<string>();

        /// <summary>
        /// Gets the children of the root.
        /// </summary>
        public ITree[] Children
        {
            get 
            {
                return _elements.Children;
            }
        }

        /// <summary>
        /// Gets whether the tree is empty.
        /// </summary>
        public bool IsEmpty
        {
            get 
            {
                return _elements.IsEmpty;
            }
        }

        /// <summary>
        /// Gets the root of the tree.
        /// </summary>
        public object Root
        {
            get 
            {
                return _elements.Root;
            }
        }

        /// <summary>
        /// Adds the given string to the set.  If the
        /// set already contains this string, the set is
        /// unchanged.
        /// </summary>
        /// <param name="s">The string to be added.</param>
        public void Add(string s)
        {
            Add(s, _elements);
        }

        /// <summary>
        /// Adds the given string to the given tree.  The
        /// tree must be a binary search tree. If the given
        /// tree already contains s, it is unchanged. 
        /// </summary>
        /// <param name="s">The string to be added.</param>
        /// <param name="t">The tree to which s is to be
        /// added.</param>
        private void Add(string s, BinaryTreeNode<string> t)
        {
            if (t.IsEmpty)
            {
                t.IsEmpty = false;
                t.RootValue = s;
                t.LeftChild = new BinaryTreeNode<string>();
                t.RightChild = new BinaryTreeNode<string>();
            }
            else
            {
                int compResult = s.CompareTo(t.RootValue);
                if (compResult < 0)
                {
                    Add(s, t.LeftChild);
                }
                else if (compResult > 0)
                {
                    Add(s, t.RightChild);
                }
            }
        }

        /// <summary>
        /// Copies the elements of the set, in alphabetic
        /// order, to the end of the given IList.
        /// </summary>
        /// <param name="list">The IList to which the
        /// elements are to be copied.</param>
        public void CopyTo(IList list)
        {
            CopyTo(_elements, list);
        }

        /// <summary>
        /// Copies the contents of the given tree to the
        /// end of the given IList using an inorder traversal.
        /// </summary>
        /// <param name="t">The tree to copy.</param>
        /// <param name="list">The IList to which t is to be
        /// copied.</param>
        private void CopyTo(BinaryTreeNode<string> t, IList list)
        {
            if (!t.IsEmpty)
            {
                CopyTo(t.LeftChild, list);
                list.Add(t.RootValue);
                CopyTo(t.RightChild, list);
            }
        }
    }
}
