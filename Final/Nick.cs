public class Nick
{
    public class NickAttack : IEnemyAttack
    {
        private int nickAttack;
        public NickAttack(int attack)
        {
            nickAttack = attack;
        }
        public int Attack()
        {
            return nickAttack;
        }
    }
    public class NickHealth : IEnemyHealth
    {
        private int nickHealth;
        public NickHealth(int health)
        {
            nickHealth = health;
        }
        public int Health()
        {
            return nickHealth;
        }
    }
    public class NickLevel : IEnemyLevel
    {
        private int nickLevel;
        public NickLevel(int level)
        {
            nickLevel = level;
        }
        public int Level()
        {
            return nickLevel;
        }
    }
    public class NickName : IEnemyName
    {
        private string nickName;
        public NickName(string name)
        {
            nickName = name;
        }
        public string Name()
        {
            return nickName;
        }

    }
}