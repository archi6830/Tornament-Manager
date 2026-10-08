using System;

namespace ConsoleApp1;

public class Single : Player
{

    private int _age;

    public int Age { get {return _age;} }


    public Single(string name, string country, int raiting, int age) : base(name, country, raiting)
    {
        _age = age;
    }
}
