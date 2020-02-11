using System;
using System.Collections.Generic;

class MyQueue
{
    public static
     Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        bool hasSearch = aQueue.Contains(search);
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        Console.WriteLine("First item: {0}", aQueue.Peek());
        aQueue.Enqueue(newItem);
        Console.WriteLine("Queue contains \"{0}\": {1}",
        search,
        hasSearch
        );

        if (hasSearch)
        {
            int upTo = 0;
            foreach (string i in aQueue)
            {
                upTo++;
                if (i == search)
                    break;
            }
            for (int i = 0; i < upTo; i++)
            {
                aQueue.Dequeue();
            }
        }
        return aQueue;
    }
}