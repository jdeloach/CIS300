using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.FileCompressor
{
    /// <summary>
    /// A MinPriority Queue generic implementation.
    /// </summary>
    /// <typeparam name="T">Type to use store with priority</typeparam>
    class MinPriorityQueue<T>
    {
        /// <summary>
        /// Root node of the priority tree
        /// </summary>
        private BinaryTreeNode<Tuple<long, T>> _rootNode = null;

        /// <summary>
        /// Number of elements in queue
        /// </summary>
        private int _numberElements = 0;

        /// <summary>
        /// Gets the current count of the queue.
        /// </summary>
        public int Count
        {
            get
            {
                return _numberElements;
            }   
        }

        /// <summary>
        /// Returns the LowestPriority on the list, not removing it.
        /// </summary>
        public long LowestPriority
        {
            get
            {
                if (_rootNode.LeftChild != null || _rootNode.RightChild != null || _rootNode.RootValue != null)
                {
                    return _rootNode.RootValue.Item1;
                }
                else
                    throw new InvalidOperationException("MinPriorityQueue is empty, no lowest priority to remove.");
            }
        }

        /// <summary>
        /// Merges to heaps into one, can be used for adding.
        /// </summary>
        /// <param name="heap1">First heap to add</param>
        /// <param name="heap2">Second heap to add</param>
        /// <returns>Resulting merged root</returns>
        private static BinaryTreeNode<Tuple<long, T>> Merge(BinaryTreeNode<Tuple<long, T>> heap1, BinaryTreeNode<Tuple<long, T>> heap2)
        {
            if (heap1 == null)
                return heap2;
            if (heap2 == null)
                return heap1;

            BinaryTreeNode<Tuple<long, T>> result = new BinaryTreeNode<Tuple<long,T>>();

            if (heap1.RootValue.Item1 > heap2.RootValue.Item1)
            {
                result.RootValue = heap2.RootValue;
                result.RightChild = Merge(heap2.LeftChild, heap1);
                result.LeftChild = heap2.RightChild;
                return result;
            }
            else
            {
                result.RootValue = heap1.RootValue;
                result.RightChild = Merge(heap1.LeftChild, heap2);
                result.LeftChild = heap1.RightChild;
                return result;
            }
        }

        /// <summary>
        /// Adds an element to the queue
        /// </summary>
        /// <param name="element">Element to keep at the priority</param>
        /// <param name="priority">Priority of the element</param>
        public void AddElement(T element, long priority)
        {
            BinaryTreeNode<Tuple<long, T>> add = new BinaryTreeNode<Tuple<long,T>>();
            add.RootValue = new Tuple<long,T>(priority, element);
            if (_rootNode != null)
                _rootNode = Merge(_rootNode, add);
            else
                _rootNode = add;
            _numberElements++;
        }

        /// <summary>
        /// Removes the lowest priority, and returns the element associated with it.
        /// </summary>
        /// <returns>Lowest priority element is returned.</returns>
        public T RemoveLowestPriority()
        {
            T result;

            if (_rootNode.LeftChild != null || _rootNode.RightChild != null || _rootNode != null)
            {
                result = _rootNode.RootValue.Item2;
                _rootNode = Merge(_rootNode.LeftChild, _rootNode.RightChild);
                _numberElements--;
                return result;
            }
            else
                throw new InvalidOperationException("MinPriorityQueue is empty, no lowest priority to remove.");
        }
    }
}
