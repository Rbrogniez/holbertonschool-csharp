using System;

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
}
