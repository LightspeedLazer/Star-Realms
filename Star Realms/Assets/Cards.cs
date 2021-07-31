using System.Collections.Generic;

public interface Card
{
    string name {get;}
    int cost {get;}
    enum Factions {MachineCult,Blob,StarEmpire,TradeFederation};
    List<Factions> faction {get;}
    void testFunction(Player currentPlayer, Player opposingPlayer);
}

public interface Ship : Card
{
    
}

public interface Base : Card
{
    int health {get;}
    bool outpost {get;}
}
