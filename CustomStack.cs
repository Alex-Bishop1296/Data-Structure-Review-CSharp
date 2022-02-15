using System;
using System.Collections.Generic;

namespace DSReview
{
    /// <summary>
    /// A stack of elements, follows last in, first out (LIFO) structure operation
    /// </summary>
    /// <typeparam name="T">Type past in at time of implementation</typeparam>
    public class CustomStack<T> {
        /// <summary>
        /// Top of the stack, the starting point of all operations with the data type
        /// </summary>
        private Node<T> top;

        // Empty constructor
        public CustomStack() {
            top = null;
        }

        // Constructor with data
        public CustomStack(T input) {
            top = new Node<T>(input);
        }

        /// <summary>
        /// Push an element to the top of the stack
        /// </summary>
        /// <param name="input">element that will be put on the stack</param>
        public void push(T input) {
            // Case 1: Stack is empty
            if(top == null) {
                top = new Node<T>(input);
            }
            // Case 2: Stack has at least one item in it
            else {
                Node<T> newNode = new Node<T>(input);
                newNode.next = top;
                top = newNode;
            }
        }
        
        /// <summary>
        /// Pop an element off the stack and return it's value
        /// </summary>
        /// <returns>Generic Data or default of generic T</returns>
        public T pop() {
            // Case 1: stack is empty
            if(top == null) {
                // incase generic T is a non-nullable type, we use default return of generic T (null in most cases)
                return default(T);
            }
            // Case 2: stack is non-empty
            Node<T> currNode = top;
            top = top.next; // If there is no top.next, then stack is now empty and top == null
            return currNode.data;
        }

        /// <summary>
        /// Return a copy of the current item on top of the stack
        /// </summary>
        /// <returns>top.data or default return of object if stack is empty</returns>
        public T peek() {
            if (isEmpty()) {
                return default(T);
            }
            return top.data;
        }

        /// <summary>
        /// Start at the top of the stack and print all values in the stack to console
        /// </summary>
        public void printStack() {
            Node<T> currNode = top;
            // Covers both Case 1 and 2; if stack is empty this code will print nothing
            while(currNode != null) {
                Console.Write("{0} ", currNode.data.ToString());
                currNode = currNode.next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Return the number of objects on the stack
        /// </summary>
        /// <returns>int containing count of objects on the stack</returns>
        public int count() {
            int stackTotal = 0;
            Node<T> currNode = top;
            // Covers both Case 1 and 2; if stack is empty this code keep stack total at zero
            while(currNode != null) {
                stackTotal++;
                currNode = currNode.next;
            }
            return stackTotal;
        }

        /// <summary>
        /// Returns if the stack is empty or not
        /// </summary>
        /// <returns>bool that will return true if the stack is empty</returns>
        public bool isEmpty() {
            if(top == null) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}