class program {
    public static string line = "--------------------------------------------------";
    static object UserStyle;
    static void Main(string[] args)
    {
        Welcome();
    }

    static void Welcome()
    {
        System.Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("You awake in a strange world that is unkown to you,");
        Console.WriteLine("You look around and find 4 strange stones with different encarvings on them,");
        Console.WriteLine("They are all on their own pedestals with engravings on them,");
        Console.WriteLine("What do you do?");
        System.Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("1: Look at the engravings");
        Console.WriteLine("2: Touch One at random");
        System.Console.WriteLine("--------------------------------------------------");
        var input = Console.ReadLine();
        if (input == "1")
        {
            Console.WriteLine(line);
            System.Console.WriteLine("You decide to look at all of the engravings");
            System.Console.WriteLine("The first podium has the symbol for Fire");
            System.Console.WriteLine("The second podium has the symbol for Water");
            System.Console.WriteLine("The third podium has the symbol for Air");
            System.Console.WriteLine("The fourth podim has the symbol for Earth");
            Console.WriteLine(line);
        }
        if (input == "2")
        {
            System.Console.WriteLine(line);
            Random random = new Random();
            int StyleNum = random.Next(3);
            if(StyleNum == 0)
            {
                System.Console.WriteLine("You touched the rock that was engraved with Fire");
                UserStyle = Style.Type.Fire;
            }
            if(StyleNum == 1) 
            {
                System.Console.WriteLine("You touched the rock that was engraved with Water");
                UserStyle = Style.Type.Water;
            }
            if(StyleNum == 2)
            {
                System.Console.WriteLine("You touched the rock that was engraved with Air");
                UserStyle = Style.Type.Air;
            }
            if(StyleNum == 3)
            {
                System.Console.WriteLine("You touched the rock that was engraved with Earth");
                UserStyle = Style.Type.Earth;
            }
            System.Console.WriteLine(line);
        }
    }
}
