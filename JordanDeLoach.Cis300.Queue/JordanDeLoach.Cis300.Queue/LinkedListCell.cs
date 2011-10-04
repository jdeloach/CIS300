using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JordanDeLoach.Cis300.Queue
{
    /// <summary>
    /// Cell of list
    /// </summary>
    /// <typeparam name="T">Element type</typeparam>
    public class LinkedListCell<T>
    {
        /// <summary>
        /// Data of element type
        /// </summary>
        private T _data;

        /// <summary>
        /// Gets/sets the data
        /// </summary>
        public T Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        /// <summary>
        /// Next cell that is stored
        /// </summary>
        private LinkedListCell<T> _next;

        /// <summary>
        /// Previous cell that is stored
        /// </summary>
        private LinkedListCell<T> _previous;

        /// <summary>
        /// Gets/sets next cell
        /// </summary>
        public LinkedListCell<T> Next
        {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }
        /// <summary>
        /// Gets/sets previous cell
        /// </summary>
        public LinkedListCell<T> Previous
        {
            get
            {
                return _previous;
            }
            set
            {
                _previous = value;
            }
        }
    }
}
