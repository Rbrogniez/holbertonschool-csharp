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
    // Explicitly implement IInteractive interface
    void IInteractive.Interact()
    {
        // Implementation goes here
    }

    // Explicitly implement IBreakable interface
    int IBreakable.Durability { get; set; }
    void IBreakable.Break()
    {
        // Implementation goes here
    }

    // Explicitly implement ICollectable interface
    bool ICollectable.IsCollected { get; set; }
    void ICollectable.Collect()
    {
        // Implementation goes here
    }

    // Additional methods and properties
    public void Break()
    {
        ((IBreakable)this).Break();
    }

    public void Collect()
    {
        ((ICollectable)this).Collect();
    }
}
