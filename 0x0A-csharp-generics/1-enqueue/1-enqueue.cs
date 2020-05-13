using System;

/// <summary>
/// My implementation of Queue type
/// </summary>
/// <typeparam name="T">base type</typeparam>
class Queue<T>
{
    private Node head;
    private Node tail;
    private int count;


    /// <summary>
    /// check Queue base type
    /// </summary>
    /// <returns>string rep of base type</returns>
    public string CheckType()
    {
        var t = this.GetType().BaseType;
        return t.ToString();
    }

    class Node
    {
        public Node(T value, Node next = null)
        {
            this.value = value;
            this.next = next;
        }

        public T value = default(T);
        public Node next = null;
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
    /// returns the value of the head node
    /// </summary>
    /// <returns>value of base type else default value</returns>
    public T Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
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
}