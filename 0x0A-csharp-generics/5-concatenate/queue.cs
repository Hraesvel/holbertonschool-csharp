using System;

/// <summary>
/// My implementation of Queue type
/// </summary>
/// <typeparam name="T">base type</typeparam>
class Queue<T>
{
    
    private int count;
    private Node head;
    private Node tail;


    /// <summary>
    /// check Queue base type
    /// </summary>
    /// <returns>string rep of base type</returns>
    public Type CheckType()
    {
        return typeof(T);
    }


    /// <summary>
    /// Added node to end of Queue
    /// </summary>
    /// <param name="value">value o node to be assigned</param>
    public void Enqueue(T value)
    {
        var node = new Node(value);
        if (this.count == 0)
            head = node;
        else
        {
            tail.next = node;
        }

        tail = node;
        count += 1;
    }

    /// <summary>
    /// returns Count of nodes in Queue
    /// </summary>
    /// <returns>int</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Remove first node from Queue and returns that value
    /// </summary>
    /// <returns></returns>
    public T Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        count -= 1;

        var h = head;
        head = head.next;

        return h.value;
    }


    /// <summary>
    /// returns the value of the first node without removing the node
    /// </summary>
    /// <returns>value of base type else default value</returns>
    public T Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    /// <summary>
    /// Print all the nodes.
    /// </summary>
    public void Print()
    {
        if (count == 0)
            Console.WriteLine("Queue is empty");
        else
            for (var temp = head; temp != null; temp = temp.next)
                Console.WriteLine($"{temp.value}");
    }

    /// <summary>
    /// Concatenates the contents of a `String` or `Char` based queue.
    /// </summary>
    /// <returns>string else null</returns>
    public string Concatenate()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) == typeof(string) || typeof(T) == typeof(char))
        {
            var concat = "";

            for (var temp = head; temp != null; temp = temp.next)
            {
                concat += temp.value;
                if (typeof(T) == typeof(string) && temp.next != null)
                    concat += " ";
            }

            return concat;
        }

        Console.WriteLine("Concatenate() is for a queue of Strings or Chars");
        return null;
    }

    class Node
    {
        public Node next = null;

        public T value = default(T);

        public Node(T value, Node next = null)
        {
            this.value = value;
            this.next = next;
        }
    }
}