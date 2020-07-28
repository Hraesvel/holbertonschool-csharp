/// <summary>
/// My implementation of Queue type
/// </summary>
/// <typeparam name="T">base type</typeparam>
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

    /// <summary>
    /// check Queue base type
    /// </summary>
    /// <returns>string rep of base type</returns>
    public Type CheckType () {
        return typeof (T);
    }
/// 

    /// <summary>
    /// Added node to end of Queue
    /// </summary>
    /// <param name="value">value o node to be assigned</param>
    public void Enqueue (T value) {
        count += 1;
        var node = new Node (value);

        if (head == null)
            head = node;

        if (tail != null)
            tail.next = node;
        tail = node;

    }

    /// <summary>
    /// returns Count of nodes in Queue
    /// </summary>
    /// <returns>int</returns>
    public int Count () {
        return count;
    }
}