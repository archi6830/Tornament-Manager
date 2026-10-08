using System;

namespace ConsoleApp1;

public class TornamentsBase 
{
    private Player?[] _players;
    private int _playersCount;

    public string Name {get;}
    public string TypeOfPlayers { get; }
    public int PlayersCount { get {return _playersCount ;} }

public TornamentsBase(string name,
        string typeOfPlayers,
        int maxPlayers)
    {
        Name = name;
        TypeOfPlayers = typeOfPlayers;
        _players = new Player?[maxPlayers];
    }
    public static void ShowCreatedTornaments(TornamentsBase[] tornamentsBases)
    {
        System.Console.WriteLine("Список:");
        for (int i = 0; i < tornamentsBases.Length; i++)
        {
            if (tornamentsBases[i] != null)
            {
                TornamentsBase tornament = tornamentsBases[i]!;
                Console.WriteLine($"{i + 1}. {tornament.Name} тип игроков {tornament.TypeOfPlayers}");
            }
        }
    }

}
