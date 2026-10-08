using System;

namespace ConsoleApp1;

public class TornamentManager
{

    public Tornaments<Chess> CreateChessTornament(string nameOfTornament, string typeOfPlayers, int maxPlayers,TornamentsBase[] tornamentsBases)
    {
        Tornaments<Chess> TornamentChess = new Tornaments<Chess>(nameOfTornament, typeOfPlayers, maxPlayers);

        Console.WriteLine($"Tournament {TornamentChess.Name} for {TornamentChess.TypeOfPlayers} players has been created.");

        Tornaments<Chess>.ShowCreatedTornaments(tornamentsBases);

        return TornamentChess;

    }

    public Tornaments<Football> CreateFootballTornament(string nameOfTornament, string typeOfPlayers,  int maxPlayers,TornamentsBase[] tornamentsBases)
    {
        Tornaments<Football> TornamentFootball = new Tornaments<Football>(nameOfTornament, typeOfPlayers, maxPlayers);

        Console.WriteLine($"Tournament {TornamentFootball.Name} for {TornamentFootball.TypeOfPlayers} players has been created.");

        Tornaments<Football>.ShowCreatedTornaments(tornamentsBases);

        return TornamentFootball;

    }
        public Tornaments<PairTanis> CreatePairTanisTornament(string nameOfTornament, string typeOfPlayers,  int maxPlayers, TornamentsBase[] tornamentsBases)
    {
        Tornaments<PairTanis> TornamentPairTanis = new Tornaments<PairTanis>(nameOfTornament, typeOfPlayers, maxPlayers);

        Console.WriteLine($"Tournament {TornamentPairTanis.Name} for {TornamentPairTanis.TypeOfPlayers} players has been created.");

        Tornaments<PairTanis>.ShowCreatedTornaments(tornamentsBases);

        return TornamentPairTanis;

    }
    

        public static void AddTornament(TornamentsBase tornaments, TornamentsBase[] CreatedTornaments)
        {
            for(int i=0; i < CreatedTornaments.Length; i++ ){
            CreatedTornaments[i] = tornaments;
            }
        }
        

}
