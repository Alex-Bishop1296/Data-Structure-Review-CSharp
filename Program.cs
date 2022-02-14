using System;

namespace DSReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
            Console.WriteLine("Peaking at first value on stack: {0}", stackTest.peak().ToString());
            Console.WriteLine("Popped: '" + stackTest.pop() + "' off the stack.");
            Console.WriteLine("Stack size is: {0}", stackTest.count().ToString());
            Console.WriteLine("Peaking at first value on stack: {0}", stackTest.peak().ToString());
            Console.WriteLine("Popped: '" + stackTest.pop() + "' off the stack.");
            Console.WriteLine("Stack size is: {0}", stackTest.count().ToString());
            Console.WriteLine("Calling method to print stack");
            stackTest.printStack();
            Console.WriteLine("Stack empty check returns: {0}", stackTest.isEmpty().ToString());
        }
    }
}
