public abstract class PersonName
{
    abstract public string Name();
}

public class UserName : PersonName
{
    private string userName;

    public UserName(string name)
    {
        userName = name;
    }

    public override string Name()
    {
        return (userName);
    }
}