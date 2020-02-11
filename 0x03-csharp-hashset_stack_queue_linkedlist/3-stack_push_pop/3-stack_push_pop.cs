using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        bool hasSearch = aStack.Contains(search);
        Console.WriteLine("Number of items: {0}", aStack.Count);
        Console.WriteLine("Top item: {0}", aStack.Peek());
        Console.WriteLine("Stack contains {0}: {1}",
            search,
            hasSearch);

        if (hasSearch)
        {
            int upTo = 0;
            foreach(string i in aStack)
            {
                upTo++;
                if (i == search)
                    break;
            }
            for(int i = 0; i < upTo; i++)
            {
                aStack.Pop();
            }
        }

        
        aStack.Push(newItem);

        return aStack;

    }
}