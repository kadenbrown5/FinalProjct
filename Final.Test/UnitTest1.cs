namespace Final.Test;

public class Tests
{
    [Test]
    public void TestingUsersHealth()
    {
        
        UserHealth userHealth = new UserHealth(100);
        Assert.AreEqual(100, userHealth.Health());
    }

    [Test]
    public void TestingUserAttack()
    {
        UserAttack userAttack = new UserAttack(100);
        Assert.AreEqual(100, userAttack.Attack());
    }
    
    [Test]
    public void TestingUserLevel()
    {
        UserLevel userLevel = new UserLevel(10);
        Assert.AreEqual(10, userLevel.Level());
    }

    [Test]
    public void TestingUserName()
    {
        UserName userName = new UserName("Tester");
        if ("Tester" == userName.Name())
        Assert.Pass();
        else Assert.Fail();
    }

    
}