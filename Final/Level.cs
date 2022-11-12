public abstract class PersonLevel
{
    abstract public int Level();
}

public class UserLevel : PersonLevel
{
    private int userLevel;

    public UserLevel(int level)
    {
        userLevel = level;
    }

    public override int Level()
    {
        return (userLevel);
    }
}