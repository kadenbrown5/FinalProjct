//Collection requirement #10
public class Weapons<TId, TName, TAttack, TDefense>
{
    public TId Id {get;}
    public TName Name {get;}
    public TAttack Attack {get;}
    public TDefense Defense {get;}
   public Weapons(TId iD, TName name, TAttack attack, TDefense defense)
   {
     Id = iD;
     Name = name;
     Attack = attack;
     Defense = defense;
   }
}

//Class Requirement #3
public class Weapons
{
    public static Weapons<int, string, int, int> Sword = new Weapons<int, string, int, int>(0, "Sword", 5, 0);
}

