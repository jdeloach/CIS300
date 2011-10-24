using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KansasStateUniversity.TreeViewer2;

namespace JordanDeLoach.Cis300.Anagrams
{
    class GenericBinaryTreeNode<T> : ITree
    {
        /// <summary>
        /// The root value of the tree.
        /// </summary>
        private T _root;

        /// <summary>
        /// The children of this tree, as ITree's
        /// </summary>
        private GenericBinaryTreeNode<T>[] _children = new GenericBinaryTreeNode<T>[2];

        /// <summary>
        /// A boolean determing if the tree is empty, or has children.
        /// </summary>
        private bool _empty = true;

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        public ITree[] Children
        {
            get 
            { 
                return _children; 
            }
        }

        /// <summary>
        /// Gets or sets the boolean value, IsEmpty
        /// </summary>
        public bool IsEmpty
        {
            get 
            {
                return _empty;
            }
            set
            {
                _empty = value;
            }
        }

        /// <summary>
        /// Gets or sets the root object in object form
        /// </summary>
        public object Root
        {
            get 
            { 
                return _root; 
            }
            set
            {
                _root = (T) value;
            }
        }

        /// <summary>
        /// Gets or sets the root as the correct type.
        /// </summary>
        public T RootTyped
        {
            get
            {
                return _root;
            }
            set
            {
                _root = value;
            }
        }

        /// <summary>
        /// Gets or sets the Right Child
        /// </summary>
        public GenericBinaryTreeNode<T> RightChild
        {
            get
            {
                return _children[1];
            }
            set
            {
                Children[1] = value;
            }
        }

        /// <summary>
        /// Gets or sets the left child.
        /// </summary>
        public GenericBinaryTreeNode<T> LeftChild
        {
            get
            {
                return _children[0];
            }
            set
            {
                Children[0] = value;
            }
        }
    }
}
