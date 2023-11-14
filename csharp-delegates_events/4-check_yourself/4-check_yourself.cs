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

// Delegate for health check event
public delegate void HPCheckEventHandler(object sender, CurrentHPArgs e);

// EventArgs for health check event
public class CurrentHPArgs : EventArgs
{
    // Properties
    public float CurrentHp { get; }

    // Constructor
    public CurrentHPArgs(float newHp)
    {
        this.CurrentHp = newHp;
    }
}

public class Player
{
    // Properties
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    // Delegate
    public delegate void CalculateHealth(float amount);

    // Event
    public event HPCheckEventHandler HPCheck;

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
        this.status = $"{name} is ready to go!";

        // Assign CheckStatus to the HPCheck EventHandler
        this.HPCheck += CheckStatus;
    }

    // Method
    public void ValidateHP()
    {
        // Trigger the HPCheck event and pass hp as the CurrentHPArgs value
        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }

    // Method to apply a modifier
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

    // Method to print health
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    // Method to take damage
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

        // Trigger the HPCheck event after taking damage
        ValidateHP();
    }

    // Method to heal damage
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

        // Trigger the HPCheck event after healing
        ValidateHP();
    }

    // Private method to check and update status based on current health
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float currentHp = e.CurrentHp;

        if (currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (currentHp >= maxHp / 2 && currentHp < maxHp)
        {
            status = $"{name} is doing well!";
        }
        else if (currentHp >= maxHp / 4 && currentHp < maxHp / 2)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (currentHp > 0 && currentHp < maxHp / 4)
        {
            status = $"{name} needs help!";
        }
        else if (currentHp == 0)
        {
            status = $"{name} is knocked out!";
        }

        Console.WriteLine(status);
    }
}
