using System;
using System.Collections.Generic;

namespace DSReview
{
    // Stack of Generic objects
    public class CustomStack<T> {
        private Node<T> top;

        // Empty constructor
        public CustomStack() {
            top = null;
        }

        // Constructor with data
        public CustomStack(T input) {
            top = new Node<T>(input);
        }

        // Push an element to the top of the Stack
        public void push(T input) {
            if(top == null) {
                top = new Node<T>(input);
            }
            else {
                Node<T> newNode = new Node<T>(input);
                newNode.next = top;
                top = newNode;
            }
        }
    }
}