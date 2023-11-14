using System;

public enum Modifier
{
    Weak,
    Base,
    Strong
}

public delegate float CalculateModifier(float baseValue, Modifier modifier);

public delegate void HPCheckEventHandler(object sender, CurrentHPArgs e);

public class CurrentHPArgs : EventArgs
{
    public float CurrentHp { get; }

    public CurrentHPArgs(float newHp)
    {
        this.CurrentHp = newHp;
    }
}

public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    public delegate void CalculateHealth(float amount);
    public event HPCheckEventHandler HPCheck;

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

        // Assign OnCheckStatus to the HPCheck EventHandler
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    public void ValidateHP()
    {
        // Trigger the OnCheckStatus method with the current health
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

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

        // Trigger the OnCheckStatus method with the updated health after taking damage
        OnCheckStatus(new CurrentHPArgs(hp));
    }

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

        // Trigger the OnCheckStatus method with the updated health after healing
        OnCheckStatus(new CurrentHPArgs(hp));
    }

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

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.CurrentHp == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Health is low!");
            Console.ResetColor();
        }
    }

    private void OnCheckStatus(CurrentHPArgs e)
    {
        // Assign HPValueWarning to the HPCheck EventHandler if necessary
        if (e.CurrentHp < maxHp / 4)
        {
            this.HPCheck += HPValueWarning;
        }

        // Trigger the HPCheck event with the Player object and e
        HPCheck?.Invoke(this, e);
    }
}
