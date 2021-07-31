using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Console console;
    void Start()
    {
        Player Player1 = new Player("Boy");
        Player Player2 = new Player("agea");
        List<Card> hand = new List<Card>();
        hand.Add(new PortOfCall());
        switch (hand[0].faction[0])
        {
            case Card.Factions.MachineCult:     print("Scrap"); break;
            case Card.Factions.Blob:            print("Ouch");  break;
            case Card.Factions.StarEmpire:      print("Card");  break;
            case Card.Factions.TradeFederation: print("Money"); break;
        }
        hand[0].testFunction(Player1, Player2);
        print(Player1);
        console.runCommand.AddListener(delegate
        {
            switch (console.command)
            {
                case "playerReport":
                    print(Player1);
                break;
            }
        });
    }
}
