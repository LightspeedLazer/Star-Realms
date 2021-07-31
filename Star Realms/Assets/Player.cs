public class Player
{
    public string name;
    public int Health;
    public int Trade;
    public int Combat;

    public Player(string Name)
    {
        name = Name;
        Health = 50;
        Trade = 0;
        Combat = 0;
    }

    public override string ToString()
    {
        return "Player Report\nName: " + name + "\nHealth: " + Health + "\nTrade: " + Trade + "\nCombat: " + Combat;
    }

    public int DeltaTrade(int amount)
    {
        Trade += amount;
        return Trade;
    }
    public int DeltaCombat(int amount)
    {
        Combat += amount;
        return Combat;
    }
    public int DeltaHealth(int amount)
    {
        Health += amount;
        return Health;
    }
}