using System;

// Enum for modifiers
public enum Modifier
{
    Weak,
    Base,
    Strong
}

// Delegate for calculating modifiers
public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class Player
{
    // Properties
    private string name;
    private float maxHp;
    private float hp;

    // Delegate
    public delegate void CalculateHealth(float amount);

    // Constructor
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.name = name;
        this.hp = this.maxHp;
    }

    // Method
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    // Delegate method 1
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }

        Console.WriteLine($"{name} takes {damage} damage!");
        hp -= damage;
        if (hp < 0)
        {
            hp = 0;
        }
    }

    // Delegate method 2
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }

        Console.WriteLine($"{name} heals {heal} HP!");
        hp += heal;
        if (hp > maxHp)
        {
            hp = maxHp;
        }
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        // Implement the logic to apply the modifier
        // For example, you might switch on the modifier and adjust the base value accordingly
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f; // Adjust base value for Weak modifier
            case Modifier.Base:
                return baseValue; // No modification for Base modifier
            case Modifier.Strong:
                return baseValue * 1.5f; // Adjust base value for Strong modifier
            default:
                return baseValue; // Default behavior for unknown modifiers
        }
    }
}
