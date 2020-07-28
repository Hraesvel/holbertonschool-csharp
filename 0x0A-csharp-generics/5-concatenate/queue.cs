using System;

class Queue<T> {

    public class Node {
        public T value;
        public Node next;

        public Node (T value, Node next = null) {
            this.value = value;
            this.next = next;
        }
    }

    Node head = null;
    Node tail = null;

    int count = 0;

    public Type CheckType () {
        return typeof (T);
    }

    public void Enqueue (T value) {
        count += 1;
        var node = new Node (value);

        if (head == null)
            head = node;

        if (tail != null)
            tail.next = node;
        tail = node;

    }

    public int Count () {
        return count;
    }

    public T Dequeue () {
        if (head == null) {
            Console.WriteLine ("Queue is empty");
            return default (T);
        }
        var val = head.value;
        head = head.next;

        count -= 1;
        return val;
    }

    public T Peek () {
        if (head == null) {
            Console.WriteLine ("Queue is empty");
            return default (T);
        }
        var val = head.value;
        return val;
    }

    public void Print () {
        if (head == null) {
            Console.WriteLine ("Queue is empty");
            return;
        }

        for (var h = head; h != null; h = h.next)
            Console.WriteLine ($"{h.value}");

    }

    public string Concatenate () {

        if (head == null) {
            Console.WriteLine ("Queue is empty");
            return null;
        }

        string concat = null;

        switch (typeof (T).ToString ()) {
            case "System.String":
                for (var h = head; h != null; h = h.next)
                    concat += $"{h.value} ";
                concat.TrimEnd ();
                break;
            case "System.Char":
                for (var h = head; h != null; h = h.next)
                    concat += $"{h.value}";
                break;
            default:
                Console.WriteLine ("Concatenate() is for a queue of Strings or Chars only.");
                break;

        }

        return concat;
    }
}