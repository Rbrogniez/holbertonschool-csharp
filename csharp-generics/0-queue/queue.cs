using System;

public class Queue<T>
{
    // Private class to represent nodes in the singly linked list
    private class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }
    }

    private Node head;  // Head of the linked list

    // Constructor to initialize the queue
    public Queue()
    {
        head = null;
    }

    // Method to check and return the type of the queue
    public Type CheckType()
    {
        return typeof(T);
    }
}
