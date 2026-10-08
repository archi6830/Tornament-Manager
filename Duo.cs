using System;

namespace ConsoleApp1;

public class Duo : Player
{
    
private bool _isBrothers;

public bool IsBrothers { get{return _isBrothers;} }

public Duo( string name, string country, int raiting, bool isBrothers) : base(name, country, raiting)
    {
        
    }

}