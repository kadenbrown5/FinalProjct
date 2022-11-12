public abstract class PersonHealth
{
 abstract public int Health();
}

public class UserHealth : PersonHealth
{
    private int userHealth;

    public UserHealth(int health)
    {
        userHealth = health;
    }

    public override int Health()
    {
        return (userHealth);
    }
}