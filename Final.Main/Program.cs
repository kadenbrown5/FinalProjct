class program {
    public static string line = "--------------------------------------------------";
    static object ?UserStyle;
    static int firsttime = 0;
    static int Dicovery = 0;
    static void Main(string[] args)
    {
        Welcome();
        NewWorld();
        MainMenu();
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
            TouchChoice();
            static void TouchChoice()
            {
                Console.WriteLine(line);
                System.Console.WriteLine("You decide to look at all of the engravings");
                System.Console.WriteLine("The first podium has the symbol for Fire");
                System.Console.WriteLine("The second podium has the symbol for Water");
                System.Console.WriteLine("The third podium has the symbol for Air");
                System.Console.WriteLine("The fourth podim has the symbol for Earth");
                Console.WriteLine(line);
                System.Console.WriteLine("1: Touch Fire");
                System.Console.WriteLine("2: Touch Water");
                System.Console.WriteLine("3: Touch Air");
                System.Console.WriteLine("4: Touch Earth");
                System.Console.WriteLine(line);
                var element = Console.ReadLine();
                if(element == "1")
                {
                    UserStyle = Style.Type.Fire;
                    User.Name = "Ozuh";
                }
                else if(element == "2")
                {
                    UserStyle = Style.Type.Water;
                    User.Name = "Kirum";
                }
                else if(element == "3")
                {
                    UserStyle = Style.Type.Air;
                    User.Name = "Palden";
                }
                else if(element == "4")
                {
                    UserStyle = Style.Type.Earth;
                    User.Name = "Xeler";
                }
                else
                {
                    System.Console.WriteLine("Invalid Input, try again");
                    TouchChoice();
                }
            }
            
        }
        else if (input == "2")
        {
            System.Console.WriteLine(line);
            Random random = new Random();
            int StyleNum = random.Next(3);
            if(StyleNum == 0)
            {
                System.Console.WriteLine("You touched the rock that was engraved with Fire");
                UserStyle = Style.Type.Fire;
                User.Name = "Ozuh";
            }
            if(StyleNum == 1) 
            {
                System.Console.WriteLine("You touched the rock that was engraved with Water");
                UserStyle = Style.Type.Water;
                User.Name = "Kirum";
            }
            if(StyleNum == 2)
            {
                System.Console.WriteLine("You touched the rock that was engraved with Air");
                UserStyle = Style.Type.Air;
                User.Name = "Palden";
            }
            if(StyleNum == 3)
            {
                System.Console.WriteLine("You touched the rock that was engraved with Earth");
                UserStyle = Style.Type.Earth;
                User.Name = "Xeler";
            }
            System.Console.WriteLine(line);
        }
        else 
        {
            System.Console.WriteLine("Invalid Input, Try Again");
            Welcome();
        }
    }
    static void NewWorld()
    {
        System.Console.WriteLine(line);
        System.Console.WriteLine("After Touching the rock you have been teleported to a new town,");
        System.Console.WriteLine("The town is small and full of people you have never seen before,");
        System.Console.WriteLine("The town is called MountainVille, Known for the great mountains they are put in");
        System.Console.WriteLine("In MountainVille you find yourself lost");
        System.Console.WriteLine("As you look around you see there is a shop,");
        System.Console.WriteLine("There is also a training grounds, ");
        System.Console.WriteLine("and a scary looking cave");
        System.Console.WriteLine("You need to find a way out of here");
        System.Console.WriteLine(line);
        System.Console.WriteLine("1: Continue");
        Console.ReadLine();
    }
    static void MainMenu()
    {
        System.Console.WriteLine(line);
        System.Console.WriteLine("What Will you do?");
        System.Console.WriteLine(line);
        System.Console.WriteLine("1: Shop");
        System.Console.WriteLine("2: Train");
        System.Console.WriteLine("3: Cave");
        System.Console.WriteLine("4: Stats");
        System.Console.WriteLine("5: Dictionary");
        System.Console.WriteLine(line);
        var menu = Console.ReadLine();
        
        if(menu == "1")
        {
            Shop();
        }
        else if(menu == "2")
        {
            Training();
        }
        else if(menu == "3")
        {
            BattleMenu();
        }
        else if(menu == "4")
        {
            Stats();
        }
        else if(menu == "5")
        {
            Dictionary();
        }
        else{
            System.Console.WriteLine("Invalid input, Try Again");
            MainMenu();
        }
    }
    static void Shop()
    {
        System.Console.WriteLine("Shop is closed");
        MainMenu();
    }
    static void Training()
    {
            System.Console.WriteLine(line);
            System.Console.WriteLine("1: Increase Health");
            System.Console.WriteLine("2: Increase Attack");
            System.Console.WriteLine("3: Leave");
            System.Console.WriteLine(line);
            var training = Console.ReadLine();
            if(training == "1")
            {
                User.MaxHealth += 10;
                User.Health += 10;
                User.Level += 1;
                System.Console.WriteLine("Health has been increased by 10");
                System.Console.WriteLine("Your Max Health is now: " + User.MaxHealth);
                Training();
            }
            else if(training == "2")
            {
                User.Attack += 1;
                User.Level += 1;
                System.Console.WriteLine("Your Attack has been increased by 1");
                System.Console.WriteLine("Your Attack is now: " + User.Attack);
                Training();
            }
            else if(training == "3")
            {
                MainMenu();
            }
            else
            {
                System.Console.WriteLine("Invalid Input, Try Again");
                Training();
            }
    }
    
    static void BattleMenu()
    {
        if(firsttime == 0)
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine("Welcome to the caves");
            System.Console.WriteLine("After touching that rock you were transported into a body of someone with powers");
            System.Console.WriteLine("That persons name is " + User.Name + "they have the ablility to control " + UserStyle);
            System.Console.WriteLine("This is where you will battle your enemies");
            System.Console.WriteLine("After defeating enemies you will learn more about yourself");
            System.Console.WriteLine("Fight your way back home.");
            System.Console.WriteLine(line);
            firsttime += 1;
            System.Console.WriteLine("1: Continue");
            var Continue = Console.ReadLine();
        }


    }

    static void Stats()
    {
        System.Console.WriteLine(line);
        System.Console.WriteLine(" Name   : " + User.Name);
        System.Console.WriteLine(" Health : " + User.Health);
        System.Console.WriteLine(" Attack : " + User.Attack);
        System.Console.WriteLine(" Level  : " + User.Level);
        System.Console.WriteLine(" Gold   : " + User.Gold);
        System.Console.WriteLine(line);
        System.Console.WriteLine("1: Go Back");
        System.Console.WriteLine(line);
        var GoBack = Console.ReadLine();
        if(GoBack == "1")
        {
            MainMenu();
        }
        else
        {
            MainMenu();
        }
    }
    static void Dictionary()
    {
        var DE = Enemies.GetEnemies();
        if(Dicovery == 1)
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine("Nick            : " + DE["Nick"]);
            System.Console.WriteLine("Iquana Parrot   : " + DE["Iquana Parrot"]);
            System.Console.WriteLine("Boarqpine       : " + DE["Boarqpine"]);
            System.Console.WriteLine("Buzzard Wasp    : " + DE["Buzzard Wasp"]);
            System.Console.WriteLine("Cat Gator       : " + DE["Cat Gator"]);
            System.Console.WriteLine("Mongoose Lizard : " + DE["Mongoose Lizard"]);
            System.Console.WriteLine("Badgermole      : " + DE["Badgermole"]);
            System.Console.WriteLine("Lion Turtle     : " + DE["Lion Turtle"]);
            System.Console.WriteLine("Dragon          : " + DE["Dragon"]);
            System.Console.WriteLine(line);
            MainMenu();
        }
        else
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine("You have not found the book yet");
            System.Console.WriteLine(line);
            MainMenu();
        }
    }

}

