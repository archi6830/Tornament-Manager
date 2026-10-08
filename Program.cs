namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Counter = 0;

            Player[] ListOfPlayers = new Player[Player.MaxQuantityOfPlayers];
            TornamentsBase[] CreatedTornaments = new TornamentsBase[3];
            Player[] ListOfPlayersInTornament = new Player[Player.MaxQuantityOfPlayers];
            Player Vasia = new Player("Vasia", "Russia", 100);
            ListOfPlayers[Counter] = Vasia;
            Counter++;
            Player Kolia = new Player("Kolia", "USA", 90);
            ListOfPlayers[Counter] = Kolia;
            Counter++;
            Player Seryozha = new Player("Seryozha", "France", 85);
            ListOfPlayers[Counter] = Seryozha;

            TornamentsBase[] AllTornaments = {
            new Tornaments<Chess>("Chess Tournament", "Single", 2),
            new Tornaments<Football>("Football Tournament", "Team", 22),
            new Tornaments<PairTanis>("Pair Tennis Tournament", "Duo", 4),

            };
            System.Console.WriteLine();
            ShowMainMenu();
            while (true)
            {
                System.Console.WriteLine();
                int choise = int.Parse(Console.ReadLine()!);

                switch (choise)
                {

                    case 1:
                        ShowTornaments(AllTornaments);
                        ShowTornamentMenu(ListOfPlayers, CreatedTornaments, ListOfPlayersInTornament);
                        break;
                    case 2:
                        Player.ShowAllPlayers(ListOfPlayers, ListOfPlayersInTornament);
                        break;
                    case 3:
                        Player.ShowPlayers(ListOfPlayersInTornament);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        return;
                    default:
                        System.Console.WriteLine("Вы ввели неверное значение. Попробуйте снова.");
                        break;
                }

            }

        }
        public static void ShowMainMenu()
        {
            System.Console.WriteLine("1. Создать турнир.");
            System.Console.WriteLine("2. Добавить участника в турнир.");
            System.Console.WriteLine("3. Показать всех участников турнира.");
            System.Console.WriteLine("4. Найти участника по имени.");
            System.Console.WriteLine("5. Удалить участника из турнира.");
            System.Console.WriteLine("6. Показать информацию о турнире.");
            System.Console.WriteLine("7. Показать количество участников.");
            System.Console.WriteLine("8. Выйти из программы.");

        }
        public static void ShowTornaments(TornamentsBase[] alltornaments)
        {
            for (int i = 0; i < alltornaments.Length; i++)
            {
                if (alltornaments != null)
                {
                    System.Console.WriteLine($"{i + 1}. {alltornaments[i].Name}");
                }
            }
        }

        public static void ShowTornamentMenu(Player[] players, TornamentsBase[] CreatedTornaments, Player[] players1)
        {
            int choiseForTornament = int.Parse(Console.ReadLine()!);
            switch (choiseForTornament)
            {
                case 1:
                    Tornaments<Chess>.CreateTornament<Chess>("Chess Tournament", "Single", 2, CreatedTornaments);
                    TornamentsBase.ShowCreatedTornaments(CreatedTornaments);
                    Player.ShowAllPlayers(players, players1);
                    break;
                case 2:
                    Tornaments<Football>.CreateTornament<Football>("Chess Football", "Team", 22, CreatedTornaments);
                    TornamentsBase.ShowCreatedTornaments(CreatedTornaments);
                    Player.ShowAllPlayers(players, players1);
                    break;
                case 3:
                    Tornaments<PairTanis>.CreateTornament<PairTanis>("PairTanis Tournament", "Duo", 4, CreatedTornaments);
                    TornamentsBase.ShowCreatedTornaments(CreatedTornaments);
                    Player.ShowAllPlayers(players, players1);
                    break;
                case 0:
                    ShowMainMenu();
                    break;
                default:
                    System.Console.WriteLine("Вы ввели неверное значение. Попробуйте снова.");
                    break;
            }
        }
    }
}