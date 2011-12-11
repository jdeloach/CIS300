using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KansasStateUniversity.TreeViewer2;

/// Code written by Dr. Howell. Copied from Assignment 7.
namespace JordanDeLoach.Cis300.FileCompressor
{
    /// <summary>
    /// A single node of a generic binary tree that can be
    /// displayed. 
    /// </summary>
    ///
    /// <typeparam name="T">The type of the data in the
    /// tree.</typeparam>
    class BinaryTreeNode<T> : ITree
    {
        /// <summary>
        /// The children of this node.
        /// </summary>
        private BinaryTreeNode<T>[] _children
            = new BinaryTreeNode<T>[2];

        /// <summary>
        /// Gets the children of this node.
        /// </summary>
        public ITree[] Children
        {
            get
            {
                return _children;
            }
        }

        /// <summary>
        /// Gets or sets the left child of this node.
        /// </summary>
        public BinaryTreeNode<T> LeftChild
        {
            get
            {
                return _children[0];
            }
            set
            {
                _children[0] = value;
            }
        }

        /// <summary>
        /// Gets or sets the right child of this node.
        /// </summary>
        public BinaryTreeNode<T> RightChild
        {
            get
            {
                return _children[1];
            }
            set
            {
                _children[1] = value;
            }
        }

        /// <summary>
        /// Indicates whether this tree is empty.
        /// </summary>
        private bool _isEmpty = true;

        /// <summary>
        /// Gets or sets whether the tree rooted at this node is
        /// empty. Always returns false.
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return _isEmpty;
            }
            set
            {
                _isEmpty = value;
            }
        }

        /// <summary>
        /// The root of this node.
        /// </summary>
        private T _root;

        /// <summary>
        /// Gets the root of this node.
        /// </summary>
        public object Root
        {
            get
            {
                return _root;
            }
        }

        /// <summary>
        /// Gets or sets the root of this node.
        /// </summary>
        public T RootValue
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
    }
}
