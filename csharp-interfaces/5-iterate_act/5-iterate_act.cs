using System;
using System.Collections.Generic;

public abstract class Base
{
    public string Name { get; set; }

    public override string ToString() => $"{Name} is a {GetType()}";
}

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int Durability { get; set; }

    void Break();
}

public interface ICollectable
{
    bool IsCollected { get; set; }

    void Collect();
}

public class Door : Base, IInteractive
{
    public Door(string name = "Door") => Name = name;

    public void Interact() => Console.WriteLine($"You try to open the {Name}. It's locked.");
}

public class Decoration : Base, IInteractive, IBreakable
{
    public bool IsQuestItem { get; set; }
    public int Durability { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        Name = name;
        Durability = durability;
        IsQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (Durability <= 0)
            Console.WriteLine($"The {Name} has been broken.");
        else if (IsQuestItem)
            Console.WriteLine($"You look at the {Name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {Name}. Not much to see here.");
    }

    public void Break()
    {
        Durability--;

        if (Durability > 0)
            Console.WriteLine($"You hit the {Name}. It cracks.");
        else if (Durability == 0)
            Console.WriteLine($"You smash the {Name}. What a mess.");
        else
            Console.WriteLine($"The {Name} is already broken.");
    }
}

public class Key : Base, ICollectable
{
    public bool IsCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        Name = name;
        IsCollected = isCollected;
    }

    public void Collect()
    {
        if (!IsCollected)
            Console.WriteLine($"You pick up the {Name}.");
        else
            Console.WriteLine($"You have already picked up the {Name}.");

        IsCollected = true;
    }
}

public static class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var item in roomObjects)
        {
            switch (item)
            {
                case IInteractive interactiveItem when type == typeof(IInteractive):
                    interactiveItem.Interact();
                    break;
                case IBreakable breakableItem when type == typeof(IBreakable):
                    breakableItem.Break();
                    break;
                case ICollectable collectableItem when type == typeof(ICollectable):
                    collectableItem.Collect();
                    break;
            }
        }
    }
}
