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

public interface IBreakable
{
    void Break();
}

public class Decoration : Base, IInteractive, IBreakable
{
    public int Durability { get; private set; }
    public bool IsQuestItem { get; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false) : base(name)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }

        this.Durability = durability;
        this.IsQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (Durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (IsQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    public void Break()
    {
        Durability--;

        if (Durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (Durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
