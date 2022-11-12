public abstract class PersonAttack
{
    abstract public int Attack();
}

public class UserAttack : PersonAttack
{
    private int userAttack;

    public UserAttack(int attack)
    {
        userAttack = attack;
    }

    public override int Attack()
    {
        return (userAttack);
    }
}