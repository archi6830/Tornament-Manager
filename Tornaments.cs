using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1;

public class Tornaments<T> : TornamentsBase
{

    private T _typeOfTornament;

    public T TypeOfTornament { get { return _typeOfTornament; } set { _typeOfTornament = value; } }

    private string? _nameOfTornament;

    private string? _typeOfPlayers;

    public new string Name { get { return _nameOfTornament; } }

    public new string? TypeOfPlayers { get { return _typeOfPlayers; } }

    public static object[]? RegistredTornaments;

    public static int FirstNum = 0;

    private static bool _isCreated = false;

    public string SportType => typeof(T).Name;


    public Tornaments(string name, string typeOfPlayers, int maxPlayers) : base(name, typeOfPlayers, maxPlayers)
    {
        _nameOfTornament = name;
        _typeOfPlayers = typeOfPlayers;
        //    // _arrayToGet=player;
    }

    public static Tornaments<T>? CreateTornament<T>(string name, string TypeOfPlayers, int maxPlayers, TornamentsBase?[] tornamentsBases)
    {
        Tornaments<T> Tornament = new Tornaments<T>(name, TypeOfPlayers, maxPlayers) ;

        Console.WriteLine($"Tournament {Tornament.Name} for {Tornament.TypeOfPlayers} players has been created.");
        
        return Tornament;

    }


    


}
