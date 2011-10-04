using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.Queue
{
    public class Queue<T>
    {
        /// <summary>
        /// The number of elements in the queue.
        /// </summary>
        private int _count;

        /// <summary>
        /// Blank cell at the top of the queue
        /// </summary>
        private LinkedListCell<T> _front = new LinkedListCell<T>();

        /// <summary>
        /// Blank cell at bottom of queue
        /// </summary>
        private LinkedListCell<T> _end = new LinkedListCell<T>();


        /// <summary>
        /// Gets the number of elements in the queue.
        /// </summary>
        public int Count
        {
            get
            {
                return _count;
            }
        }
            
        public Queue()
        {
            Clear();

        }

        /// <summary>
        /// Adds the item to the queue.
        /// </summary>
        /// <param name="x">Item to enqueue</param>
        public void Enqueue(T x)
        {
            LinkedListCell<T> y = new LinkedListCell<T>();
            y.Data = x;
            y.Next = _end;

            if (_end.Previous == _front)
            {
                y.Previous = _front;
                _front.Next = y;
            }
            else
            {
                y.Previous = _end.Previous;
                y.Previous.Next = y;
            }

            _end.Previous = y;
            _count++;
        }

        /// <summary>
        /// Returns element at top
        /// </summary>
        /// <returns>Top element</returns>
        public T Peek()
        {
            if (_count == 0)
                throw new InvalidOperationException("The Queue is empty.");

            return _front.Next.Data;
        }

        /// <summary>
        /// Removes top element
        /// </summary>
        /// <returns>Top element</returns>
        public T Dequeue()
        {
            T x = Peek();
            _front.Next = _front.Next.Next;
            _front.Next.Previous = _front;
            _count--;
            return x;
        }

        /// <summary>
        /// Clears the queue and resets the count.
        /// </summary>
        private void Clear()
        {
            _front.Next = _end;
            _end.Previous = _front;
            _count = 0;
        }
    }
}
