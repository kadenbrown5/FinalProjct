public abstract class PersonEnergy
{
    abstract public int Energy();
}

public class UserEnergy : PersonEnergy
{
    private int userEnergy;

    public UserEnergy(int energy)
    {
        userEnergy = energy;
    }

    public override int Energy()
    {
        return (userEnergy);
    }
}