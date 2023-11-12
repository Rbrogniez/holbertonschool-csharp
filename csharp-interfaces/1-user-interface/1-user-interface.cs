using System;

// Define the IInteractive interface
public interface IInteractive
{
    void Interact();
}

// Define the IBreakable interface
public interface IBreakable
{
    int Durability { get; set; }
    void Break();
}

// Define the ICollectable interface
public interface ICollectable
{
    bool IsCollected { get; set; }
    void Collect();
}

// Define the Base class
public abstract class Base
{
    public string name;

    public override string ToString() => $"{name} is a {GetType()}";
}

// Define the TestObject class that inherits from Base and implements all three interfaces
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    // Implement IInteractive interface
    public void Interact()
    {
        // Implementation goes here
    }

    // Implement IBreakable interface
    public int Durability { get; set; }
    public void Break()
    {
        // Implementation goes here
    }

    // Implement ICollectable interface
    public bool IsCollected { get; set; }
    public void Collect()
    {
        // Implementation goes here
    }
}

