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
    // Properties with traditional get and set methods
    public int Durability { get; set; }
    public bool IsCollected { get; set; }

    // Explicitly implement IInteractive interface
    public void Interact()
    {
        // Implementation goes here
    }

    // Explicitly implement IBreakable interface
    public void Break()
    {
        // Implementation goes here
    }

    // Explicitly implement ICollectable interface
    public void Collect()
    {
        // Implementation goes here
    }
}
