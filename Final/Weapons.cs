public class Weapons<TId, TName, TAttack, TDefense>
{
   public TId Id {get; set;}
   public TName? Name {get; set;}
   public TAttack Attack {get; set;}
   public TDefense Defense {get; set;} 
}

public class Weapons
{
    public static void Sword()
    {
    Weapons<int, string, int, int> BasicSword = new Weapons<int, string, int, int>();
    BasicSword.Id = 0;
    BasicSword.Name = "Sword";
    BasicSword.Attack = 5;
    BasicSword.Defense = 0;
    }
}