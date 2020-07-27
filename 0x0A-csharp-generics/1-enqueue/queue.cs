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

    public string CheckType () {
        return typeof (T).ToString ();
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

    public int Count() {
        return count;
    }
}