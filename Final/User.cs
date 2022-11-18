public class User
{
    UserHealth health = new UserHealth(10);
    UserAttack attack = new UserAttack(1);
    UserLevel level = new UserLevel(1);
    UserName name = new UserName("Default Name");
    UserEnergy energy = new UserEnergy(100);

    public void print()
    {
        System.Console.WriteLine(name.Name());
        System.Console.WriteLine("HP : " + health.Health());
        System.Console.WriteLine("ATK : " + attack.Attack());
        System.Console.WriteLine("LVL: " + level.Level());
        System.Console.WriteLine("Energy: " + energy.Energy());
    }
}