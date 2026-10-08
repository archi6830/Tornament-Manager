using System;

namespace ConsoleApp1;

public class Team : Player
{

    private int _numberOfPlayers;

    public int NumberOfPlayers {get{return _numberOfPlayers;} set{_numberOfPlayers = value;}}

    public Team(string name, string country, int raiting, int numberOfPlayers) : base (name, country, raiting)
    {
        _numberOfPlayers = numberOfPlayers;
    }

}
