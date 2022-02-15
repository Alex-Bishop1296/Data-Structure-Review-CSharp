using System;

namespace DSReview
{
    /// <summary>
    /// A queue of elements, follows first in, first out (FIFO) structure operation
    /// </summary>
    /// <typeparam name="T">Object Type past in at time of implementation</typeparam>
    class CustomQueue<T> {
        // Need pointers to first and last of the queue for operations
        private DLNode<T> first;
        private DLNode<T> last;

        // Empty Constructor
        public CustomQueue() {
            first = null;
            last = null;
        }

        // Constructor with starter data
        public CustomQueue(T input) {
            first = new DLNode<T>(input);
            last = first;
        }

        /// <summary>
        /// Check if the queue is empty
        /// </summary>
        /// <returns>True if empty, False if not</returns>
        public bool isEmpty() {
            // There will always be a start and end to queue if it is non-empty, so we don't need to look at both
            if(first == null) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Put an element at the start of the queue
        /// </summary>
        /// <param name="input">item to place at start of queue</param>
        public void enqueue(T input) {
            // Case 1: queue is empty
            DLNode<T> newNode = new DLNode<T>(input);
            if(isEmpty()) {
                // Start and End are now the same
                first = newNode;
                last = newNode;
            }
            // Case 2: queue has items
            else {
                // Append the new node to the last of the queue
                last.next = newNode;
                newNode.prev = last;
                last = last.next;
            }
        }

        /// <summary>
        /// Return the data from the element at the end of the queue and remove that element from the queue
        /// </summary>
        /// <returns>Value of the element that was at the end of the queue</returns>
        public T dequeue() {
            // Case 1: Queue empty, can't dequeue
            if(isEmpty()) {
                return default(T);
            }
            else {
                // Get data in element at end of queue
                T dequeuedData = first.data;
                // Assign new first in the queue
                first = first.next;
                // Clear dequeued node's pointers
                first.prev.next = null;
                // Remove dequeued node
                first.prev = null;
                return dequeuedData;
            }
        }

        /// <summary>
        /// Return a copy of the current item first in queue
        /// </summary>
        /// <returns>top.data or default return of object if queue us empty</returns>
        public T peek() {
            if (isEmpty()) {
                return default(T);
            }
            return first.data;
        }

        /// <summary>
        /// Return the number of objects in the queue
        /// </summary>
        /// <returns>int containing count of objects in the queue</returns>
        public int count() {
            int queueTotal = 0;
            DLNode<T> currNode = first;
            // Covers both Case 1 and 2; if stack is empty this code keep queue total at zero
            while(currNode != null) {
                queueTotal++;
                currNode = currNode.next;
            }
            return queueTotal;
        }

        /// <summary>
        /// Print Queue to console
        /// </summary>
        public void printQueueToConsole() {
            DLNode<T> currNode = first;
            // Covers both Case 1 and 2; if stack is empty this code will print nothing
            while(currNode != null) {
                Console.Write("{0} ", currNode.data.ToString());
                currNode = currNode.next;
            }
            Console.WriteLine();
        }
    }
}