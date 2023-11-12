using System;

public abstract class Base
{
    string name { get; }

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

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public void Interact(){}

    public int durability { get; set; }

    public void Break(){}

    public bool isCollected { get; set; }

    public void Collect(){}

    public string name { get; set; }
}
