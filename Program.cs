using System;

namespace DSReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            queueTests();
        }

        static void stackTests() {
            // Test the Stack
            Console.WriteLine("Creating a stack of ints.");
            CustomStack<int> stackTest = new CustomStack<int>();
            Console.WriteLine("Pushing 1 to stack.");
            stackTest.push(1);
            Console.WriteLine("Popped: '" + stackTest.pop() + "' off the stack.");
            Console.WriteLine("Stack empty check returns: {0}", stackTest.isEmpty().ToString());
            Console.WriteLine("Pushing 1 through 5 to the stack");
            stackTest.push(1);
            stackTest.push(2);
            stackTest.push(3);
            stackTest.push(4);
            stackTest.push(5);
            Console.WriteLine("Calling method to print stack");
            stackTest.printStack();
            Console.WriteLine("Stack size is: {0}", stackTest.count().ToString());
            Console.WriteLine("Peeking at first value on stack: {0}", stackTest.peek().ToString());
            Console.WriteLine("Popped: '" + stackTest.pop() + "' off the stack.");
            Console.WriteLine("Stack size is: {0}", stackTest.count().ToString());
            Console.WriteLine("Peeking at first value on stack: {0}", stackTest.peek().ToString());
            Console.WriteLine("Popped: '" + stackTest.pop() + "' off the stack.");
            Console.WriteLine("Stack size is: {0}", stackTest.count().ToString());
            Console.WriteLine("Calling method to print stack");
            stackTest.printStack();
            Console.WriteLine("Stack empty check returns: {0}", stackTest.isEmpty().ToString());
        }

        static void queueTests() {
            Console.WriteLine("Creating a queue of strings");
            CustomQueue<string> queueTest = new CustomQueue<string>();
            Console.WriteLine("Queue size is: {0}", queueTest.count().ToString());
            Console.WriteLine("Queue empty check returns: {0}", queueTest.isEmpty().ToString());
            Console.WriteLine("Putting 'STR', 'DEX', 'CON', 'INT', 'WIS', and 'CHR' in Queue.");
            queueTest.enqueue("STR");
            queueTest.enqueue("DEX");
            queueTest.enqueue("CON");
            queueTest.enqueue("INT");
            queueTest.enqueue("WIS");
            queueTest.enqueue("CHR");
            Console.WriteLine("Queue size is: {0}", queueTest.count().ToString());
            Console.WriteLine("Queue empty check returns: {0}", queueTest.isEmpty().ToString());
            Console.WriteLine("Calling method to print queue");
            queueTest.printQueueToConsole();
            Console.WriteLine("Peeking at first value in queue: {0}", queueTest.peek().ToString());
            Console.WriteLine("Dequeuing: '" + queueTest.dequeue() + "' from the queue.");
            Console.WriteLine("Peeking at first value in queue: {0}", queueTest.peek().ToString());
            Console.WriteLine("Dequeuing: '" + queueTest.dequeue() + "' from the queue.");
            Console.WriteLine("Dequeuing: '" + queueTest.dequeue() + "' from the queue.");
            Console.WriteLine("Queue size is: {0}", queueTest.count().ToString());
            Console.WriteLine("Queue empty check returns: {0}", queueTest.isEmpty().ToString());
            Console.WriteLine("Calling method to print queue");
            queueTest.printQueueToConsole();
        }
    }
}
