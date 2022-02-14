// Generic Node class for use in single-linked list and similar Data Structures
using System;
using System.Collections.Generic;

namespace DSReview
{
    /// <summary>
    /// A single pointer node, points to the next node but has no reference to the previous one
    /// </summary>
    /// <typeparam name="T">Generic Datatype, actual data type of defined node decided at implementation</typeparam>
    public class Node<T> {
        /// <summary>
        /// Data contained in the node, generic T allows data to be determined at implementation
        /// </summary>
        public T data;
        /// <summary>
        /// "Pointer" to the next node
        /// </summary>
        public Node<T> next;
        // Constructor
        public Node(T dataInput) {
            data = dataInput;
            next = null;
        }        
    }
}