// Generic Node class for use in single-linked list and similar Data Structures
using System;
using System.Collections.Generic;

namespace DSReview
{
    /// <summary>
    /// A doubly-linked node, points to the next node and the previous one
    /// </summary>
    /// <typeparam name="T">Generic Datatype, actual data type of defined node decided at implementation</typeparam>
    public class DLNode<T> {
        /// <summary>
        /// Data contained in the node, generic T allows data to be determined at implementation
        /// </summary>
        public T data;
        /// <summary>
        /// "Pointer" to the next node
        /// </summary>
        public DLNode<T> next;

        /// <summary>
        /// "Pointer" to the previous node
        /// </summary>
        public DLNode<T> prev;

        // Constructor
        public DLNode(T dataInput) {
            data = dataInput;
            next = null;
            prev = null;
        }        
    }
}