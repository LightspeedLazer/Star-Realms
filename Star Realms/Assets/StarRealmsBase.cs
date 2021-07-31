using System.Collections.Generic;
using UnityEngine;

public class Scout : Ship
{
    public string name {get {return "Scout";}}
    public int cost {get {return 0;}}
    public List<Card.Factions> faction {get {
        List<Card.Factions> faction = new List<Card.Factions>();
        return faction;
    }}
    public void testFunction(Player currentPlayer, Player opposingPlayer)
    {
        Debug.Log("a");
    }
}

public class Flagship : Ship
{
    public string name {get {return "Flagship";}}
    public int cost {get {return 6;}}
    public List<Card.Factions> faction {get {
        List<Card.Factions> faction = new List<Card.Factions>();
        faction.Add(Card.Factions.TradeFederation);
        return faction;
    }}
    public void testFunction(Player currentPlayer, Player opposingPlayer)
    {
        currentPlayer.DeltaHealth(5);
        currentPlayer.DeltaCombat(5);
    }
}

public class PortOfCall : Base
{
    public string name {get {return "Port of Call";}}
    public int cost {get {return 6;}}
    public List<Card.Factions> faction {get {
        List<Card.Factions> faction = new List<Card.Factions>();
        faction.Add(Card.Factions.TradeFederation);
        return faction;
    }}
    public int health {get {return 6;}}
    public bool outpost {get {return true;}}
    public void testFunction(Player currentPlayer, Player opposingPlayer)
    {
        currentPlayer.DeltaTrade(3);
    }
}
