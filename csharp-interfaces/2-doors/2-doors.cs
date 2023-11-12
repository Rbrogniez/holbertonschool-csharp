using System;

public abstract class Base
{
    public string name { get; }

    protected Base(string name = "Door")
    {
        this.name = name;
    }

    public override string ToString() => $"{name} is a {GetType()}";
}

public interface IInteractive
{
    void Interact();
}

public class Door : Base, IInteractive
{
    public Door(string name = "Door") : base(name)
    {
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

