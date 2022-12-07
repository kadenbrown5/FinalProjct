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
                User.Attack += 5;
                User.Level += 1;
                System.Console.WriteLine("Your Attack has been increased by 5");
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
            System.Console.WriteLine("That persons name is " + User.Name + ", they have the ablility to control " + UserStyle);
            System.Console.WriteLine("This is where you will battle your enemies");
            System.Console.WriteLine("After defeating enemies you will learn more about yourself");
            System.Console.WriteLine("Fight your way back home.");
            System.Console.WriteLine(line);
            firsttime += 1;
            System.Console.WriteLine("1: Continue");
            var Continue = Console.ReadLine();
            BattleMenu();
        }
        
        System.Console.WriteLine(line);
        System.Console.WriteLine("Welcome back to the caves");
        System.Console.WriteLine(line);
        System.Console.WriteLine("1: Iquana Parrot");
        System.Console.WriteLine("2: Boarqpine");
        System.Console.WriteLine("3: Buzzard Wasps");
        System.Console.WriteLine("4: Cat Gator");
        System.Console.WriteLine("5: Mongoose Lizard");
        System.Console.WriteLine("6: Badgermole");
        System.Console.WriteLine("7: Lion Turtle");
        System.Console.WriteLine("8: Dragon");
        System.Console.WriteLine("9: Mystery Man");
        System.Console.WriteLine("E: Exit");
        System.Console.WriteLine(line);
        var caves = Console.ReadLine();
        if(caves == "1")
        {
            IquanaParrot();
        }
        else if(caves == "2")
        {
            Boarqpine();
        }
        else if(caves == "3")
        {
            BuzzardWasp();   
        }
        else if(caves == "4")
        {
            CatGator();
        }
        else if(caves == "5")
        {
            MongooseLizard();
        }
        else if(caves == "6")
        {
            BadgerMole();
        }
        else if(caves == "7")
        {
            LionTurtle();
        }
        else if(caves == "8")
        {
            Dragon();
        }
        else if(caves == "9")
        {
            Nick();
        }
        else if(caves == "E" || caves == "e")
        {
            MainMenu();
        }
        else
        {
            System.Console.WriteLine("Invalid Input, Try Again");
            BattleMenu();
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
    static void IquanaParrot()
    {
        bool Alive = true;
        EnemyName IPname = new EnemyName("Iquana Parrot");
        EnemyHealth IPhealth = new EnemyHealth(100);
        EnemyAttack IPattack = new EnemyAttack(10);
        EnemyLevel  IPlevel = new EnemyLevel(20);
        int EnemyHealth = IPhealth.Health();
        int EnemyAttack = IPattack.Attack();
        while(Alive)
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine(IPname.Name());
            System.Console.WriteLine("Level : " + IPlevel.Level());
            System.Console.WriteLine("Health: " + EnemyHealth);
            System.Console.WriteLine("Attack: " + EnemyAttack);
            System.Console.WriteLine(line);
            System.Console.WriteLine(User.Name);
            System.Console.WriteLine("Level : " + User.Level);
            System.Console.WriteLine("Health: " + User.Health);
            System.Console.WriteLine("Attack: " + User.Attack);
            System.Console.WriteLine(line);
            System.Console.WriteLine("1: Attack");
            System.Console.WriteLine("2: Escape");
            System.Console.WriteLine(line);
            var Battle = Console.ReadLine();

            void Attack()
            {
                    EnemyHealth -= User.Attack;
                if(EnemyHealth > 0)
                {
                    User.Health -= EnemyAttack;
                }
            }

            if(Battle == "1")
            {
                
                Attack();

            }
            else if(Battle == "2")
            {
                Random TryLeave = new Random();
                int NoLeave = TryLeave.Next(10);
                if(NoLeave == 5)
                {
                    System.Console.WriteLine("You failed to excape");
                    Attack();
                }
                else
                {
                    System.Console.WriteLine("You escaped");
                    User.Health = User.MaxHealth;
                    MainMenu();
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Input, You Attack");
                Attack();
                
            }

            if(EnemyHealth <= 0)
            {
                User.Health = User.MaxHealth;
                User.Gold += 10;
                Alive = false;
                System.Console.WriteLine("You killed the Iquana Parrot, You now have " + User.Gold + " Gold");
            }

            if(User.Health <= 0)
            {
                User.Health = User.MaxHealth;
                double half = 1/2;
                double HalfGold = User.Gold * half;
                Math.Ceiling(HalfGold);
                User.Gold = Convert.ToInt32(HalfGold);
                System.Console.WriteLine(line);
                System.Console.WriteLine("You have Died and lost half of your gold");
                System.Console.WriteLine("You now have Gold: " + User.Gold);
                System.Console.WriteLine(line);
                MainMenu();
            }
        }
    }
    static void Boarqpine()
    {
        bool Alive = true;
        EnemyName enemyName = new EnemyName("Boarqpine");
        EnemyHealth enemyHealth = new EnemyHealth(200);
        EnemyAttack enemyAttack = new EnemyAttack(20);
        EnemyLevel  enemyLevel = new EnemyLevel(30);
        int EnemyHealth = enemyHealth.Health();
        int EnemyAttack = enemyAttack.Attack();
        while(Alive)
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine(enemyName.Name());
            System.Console.WriteLine("Level : " + enemyLevel.Level());
            System.Console.WriteLine("Health: " + EnemyHealth);
            System.Console.WriteLine("Attack: " + EnemyAttack);
            System.Console.WriteLine(line);
            System.Console.WriteLine(User.Name);
            System.Console.WriteLine("Level : " + User.Level);
            System.Console.WriteLine("Health: " + User.Health);
            System.Console.WriteLine("Attack: " + User.Attack);
            System.Console.WriteLine(line);
            System.Console.WriteLine("1: Attack");
            System.Console.WriteLine("2: Escape");
            System.Console.WriteLine(line);
            var Battle = Console.ReadLine();

            void Attack()
            {
                    EnemyHealth -= User.Attack;
                if(EnemyHealth > 0)
                {
                    User.Health -= EnemyAttack;
                }
            }

            if(Battle == "1")
            {
                
                Attack();

            }
            else if(Battle == "2")
            {
                Random TryLeave = new Random();
                int NoLeave = TryLeave.Next(10);
                if(NoLeave == 5)
                {
                    System.Console.WriteLine("You failed to excape");
                    Attack();
                }
                else
                {
                    System.Console.WriteLine("You escaped");
                    User.Health = User.MaxHealth;
                    MainMenu();
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Input, You Attack");
                Attack();
                
            }

            if(EnemyHealth <= 0)
            {
                User.Health = User.MaxHealth;
                User.Gold += 20;
                Alive = false;
                System.Console.WriteLine("You killed the Iquana Parrot, You now have " + User.Gold + " Gold");
            }

            if(User.Health <= 0)
            {
                User.Health = User.MaxHealth;
                double half = 1/2;
                double HalfGold = User.Gold * half;
                Math.Ceiling(HalfGold);
                User.Gold = Convert.ToInt32(HalfGold);
                System.Console.WriteLine(line);
                System.Console.WriteLine("You have Died and lost half of your gold");
                System.Console.WriteLine("You now have Gold: " + User.Gold);
                System.Console.WriteLine(line);
                MainMenu();
            }
        }
    }
    static void BuzzardWasp()
    {
       bool Alive = true;
        EnemyName enemyName = new EnemyName("Buzzard Wasp");
        EnemyHealth enemyHealth = new EnemyHealth(500);
        EnemyAttack enemyAttack = new EnemyAttack(50);
        EnemyLevel  enemyLevel = new EnemyLevel(40);
        int EnemyHealth = enemyHealth.Health();
        int EnemyAttack = enemyAttack.Attack();
        while(Alive)
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine(enemyName.Name());
            System.Console.WriteLine("Level : " + enemyLevel.Level());
            System.Console.WriteLine("Health: " + EnemyHealth);
            System.Console.WriteLine("Attack: " + EnemyAttack);
            System.Console.WriteLine(line);
            System.Console.WriteLine(User.Name);
            System.Console.WriteLine("Level : " + User.Level);
            System.Console.WriteLine("Health: " + User.Health);
            System.Console.WriteLine("Attack: " + User.Attack);
            System.Console.WriteLine(line);
            System.Console.WriteLine("1: Attack");
            System.Console.WriteLine("2: Escape");
            System.Console.WriteLine(line);
            var Battle = Console.ReadLine();

            void Attack()
            {
                    EnemyHealth -= User.Attack;
                if(EnemyHealth > 0)
                {
                    User.Health -= EnemyAttack;
                }
            }

            if(Battle == "1")
            {
                
                Attack();

            }
            else if(Battle == "2")
            {
                Random TryLeave = new Random();
                int NoLeave = TryLeave.Next(10);
                if(NoLeave == 5)
                {
                    System.Console.WriteLine("You failed to excape");
                    Attack();
                }
                else
                {
                    System.Console.WriteLine("You escaped");
                    User.Health = User.MaxHealth;
                    MainMenu();
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Input, You Attack");
                Attack();
                
            }

            if(EnemyHealth <= 0)
            {
                User.Health = User.MaxHealth;
                User.Gold += 50;
                Alive = false;
                System.Console.WriteLine("You killed the Iquana Parrot, You now have " + User.Gold + " Gold");
            }

            if(User.Health <= 0)
            {
                User.Health = User.MaxHealth;
                double half = 1/2;
                double HalfGold = User.Gold * half;
                Math.Ceiling(HalfGold);
                User.Gold = Convert.ToInt32(HalfGold);
                System.Console.WriteLine(line);
                System.Console.WriteLine("You have Died and lost half of your gold");
                System.Console.WriteLine("You now have Gold: " + User.Gold);
                System.Console.WriteLine(line);
                MainMenu();
            }
        }
    }
    static void CatGator()
    {
        bool Alive = true;
        EnemyName enemyName = new EnemyName("Cat Gator");
        EnemyHealth enemyHealth = new EnemyHealth(1000);
        EnemyAttack enemyAttack = new EnemyAttack(100);
        EnemyLevel  enemyLevel = new EnemyLevel(50);
        int EnemyHealth = enemyHealth.Health();
        int EnemyAttack = enemyAttack.Attack();
        while(Alive)
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine(enemyName.Name());
            System.Console.WriteLine("Level : " + enemyLevel.Level());
            System.Console.WriteLine("Health: " + EnemyHealth);
            System.Console.WriteLine("Attack: " + EnemyAttack);
            System.Console.WriteLine(line);
            System.Console.WriteLine(User.Name);
            System.Console.WriteLine("Level : " + User.Level);
            System.Console.WriteLine("Health: " + User.Health);
            System.Console.WriteLine("Attack: " + User.Attack);
            System.Console.WriteLine(line);
            System.Console.WriteLine("1: Attack");
            System.Console.WriteLine("2: Escape");
            System.Console.WriteLine(line);
            var Battle = Console.ReadLine();

            void Attack()
            {
                    EnemyHealth -= User.Attack;
                if(EnemyHealth > 0)
                {
                    User.Health -= EnemyAttack;
                }
            }

            if(Battle == "1")
            {
                
                Attack();

            }
            else if(Battle == "2")
            {
                Random TryLeave = new Random();
                int NoLeave = TryLeave.Next(10);
                if(NoLeave == 5)
                {
                    System.Console.WriteLine("You failed to excape");
                    Attack();
                }
                else
                {
                    System.Console.WriteLine("You escaped");
                    User.Health = User.MaxHealth;
                    MainMenu();
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Input, You Attack");
                Attack();
                
            }

            if(EnemyHealth <= 0)
            {
                User.Health = User.MaxHealth;
                User.Gold += 100;
                Alive = false;
                System.Console.WriteLine("You killed the Iquana Parrot, You now have " + User.Gold + " Gold");
            }

            if(User.Health <= 0)
            {
                User.Health = User.MaxHealth;
                double half = 1/2;
                double HalfGold = User.Gold * half;
                Math.Ceiling(HalfGold);
                User.Gold = Convert.ToInt32(HalfGold);
                System.Console.WriteLine(line);
                System.Console.WriteLine("You have Died and lost half of your gold");
                System.Console.WriteLine("You now have Gold: " + User.Gold);
                System.Console.WriteLine(line);
                MainMenu();
            }
        }
    }
    static void MongooseLizard()
    {
        bool Alive = true;
        EnemyName enemyName = new EnemyName("Mongoose Lizard");
        EnemyHealth enemyHealth = new EnemyHealth(1500);
        EnemyAttack enemyAttack = new EnemyAttack(150);
        EnemyLevel  enemyLevel = new EnemyLevel(60);
        int EnemyHealth = enemyHealth.Health();
        int EnemyAttack = enemyAttack.Attack();
        while(Alive)
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine(enemyName.Name());
            System.Console.WriteLine("Level : " + enemyLevel.Level());
            System.Console.WriteLine("Health: " + EnemyHealth);
            System.Console.WriteLine("Attack: " + EnemyAttack);
            System.Console.WriteLine(line);
            System.Console.WriteLine(User.Name);
            System.Console.WriteLine("Level : " + User.Level);
            System.Console.WriteLine("Health: " + User.Health);
            System.Console.WriteLine("Attack: " + User.Attack);
            System.Console.WriteLine(line);
            System.Console.WriteLine("1: Attack");
            System.Console.WriteLine("2: Escape");
            System.Console.WriteLine(line);
            var Battle = Console.ReadLine();

            void Attack()
            {
                    EnemyHealth -= User.Attack;
                if(EnemyHealth > 0)
                {
                    User.Health -= EnemyAttack;
                }
            }

            if(Battle == "1")
            {
                
                Attack();

            }
            else if(Battle == "2")
            {
                Random TryLeave = new Random();
                int NoLeave = TryLeave.Next(10);
                if(NoLeave == 5)
                {
                    System.Console.WriteLine("You failed to excape");
                    Attack();
                }
                else
                {
                    System.Console.WriteLine("You escaped");
                    User.Health = User.MaxHealth;
                    MainMenu();
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Input, You Attack");
                Attack();
                
            }

            if(EnemyHealth <= 0)
            {
                User.Health = User.MaxHealth;
                User.Gold += 150;
                Alive = false;
                System.Console.WriteLine("You killed the Iquana Parrot, You now have " + User.Gold + " Gold");
            }

            if(User.Health <= 0)
            {
                User.Health = User.MaxHealth;
                double half = 1/2;
                double HalfGold = User.Gold * half;
                Math.Ceiling(HalfGold);
                User.Gold = Convert.ToInt32(HalfGold);
                System.Console.WriteLine(line);
                System.Console.WriteLine("You have Died and lost half of your gold");
                System.Console.WriteLine("You now have Gold: " + User.Gold);
                System.Console.WriteLine(line);
                MainMenu();
            }
        }
    }
    static void BadgerMole()
    {
       bool Alive = true;
        EnemyName enemyName = new EnemyName("Badgermole");
        EnemyHealth enemyHealth = new EnemyHealth(2000);
        EnemyAttack enemyAttack = new EnemyAttack(200);
        EnemyLevel  enemyLevel = new EnemyLevel(70);
        int EnemyHealth = enemyHealth.Health();
        int EnemyAttack = enemyAttack.Attack();
        while(Alive)
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine(enemyName.Name());
            System.Console.WriteLine("Level : " + enemyLevel.Level());
            System.Console.WriteLine("Health: " + EnemyHealth);
            System.Console.WriteLine("Attack: " + EnemyAttack);
            System.Console.WriteLine(line);
            System.Console.WriteLine(User.Name);
            System.Console.WriteLine("Level : " + User.Level);
            System.Console.WriteLine("Health: " + User.Health);
            System.Console.WriteLine("Attack: " + User.Attack);
            System.Console.WriteLine(line);
            System.Console.WriteLine("1: Attack");
            System.Console.WriteLine("2: Escape");
            System.Console.WriteLine(line);
            var Battle = Console.ReadLine();

            void Attack()
            {
                    EnemyHealth -= User.Attack;
                if(EnemyHealth > 0)
                {
                    User.Health -= EnemyAttack;
                }
            }

            if(Battle == "1")
            {
                
                Attack();

            }
            else if(Battle == "2")
            {
                Random TryLeave = new Random();
                int NoLeave = TryLeave.Next(10);
                if(NoLeave == 5)
                {
                    System.Console.WriteLine("You failed to excape");
                    Attack();
                }
                else
                {
                    System.Console.WriteLine("You escaped");
                    User.Health = User.MaxHealth;
                    MainMenu();
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Input, You Attack");
                Attack();
                
            }

            if(EnemyHealth <= 0)
            {
                User.Health = User.MaxHealth;
                User.Gold += 200;
                Alive = false;
                System.Console.WriteLine("You killed the Iquana Parrot, You now have " + User.Gold + " Gold");
            }

            if(User.Health <= 0)
            {
                User.Health = User.MaxHealth;
                double half = 1/2;
                double HalfGold = User.Gold * half;
                Math.Ceiling(HalfGold);
                User.Gold = Convert.ToInt32(HalfGold);
                System.Console.WriteLine(line);
                System.Console.WriteLine("You have Died and lost half of your gold");
                System.Console.WriteLine("You now have Gold: " + User.Gold);
                System.Console.WriteLine(line);
                MainMenu();
            }
        }
    }
    static void LionTurtle()
    {
        System.Console.WriteLine("This area is a work in progress");
        BattleMenu();
    }
    static void Dragon()
    {
        System.Console.WriteLine("This area is a work in progress");
        BattleMenu();
    }
    static void Nick()
    {
        System.Console.WriteLine("This area is a work in progress");
        BattleMenu();
    }
}