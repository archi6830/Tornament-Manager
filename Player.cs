using System;

namespace ConsoleApp1;

public class Player
{
    private string? _name;

    private string? _country;

    private int _raiting;

    public string? Name { get { return _name; } }

    public string? Country { get { return _country; } }

    public int Rating { get { return _raiting; } }

    public static int MaxQuantityOfPlayers = 10;

    public Player(string name, string country, int raiting)
    {
        _name = name;
        _country = country;
        _raiting = raiting;
    }

    public static void CheckForEnoughSpace(Player[] ListOfPlayers, int MaxQuantityOfPlayers)
    {


        if (MaxQuantityOfPlayers >= 10)
        {
            Player[] ListOfPlayersPlusOne = new Player[ListOfPlayers.Length + 1];

            for (int i = 0; i < ListOfPlayers.Length; i++)
            {
                ListOfPlayersPlusOne[i] = ListOfPlayers[i];
            }

            ListOfPlayers = ListOfPlayersPlusOne;
        }
    }


    public static void ShowAllPlayers(Player?[] ListOfPlayers, Player?[] ListOfPlayersInTornament)
    {
        Console.WriteLine();
        Console.WriteLine("Список всех игроков:");
        System.Console.WriteLine("0 если закончили выбор");

        Console.WriteLine();

        for (int i = 0; i < ListOfPlayers.Length; i++)
        {
            if (ListOfPlayers[i] != null)
            {
                Console.WriteLine($"{i + 1}. {ListOfPlayers[i].Name} ({ListOfPlayers[i].Country})");
            }
        }
        Player.PickAPlayer(ListOfPlayers, ListOfPlayersInTornament);

        Program.ShowMainMenu();


        Console.WriteLine();
    }

    public static Player?[] PickAPlayer(Player?[] ListOfPlayers, Player?[] ListOfPlayersInTornament)
    {
        
        Console.WriteLine();
        Console.WriteLine("Выберите игроков для участия в турнире:");
        Console.WriteLine();

        int choiseForPlayer = int.Parse(Console.ReadLine()!);

        for (int j = 0; j < ListOfPlayers.Length; j++)
        {

            if (choiseForPlayer == (j + 1) && ListOfPlayers[j] != null)
            {
                Console.WriteLine($"Вы выбрали игрока {ListOfPlayers[choiseForPlayer - 1].Name} ({ListOfPlayers[choiseForPlayer - 1].Country})");
                ListOfPlayersInTornament[j] = ListOfPlayers[choiseForPlayer - 1];
                ListOfPlayers[choiseForPlayer - 1] = null!;
                PickAPlayer(ListOfPlayers, ListOfPlayersInTornament);
            }
            else if (choiseForPlayer == 0)
            {
                return ListOfPlayersInTornament;
            }
        }
        return ListOfPlayersInTornament;
    }

    public static void ShowPlayers(Player[] ListOfPlayersInTornament)
    {
        for (int i = 0; i < ListOfPlayersInTornament.Length; i++)
        {
            if (ListOfPlayersInTornament[i] != null)
            {
                Console.WriteLine($"Вы выбрали игрока {ListOfPlayersInTornament[i].Name} ({ListOfPlayersInTornament[i].Country})");
            }
        }
    }

}
