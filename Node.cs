// Generic Node class for use in single-linked list and similar Data Structures
using System;
using System.Collections.Generic;

namespace DSReview
{
    public class Node<T> {
        // Using generic for data
        public T data;
        public Node<T> next;
        // Constructor
        public Node(T dataInput) {
            data = dataInput;
            next = null;
        }        
    }
}