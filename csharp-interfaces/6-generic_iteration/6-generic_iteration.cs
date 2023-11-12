using System;
using System.Collections;
using System.Collections.Generic;

public abstract class Base
{
    public string name { get; set; }

    public override string ToString() => $"{name} is a {GetType()}";
}

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

public class Door : Base, IInteractive
{
    public Door(string name = "Door") => this.name = name;

    public void Interact() => System.Console.WriteLine($"You try to open the {name}. It's locked.");
}

public class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
            System.Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            System.Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            System.Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    public void Break()
    {
        durability--;

        if (durability > 0)
            System.Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            System.Console.WriteLine($"You smash the {name}. What a mess.");
        else
            System.Console.WriteLine($"The {name} is already broken.");
    }
}

public class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (!isCollected)
            System.Console.WriteLine($"You pick up the {name}.");
        else
            System.Console.WriteLine($"You have already picked up the {name}.");

        isCollected = true;
    }
}

public class Objs<T> : IEnumerable<T>
{
    private Node head;
    private Node tail;

    public class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T value) => this.value = value;
    }

    public void Add(T value)
    {
        Node node = new Node(value);

        if (head == null)
            head = node;
        else
            tail.next = node;
        tail = node;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node node = head;

        for (; node != null; node = node.next)
            yield return node.value;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
