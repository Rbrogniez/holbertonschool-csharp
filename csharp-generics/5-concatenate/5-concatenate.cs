using System;
using System.Text;

public class Queue<T>
{
    public class Node
    {
        public T value;
        public Node next;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T dequeuedValue = head.value;
        head = head.next;
        count--;

        return dequeuedValue;
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.WriteLine($"{current.value}");
            current = current.next;
        }
    }

    public int Count()
    {
        return count;
    }

    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (!(typeof(T) == typeof(string) || typeof(T) == typeof(char)))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        Node current = head;
        StringBuilder result = new StringBuilder();

        while (current != null)
        {
            result.Append(current.value.ToString());

            // Add a space if there is another element in the queue
            if (current.next != null)
            {
                result.Append(" ");
            }

            current = current.next;
        }

        return result.ToString();
    }
}
