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

        OnCheckStatus(); // Call OnCheckStatus to set up HPCheck event handler

        this.HPCheck += CheckStatus;
        this.HPCheck += HPValueWarning; // Add HPValueWarning to the event handler list
    }

    public void ValidateHP()
    {
        OnCheckStatus(); // Call OnCheckStatus instead of HPCheck directly
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

        OnCheckStatus(); // Call OnCheckStatus after taking damage
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

        OnCheckStatus(); // Call OnCheckStatus after healing
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
            Console.WriteLine("Health has reached zero!");
        }
    }

    // New method to check health status and set up HPCheck event handler
    private void OnCheckStatus()
    {
        CurrentHPArgs args = new CurrentHPArgs(hp);

        // Check if currentHp is less than 1/4 of maxHp
        if (args.CurrentHp < maxHp / 4)
        {
            // Assign HPValueWarning to the HPCheck EventHandler
            this.HPCheck += HPValueWarning;
        }

        // Call HPCheck with the Player object and e
        HPCheck?.Invoke(this, args);
    }
}
