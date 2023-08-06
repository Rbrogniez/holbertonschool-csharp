using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int NumberItem = aQueue.Count;
        Console.WriteLine("Number of items: "+ NumberItem);

        if (aQueue.Count > 0)
        {
            string TopQueue = aQueue.Peek();
            Console.WriteLine("First item: " + TopQueue);
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        aQueue.Enqueue(newItem);

        bool containsSearched = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearched}");

        if (aQueue.Contains(search))
        {
            while(aQueue.Dequeue() != search)
            {
                continue;
            }
        }

        return aQueue;
    }
}
