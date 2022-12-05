    public class EnemyAttack : IEnemyAttack
    {
        //Properties requirment #11
        private int enemyAttack;
        public EnemyAttack(int attack)
        {
            enemyAttack = attack;
        }
        public int Attack()
        {
            return enemyAttack;
        }
    }
    public class EnemyHealth : IEnemyHealth
    {
        private int enemyHealth;
        public EnemyHealth(int health)
        {
            enemyHealth = health;
        }
        public int Health()
        {
            return enemyHealth;
        }
    }
    public class EnemyLevel : IEnemyLevel
    {
        private int enemyLevel;
        public EnemyLevel(int level)
        {
            enemyLevel = level;
        }
        public int Level()
        {
            return enemyLevel;
        }
    }
    public class EnemyName : IEnemyName
    {
        private string enemyName;
        public EnemyName(string name)
        {
            enemyName = name;
        }
        public string Name()
        {
            return enemyName;
        }

    }