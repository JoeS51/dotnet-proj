while (true)
{
    //Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Select an action:");
    Console.WriteLine("1. Add a new game");
    Console.WriteLine("2. View all games");
    Console.WriteLine("3. Stats Summary");
    Console.WriteLine("4. Delete line");
    Console.WriteLine("5. Quit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            GameStats newGame = new GameStats();
            Console.WriteLine("Enter Location: ");
            string loc = Console.ReadLine();
            Console.WriteLine("Number of goals: ");
            string goals = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("print game");
            break;
        case "2":
            Console.WriteLine("Print all games");
            break;
        default:
            Console.WriteLine("test");
            return;
    }

}